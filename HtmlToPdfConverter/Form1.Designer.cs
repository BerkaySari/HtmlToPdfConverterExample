using System;

namespace HtmlToPdfConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbOut1 = new System.Windows.Forms.Label();
            this.tbOutPathFile = new System.Windows.Forms.TextBox();
            this.tbFileNameFile = new System.Windows.Forms.TextBox();
            this.tbJsFile = new System.Windows.Forms.TextBox();
            this.tbCssFile = new System.Windows.Forms.TextBox();
            this.tbHtmlFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbOutPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbOut2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbJs = new System.Windows.Forms.RichTextBox();
            this.rtbCss = new System.Windows.Forms.RichTextBox();
            this.rtbHtml = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 455);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lbOut1);
            this.tabPage1.Controls.Add(this.tbOutPathFile);
            this.tabPage1.Controls.Add(this.tbFileNameFile);
            this.tabPage1.Controls.Add(this.tbJsFile);
            this.tabPage1.Controls.Add(this.tbCssFile);
            this.tabPage1.Controls.Add(this.tbHtmlFile);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnConvertFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read From File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "File Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Output Path";
            // 
            // lbOut1
            // 
            this.lbOut1.AutoSize = true;
            this.lbOut1.Location = new System.Drawing.Point(202, 364);
            this.lbOut1.Name = "lbOut1";
            this.lbOut1.Size = new System.Drawing.Size(68, 13);
            this.lbOut1.TabIndex = 7;
            this.lbOut1.Text = "Output Label";
            this.lbOut1.Visible = false;
            this.lbOut1.Click += new System.EventHandler(this.tbJsFile_Click);
            // 
            // tbOutPathFile
            // 
            this.tbOutPathFile.Location = new System.Drawing.Point(205, 270);
            this.tbOutPathFile.Name = "tbOutPathFile";
            this.tbOutPathFile.Size = new System.Drawing.Size(449, 20);
            this.tbOutPathFile.TabIndex = 6;
            // 
            // tbFileNameFile
            // 
            this.tbFileNameFile.Location = new System.Drawing.Point(205, 306);
            this.tbFileNameFile.Name = "tbFileNameFile";
            this.tbFileNameFile.Size = new System.Drawing.Size(449, 20);
            this.tbFileNameFile.TabIndex = 6;
            this.tbFileNameFile.Click += new System.EventHandler(this.tbJsFile_Click);
            // 
            // tbJsFile
            // 
            this.tbJsFile.Location = new System.Drawing.Point(205, 150);
            this.tbJsFile.Name = "tbJsFile";
            this.tbJsFile.Size = new System.Drawing.Size(449, 20);
            this.tbJsFile.TabIndex = 6;
            this.tbJsFile.Click += new System.EventHandler(this.tbJsFile_Click);
            // 
            // tbCssFile
            // 
            this.tbCssFile.Location = new System.Drawing.Point(205, 101);
            this.tbCssFile.Name = "tbCssFile";
            this.tbCssFile.Size = new System.Drawing.Size(449, 20);
            this.tbCssFile.TabIndex = 5;
            this.tbCssFile.Click += new System.EventHandler(this.tbCssFile_Click);
            // 
            // tbHtmlFile
            // 
            this.tbHtmlFile.Location = new System.Drawing.Point(205, 56);
            this.tbHtmlFile.Name = "tbHtmlFile";
            this.tbHtmlFile.Size = new System.Drawing.Size(449, 20);
            this.tbHtmlFile.TabIndex = 4;
            this.tbHtmlFile.Click += new System.EventHandler(this.tbHtmlFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Javascript File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Css File Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Html File Path";
            // 
            // btnConvertFile
            // 
            this.btnConvertFile.Location = new System.Drawing.Point(336, 196);
            this.btnConvertFile.Name = "btnConvertFile";
            this.btnConvertFile.Size = new System.Drawing.Size(105, 50);
            this.btnConvertFile.TabIndex = 0;
            this.btnConvertFile.Text = "Convert";
            this.btnConvertFile.UseVisualStyleBackColor = true;
            this.btnConvertFile.Click += new System.EventHandler(this.btnConvertFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbFileName);
            this.tabPage2.Controls.Add(this.tbOutPath);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lbOut2);
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rtbJs);
            this.tabPage2.Controls.Add(this.rtbCss);
            this.tabPage2.Controls.Add(this.rtbHtml);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read From Input";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(79, 389);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(390, 20);
            this.tbFileName.TabIndex = 11;
            // 
            // tbOutPath
            // 
            this.tbOutPath.Location = new System.Drawing.Point(79, 343);
            this.tbOutPath.Name = "tbOutPath";
            this.tbOutPath.Size = new System.Drawing.Size(390, 20);
            this.tbOutPath.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "File Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Out Path";
            // 
            // lbOut2
            // 
            this.lbOut2.AutoSize = true;
            this.lbOut2.Location = new System.Drawing.Point(519, 392);
            this.lbOut2.Name = "lbOut2";
            this.lbOut2.Size = new System.Drawing.Size(68, 13);
            this.lbOut2.TabIndex = 7;
            this.lbOut2.Text = "Output Label";
            this.lbOut2.Visible = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(570, 330);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(110, 44);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Javascript";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Css";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Html";
            // 
            // rtbJs
            // 
            this.rtbJs.Location = new System.Drawing.Point(79, 219);
            this.rtbJs.Name = "rtbJs";
            this.rtbJs.Size = new System.Drawing.Size(601, 96);
            this.rtbJs.TabIndex = 2;
            this.rtbJs.Text = "";
            // 
            // rtbCss
            // 
            this.rtbCss.Location = new System.Drawing.Point(79, 117);
            this.rtbCss.Name = "rtbCss";
            this.rtbCss.Size = new System.Drawing.Size(601, 96);
            this.rtbCss.TabIndex = 1;
            this.rtbCss.Text = "";
            // 
            // rtbHtml
            // 
            this.rtbHtml.Location = new System.Drawing.Point(79, 15);
            this.rtbHtml.Name = "rtbHtml";
            this.rtbHtml.Size = new System.Drawing.Size(601, 96);
            this.rtbHtml.TabIndex = 0;
            this.rtbHtml.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConvertFile;
        private System.Windows.Forms.TextBox tbJsFile;
        private System.Windows.Forms.TextBox tbCssFile;
        private System.Windows.Forms.TextBox tbHtmlFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbJs;
        private System.Windows.Forms.RichTextBox rtbCss;
        private System.Windows.Forms.RichTextBox rtbHtml;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbOut1;
        private System.Windows.Forms.Label lbOut2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOutPathFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFileNameFile;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbOutPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

