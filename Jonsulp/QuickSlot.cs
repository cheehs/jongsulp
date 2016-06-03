﻿using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System;
using Jonsulp.Properties;

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

//Additional namespace
using Microsoft.Office.Core;
//using Microsoft.Office.Interop.PowerPoint;
using WolframAlphaNET;
namespace Jonsulp
{
    class QuickSlot
    {
        public Panel slot_base;

        private PictureBox slot_exit;
        private PictureBox image;
        private PictureBox ppt;
        private PictureBox graph;
        private PictureBox search;

        private Form parent;
        private Control control;
        private Timer sbTimer = new Timer();
        private Timer siTimer = new Timer();
        private Stopwatch stopWatch = new Stopwatch();

        private Point currentCursorPos;

        private bool is_shown = false;
        private bool is_animaiting = false;
        private bool showSize = false;

        private double tick;
        private int opacity = 255;

        private static int SB_S = 200;  //Base의size
        private static int SE_S = 76;   //Exit의 Size
        private static int Other_Button_Size = 40;  //나머지 버튼들 사이즈

        public QuickSlot(Control control, Form parent)
        {
            this.control = control;
            this.parent = parent;
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

            ppt = new PictureBox
            {
                Size = new Size(Other_Button_Size, Other_Button_Size),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(SB_S / 2 - SE_S, SB_S / 2 - Other_Button_Size / 2),
                Image = Resources.image,
                Visible = false,
            };

            graph = new PictureBox
            {
                Size = new Size(Other_Button_Size, Other_Button_Size),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(SB_S / 2 + SE_S / 2, SB_S / 2 - Other_Button_Size / 2),
                Image = Resources.graph2,
                Visible = false,
            };

            search = new PictureBox
            {
                Size = new Size(Other_Button_Size, Other_Button_Size),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(SB_S / 2 - Other_Button_Size / 2, SB_S / 2 + SE_S / 2),
                Image = Resources.search__2_,
                Visible = false,
            };

            image = new PictureBox
            {
                Size = new Size(Other_Button_Size, Other_Button_Size),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(SB_S / 2 - Other_Button_Size / 2, SB_S / 2 - SE_S),
                Image = Resources.image,
                Visible = false,
            };


            //exit 버튼에 마우스 이벤트 핸들러 추가
            slot_exit.MouseClick += new MouseEventHandler(slot_exitMouseHander);
            ppt.MouseClick += new MouseEventHandler(pptMouseHander);
            graph.MouseClick += new MouseEventHandler(graphMouseHander);
            search.MouseClick += new MouseEventHandler(searchMouseHander);
            image.MouseClick += new MouseEventHandler(imageMouseHander);


            //퀵 슬롯 base에 버튼 추가
            slot_base.Controls.Add(slot_exit);
            slot_base.Controls.Add(ppt);
            slot_base.Controls.Add(search);
            slot_base.Controls.Add(graph);
            slot_base.Controls.Add(image);


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


            img = Resources.ppt__2_;
            origin = new Bitmap(img);
            newbit = new Bitmap(img.Width, img.Height);
            c = Color.Black;
            v = Color.Black;
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
            ppt.Image = newbit;
            ppt.Visible = true;

            img = Resources.image;
            origin = new Bitmap(img);
            newbit = new Bitmap(img.Width, img.Height);
            c = Color.Black;
            v = Color.Black;
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
            image.Image = newbit;
            image.Visible = true;


            img = Resources.search__2_;
            origin = new Bitmap(img);
            newbit = new Bitmap(img.Width, img.Height);
            c = Color.Black;
            v = Color.Black;
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
            search.Image = newbit;
            search.Visible = true;

            img = Resources.graph2;
            origin = new Bitmap(img);
            newbit = new Bitmap(img.Width, img.Height);
            c = Color.Black;
            v = Color.Black;
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
            graph.Image = newbit;
            graph.Visible = true;

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
                    opacity += 45;
                else
                {
                    slot_exit.Visible = false;
                    ppt.Visible = false;
                    graph.Visible = false;
                    search.Visible = false;
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

                    if (stopWatch.ElapsedMilliseconds >= 500 && !is_animaiting)
                    {
                        show();
                    }
                }
                else
                    hide();
            }
        }

        private void controlMouseDownEventHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!is_shown)
                    stopWatch.Restart();
            }
        }

        private void slot_exitMouseHander(object sender, MouseEventArgs e)
        {
            hide();
        }

        private void pptMouseHander(object sender, MouseEventArgs e)
        {

        }
        private void searchMouseHander(object sender, MouseEventArgs e)
        {
            
        }
        private void graphMouseHander(object sender, MouseEventArgs e)
        {

        }
        private void imageMouseHander(object sender, MouseEventArgs e)
        {

        }



    }
}
