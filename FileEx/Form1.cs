using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd=new FolderBrowserDialog() { Description="Select Path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                pathBox.Text = fbd.SelectedPath;
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }


        
    }
}
