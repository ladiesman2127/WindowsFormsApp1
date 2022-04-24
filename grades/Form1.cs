using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Button btnGrade;
		private TextBox txtCountGrade;
		private int sum = 0;
		private int countOfGrades = 0;
		List<TextBox> txtBoxes = new List<TextBox>();
		private void buttonStart_Click(object sender, EventArgs e)
		{
			buttonStats.Show();
			int start_x_buttons = 18, start_x_txtBoxes = 24, start_y = -10, start_y_txtBoxes = 10;
			for (int i = 0; i < 5; i++)
			{
				btnGrade = new Button();
				txtCountGrade = new TextBox();
				txtBoxes.Add(txtCountGrade);
				panelCountGrades.Controls.Add(txtCountGrade);
				txtCountGrade.Size = new Size(210, 100);
				txtCountGrade.Tag = i;
				txtCountGrade.Location = new Point(start_x_txtBoxes, start_y_txtBoxes += txtCountGrade.Height + 40);
				txtCountGrade.Text = "0";
				panelGradeButtons.Controls.Add(btnGrade);
				btnGrade.Text = "Оценка " + (i + 1).ToString();
				btnGrade.Tag = i;
				btnGrade.Size = new Size(210, 50);
				btnGrade.Location = new Point(start_x_buttons, start_y += btnGrade.Height + 10);
				btnGrade.Click += BtnGrade_Click;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			buttonStats.Hide();
		}

		private void buttonStats_Click(object sender, EventArgs e)
		{
			labelStats.Text = "Кол-во баллов: " + sum.ToString() + "\r\n" +
			                  "Кол-во оценок: " + countOfGrades.ToString() + "\r\n" +
			                  "Средний балл: " + (sum / countOfGrades).ToString();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 5; i++)
			{
				txtBoxes[i].Text = "0";
			}
			sum = countOfGrades = 0;
			labelStats.Text = "";
		}

		private void BtnGrade_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int curVal = Convert.ToInt32(txtBoxes[(int)btn.Tag].Text);
			countOfGrades++;
			txtBoxes[(int)btn.Tag].Text = (++curVal).ToString();
			sum+=(int)btn.Tag + 1;

		}
	}
}
