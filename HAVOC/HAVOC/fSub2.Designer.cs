namespace HAVOC
{
    partial class fSub2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTry = new System.Windows.Forms.Label();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.txtDatabaseNumber = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClue = new System.Windows.Forms.Button();
            this.lblClue1 = new System.Windows.Forms.Label();
            this.lblClue2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtCopy = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.lblTry);
            this.panel1.Location = new System.Drawing.Point(46, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 255);
            this.panel1.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(14, 177);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(146, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.BackColor = System.Drawing.Color.Yellow;
            this.lblTry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTry.Location = new System.Drawing.Point(39, 32);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(56, 28);
            this.lblTry.TabIndex = 1;
            this.lblTry.Text = "try 1";
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(310, 64);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(132, 48);
            this.btnDatabase.TabIndex = 1;
            this.btnDatabase.Text = "Choose Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // txtDatabaseNumber
            // 
            this.txtDatabaseNumber.Location = new System.Drawing.Point(309, 141);
            this.txtDatabaseNumber.Name = "txtDatabaseNumber";
            this.txtDatabaseNumber.Size = new System.Drawing.Size(37, 20);
            this.txtDatabaseNumber.TabIndex = 2;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(377, 141);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(134, 20);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "of";
            // 
            // btnClue
            // 
            this.btnClue.Location = new System.Drawing.Point(310, 202);
            this.btnClue.Name = "btnClue";
            this.btnClue.Size = new System.Drawing.Size(132, 48);
            this.btnClue.TabIndex = 5;
            this.btnClue.Text = "&Clue";
            this.btnClue.UseVisualStyleBackColor = true;
            this.btnClue.Click += new System.EventHandler(this.btnClue_Click);
            // 
            // lblClue1
            // 
            this.lblClue1.AutoSize = true;
            this.lblClue1.BackColor = System.Drawing.Color.Yellow;
            this.lblClue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClue1.Location = new System.Drawing.Point(493, 202);
            this.lblClue1.Name = "lblClue1";
            this.lblClue1.Size = new System.Drawing.Size(155, 28);
            this.lblClue1.TabIndex = 6;
            this.lblClue1.Text = "<NULLGATE>";
            this.lblClue1.Click += new System.EventHandler(this.lblClue1_Click);
            // 
            // lblClue2
            // 
            this.lblClue2.AutoSize = true;
            this.lblClue2.BackColor = System.Drawing.Color.Yellow;
            this.lblClue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClue2.Location = new System.Drawing.Point(493, 243);
            this.lblClue2.Name = "lblClue2";
            this.lblClue2.Size = new System.Drawing.Size(155, 28);
            this.lblClue2.TabIndex = 7;
            this.lblClue2.Text = "<NULLGATE>";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(240, 64);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 15);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score = 0";
            // 
            // txtCopy
            // 
            this.txtCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCopy.Location = new System.Drawing.Point(616, 12);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(140, 167);
            this.txtCopy.TabIndex = 9;
            this.txtCopy.Text = "";
            // 
            // fSub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblClue2);
            this.Controls.Add(this.lblClue1);
            this.Controls.Add(this.btnClue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.txtDatabaseNumber);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.panel1);
            this.Name = "fSub2";
            this.Text = "ExpectedValue";
            this.Load += new System.EventHandler(this.fSub2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.TextBox txtDatabaseNumber;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClue;
        private System.Windows.Forms.Label lblClue1;
        private System.Windows.Forms.Label lblClue2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.RichTextBox txtCopy;
    }
}