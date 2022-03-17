using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void buttonOutput_Click(object sender, EventArgs e)
		{
			richTextBoxOutput.Clear();
			uint futureAge = Convert.ToUInt16(numericUpDownYear.Value - DateTime.Now.Year + numericUpDownAge.Value);
			richTextBoxOutput.Text += textBoxSurname.Text + " " + textBoxName.Text + "\r\n"
									+ "В " + numericUpDownYear.Value.ToString() + " году Вам\r\n"
									+ "будет " + futureAge + " лет.\r\n";
			if (radioButtonFemale.Checked && textBoxFootLength.Text != "")
			{
				string hellHeight = "";
				if (Convert.ToDouble(textBoxFootLength.Text) / 7 % 1 == 0)
					 hellHeight += (Convert.ToInt32(textBoxFootLength.Text) / 7).ToString();
				else hellHeight += (Math.Floor(Convert.ToDouble(textBoxFootLength.Text) / 7)).ToString()
								+ "-"
								+ (Math.Ceiling(Convert.ToDouble(textBoxFootLength.Text) / 7)).ToString();
				richTextBoxOutput.Text += "Вам подойдут\r\n"
										+ "каблуки " + hellHeight + " см\r\n";
			}
			else if(radioButtonMale.Checked && textBoxGrowth.Text != "")
			{
				double normalWeight = Convert.ToDouble(textBoxGrowth.Text) * 0.7 - 50;
				richTextBoxOutput.Text += "Нормальная масса вашего тела " + normalWeight.ToString() + " кг";
			}
		}
	}
}

