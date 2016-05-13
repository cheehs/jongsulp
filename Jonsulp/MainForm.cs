using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

//Additional namespace
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using WolframAlphaNET;
using WolframAlphaNET.Objects;

namespace Jonsulp
{
    public partial class MainForm : Form
    {
        // ppt temp path
        string ppt_temp_path = System.Windows.Forms.Application.StartupPath + "\\ppt_temp";
        string input = "y=(x+1)(x-1)(x-3)";
        // objects
        Presentation ppt;

        //Imaging
        private Boolean drag = false;
        private System.Drawing.Point point;


        // variables
        int slide = 0;
        int slide_max = 0;

        public MainForm()
        {
            InitializeComponent();
            text_input.Text = input;
            pictureBox_image.MouseWheel += new MouseEventHandler(mouse_wheel);
        }

        private void mouse_wheel(object sender, MouseEventArgs e)
        {
            if ((e.Delta / 120) > 0)
            {
                pictureBox_image.Width+=5;
                pictureBox_image.Height+=5;  
                //wheel up
            }
            else
            {
                pictureBox_image.Width-=5;
                pictureBox_image.Height-=5;
                //wheel down
            }
        }

        private int LoadFile(OpenFileDialog ofd)
        {
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.Title = "Select a File.";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return 1;

            return 0;
        }

        private void LoadImage(string path)
        {
            //var uri = new Uri(path);
            image.ImageLocation = path;
        }

        private Presentation LoadPPT(string path)
        {
            ApplicationClass app = new ApplicationClass();
            Presentation ppt = app.Presentations.Open
                (
                path,
                MsoTriState.msoTrue,
                MsoTriState.msoFalse,
                MsoTriState.msoFalse
                );

            app.Quit();
            return ppt;
        }

        private void MakePPTimage(Presentation ppt)
        {
            string picturesPath = ppt_temp_path;
            MakeDir(picturesPath);
            slide_max = ppt.Slides.Count;
            for (int i = 0; i < ppt.Slides.Count; ++i)
            {
                ppt.Slides[i + 1].Export
                    (
                    string.Format("{0}\\temp{1}.jpg", picturesPath, i),
                    "JPG",
                    (int)ppt.Slides[i + 1].Master.Width,
                    (int)ppt.Slides[i + 1].Master.Height
                    );
            }
        }

        private void DisplayPPTimage(int slide)
        {
            LoadImage(ppt_temp_path + "\\temp" + slide + ".jpg");
        }

        private void            MakeDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
                dir.Create();
        }

        //For debug
        private void printText(string text)
        {
            text_debug.Text = text;
        }


        private void button_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (LoadFile(ofd) != 0)
                return;

            pictureBox_image.Visible = true;
            pictureBox_image.ImageLocation = ofd.FileName;
            
        }

        private void button_ppt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (LoadFile(ofd) != 0)
                return;

            ppt = LoadPPT(ofd.FileName);
            MakePPTimage(ppt);

            DisplayPPTimage(slide);
        }

        private void button_graph_Click(object sender, EventArgs e)
        {
            WolframAlpha wolf = new WolframAlpha("K8WRVX-A3Y7YUUQAV");
            picture_Graph(wolf.get_Graph_address(text_input.Text));
            text_input.Text = "";
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (slide <= 0)
                return;

            slide--;
            DisplayPPTimage(slide);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (slide > slide_max)
                return;

            slide++;
            DisplayPPTimage(slide);
        }

        private void picture_Graph(string src)
        {
            image_graph.Visible = true;
            image_graph.ImageLocation = src;
        }

        private void button_ink_Click(object sender, EventArgs e)
        {
            InkRecognition.InkRecognition ink = new InkRecognition.InkRecognition();
            ink.Owner = this;
            ink.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            search web = new search();
            web.recv(text_input.Text);
            web.Show();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            image_graph.Visible = false;
            pictureBox_image.Visible = false;
        }

        //종료 메뉴 클릭시
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //image 버튼과 같음
        private void 이미지열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (LoadFile(ofd) != 0)
                return;

            LoadImage(ofd.FileName);
        }

        //ppt 버튼과 같음
        private void pPT열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (LoadFile(ofd) != 0)
                return;

            ppt = LoadPPT(ofd.FileName);
            MakePPTimage(ppt);

            DisplayPPTimage(slide);
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WolframAlpha wolf = new WolframAlpha("K8WRVX-A3Y7YUUQAV");
            picture_Graph(wolf.get_Graph_address(text_input.Text));
            text_input.Text = "";
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search web = new search();
            web.recv(text_input.Text);
            web.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image_graph.Visible = false;
        }

        private void 필기인식ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InkRecognition.InkRecognition ink = new InkRecognition.InkRecognition();
            ink.Owner = this;
            ink.Show();
        }

        private void pictureBox_image_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pictureBox_image_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                PictureBox temp = (PictureBox)sender;
                temp.Left = e.X + temp.Left - point.X;
                temp.Top = e.Y + temp.Top - point.Y;
            }
        }

        private void pictureBox_image_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            point = new System.Drawing.Point(e.X, e.Y);
        }
    }
}
