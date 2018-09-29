namespace RYDX
{
    partial class Form1
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
            this.txtPath = new System.Windows.Forms.RichTextBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRNext = new System.Windows.Forms.Button();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstB = new System.Windows.Forms.ListBox();
            this.btnRAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPlayB = new System.Windows.Forms.ListBox();
            this.lstPlayA = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(32, 58);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(338, 159);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "";
            this.txtPath.Visible = false;
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(21, 94);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(121, 225);
            this.lstA.TabIndex = 1;
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(43, 12);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(97, 28);
            this.btnQNext.TabIndex = 2;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnRAll);
            this.groupBox1.Controls.Add(this.lstB);
            this.groupBox1.Controls.Add(this.btnRNext);
            this.groupBox1.Controls.Add(this.txtText2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtText1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstA);
            this.groupBox1.Location = new System.Drawing.Point(22, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workout";
            // 
            // btnRNext
            // 
            this.btnRNext.Location = new System.Drawing.Point(291, 94);
            this.btnRNext.Name = "btnRNext";
            this.btnRNext.Size = new System.Drawing.Size(97, 28);
            this.btnRNext.TabIndex = 6;
            this.btnRNext.Text = "&RNext";
            this.btnRNext.UseVisualStyleBackColor = true;
            this.btnRNext.Click += new System.EventHandler(this.btnRNext_Click);
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(106, 56);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(222, 20);
            this.txtText2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "msText2 =";
            // 
            // txtText1
            // 
            this.txtText1.Location = new System.Drawing.Point(106, 30);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(222, 20);
            this.txtText1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "msText1 =";
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.Location = new System.Drawing.Point(162, 94);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(123, 225);
            this.lstB.TabIndex = 7;
            // 
            // btnRAll
            // 
            this.btnRAll.Location = new System.Drawing.Point(291, 128);
            this.btnRAll.Name = "btnRAll";
            this.btnRAll.Size = new System.Drawing.Size(97, 28);
            this.btnRAll.TabIndex = 8;
            this.btnRAll.Text = "&RAll";
            this.btnRAll.UseVisualStyleBackColor = true;
            this.btnRAll.Click += new System.EventHandler(this.btnRAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.lstPlayB);
            this.groupBox2.Controls.Add(this.lstPlayA);
            this.groupBox2.Location = new System.Drawing.Point(441, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 424);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play";
            // 
            // lstPlayB
            // 
            this.lstPlayB.FormattingEnabled = true;
            this.lstPlayB.Location = new System.Drawing.Point(236, 44);
            this.lstPlayB.Name = "lstPlayB";
            this.lstPlayB.Size = new System.Drawing.Size(190, 342);
            this.lstPlayB.TabIndex = 9;
            this.lstPlayB.Click += new System.EventHandler(this.lstPlayB_Click);
            // 
            // lstPlayA
            // 
            this.lstPlayA.FormattingEnabled = true;
            this.lstPlayA.Location = new System.Drawing.Point(30, 44);
            this.lstPlayA.Name = "lstPlayA";
            this.lstPlayA.Size = new System.Drawing.Size(188, 342);
            this.lstPlayA.TabIndex = 8;
            this.lstPlayA.Click += new System.EventHandler(this.lstPlayA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "RYDX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPath;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRNext;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button btnRAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstPlayB;
        private System.Windows.Forms.ListBox lstPlayA;
    }
}

