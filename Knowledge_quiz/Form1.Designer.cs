namespace Knowledge_quiz
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnA = new System.Windows.Forms.Button();
			this.btn_B = new System.Windows.Forms.Button();
			this.btn_C = new System.Windows.Forms.Button();
			this.btn_D = new System.Windows.Forms.Button();
			this.lbl_soru_no = new System.Windows.Forms.Label();
			this.lbl_dgr = new System.Windows.Forms.Label();
			this.lbl_ynl = new System.Windows.Forms.Label();
			this.no = new System.Windows.Forms.Label();
			this.dgr = new System.Windows.Forms.Label();
			this.ynl = new System.Windows.Forms.Label();
			this.btn_Son = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(1, 1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(415, 200);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnA
			// 
			this.btnA.Location = new System.Drawing.Point(1, 207);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(195, 36);
			this.btnA.TabIndex = 1;
			this.btnA.Text = "A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.Click += new System.EventHandler(this.btnA_Click);
			// 
			// btn_B
			// 
			this.btn_B.Location = new System.Drawing.Point(217, 207);
			this.btn_B.Name = "btn_B";
			this.btn_B.Size = new System.Drawing.Size(199, 36);
			this.btn_B.TabIndex = 2;
			this.btn_B.Text = "B";
			this.btn_B.UseVisualStyleBackColor = true;
			this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
			// 
			// btn_C
			// 
			this.btn_C.Location = new System.Drawing.Point(1, 249);
			this.btn_C.Name = "btn_C";
			this.btn_C.Size = new System.Drawing.Size(195, 36);
			this.btn_C.TabIndex = 3;
			this.btn_C.Text = "C";
			this.btn_C.UseVisualStyleBackColor = true;
			this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
			// 
			// btn_D
			// 
			this.btn_D.Location = new System.Drawing.Point(217, 249);
			this.btn_D.Name = "btn_D";
			this.btn_D.Size = new System.Drawing.Size(199, 36);
			this.btn_D.TabIndex = 4;
			this.btn_D.Text = "D";
			this.btn_D.UseVisualStyleBackColor = true;
			this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
			// 
			// lbl_soru_no
			// 
			this.lbl_soru_no.AutoSize = true;
			this.lbl_soru_no.Location = new System.Drawing.Point(422, 18);
			this.lbl_soru_no.Name = "lbl_soru_no";
			this.lbl_soru_no.Size = new System.Drawing.Size(96, 28);
			this.lbl_soru_no.TabIndex = 5;
			this.lbl_soru_no.Text = "Soru No:";
			// 
			// lbl_dgr
			// 
			this.lbl_dgr.AutoSize = true;
			this.lbl_dgr.Location = new System.Drawing.Point(441, 56);
			this.lbl_dgr.Name = "lbl_dgr";
			this.lbl_dgr.Size = new System.Drawing.Size(77, 28);
			this.lbl_dgr.TabIndex = 6;
			this.lbl_dgr.Text = "Doğru:";
			// 
			// lbl_ynl
			// 
			this.lbl_ynl.AutoSize = true;
			this.lbl_ynl.Location = new System.Drawing.Point(446, 95);
			this.lbl_ynl.Name = "lbl_ynl";
			this.lbl_ynl.Size = new System.Drawing.Size(72, 28);
			this.lbl_ynl.TabIndex = 7;
			this.lbl_ynl.Text = "Yanlış:";
			// 
			// no
			// 
			this.no.AutoSize = true;
			this.no.Location = new System.Drawing.Point(517, 18);
			this.no.Name = "no";
			this.no.Size = new System.Drawing.Size(24, 28);
			this.no.TabIndex = 8;
			this.no.Text = "0";
			// 
			// dgr
			// 
			this.dgr.AutoSize = true;
			this.dgr.Location = new System.Drawing.Point(517, 56);
			this.dgr.Name = "dgr";
			this.dgr.Size = new System.Drawing.Size(24, 28);
			this.dgr.TabIndex = 9;
			this.dgr.Text = "0";
			// 
			// ynl
			// 
			this.ynl.AutoSize = true;
			this.ynl.Location = new System.Drawing.Point(517, 95);
			this.ynl.Name = "ynl";
			this.ynl.Size = new System.Drawing.Size(24, 28);
			this.ynl.TabIndex = 10;
			this.ynl.Text = "0";
			// 
			// btn_Son
			// 
			this.btn_Son.Location = new System.Drawing.Point(422, 146);
			this.btn_Son.Name = "btn_Son";
			this.btn_Son.Size = new System.Drawing.Size(225, 36);
			this.btn_Son.TabIndex = 11;
			this.btn_Son.Text = "Sonraki";
			this.btn_Son.UseVisualStyleBackColor = true;
			this.btn_Son.Click += new System.EventHandler(this.btn_Son_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(437, 202);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 83);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(571, 202);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(115, 83);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 301);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 28);
			this.label1.TabIndex = 14;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(234, 304);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 28);
			this.label2.TabIndex = 15;
			this.label2.Text = "label2";
			this.label2.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 378);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_Son);
			this.Controls.Add(this.ynl);
			this.Controls.Add(this.dgr);
			this.Controls.Add(this.no);
			this.Controls.Add(this.lbl_ynl);
			this.Controls.Add(this.lbl_dgr);
			this.Controls.Add(this.lbl_soru_no);
			this.Controls.Add(this.btn_D);
			this.Controls.Add(this.btn_C);
			this.Controls.Add(this.btn_B);
			this.Controls.Add(this.btnA);
			this.Controls.Add(this.richTextBox1);
			this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnA;
		private System.Windows.Forms.Button btn_B;
		private System.Windows.Forms.Button btn_C;
		private System.Windows.Forms.Button btn_D;
		private System.Windows.Forms.Label lbl_soru_no;
		private System.Windows.Forms.Label lbl_dgr;
		private System.Windows.Forms.Label lbl_ynl;
		private System.Windows.Forms.Label no;
		private System.Windows.Forms.Label dgr;
		private System.Windows.Forms.Label ynl;
		private System.Windows.Forms.Button btn_Son;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

