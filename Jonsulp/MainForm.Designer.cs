﻿namespace Jonsulp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.text_debug = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPT열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최대화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최대화ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그래프ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.웹검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.립모션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.text_input = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // text_debug
            // 
            this.text_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_debug.AutoSize = true;
            this.text_debug.Location = new System.Drawing.Point(12, 540);
            this.text_debug.Name = "text_debug";
            this.text_debug.Size = new System.Drawing.Size(98, 12);
            this.text_debug.TabIndex = 0;
            this.text_debug.Text = "Debug message";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pPTToolStripMenuItem,
            this.graphToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 114);
            // 
            // pPTToolStripMenuItem
            // 
            this.pPTToolStripMenuItem.Name = "pPTToolStripMenuItem";
            this.pPTToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pPTToolStripMenuItem.Text = "PPT";
            this.pPTToolStripMenuItem.Click += new System.EventHandler(this.pPT열기ToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.그래프ToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.웹검색ToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.초기화ToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.이미지열기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Text = "지도";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem2.Text = "도형";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.최대화ToolStripMenuItem,
            this.입력ToolStripMenuItem,
            this.기타ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이미지열기ToolStripMenuItem,
            this.pPT열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // 이미지열기ToolStripMenuItem
            // 
            this.이미지열기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("이미지열기ToolStripMenuItem.Image")));
            this.이미지열기ToolStripMenuItem.Name = "이미지열기ToolStripMenuItem";
            this.이미지열기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.이미지열기ToolStripMenuItem.Text = "이미지 열기";
            this.이미지열기ToolStripMenuItem.Click += new System.EventHandler(this.이미지열기ToolStripMenuItem_Click);
            // 
            // pPT열기ToolStripMenuItem
            // 
            this.pPT열기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pPT열기ToolStripMenuItem.Image")));
            this.pPT열기ToolStripMenuItem.Name = "pPT열기ToolStripMenuItem";
            this.pPT열기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pPT열기ToolStripMenuItem.Text = "PPT 열기";
            this.pPT열기ToolStripMenuItem.Click += new System.EventHandler(this.pPT열기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 최대화ToolStripMenuItem
            // 
            this.최대화ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.최대화ToolStripMenuItem1});
            this.최대화ToolStripMenuItem.Name = "최대화ToolStripMenuItem";
            this.최대화ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.최대화ToolStripMenuItem.Text = "보기";
            // 
            // 최대화ToolStripMenuItem1
            // 
            this.최대화ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("최대화ToolStripMenuItem1.Image")));
            this.최대화ToolStripMenuItem1.Name = "최대화ToolStripMenuItem1";
            this.최대화ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.최대화ToolStripMenuItem1.Text = "최대화";
            this.최대화ToolStripMenuItem1.Click += new System.EventHandler(this.최대화ToolStripMenuItem1_Click);
            // 
            // 입력ToolStripMenuItem
            // 
            this.입력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그래프ToolStripMenuItem,
            this.웹검색ToolStripMenuItem,
            this.초기화ToolStripMenuItem});
            this.입력ToolStripMenuItem.Name = "입력ToolStripMenuItem";
            this.입력ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.입력ToolStripMenuItem.Text = "입력";
            // 
            // 그래프ToolStripMenuItem
            // 
            this.그래프ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("그래프ToolStripMenuItem.Image")));
            this.그래프ToolStripMenuItem.Name = "그래프ToolStripMenuItem";
            this.그래프ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.그래프ToolStripMenuItem.Text = "그래프";
            this.그래프ToolStripMenuItem.Click += new System.EventHandler(this.그래프ToolStripMenuItem_Click);
            // 
            // 웹검색ToolStripMenuItem
            // 
            this.웹검색ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("웹검색ToolStripMenuItem.Image")));
            this.웹검색ToolStripMenuItem.Name = "웹검색ToolStripMenuItem";
            this.웹검색ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.웹검색ToolStripMenuItem.Text = "웹 검색";
            this.웹검색ToolStripMenuItem.Click += new System.EventHandler(this.웹검색ToolStripMenuItem_Click);
            // 
            // 초기화ToolStripMenuItem
            // 
            this.초기화ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("초기화ToolStripMenuItem.Image")));
            this.초기화ToolStripMenuItem.Name = "초기화ToolStripMenuItem";
            this.초기화ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.초기화ToolStripMenuItem.Text = "초기화";
            this.초기화ToolStripMenuItem.Click += new System.EventHandler(this.초기화ToolStripMenuItem_Click);
            // 
            // 기타ToolStripMenuItem
            // 
            this.기타ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem,
            this.립모션ToolStripMenuItem});
            this.기타ToolStripMenuItem.Name = "기타ToolStripMenuItem";
            this.기타ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기타ToolStripMenuItem.Text = "기타";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 립모션ToolStripMenuItem
            // 
            this.립모션ToolStripMenuItem.Name = "립모션ToolStripMenuItem";
            this.립모션ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.립모션ToolStripMenuItem.Text = "립모션";
            this.립모션ToolStripMenuItem.Click += new System.EventHandler(this.립모션ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.text_input,
            this.toolStripSeparator3,
            this.toolStripButton7,
            this.toolStripTextBox1,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton5.Text = "PPT";
            this.toolStripButton5.Click += new System.EventHandler(this.pPT열기ToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton6.Text = "Image";
            this.toolStripButton6.Click += new System.EventHandler(this.이미지열기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "Graph";
            this.toolStripButton2.Click += new System.EventHandler(this.그래프ToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton3.Text = "Search";
            this.toolStripButton3.Click += new System.EventHandler(this.웹검색ToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton4.Text = "Clear";
            this.toolStripButton4.Click += new System.EventHandler(this.초기화ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "Word : ";
            // 
            // text_input
            // 
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(25, 25);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_image.Location = new System.Drawing.Point(141, 122);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(439, 342);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            this.pictureBox_image.Visible = false;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.BackColor = System.Drawing.Color.White;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.ContextMenuStrip = this.contextMenuStrip1;
            this.image.Location = new System.Drawing.Point(0, 52);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(784, 509);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            this.image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.image);
            this.Controls.Add(this.text_debug);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Leaper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_debug;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPT열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.ToolStripMenuItem 최대화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 최대화ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 그래프ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 웹검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 초기화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripTextBox text_input;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 립모션ToolStripMenuItem;
    }
}

