using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Threading.Thread;

namespace timer_event
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//Fiels 
		private int i = 0;

		private readonly Random _rnd = new Random();
		private void buttonStart_Click(object sender, EventArgs e)
		{
			timerChangeBackColor.Start();
		}

		private void buttonChangeBackColor_Click(object sender, EventArgs e)
		{
			timerChangeBackColor.Stop();
			colorDialog1.ShowDialog();
			if(colorDialog1.ShowDialog() == DialogResult.OK)
				BackColor = colorDialog1.Color;

		}

		private void timerChangeBackColor_Tick(object sender, EventArgs e)
		{
			buttonChangeBackColor.Location = new Point(_rnd.Next(Width - buttonChangeBackColor.Width),
													   _rnd.Next(Height - buttonChangeBackColor.Height - 20));
			BackColor = Color.FromArgb(_rnd.Next(256),
									_rnd.Next(256),
									_rnd.Next(256)
			);
		}

		private void buttonStartNameDisaster_Click(object sender, EventArgs e)
		{
			i = 0;
			timerNameDisaster.Start();
			richTextBoxNameDisaster.Text = listNames.SelectedItem.ToString();
		}


		private void timerNameDisaster_Tick(object sender, EventArgs e)
		{
			while(i < richTextBoxNameDisaster.TextLength)
			{
				richTextBoxNameDisaster.SelectionStart = i;
				richTextBoxNameDisaster.SelectionLength = 1;
				i++;
			}

			timerNameDisaster.Stop();
		}
	}
}
