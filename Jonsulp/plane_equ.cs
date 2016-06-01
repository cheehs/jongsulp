using System;
using Leap;
using System.Threading;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Jonsulp
{
    class plane_equ
    {
        float constant;
        float pow, sqrt, size;
        Leap.Vector n;
        public Leap.Vector[] p;
        Matrix<double> H;
        Rectangle resolution;

        public plane_equ(Leap.Vector a, Leap.Vector b, Leap.Vector c, Leap.Vector d, Rectangle resolution)
        {
            Leap.Vector temp1 = b - a;
            Leap.Vector temp2 = c - a;
            this.resolution = resolution;

            n = temp1.Cross(temp2);

            constant = n.x * (-a.x) + n.y * (-a.y) + n.z * (-a.z);
            pow = n.x * n.x + n.y * n.y + n.z * n.z;
            sqrt = (float)Math.Sqrt(pow);

            p = new Leap.Vector[4];
            p[0] = a;
            p[1] = b;
            p[2] = c;
            p[3] = point_on_plane(d);

            size_plane();
            calc_homogeneous_matrix();
        }

        public Leap.Vector point_on_plane(Leap.Vector p)
        {
            Leap.Vector res = new Leap.Vector();
            float temp = n.x * p.x + n.y * p.y + n.z * p.z + constant;

            temp = (-temp) / pow;
            res.x = p.x + temp * n.x;
            res.y = p.y + temp * n.y;
            res.z = p.z + temp * n.z;

            return res;
        }

        public float size_triangle(Leap.Vector a, Leap.Vector b, Leap.Vector c)
        {
            Leap.Vector t;
            float res;

            b = b - a;
            c = c - a;
            t = new Leap.Vector(b.y * c.z - b.z * c.y, b.z * c.x - b.x * c.z, b.x * c.y - b.y * c.x);
            res = (float)Math.Sqrt(t.x * t.x + t.y * t.y + t.z * t.z) / 2;

            return res;
        }

        public void size_plane()
        {
            Leap.Vector t1 = p[3] - p[0];
            Leap.Vector t2 = p[2] - p[1];
            Leap.Vector t = new Leap.Vector(t1.y * t2.z - t1.z * t2.y, t1.z * t2.x - t1.x * t2.z, t1.x * t2.y - t1.y * t2.x);

            size = (float)Math.Sqrt(t.x * t.x + t.y * t.y + t.z * t.z) / 2;
        }

        public Leap.Vector get_projected_coor(Leap.Vector coor)
        {
            MathNet.Numerics.LinearAlgebra.Vector<double> v =
                MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(new double[] {
                coor.x, coor.y, 1});
            v = H.Multiply(v);

            return new Leap.Vector((float)v[0] * 100, (float)v[1] * 100, 0);
        }

        public void calc_homogeneous_matrix()
        {
            //Screen width & height value.
            double[] screen_value = new double[8]
            {
            0, resolution.Height / 100,
            resolution.Width / 100, resolution.Height / 100,
            0, 0,
            resolution.Width / 100, 0
            };
            double[,] ma = new double[8, 8];
            int i = 0;

            //Create 8 by 8 value.
            for (int j = 0; j < 4; j++)
            {
                ma[i, 0] = p[j].x;
                ma[i, 1] = p[j].y;
                ma[i, 2] = 1;
                ma[i, 6] = -(p[j].x * screen_value[j * 2]);
                ma[i, 7] = -(p[j].y * screen_value[j * 2]);

                i++;

                ma[i, 3] = p[j].x;
                ma[i, 4] = p[j].y;
                ma[i, 5] = 1;
                ma[i, 6] = -(p[j].x * screen_value[j * 2 + 1]);
                ma[i, 7] = -(p[j].y * screen_value[j * 2 + 1]);

                i++;
            }

            Matrix<double> A = DenseMatrix.OfArray(ma);
            MathNet.Numerics.LinearAlgebra.Vector<double> b =
                MathNet.Numerics.LinearAlgebra.Vector<double>.Build.Dense(screen_value);
            MathNet.Numerics.LinearAlgebra.Vector<double> x = A.Solve(b);

            double[,] hd = new double[3, 3];
            hd[0, 0] = x[0];
            hd[0, 1] = x[1];
            hd[0, 2] = x[2];
            hd[1, 0] = x[3];
            hd[1, 1] = x[4];
            hd[1, 2] = x[5];
            hd[2, 0] = x[6];
            hd[2, 1] = x[7];
            hd[2, 2] = 1;

            H = DenseMatrix.OfArray(hd);

            Console.WriteLine(A);
            Console.WriteLine(x);
            Console.WriteLine(H);
        }

        public bool check_inside(Leap.Vector v)
        {
            float temp = size_triangle(p[0], p[1], v) + size_triangle(p[1], p[3], v) + size_triangle(p[2], p[3], v) + size_triangle(p[0], p[2], v);
            //Console.WriteLine("<"+temp+" "+size+">");
            return temp > size ? false : true;
        }

        public float distance_from_plane_to_point(Leap.Vector point)
        {
            float distance = (Math.Abs(n.x * point.x + n.y * point.y + n.z * point.z + constant)) / sqrt;

            return distance;
        }

        public float on_plane(Leap.Vector a)
        {
            //Console.WriteLine(distance_from_plane_to_point(a));
            // && check_inside(point_on_plane(a))
            float result = distance_from_plane_to_point(a);
            if (result < 15)
                return result;
            else
                return 10000;
        }
    }
}
