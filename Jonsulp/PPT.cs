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
    public partial class PPT : Form
    {
        // ppt temp path
        string ppt_temp_path = System.Windows.Forms.Application.StartupPath + "\\ppt_temp";
        string input = "y=(x+1)(x-1)(x-3)";
        // objects
        Presentation ppt;

        // variables
        int slide = 0;

        public PPT()
        {
            InitializeComponent();
            text_input.Text = input;
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

            LoadImage(ofd.FileName);
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
            picture_Graph(plot_Graph(text_input.Text));
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
            if (slide >= ppt.Slides.Count)
                return;

            slide++;
            DisplayPPTimage(slide);
        }

        private string plot_Graph(string equations)
        {
            WolframAlpha wolfram = new WolframAlpha("K8WRVX-A3Y7YUUQAV");

            QueryResult results = wolfram.Query(equations);

            if (results != null)
            {
                foreach (Pod pod in results.Pods)
                {
                    if (pod.SubPods != null)
                    {
                        foreach (SubPod subPod in pod.SubPods)
                        {
                            if (pod.Title.Contains("Plot") || pod.Title.Contains("plot"))
                            {
                                return subPod.Image.Src;
                            }
                        }
                    }
                }
            }
            return null;
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
        }
    }
}
