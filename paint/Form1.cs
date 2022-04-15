using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics _gr;
        Pen _p1;
        private void buttonColorLine_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            _p1 = new Pen(colorDialog1.Color, Convert.ToInt32(comboBox1.Text));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Beige;
            _gr = Graphics.FromHwnd(panel1.Handle);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _p1 = new Pen(colorDialog1.Color, Convert.ToInt32(comboBox1.Text));
        }
        int x, y;
        bool isDown = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                isDown = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                _gr.DrawLine(_p1, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                
            }
            
        }
    }
}
