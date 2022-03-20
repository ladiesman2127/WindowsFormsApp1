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
		private int _i = 0, _j = 0;
		public string Dis;

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
			_i = 0;
			richTextBoxNameDisaster.Text = listNames.SelectedItem.ToString();
			timerNameDisaster.Start();
			richTextBoxNameDisaster.HideSelection = true;
			timerNameDisaster2.Start();
		}


		private void timerNameDisaster_Tick(object sender, EventArgs e)
		{
			richTextBoxNameDisaster.HideSelection = false;
			if(_i > richTextBoxNameDisaster.TextLength - 1)
			{
				_i = 0;
				timerNameDisaster.Stop();
			}

			richTextBoxNameDisaster.SelectionStart = _i;
			richTextBoxNameDisaster.SelectionLength = 1;
			_i++;

		}

		private void timerNameDisaster2_Tick(object sender, EventArgs e)
		{

			_j = richTextBoxNameDisaster.TextLength;
			if(_j == 1)
			{
				richTextBoxNameDisaster.Text = "";
				timerNameDisaster2.Stop();
				return;
			}
			Dis = richTextBoxNameDisaster.Text;
			Dis = Dis.Remove(_j - 1, 1);
			richTextBoxNameDisaster.Text = Dis;

		}
	}
}
