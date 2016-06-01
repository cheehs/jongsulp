using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Jonsulp
{
    public class Image_control
    {
        enum Direction
        {
            NW,
            N,
            NE,
            W,
            E,
            SW,
            S,
            SE,
            None
        }
        Direction dir;

        private const int DRAG_HANDLE_SIZE = 7;
        private int mouseX, mouseY;
        private Control SelectedControl;
        private Control pictureBox_Control;
        private Form parent;
        private Point newLoc;
        private Size newSize;
        private Timer timer1;

        public Image_control(Control control, Form parent)
        {
            pictureBox_Control = control;
            this.parent = parent;
            pictureBox_Control.MouseEnter += control_MouseEnter;
            pictureBox_Control.MouseLeave += control_MouseLeave;
            pictureBox_Control.MouseDown += control_MouseDown;
            pictureBox_Control.MouseUp += control_MouseUp;
            pictureBox_Control.MouseMove += control_MouseMove;
            parent.MouseMove += Form1_MouseMove;
            parent.MouseUp += Form1_MouseUp;
            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += new System.EventHandler(timer1_Tick);
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            parent.Cursor = Cursors.SizeAll;
        }
        private void control_MouseLeave(object sender, EventArgs e)
        {
            parent.Cursor = Cursors.Default;
            timer1.Start();
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                parent.Invalidate();
                SelectedControl = (Control)sender;
                Control control = (Control)sender;
                mouseX = -e.X;
                mouseY = -e.Y;
                control.Invalidate();
                DrawControlBorder(control);
            }
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control control = (Control)sender;
                Point nextpnt = new Point();
                nextpnt = parent.PointToClient(Control.MousePosition);
                nextpnt.Offset(mouseX, mouseY);
                control.Location = nextpnt;
                parent.Invalidate();
            }
        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control control = (Control)sender;
                Cursor.Clip = System.Drawing.Rectangle.Empty;
                control.Invalidate();
                DrawControlBorder(control);
            }
        }

        private void DrawControlBorder(object sender)
        {
            Control control = (Control)sender;
            
            Rectangle Border = new Rectangle(
                 new Point(control.Location.X - DRAG_HANDLE_SIZE / 2,
                 control.Location.Y - DRAG_HANDLE_SIZE / 2),
                 new Size(control.Size.Width + DRAG_HANDLE_SIZE,
                     control.Size.Height + DRAG_HANDLE_SIZE));
            //define the 8 drag handles, that has the size of DRAG_HANDLE_SIZE
            Rectangle NW = new Rectangle(
                new Point(control.Location.X - DRAG_HANDLE_SIZE,
                control.Location.Y - DRAG_HANDLE_SIZE),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle N = new Rectangle(
                new Point(control.Location.X + control.Width / 2 - DRAG_HANDLE_SIZE / 2,
                control.Location.Y - DRAG_HANDLE_SIZE),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle NE = new Rectangle(
                new Point(control.Location.X + control.Width,
                control.Location.Y - DRAG_HANDLE_SIZE),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle W = new Rectangle(
                new Point(control.Location.X - DRAG_HANDLE_SIZE,
                control.Location.Y + control.Height / 2 - DRAG_HANDLE_SIZE / 2),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle E = new Rectangle(
                new Point(control.Location.X + control.Width,
                control.Location.Y + control.Height / 2 - DRAG_HANDLE_SIZE / 2),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle SW = new Rectangle(
                new Point(control.Location.X - DRAG_HANDLE_SIZE,
                control.Location.Y + control.Height),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle S = new Rectangle(
                new Point(control.Location.X + control.Width / 2 - DRAG_HANDLE_SIZE / 2,
                control.Location.Y + control.Height),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            Rectangle SE = new Rectangle(
                new Point(control.Location.X + control.Width,
                control.Location.Y + control.Height),
                new Size(DRAG_HANDLE_SIZE, DRAG_HANDLE_SIZE));
            //get the form graphic
            Graphics g = parent.CreateGraphics();
            //draw the border and drag handles
            
            ControlPaint.DrawBorder(g, Border, Color.Gray, ButtonBorderStyle.Dotted);
            ControlPaint.DrawGrabHandle(g, NW, true, true);
            ControlPaint.DrawGrabHandle(g, N, true, true);
            ControlPaint.DrawGrabHandle(g, NE, true, true);
            ControlPaint.DrawGrabHandle(g, W, true, true);
            ControlPaint.DrawGrabHandle(g, E, true, true);
            ControlPaint.DrawGrabHandle(g, SW, true, true);
            ControlPaint.DrawGrabHandle(g, S, true, true);
            ControlPaint.DrawGrabHandle(g, SE, true, true);
            g.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedControl != null && e.Button == MouseButtons.Left)
            {
                timer1.Stop();
                parent.Invalidate();

                if (SelectedControl.Height < 20)
                {
                    SelectedControl.Height = 20;
                    dir = Direction.None;
                    parent.Cursor = Cursors.Default;
                    return;
                }


                Point pos = parent.PointToClient(Control.MousePosition);
                #region resize the control in 8 directions
                if (dir == Direction.NW)
                {
                    //north west, location and width, height change
                    newLoc = new Point(pos.X, pos.Y);
                    newSize = new Size(SelectedControl.Size.Width - (newLoc.X - SelectedControl.Location.X),
                        SelectedControl.Height - (newLoc.Y - SelectedControl.Location.Y));
                    SelectedControl.Location = newLoc;
                    SelectedControl.Size = newSize;
                }
                else if (dir == Direction.N)
                {
                    //north, location and height change
                    newLoc = new Point(SelectedControl.Location.X, pos.Y);
                    newSize = new Size(SelectedControl.Width,
                        SelectedControl.Height - (pos.Y - SelectedControl.Location.Y));
                    SelectedControl.Location = newLoc;
                    SelectedControl.Size = newSize;
                }
                else if (dir == Direction.NE)
                {
                    //north east, location, width and height change
                    newLoc = new Point(SelectedControl.Location.X, pos.Y);
                    newSize = new Size(pos.X - SelectedControl.Location.X,
                        SelectedControl.Height - (pos.Y - SelectedControl.Location.Y));
                    SelectedControl.Location = newLoc;
                    SelectedControl.Size = newSize;
                }

                else if (dir == Direction.W)
                {
                    //west, location and width will change
                    newLoc = new Point(pos.X, SelectedControl.Location.Y);
                    newSize = new Size(SelectedControl.Width - (pos.X - SelectedControl.Location.X),
                        SelectedControl.Height);
                    SelectedControl.Location = newLoc;
                    SelectedControl.Size = newSize;
                }
                else if (dir == Direction.E)
                {
                    //east, only width changes
                    newLoc = new Point(pos.X, pos.Y);
                    newSize = new Size(pos.X - SelectedControl.Location.X,
                        SelectedControl.Height);
                    SelectedControl.Size = newSize;
                }
                else if (dir == Direction.SW)
                {
                    //south west, location, width and height change
                    newLoc = new Point(pos.X, SelectedControl.Location.Y);
                    newSize = new Size(SelectedControl.Width - (pos.X - SelectedControl.Location.X),
                        pos.Y - SelectedControl.Location.Y);
                    SelectedControl.Location = newLoc;
                    SelectedControl.Size = newSize;
                }
                else if (dir == Direction.S)
                {
                    //south, only the height changes
                    newLoc = new Point(pos.X, pos.Y);
                    newSize = new Size(SelectedControl.Width, pos.Y - SelectedControl.Location.Y);

                    SelectedControl.Size = newSize;
                }
                else if (dir == Direction.SE)
                {
                    //south east, width and height change
                    newLoc = new Point(pos.X, pos.Y);
                    newSize = new Size(SelectedControl.Width + (newLoc.X - SelectedControl.Size.Width - SelectedControl.Location.X),
                        SelectedControl.Height + (newLoc.Y - SelectedControl.Height - SelectedControl.Location.Y));

                    SelectedControl.Size = newSize;
                }
                else // 크기 변환 부분이 아닐 때는 그냥 이동.
                {
                    Rectangle rect = SelectedControl.RectangleToScreen(SelectedControl.Bounds);

                    Point mouse = e.Location;
                    mouse.X += rect.X;
                    mouse.Y += rect.Y;

                    //pictureBox 범위 안에 있을 때 이동
                    if (rect.Contains(mouse))
                    {
                        Point pt = new Point(SelectedControl.Location.X - Control.MousePosition.X, SelectedControl.Location.Y - Control.MousePosition.Y);
                        SelectedControl.Location = new Point(SelectedControl.Location.X + pt.X, SelectedControl.Location.Y + pt.Y);
                    }
                    else
                        mouse = Point.Empty;
                }
                #endregion
            }
            else
            {
                timer1.Start();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (SelectedControl != null)
                DrawControlBorder(SelectedControl);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Get the direction and display correct cursor
            if (SelectedControl != null)
            {
                Point pos = parent.PointToClient(Control.MousePosition);
                //check if the mouse cursor is within the drag handle
                if ((pos.X >= SelectedControl.Location.X - DRAG_HANDLE_SIZE &&
                    pos.X <= SelectedControl.Location.X) &&
                    (pos.Y >= SelectedControl.Location.Y - DRAG_HANDLE_SIZE &&
                    pos.Y <= SelectedControl.Location.Y))
                {
                    dir = Direction.NW;
                    parent.Cursor = Cursors.SizeNWSE;
                }

                else if ((pos.X >= SelectedControl.Location.X + SelectedControl.Width &&
                    pos.X <= SelectedControl.Location.X + SelectedControl.Width + DRAG_HANDLE_SIZE &&
                    pos.Y >= SelectedControl.Location.Y + SelectedControl.Height &&
                    pos.Y <= SelectedControl.Location.Y + SelectedControl.Height + DRAG_HANDLE_SIZE))
                {
                    dir = Direction.SE;
                    parent.Cursor = Cursors.SizeNWSE;
                }

                else if ((pos.X >= SelectedControl.Location.X + SelectedControl.Width / 2 - DRAG_HANDLE_SIZE / 2) &&
                    pos.X <= SelectedControl.Location.X + SelectedControl.Width / 2 + DRAG_HANDLE_SIZE / 2 &&
                    pos.Y >= SelectedControl.Location.Y - DRAG_HANDLE_SIZE &&
                    pos.Y <= SelectedControl.Location.Y)
                {
                    dir = Direction.N;
                    parent.Cursor = Cursors.SizeNS;
                }

                else if ((pos.X >= SelectedControl.Location.X + SelectedControl.Width / 2 - DRAG_HANDLE_SIZE / 2) &&
                    pos.X <= SelectedControl.Location.X + SelectedControl.Width / 2 + DRAG_HANDLE_SIZE / 2 &&
                    pos.Y >= SelectedControl.Location.Y + SelectedControl.Height &&
                    pos.Y <= SelectedControl.Location.Y + SelectedControl.Height + DRAG_HANDLE_SIZE)
                {
                    dir = Direction.S;
                    parent.Cursor = Cursors.SizeNS;
                }

                else if ((pos.X >= SelectedControl.Location.X - DRAG_HANDLE_SIZE &&
                    pos.X <= SelectedControl.Location.X &&
                    pos.Y >= SelectedControl.Location.Y + SelectedControl.Height / 2 - DRAG_HANDLE_SIZE / 2 &&
                    pos.Y <= SelectedControl.Location.Y + SelectedControl.Height / 2 + DRAG_HANDLE_SIZE / 2))
                {
                    dir = Direction.W;
                    parent.Cursor = Cursors.SizeWE;
                }

                else if ((pos.X >= SelectedControl.Location.X + SelectedControl.Width &&
                    pos.X <= SelectedControl.Location.X + SelectedControl.Width + DRAG_HANDLE_SIZE &&
                    pos.Y >= SelectedControl.Location.Y + SelectedControl.Height / 2 - DRAG_HANDLE_SIZE / 2 &&
                    pos.Y <= SelectedControl.Location.Y + SelectedControl.Height / 2 + DRAG_HANDLE_SIZE / 2))
                {
                    dir = Direction.E;
                    parent.Cursor = Cursors.SizeWE;
                }

                else if ((pos.X >= SelectedControl.Location.X + SelectedControl.Width &&
                    pos.X <= SelectedControl.Location.X + SelectedControl.Width + DRAG_HANDLE_SIZE) &&
                    (pos.Y >= SelectedControl.Location.Y - DRAG_HANDLE_SIZE &&
                    pos.Y <= SelectedControl.Location.Y))
                {
                    dir = Direction.NE;
                    parent.Cursor = Cursors.SizeNESW;
                }

                else if ((pos.X >= SelectedControl.Location.X - DRAG_HANDLE_SIZE &&
                    pos.X <= SelectedControl.Location.X + DRAG_HANDLE_SIZE) &&
                    (pos.Y >= SelectedControl.Location.Y + SelectedControl.Height - DRAG_HANDLE_SIZE &&
                    pos.Y <= SelectedControl.Location.Y + SelectedControl.Height + DRAG_HANDLE_SIZE))
                {
                    dir = Direction.SW;
                    parent.Cursor = Cursors.SizeNESW;
                }

                else
                {
                    parent.Cursor = Cursors.Default;
                    dir = Direction.None;
                }
            }

            else
            {
                dir = Direction.None;
                parent.Cursor = Cursors.Default;
            }
            #endregion
        }
    }
}
