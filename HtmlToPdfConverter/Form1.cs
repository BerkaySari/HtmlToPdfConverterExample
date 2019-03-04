using System;
using System.Diagnostics;
using System.Windows.Forms;
using Business;

namespace HtmlToPdfConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbOutPathFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            tbOutPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }


        private void btnConvertFile_Click(object sender, EventArgs e)
        {
            string htmlPath = tbHtmlFile.Text;
            string cssPath = tbCssFile.Text;
            string js = tbJsFile.Text;

            string outPath = tbOutPathFile.Text;
            string fileName = tbFileNameFile.Text;
            
            ConverterLibrary lib = (ConverterLibrary)Enum.Parse(typeof(ConverterLibrary), cbLibrary.Text, true);
            lbOut1.Text = ConvertSelector.PathPreConvertEvents(lib, htmlPath, cssPath, js, outPath, fileName);
            lbOut1.Visible = true;

            bool download = cbOpen1.Checked;
            if (download)
                Process.Start(lbOut1.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string html = rtbHtml.Text;
            string css = rtbCss.Text;
            string js = rtbJs.Text;

            string outPath = tbOutPath.Text;
            string fileName = tbFileName.Text;
            
            ConverterLibrary lib = (ConverterLibrary)Enum.Parse(typeof(ConverterLibrary), cbLibrary2.Text, true);
            lbOut2.Text = ConvertSelector.HtmlCssToPdfConvert(lib, html, css, js, outPath, fileName);
            lbOut2.Visible = true;

            bool download = cbOpen2.Checked;
            if (download)
                Process.Start(lbOut2.Text);
        }


        private void tbHtmlFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
        
            if (file.ShowDialog() == DialogResult.OK)
            {
                tbHtmlFile.Text = file.FileName;
            }
        }

        private void tbCssFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                tbCssFile.Text = file.FileName;
            }
        }

        private void tbJsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                tbJsFile.Text = file.FileName;
            }
        }
    }
}
