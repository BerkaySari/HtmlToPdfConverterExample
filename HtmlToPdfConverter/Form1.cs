using System;
using System.Windows.Forms;

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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string html = tbHtmlFile.Text;
            string css = tbCssFile.Text;
            //string js = tbJsFile.Text;

            string outPath = tbOutPath.Text;
            string fileName = tbFileName.Text;

            Business.Convert cn = new Business.Convert();
            lbOut2.Text = cn.HtmlCssToPdfConvert(html, css, outPath, fileName);
            lbOut2.Visible = true;
        }

        private void btnConvertFile_Click(object sender, EventArgs e)
        {
            string htmlPath = tbHtmlFile.Text;
            string cssPath = tbCssFile.Text;
            //string js = tbJsFile.Text;

            string outPath = tbOutPathFile.Text;
            string fileName = tbFileNameFile.Text;
            
            Business.Convert cn = new Business.Convert();
            lbOut1.Text = cn.PathPreConvertEvents(htmlPath, cssPath, "", outPath, fileName);
            lbOut1.Visible = true;
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
