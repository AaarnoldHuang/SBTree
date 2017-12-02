namespace tree
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ptext = new System.Windows.Forms.TextBox();
            this.addtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.displaybox = new System.Windows.Forms.TextBox();
            this.addroot = new System.Windows.Forms.RadioButton();
            this.count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加：";
            // 
            // ptext
            // 
            this.ptext.Location = new System.Drawing.Point(193, 48);
            this.ptext.Name = "ptext";
            this.ptext.Size = new System.Drawing.Size(93, 21);
            this.ptext.TabIndex = 1;
            // 
            // addtext
            // 
            this.addtext.Location = new System.Drawing.Point(36, 48);
            this.addtext.Name = "addtext";
            this.addtext.Size = new System.Drawing.Size(100, 21);
            this.addtext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "目标：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "元素：";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(528, 143);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 7;
            this.show.Text = "显示";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.getnumber_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(13, 293);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 12);
            this.info.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(532, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "添加孩子";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(532, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "添加兄弟";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(528, 100);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 13;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // displaybox
            // 
            this.displaybox.Location = new System.Drawing.Point(36, 96);
            this.displaybox.Multiline = true;
            this.displaybox.Name = "displaybox";
            this.displaybox.Size = new System.Drawing.Size(455, 177);
            this.displaybox.TabIndex = 16;
            // 
            // addroot
            // 
            this.addroot.AutoSize = true;
            this.addroot.Location = new System.Drawing.Point(532, 18);
            this.addroot.Name = "addroot";
            this.addroot.Size = new System.Drawing.Size(71, 16);
            this.addroot.TabIndex = 18;
            this.addroot.TabStop = true;
            this.addroot.Text = "添加Root";
            this.addroot.UseVisualStyleBackColor = true;
            this.addroot.CheckedChanged += new System.EventHandler(this.addroot_CheckedChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(528, 182);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 23);
            this.count.TabIndex = 19;
            this.count.Text = "统计结点";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 359);
            this.Controls.Add(this.count);
            this.Controls.Add(this.addroot);
            this.Controls.Add(this.displaybox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addtext);
            this.Controls.Add(this.ptext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "兄弟孩子树";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ptext;
        private System.Windows.Forms.TextBox addtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox displaybox;
        private System.Windows.Forms.RadioButton addroot;
        private System.Windows.Forms.Button count;
    }
}

