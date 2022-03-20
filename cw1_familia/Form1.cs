using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw1_familia
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private readonly Random _rnd = new Random();

		private int _first, _second, _third;
		private string _firstPic,_secondPic,_thirdPic;
		private uint _cntOf2Same = 0,_cntOf3Same = 0;
		private int _lastResult;
		private int _score = 0;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonMain_MouseUp(object sender, MouseEventArgs e)
		{
			buttonMain.BackgroundImage = cw1_familia.Properties.Resources.handleUp;

			//Generating nums in [1,6] for getting random pics
			_first = _rnd.Next(1, 7);
			_second = _rnd.Next(1, 7);
			_third = _rnd.Next(1, 7);
			_firstPic = "suit" + _first.ToString();
			_secondPic = "suit" + _second.ToString();
			_thirdPic = "suit" + _third.ToString();
			//Scoring
			if (_first == _second && _second == _third)
			{
				_lastResult = 50;
				_cntOf2Same++;
				_cntOf3Same++;
			}
			else if (_first == _second ||
			         _second == _third ||
			         _first == _third)
			{
				_lastResult = 10;
				_cntOf2Same++;
			}
			else _lastResult = 0;
			_score += _lastResult;
			pictureBox1.Image = (Bitmap)cw1_familia.Properties.Resources.ResourceManager.GetObject(_firstPic);
			pictureBox2.Image = (Bitmap)cw1_familia.Properties.Resources.ResourceManager.GetObject(_secondPic);
			pictureBox3.Image = (Bitmap)cw1_familia.Properties.Resources.ResourceManager.GetObject(_secondPic);
			labelLastResultValue.Text = _lastResult.ToString();
			labelScoreValue.Text = _score.ToString();
			labelDropped2SameValue.Text = _cntOf2Same.ToString();
			labelDropped3SameValue.Text = _cntOf3Same.ToString();
		}

		private void buttonMain_MouseDown(object sender, MouseEventArgs e)
		{
			buttonMain.BackgroundImage = cw1_familia.Properties.Resources.handleDown;
		}
	}
}