using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace Jonsulp
{
    class PPT
    {
        private Presentation ppt;
        private int slide;
        private int slide_max;
        private string ppt_temp_path = System.Windows.Forms.Application.StartupPath + "\\ppt_temp";
        private Control control;

        public PPT(Control control)
        {
            this.control = control;
        }
        //PPT 클래스가 소멸할 때 PPT 이미지 파일들을 삭제한다.
        ~PPT()
        {
            DirectoryInfo dir = new DirectoryInfo(ppt_temp_path);
            FileInfo[] files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                file.Attributes = FileAttributes.Normal;
            }
            Directory.Delete(ppt_temp_path, true);
        }
        public void openPPT(OpenFileDialog ofd)
        {
            if (LoadFile(ofd) != 0)
                return;
            ppt = LoadPPT(ofd.FileName);
            MakePPTimage(ppt);

            DisplayPPTimage(slide);
        }
        public void ppt_next()
        {
            if (slide > slide_max)
                return;
            slide++;
            DisplayPPTimage(slide);
        }
        public void ppt_prev()
        {
            if (slide <= 0)
                return;
            slide--;
            DisplayPPTimage(slide);
        }

        private int LoadFile(OpenFileDialog ofd)
        {
            ofd.Filter = "Powerpoint 프레젠테이션 (*.ppt;*.pptx)|*.ppt;*.pptx";
            ofd.Title = "Select a File.";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return 1;

            return 0;
        }

        private void LoadImage(string path, Control control)
        {
            control.Visible = true;
            ((PictureBox)control).ImageLocation = path;
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
            LoadImage(ppt_temp_path + "\\temp" + slide + ".jpg", control);
        }

        private void MakeDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
                dir.Create();
        }
    }
}
