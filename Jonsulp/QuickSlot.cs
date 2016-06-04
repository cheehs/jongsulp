using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System;
using Jonsulp.Properties;

namespace Jonsulp
{
    public class QuickSlot
    {
        public static Panel slot_base;
        private static PictureBox slot_exit;
        private Control control;
        private static System.Windows.Forms.Timer sbTimer = new System.Windows.Forms.Timer();
        private static System.Windows.Forms.Timer siTimer = new System.Windows.Forms.Timer();
        private static Stopwatch stopWatch = new Stopwatch();
        private readonly object meLock = new object();

        private Point currentCursorPos;
        private bool me_active = false;
        private bool is_shown = false;
        private bool is_animaiting = false;
        private bool showSize = false;

        private double tick;
        private int opacity = 255;

        private static int SB_S = 200;
        private static int SE_S = 76;
        private static int xpos;

        public QuickSlot(Control control)
        {
            this.control = control;

            //퀵 슬롯 베이스
            slot_base = new Panel
            {
                Size = new Size(0, 0),
                BackColor = Color.Transparent,
                BackgroundImage = Resources.slot_base,
                BackgroundImageLayout = ImageLayout.Stretch,
                Visible = false
            };

            //exit 버튼
            slot_exit = new PictureBox
            {
                Size = new Size(SE_S, SE_S),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(SB_S / 2 - SE_S / 2, SB_S / 2 - SE_S / 2),
                Image = Resources.slot_exit,
                Visible = false,
            };
            //exit 버튼에 마우스 이벤트 핸들러 추가
            slot_exit.MouseClick += new MouseEventHandler(slot_exitMouseHander);

            //퀵 슬롯 base에 exit 버튼 추가
            slot_base.Controls.Add(slot_exit);

            //Form에 퀵 슬롯 추가
            control.Controls.Add(slot_base);

            //Form에 마우스 이벤트 핸들러 추가
            control.MouseDown += new MouseEventHandler(controlMouseDownEventHandler);
            control.MouseUp += new MouseEventHandler(controlMouseUpEventHandler);

            //sbTimer에 애니메이션을 처리할 타임 이벤트 핸들러 추가
            sbTimer.Tick += new EventHandler(slotBaseTimer_Tick);
            sbTimer.Interval = 1;
            sbTimer.Enabled = true;
            sbTimer.Stop();

            //siTimer에 애니메이션을 처리할 타임 이벤트 핸들러 추가
            siTimer.Tick += new EventHandler(slotIconTimer_Tick);
            siTimer.Interval = 1;
            siTimer.Enabled = true;
            siTimer.Stop();
        }

        private void show()
        {
            currentCursorPos = control.PointToClient(Cursor.Position);
            slot_base.Visible = true;
            sbTimer.Start();
        }

        private void hide()
        {
            siTimer.Start();
        }

        private void slotIconTimer_Tick(object sender, EventArgs e)
        {
            Image img = Resources.slot_exit;
            Bitmap origin = new Bitmap(img);
            Bitmap newbit = new Bitmap(img.Width, img.Height);
            Color c = Color.Black;
            Color v = Color.Black;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    c = origin.GetPixel(x, y);
                    int o = c.A - opacity;
                    v = Color.FromArgb(o > 255 ? 255 : o < 0 ? 0 : o, c.R, c.G, c.B);
                    newbit.SetPixel(x, y, v);
                }
            }

            slot_exit.Image = newbit;
            slot_exit.Visible = true;

            if (!is_shown)
            {
                if (opacity > 45)
                    opacity -= 45;
                else
                {
                    siTimer.Stop();
                    is_shown = true;
                    is_animaiting = false;
                }
            }
            else
            {
                if (opacity < 255)
                    opacity += 90;
                else
                {
                    slot_exit.Visible = false;
                    siTimer.Stop();
                    sbTimer.Start();
                }
            }
        }

        private void slotBaseTimer_Tick(object sender, EventArgs e)
        {
            if (!is_animaiting)
            {
                is_animaiting = true;
                tick = 0;
            }

            int tick_pow = (int)(tick * tick);

            if (!is_shown)
            {
                if (slot_base.Size.Width < SB_S + SB_S / 10 && !showSize)
                {
                    slot_base.Size = new Size(slot_base.Size.Width + tick_pow, slot_base.Size.Height + tick_pow);
                    slot_base.Location = new Point(currentCursorPos.X - slot_base.Size.Width / 2,
                        currentCursorPos.Y - slot_base.Size.Height / 2);
                }
                else if (slot_base.Size.Width > SB_S)
                {
                    if (!showSize)
                    {
                        showSize = true;
                    }
                    slot_base.Size = new Size(slot_base.Size.Width - tick_pow, slot_base.Size.Height - tick_pow);
                    slot_base.Location = new Point(currentCursorPos.X - slot_base.Size.Width / 2,
                        currentCursorPos.Y - slot_base.Size.Height / 2);
                }
                else
                {
                    showSize = false;
                    slot_base.Size = new Size(SB_S, SB_S);
                    slot_base.Location = new Point(currentCursorPos.X - slot_base.Size.Width / 2,
                        currentCursorPos.Y - slot_base.Size.Height / 2);
                    sbTimer.Stop();
                    siTimer.Start();
                }
            }
            else
            {
                if (slot_base.Size.Width > 0)
                {
                    slot_base.Size = new Size(slot_base.Size.Width - tick_pow, slot_base.Size.Height - tick_pow);
                    slot_base.Location = new Point(currentCursorPos.X - slot_base.Size.Width / 2,
                        currentCursorPos.Y - slot_base.Size.Height / 2);
                }
                else
                {
                    sbTimer.Stop();
                    is_shown = false;
                    is_animaiting = false;
                }
            }

            tick += 0.3;
        }

        private void controlMouseUpEventHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!is_shown)
                {
                    stopWatch.Stop();

                    if (Math.Abs(e.Location.X - xpos) < 100
                        && stopWatch.ElapsedMilliseconds >= 500
                        && !is_animaiting)
                    {
                        show();
                    }
                }
                else
                    hide();

                if (Monitor.TryEnter(meLock))
                {
                    try
                    {
                        me_active = false;
                    }
                    finally
                    {
                        Monitor.Exit(meLock);
                    }
                }
            }
        }

        private void controlMouseDownEventHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("C");
                if (Monitor.TryEnter(meLock))
                {
                    try
                    {
                        if (me_active)
                            return;

                        Console.Write("Enter\n");
                        me_active = true;

                        if (!is_shown)
                        {
                            xpos = e.Location.X;
                            stopWatch.Restart();
                        }
                    }
                    finally
                    {
                        Monitor.Exit(meLock);
                    }
                }
            }
        }

        private void slot_exitMouseHander(object sender, MouseEventArgs e)
        {
            hide();
        }
    }
}
