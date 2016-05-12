namespace Jonsulp
{
    partial class PPT
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
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_graph)).BeginInit();
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
            this.image.Location = new System.Drawing.Point(12, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(622, 459);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // button_image
            // 
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
            this.text_input.Location = new System.Drawing.Point(640, 106);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(132, 21);
            this.text_input.TabIndex = 6;
            // 
            // button_graph
            // 
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
            this.image_graph.Location = new System.Drawing.Point(20, 20);
            this.image_graph.Name = "image_graph";
            this.image_graph.Size = new System.Drawing.Size(605, 437);
            this.image_graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_graph.TabIndex = 8;
            this.image_graph.TabStop = false;
            this.image_graph.Visible = false;
            // 
            // button_ink
            // 
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
            this.button_clear.Location = new System.Drawing.Point(697, 191);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // PPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Name = "PPT";
            this.Text = "Leaper";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_graph)).EndInit();
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
    }
}

