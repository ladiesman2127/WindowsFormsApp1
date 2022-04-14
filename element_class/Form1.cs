using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace element_class
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private Button _buttonNew;
		private void buttonEnter_Click(object sender, EventArgs e)
		{
			int x = 5, y = 5;
			Random rnd = new Random();
			panelMain.Controls.Clear();
			for (int i = 0; i < Convert.ToInt32(textBoxCountOfButton.Text); i++)
			{
				_buttonNew = new Button();
				panelMain.Controls.Add(_buttonNew);
				_buttonNew.Text = "k";
				_buttonNew.UseVisualStyleBackColor = true;
				_buttonNew.BackColor = _myColor[rnd.Next(4)];
				_buttonNew.Size = new Size(50, 50);
				_buttonNew.Location = new Point(x, y);
				_buttonNew.Tag = i;
				_buttonNew.Click += ButtonNew_Click;
				x += _buttonNew.Size.Width;
			}
		}

		private void ButtonNew_Click(object sender, EventArgs e)
		{
			Button bb = (Button)sender;
			MessageBox.Show(bb.Text + " " + bb.Tag);
			//panelMain.Controls.Remove(bb);
			
			panelMain.Controls.RemoveAt(panelMain.Controls.IndexOf(bb));
		}

		private readonly Color[] _myColor = new Color[4];

		private void Form1_Load(object sender, EventArgs e)
		{
			_myColor[0] = Color.Aqua;
			_myColor[1] = Color.BlueViolet;
			_myColor[2] = Color.Brown;
			_myColor[3] = Color.Magenta;
		}
	}
}
