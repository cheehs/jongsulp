using System;
using Leap;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Jonsulp
{
    public partial class Leapmtion : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x01;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private System.Windows.Forms.Timer timer;

        private Leap.Vector p1;
        private Leap.Vector p2;
        private Leap.Vector p3;
        private Leap.Vector p4;

        private static Rectangle resolution;
        private static Controller controller;
        //private static Pointable pointable;
        private static plane_equ plane;

        private static Leap.Vector coor;
        private static Leap.Vector touch;
        private static Frame frame;
        private static Hand hand;
        private static FingerList pointer;
        private static bool clicked;

        public Leapmtion()
        {
            InitializeComponent();
            p1 = new Leap.Vector();
            p2 = new Leap.Vector();
            p3 = new Leap.Vector();
            p4 = new Leap.Vector();

            resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            controller = new Controller();

        }

        private void initTimer()
        {
            clicked = false;
            plane = new plane_equ(p1, p2, p3, p4, resolution);
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10;
            timer.Start();
        }

        //private bool index_meets_thumb()
        //{
        //    Leap.Vector index;
        //    Leap.Vector thumb;

        //    index = get_point(Finger.FingerType.TYPE_INDEX);
        //    thumb = get_point(Finger.FingerType.TYPE_THUMB);

        //    double distance = Math.Sqrt(Math.Pow(index.x - thumb.x, 2)
        //                                + Math.Pow(index.y - thumb.y, 2)
        //                                + Math.Pow(index.z - thumb.z, 2));

        //    return distance <= 20;
        //}

        private void timer_Tick(object sender, EventArgs e)
        {
            bool up = false;
            coor = get_point(Finger.FingerType.TYPE_INDEX);

            //frame = controller.Frame();
            //pointable = frame.Pointables.Frontmost;
            //coor = pointable.TipPosition;
            //Console.WriteLine(coor);

            touch = plane.get_projected_coor(coor);

            if (touch.x >= 0 && touch.x <= resolution.Width
                && touch.y >= 0 && touch.y <= resolution.Height)
            {
                float res = plane.on_plane(coor);
                //WindowsHandler.SetCursorPos((int)touch.x, resolution.Height - (int)touch.y);
                //Console.Write(touch);
                //Console.Write("\n");
                //Console.Write(res);
                if (res < 100)
                {
                    Cursor.Position = new Point((int)touch.x, resolution.Height - (int)touch.y);
                    if (res < 5)
                    {
                        //Console.WriteLine("Clicked");
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        clicked = true;
                    }
                    else if (clicked)
                        up = true;
                }
                else if (clicked)
                    up = true;
                
            }
            else if (clicked)
                up = true;

            if (up)
            {
                //Console.WriteLine("Release");
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                clicked = false;
            }
        }

        private Leap.Vector get_point()
        {
            frame = controller.Frame();
            hand = frame.Hands.Rightmost;
            return hand.PalmPosition;
        }

        private Leap.Vector get_point(Leap.Finger.FingerType type)
        {
            frame = controller.Frame();
            hand = frame.Hands.Rightmost;
            pointer = hand.Fingers.FingerType(type);
            return pointer[0].Bone(Bone.BoneType.TYPE_DISTAL).NextJoint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = get_point(Finger.FingerType.TYPE_INDEX);
            label1.Text = p1.x + " " + p1.y + " " + p1.z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p2 = get_point(Finger.FingerType.TYPE_INDEX);
            label2.Text = p2.x + " " + p2.y + " " + p2.z;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p3 = get_point(Finger.FingerType.TYPE_INDEX);
            label3.Text = p3.x + " " + p3.y + " " + p3.z;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p4 = get_point(Finger.FingerType.TYPE_INDEX);
            label4.Text = p4.x + " " + p4.y + " " + p4.z;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            initTimer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string savePath = Application.StartupPath + "\\Leap_position.dat";
            System.IO.File.WriteAllText(savePath, p1.x + " " + p1.y + " " + p1.z + Environment.NewLine);
            System.IO.File.AppendAllText(savePath, p2.x + " " + p2.y + " " + p2.z + Environment.NewLine);
            System.IO.File.AppendAllText(savePath, p3.x + " " + p3.y + " " + p3.z + Environment.NewLine);
            System.IO.File.AppendAllText(savePath, p4.x + " " + p4.y + " " + p4.z + Environment.NewLine);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string savePath = Application.StartupPath + "\\Leap_position.dat";
            string[] textValue = System.IO.File.ReadAllLines(savePath);

            string[] values = textValue[0].Split(' ');
            p1.x = System.Convert.ToSingle(values[0]);
            p1.y = System.Convert.ToSingle(values[1]);
            p1.z = System.Convert.ToSingle(values[2]);

            values = textValue[1].Split(' ');
            p2.x = System.Convert.ToSingle(values[0]);
            p2.y = System.Convert.ToSingle(values[1]);
            p2.z = System.Convert.ToSingle(values[2]);

            values = textValue[2].Split(' ');
            p3.x = System.Convert.ToSingle(values[0]);
            p3.y = System.Convert.ToSingle(values[1]);
            p3.z = System.Convert.ToSingle(values[2]);

            values = textValue[3].Split(' ');
            p4.x = System.Convert.ToSingle(values[0]);
            p4.y = System.Convert.ToSingle(values[1]);
            p4.z = System.Convert.ToSingle(values[2]);
        }
    }
}
