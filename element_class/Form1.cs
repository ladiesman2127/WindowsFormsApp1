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
        private int a;

        private Button buttonNew;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            timer.Start();
        }


        Random rnd = new Random();
        private void timer_Tick(object sender, EventArgs e)
        {


            buttonNew = new Button();
            listOfButtons.Add(buttonNew);
            a = rnd.Next(50);
            panelMain.Controls.Add(buttonNew);
            buttonNew.Text = a.ToString();
            buttonNew.Size = new Size(50, 50);
            buttonNew.Tag = a;
            buttonNew.Location = new Point(rnd.Next(50, panelMain.Width - 50), rnd.Next(50, panelMain.Height - 50));
            buttonNew.Click += ButtonNew_Click;

        }
        Button btnn;
        List<Button> listOfButtons = new List<Button>();

        private void ButtonNew_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btnn = btn;
          
            
            //panelMain.Controls.Remove(btn);
            if ((int)btn.Tag % 2 == 0)
            {
                timer.Stop();
                timer2.Start();
            }

            else if ((int)btn.Tag % 2 != 0)
                timer1.Start();


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            btnn.Location = new Point(btnn.Location.X, btnn.Location.Y + 1);
            if (btnn.Location.Y == panelMain.Height - 50)
            {
                timer1.Stop();
            }
        }
        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            listOfButtons[i].Location = new Point(listOfButtons[i].Location.X, listOfButtons[i].Location.Y + 1);
            if (listOfButtons[i].Location.Y == panelMain.Height - 50)
                i++;
            if (i == listOfButtons.Count)
            {
                timer2.Stop();
                i = 0;
            }
                

        }
    }
}
