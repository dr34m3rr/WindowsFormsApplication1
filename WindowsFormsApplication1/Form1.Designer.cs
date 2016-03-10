namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pa = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.TextBox();
            this.eps = new System.Windows.Forms.TextBox();
            this.x0tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.xbox = new System.Windows.Forms.TextBox();
            this.fxbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(693, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pa
            // 
            this.pa.Location = new System.Drawing.Point(60, 12);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(47, 20);
            this.pa.TabIndex = 1;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(60, 49);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(47, 20);
            this.pb.TabIndex = 2;
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(60, 88);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(47, 20);
            this.eps.TabIndex = 3;
            // 
            // x0tb
            // 
            this.x0tb.Location = new System.Drawing.Point(60, 132);
            this.x0tb.Name = "x0tb";
            this.x0tb.Size = new System.Drawing.Size(47, 20);
            this.x0tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X(0)";
            // 
            // Lip
            // 
            this.Lip.Location = new System.Drawing.Point(60, 173);
            this.Lip.Name = "Lip";
            this.Lip.ReadOnly = true;
            this.Lip.Size = new System.Drawing.Size(47, 20);
            this.Lip.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lip";
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(187, 19);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(571, 328);
            this.resultBox.TabIndex = 11;
            // 
            // xbox
            // 
            this.xbox.Location = new System.Drawing.Point(60, 212);
            this.xbox.Name = "xbox";
            this.xbox.ReadOnly = true;
            this.xbox.Size = new System.Drawing.Size(47, 20);
            this.xbox.TabIndex = 12;
            // 
            // fxbox
            // 
            this.fxbox.Location = new System.Drawing.Point(60, 255);
            this.fxbox.Name = "fxbox";
            this.fxbox.ReadOnly = true;
            this.fxbox.Size = new System.Drawing.Size(47, 20);
            this.fxbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "f(x)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 403);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fxbox);
            this.Controls.Add(this.xbox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x0tb);
            this.Controls.Add(this.eps);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pa);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pa;
        private System.Windows.Forms.TextBox pb;
        private System.Windows.Forms.TextBox eps;
        private System.Windows.Forms.TextBox x0tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox xbox;
        private System.Windows.Forms.TextBox fxbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

