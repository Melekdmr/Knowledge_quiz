using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_quiz
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int soruno = 0, dogru = 0, yanlis = 0;

		

		private void btn_Son_Click(object sender, EventArgs e)
		{
			btnA.Enabled = true;
			btn_B.Enabled =true;
			btn_C.Enabled =true;
			btn_D.Enabled =true;
			btn_Son.Enabled = false;

			pictureBox1.Visible = false;
			pictureBox2.Visible = false;

			soruno++;
			no.Text = soruno.ToString();
			if (soruno == 1)
			{
				richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
				btnA.Text = "1920";
				btn_B.Text = "1921";
				btn_C.Text = "1922";
				btn_D.Text = "1923";
				label1.Text = "1923";
;
			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Hangi il ege bölgemizde bulunmaz?";
				btnA.Text = "İzmir";
				btn_B.Text = "Balıkesir";
				btn_C.Text = "Aydın";
				btn_D.Text = "Manisa";
				label1.Text = "Balıkesir";
				;
			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Son kuşlar hangi yazara aittir?";
				btnA.Text = "Sait Faik";
				btn_B.Text = "Cemal süreya";
				btn_C.Text = "Atilla İlhan";
				btn_D.Text = "Reşat Nuri";
				label1.Text = "Sait Faik";
				btn_Son.Text = "Sonuçlar";
			}
			if (soruno == 4)
			{
				btnA.Enabled = false;
				btn_B.Enabled =false;
				btn_C.Enabled =false;
				btn_D.Enabled =false;
				btn_Son.Enabled = false;
				MessageBox.Show("Doğru: " + dogru + " \n" + "Yanlış: " + yanlis);
			}
			

		}

		

		private void btnA_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btn_B.Enabled = false;
			btn_C.Enabled = false;
			btn_D.Enabled = false;
			btn_Son.Enabled = true;


			label2.Text = btnA.Text;
			if (label1.Text == label2.Text)
			{
				dogru++;
				dgr.Text = dogru.ToString();
				pictureBox2.Visible = true;
			}
			else
			{
				yanlis++;
				ynl.Text = yanlis.ToString();
				pictureBox1.Visible = true;
			}

		}

		
		private void btn_B_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btn_B.Enabled = false;
			btn_C.Enabled = false;
			btn_D.Enabled = false;
			btn_Son.Enabled = true;
			label2.Text = btn_B.Text;

			if (label1.Text == label2.Text)
			{
				dogru++;
				dgr.Text = dogru.ToString();
				pictureBox2.Visible = true;
			}
			else
			{
				yanlis++;
				ynl.Text = yanlis.ToString();
				pictureBox1.Visible = true;
			}

		}
		private void btn_C_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btn_B.Enabled = false;
			btn_C.Enabled = false;
			btn_D.Enabled = false;
			btn_Son.Enabled = true;

			label2.Text = btn_C.Text;

			if (label1.Text == label2.Text)
			{
				dogru++;
				dgr.Text = dogru.ToString();
				pictureBox2.Visible = true;
			}
			else
			{
				yanlis++;
				ynl.Text = yanlis.ToString();
				pictureBox1.Visible = true;
			}

		}
		private void btn_D_Click(object sender, EventArgs e)
		{
			btnA.Enabled = false;
			btn_B.Enabled = false;
			btn_C.Enabled = false;
			btn_D.Enabled = false;
			btn_Son.Enabled = true;

			label2.Text = btn_D.Text;

			if (label1.Text == label2.Text)
			{
				dogru++;
				dgr.Text = dogru.ToString();
				pictureBox2.Visible = true;
			}
			else
			{
				yanlis++;
				ynl.Text = yanlis.ToString();
				pictureBox1.Visible = true;
			}

		}

	}
}
