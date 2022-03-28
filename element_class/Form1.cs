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

		private Button buttonNew;
		private void buttonEnter_Click(object sender, EventArgs e)
		{
			int x = 5, y = 5;
			Random rnd = new Random();
			panelMain.Controls.Clear();
			for (int i = 0; i < Convert.ToInt32(textBoxCountOfButton.Text); i++)
			{
				buttonNew = new Button();
				panelMain.Controls.Add(buttonNew);
				buttonNew.Text = "k";
				buttonNew.UseVisualStyleBackColor = true;
				buttonNew.BackColor = my_color[rnd.Next(4)];
				buttonNew.Size = new Size(50, 50);
				buttonNew.Location = new Point(x, y);
				buttonNew.Tag = ;
				buttonNew.Click += ButtonNew_Click;
				x += buttonNew.Size.Width;
			}
		}

		private void ButtonNew_Click(object sender, EventArgs e)
		{
			Button bb = (Button)sender;
			MessageBox.Show(bb.Text + " " + bb.Tag);
			//panelMain.Controls.Remove(bb);
			
			panelMain.Controls.RemoveAt(panelMain.Controls.IndexOf(bb));
		}

		private Color[] my_color = new Color[4];

		private void Form1_Load(object sender, EventArgs e)
		{
			my_color[0] = Color.Aqua;
			my_color[1] = Color.BlueViolet;
			my_color[2] = Color.Brown;
			my_color[3] = Color.Magenta;
		}
	}
}
