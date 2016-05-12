using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jonsulp
{
    public partial class search : Form
    {
        String path = "https://www.google.co.kr/search?newwindow=1&hl=ko&q=";

        public search()
        {
            InitializeComponent();
        }

        public void recv(string word)
        {
            webBrowser1.Navigate(path + word);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri == webBrowser1.Url.AbsoluteUri)
            {
                string data = "";
                HtmlDocument Doc = webBrowser1.Document;
                for (int i = 0; i < Doc.GetElementsByTagName("a").Count; i++)
                {
                    if (Doc.GetElementsByTagName("a")[i].GetAttribute("className").IndexOf("nobr") > -1)
                    {
                        data = Doc.GetElementsByTagName("a")[i].InnerText;
                        databox.AppendText(data + "\n");
                    }
                }

            }
        }
    }
}
