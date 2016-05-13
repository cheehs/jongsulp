namespace Jonsulp
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
            this.text_debug = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.button_image = new System.Windows.Forms.Button();
            this.button_ppt = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.text_input = new System.Windows.Forms.TextBox();
            this.button_graph = new System.Windows.Forms.Button();
            this.image_graph = new System.Windows.Forms.PictureBox();
            this.button_ink = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPT열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.필기인식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.최대화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최대화ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_graph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
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
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Location = new System.Drawing.Point(12, 38);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(622, 433);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // button_image
            // 
            this.button_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_image.Location = new System.Drawing.Point(697, 18);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(75, 23);
            this.button_image.TabIndex = 2;
            this.button_image.Text = "Image";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // button_ppt
            // 
            this.button_ppt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ppt.Location = new System.Drawing.Point(697, 47);
            this.button_ppt.Name = "button_ppt";
            this.button_ppt.Size = new System.Drawing.Size(75, 23);
            this.button_ppt.TabIndex = 3;
            this.button_ppt.Text = "PPT";
            this.button_ppt.UseVisualStyleBackColor = true;
            this.button_ppt.Click += new System.EventHandler(this.button_ppt_Click);
            // 
            // button_prev
            // 
            this.button_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_prev.Location = new System.Drawing.Point(478, 477);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 4;
            this.button_prev.Text = "Prev";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_next.Location = new System.Drawing.Point(559, 477);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 5;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // text_input
            // 
            this.text_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_input.Location = new System.Drawing.Point(640, 106);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(132, 21);
            this.text_input.TabIndex = 6;
            // 
            // button_graph
            // 
            this.button_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_graph.Location = new System.Drawing.Point(697, 133);
            this.button_graph.Name = "button_graph";
            this.button_graph.Size = new System.Drawing.Size(75, 23);
            this.button_graph.TabIndex = 7;
            this.button_graph.Text = "Graph";
            this.button_graph.UseVisualStyleBackColor = true;
            this.button_graph.Click += new System.EventHandler(this.button_graph_Click);
            // 
            // image_graph
            // 
            this.image_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image_graph.Location = new System.Drawing.Point(20, 47);
            this.image_graph.Name = "image_graph";
            this.image_graph.Size = new System.Drawing.Size(605, 410);
            this.image_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_graph.TabIndex = 8;
            this.image_graph.TabStop = false;
            this.image_graph.Visible = false;
            // 
            // button_ink
            // 
            this.button_ink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ink.Location = new System.Drawing.Point(697, 76);
            this.button_ink.Name = "button_ink";
            this.button_ink.Size = new System.Drawing.Size(75, 23);
            this.button_ink.TabIndex = 9;
            this.button_ink.Text = "Ink";
            this.button_ink.UseVisualStyleBackColor = true;
            this.button_ink.Click += new System.EventHandler(this.button_ink_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Location = new System.Drawing.Point(697, 162);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(697, 191);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
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
            this.이미지열기ToolStripMenuItem.Name = "이미지열기ToolStripMenuItem";
            this.이미지열기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.이미지열기ToolStripMenuItem.Text = "이미지 열기";
            this.이미지열기ToolStripMenuItem.Click += new System.EventHandler(this.이미지열기ToolStripMenuItem_Click);
            // 
            // pPT열기ToolStripMenuItem
            // 
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
            // 입력ToolStripMenuItem
            // 
            this.입력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.필기인식ToolStripMenuItem});
            this.입력ToolStripMenuItem.Name = "입력ToolStripMenuItem";
            this.입력ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.입력ToolStripMenuItem.Text = "입력";
            // 
            // 필기인식ToolStripMenuItem
            // 
            this.필기인식ToolStripMenuItem.Name = "필기인식ToolStripMenuItem";
            this.필기인식ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.필기인식ToolStripMenuItem.Text = "필기 인식";
            this.필기인식ToolStripMenuItem.Click += new System.EventHandler(this.필기인식ToolStripMenuItem_Click);
            // 
            // 기타ToolStripMenuItem
            // 
            this.기타ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.기타ToolStripMenuItem.Name = "기타ToolStripMenuItem";
            this.기타ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기타ToolStripMenuItem.Text = "기타";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 70);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(207, 162);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(194, 147);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            this.pictureBox_image.Visible = false;
            this.pictureBox_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_image_MouseDown);
            this.pictureBox_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_image_MouseMove);
            this.pictureBox_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_image_MouseUp);
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
            this.최대화ToolStripMenuItem1.Name = "최대화ToolStripMenuItem1";
            this.최대화ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.최대화ToolStripMenuItem1.Text = "최대화";
            this.최대화ToolStripMenuItem1.Click += new System.EventHandler(this.최대화ToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_ink);
            this.Controls.Add(this.image_graph);
            this.Controls.Add(this.button_graph);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_ppt);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.image);
            this.Controls.Add(this.text_debug);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Leaper";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_graph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_debug;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.Button button_ppt;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_graph;
        private System.Windows.Forms.PictureBox image_graph;
        private System.Windows.Forms.Button button_ink;
        public System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPT열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 필기인식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.ToolStripMenuItem 최대화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 최대화ToolStripMenuItem1;
    }
}

