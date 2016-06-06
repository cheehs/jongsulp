using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

//Additional namespace
using WolframAlphaNET;

namespace Jonsulp
{
    public partial class MainForm : Form
    {
        PPT ppt;
        string path;
        // variables
        string input = "y=(x+1)(x-1)(x-3)";
        int xpos;
        Bitmap gBitmap;
        ArrayList filelist = new ArrayList();

        /// <summary>
        /// MainForm 생성자
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            text_input.Text = input;

            ppt = new PPT(image);
            QuickSlot qs = new QuickSlot(image, this);
            Image_control ic = new Image_control(pictureBox_image, this);

            //이미지 파일 목록 불러오기
            path = System.Windows.Forms.Application.StartupPath + "\\Images\\Maps";
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            foreach (string s in System.IO.Directory.GetFiles(path))
            {
                ToolStripMenuItem temp = new ToolStripMenuItem();
                filelist.Add(s);
                toolStripMenuItem1.DropDownItems.Add(temp);
                temp.Name = s.Substring(path.Length + 1);
                temp.Size = new System.Drawing.Size(152, 22);
                temp.Text = s.Substring(path.Length + 1);
                temp.Click += new System.EventHandler(this.contextButton_Click);
            }

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void 이미지열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "이미지";
            openFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            string openstrFilename;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openstrFilename = openFileDialog1.FileName;
                Image image1 = Image.FromFile(openstrFilename);

                pictureBox_image.Image = image1;
                gBitmap = new Bitmap(image1);
                pictureBox_image.Visible = true;
                image.Invalidate();
            }
        }

        public void pPT열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ppt.openPPT(ofd);
        }

        public void 그래프ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InkRecognition.InkRecognition ink = new InkRecognition.InkRecognition(
                new System.Drawing.Point(MousePosition.X, MousePosition.Y)
                ,'g');
            ink.Owner = this;
            ink.Show();
        }

        public void Plot_graph()
        {
            WolframAlpha wolf = new WolframAlpha("K8WRVX-A3Y7YUUQAV");
            display_Graph(wolf.get_Graph_address(text_input.Text));
            text_input.Text = "";
        }

        private void display_Graph(string src)
        {
            pictureBox_image.Visible = true;
            pictureBox_image.ImageLocation = src;
        }

        public void 초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox_image.Visible = false;
            image.Enabled = true;
        }

        public void 웹검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InkRecognition.InkRecognition ink = new InkRecognition.InkRecognition(
                new System.Drawing.Point(MousePosition.X, MousePosition.Y)
                , 's');
            ink.Owner = this;
            ink.Show();
        }

        public void Search_web()
        {
            search web = new search();
            web.recv(text_input.Text);
            web.Show();
        }

        private void 최대화ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 현재 Full-Screen 모드일 경우 처리  
            if ((FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
                && (WindowState == FormWindowState.Maximized))
            {
                menuStrip1.Visible = true;
                toolStrip1.Visible = true;
                image.Dock = DockStyle.None;
                // Form 상태 변경  
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }

            // 현재 Full-Screen 모드가 아닐 경우 처리  
            else
            {
                //menuStrip1.Visible = false;
                image.Dock = DockStyle.Fill;
                // Form 상태 변경  
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                menuStrip1.Visible = false;
                toolStrip1.Visible = false;
            }

        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            xpos = e.Location.X;
        }

        private void image_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Location.X - xpos > 100) ppt.ppt_prev();
            else if (e.Location.X - xpos < -100) ppt.ppt_next();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                최대화ToolStripMenuItem1_Click(sender, e);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ppt.ppt_prev();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ppt.ppt_next();
        }

        void Image_open(string filename)
        {
            string openstrFilename = filename;
            Image image1 = Image.FromFile(openstrFilename);

            pictureBox_image.Image = image1;
            gBitmap = new Bitmap(image1);
            pictureBox_image.Visible = true;
            image.Invalidate();
        }

        private void 립모션ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leapmtion temp = new Leapmtion();
            temp.Show();
        }

        private void contextButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            Image_open(path+"\\"+temp.Text);
        }
    }
}
