namespace SROfficeHelper
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentTextBox = new System.Windows.Forms.RichTextBox();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.FormatTextToolStripMenuItem,
            this.SetToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(404, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // SetToolStripMenuItem
            // 
            this.SetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetTopToolStripMenuItem,
            this.HideBorderToolStripMenuItem,
            this.OpacityToolStripMenuItem});
            this.SetToolStripMenuItem.Name = "SetToolStripMenuItem";
            this.SetToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.SetToolStripMenuItem.Text = "设置";
            // 
            // SetTopToolStripMenuItem
            // 
            this.SetTopToolStripMenuItem.Name = "SetTopToolStripMenuItem";
            this.SetTopToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.SetTopToolStripMenuItem.Text = "顶端显示";
            this.SetTopToolStripMenuItem.Click += new System.EventHandler(this.SetTopToolStripMenuItem_Click);
            // 
            // HideBorderToolStripMenuItem
            // 
            this.HideBorderToolStripMenuItem.Name = "HideBorderToolStripMenuItem";
            this.HideBorderToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.HideBorderToolStripMenuItem.Text = "去除边框";
            this.HideBorderToolStripMenuItem.Click += new System.EventHandler(this.HideBorderToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.ClearToolStripMenuItem.Text = "清空";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.PasteToolStripMenuItem.Text = "粘贴";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.CopyToolStripMenuItem.Text = "复制";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTextBox.Location = new System.Drawing.Point(0, 27);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(404, 347);
            this.ContentTextBox.TabIndex = 1;
            this.ContentTextBox.Text = "";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // OpacityToolStripMenuItem
            // 
            this.OpacityToolStripMenuItem.Name = "OpacityToolStripMenuItem";
            this.OpacityToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.OpacityToolStripMenuItem.Text = "透明";
            this.OpacityToolStripMenuItem.Click += new System.EventHandler(this.OpacityToolStripMenuItem_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTextToolStripMenuItem,
            this.SaveTextToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.FileToolStripMenuItem.Text = "文件";
            // 
            // OpenTextToolStripMenuItem
            // 
            this.OpenTextToolStripMenuItem.Name = "OpenTextToolStripMenuItem";
            this.OpenTextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.OpenTextToolStripMenuItem.Text = "打开文本";
            this.OpenTextToolStripMenuItem.Click += new System.EventHandler(this.OpenTextToolStripMenuItem_Click);
            // 
            // SaveTextToolStripMenuItem
            // 
            this.SaveTextToolStripMenuItem.Name = "SaveTextToolStripMenuItem";
            this.SaveTextToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.SaveTextToolStripMenuItem.Text = "保存文本";
            this.SaveTextToolStripMenuItem.Click += new System.EventHandler(this.SaveTextToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // FormatTextToolStripMenuItem
            // 
            this.FormatTextToolStripMenuItem.Name = "FormatTextToolStripMenuItem";
            this.FormatTextToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.FormatTextToolStripMenuItem.Text = "格式化";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 374);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main";
            this.Text = "Office助手";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ContentTextBox;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatTextToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

