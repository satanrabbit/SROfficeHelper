using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SROfficeHelper
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            fileName = "";
            fileExt = "";
        }
        private string fileName { get; set; }
        private string fileExt{get;set;}
        private void SetTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = (!this.TopMost);
            if (this.TopMost)
            {
                this.SetTopToolStripMenuItem.Text = "取消置顶";
            }
            else
            {
                this.SetTopToolStripMenuItem.Text = "顶端显示";
            }
        }

        private void HideBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.HideBorderToolStripMenuItem.Text = "隐藏边框";
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.HideBorderToolStripMenuItem.Text = "显示边框";
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ContentTextBox.Text = "";
        }

        private void OpacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ShowDialog()
            if (this.Opacity == 1)
            {
                this.Opacity = 0.6;
                this.OpacityToolStripMenuItem.Text = "不透明";
            }
            else
            {
                this.Opacity = 1;
                this.OpacityToolStripMenuItem.Text = "透明";
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text文件(*.txt)|*.txt";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                
                StreamReader streamReader = new StreamReader(filePath, Encoding.GetEncoding("gb2312"));
                 
                string text = streamReader.ReadToEnd();
                streamReader.Dispose();
                this.ContentTextBox.Text = text;
                fileName=filePath.Substring(filePath.LastIndexOf("\\")+1);
                fileExt = filePath.Substring(filePath.LastIndexOf("."));
            }
        }

        private void SaveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = this.ContentTextBox.Text;
            if (text == "")
            {
                MessageBox.Show("空文本，无需保存！");
            }
            else
            {
                this.saveFileDialog.Filter = "Text文件(*.txt)|*.txt";
                if (fileName == "")
                {
                    fileName = "Office助手文件" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                }
                this.saveFileDialog.FileName = fileName;
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = this.saveFileDialog.FileName.ToString(); //获得文件路径 
                    string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                    //获取文件路径，不带文件名 
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                    //给文件名前加上时间 
                    //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;

                    //在文件名里加字符 
                    //saveFileDialog1.FileName.Insert(1,"dameng");

                    //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件

                    ////fs输出带文字或图片的文件，就看需求了 

                    using (StreamWriter writer = new StreamWriter(localFilePath, false, Encoding.UTF8))
                    {
                        writer.Write(text);
                    }

                }
            }
        }
        
    }
}
