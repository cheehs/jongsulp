using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Additinal namespace
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System.Windows.Forms;
using System.IO;
using WolframAlphaNET;
using WolframAlphaNET.Misc;
using WolframAlphaNET.Objects;

namespace appbase
{
    public partial class MainWindow : Window
    {
        // ppt temp path
        string ppt_temp_path = System.Windows.Forms.Application.StartupPath + "\\ppt_temp";

        // objects
        Presentation ppt;

        // variables
        int slide = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        // Additional Functions
        private int             LoadFile(OpenFileDialog ofd)
        {
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.Title = "Select a File.";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return 1;

            return 0;
        }
        private void            LoadImage(string path)
        {
            var uri = new Uri(path);
            var bitmap = new BitmapImage(uri);
            image.Source = bitmap;
        }
        private Presentation    LoadPPT(string path)
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
        private void            MakePPTimage(Presentation ppt)
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
        private void            DisplayPPTimage(int slide)
        {
            LoadImage(ppt_temp_path + "\\temp" + slide + ".jpg");
        }
        private void            MakeDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
                dir.Create();
        }

        // for debug
        private void            printText(string text)
        {
            text_debug.Text = text;
        }


        // Buttom Event
        private void Button_Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (LoadFile(ofd) != 0)
                return;

            LoadImage(ofd.FileName);
        }

        private void Button_PPT_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (LoadFile(ofd) != 0)
                return;

            ppt = LoadPPT(ofd.FileName);
            MakePPTimage(ppt);

            DisplayPPTimage(slide);
        }

        private void Button_Other_Click(object sender, RoutedEventArgs e)
        {
            printText("아직 기능이 구현되지 않은 버튼입니다.");
        }

        private void Button_Prev_Click(object sender, RoutedEventArgs e)
        {
            if (slide <= 0)
                return;

            slide--;
            DisplayPPTimage(slide);
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            if (slide >= ppt.Slides.Count)
                return;

            slide++;
            DisplayPPTimage(slide);
        }

        private void button_graph_Click(object sender, RoutedEventArgs e)
        {          
            plot_Graph(textBox1.Text);
            textBox1.Text = "";
        }

        private void plot_Graph(string equations)
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
                                BitmapImage temp = new BitmapImage();
                                temp.BeginInit();
                                temp.UriSource = new Uri(subPod.Image.Src);
                                temp.EndInit();

                                image_Graph.Source = temp;
                            }
                        }
                    }
                }
            }
        }
    }
}
