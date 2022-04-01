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

		 int _first, _second, _third;
		 string _firstPic,_secondPic,_thirdPic;
		 int _cntOf2Same = 0,_cntOf3Same = 0;
		 int _lastResult;
		 int _score = 0;
		 string _postFix;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonMain_MouseUp(object sender, MouseEventArgs e)
		{
			buttonMain.BackgroundImage = cw1_familia.Properties.Resources.handleUp;
		}

		private void buttonMain_MouseDown(object sender, MouseEventArgs e)
		{
			
			buttonMain.BackgroundImage = cw1_familia.Properties.Resources.handleDown;

			//Generating nums in [1,6] for getting random pics
			_first = _rnd.Next(1, 7);
			_second = _rnd.Next(1, 7);
			_third = _rnd.Next(1, 7);
			_firstPic = "suit" + _first.ToString();
			_secondPic = "suit" + _second.ToString();
			_thirdPic = "suit" + _third.ToString();
			//Scoring
			
			
			if (_first == _second && _second == _third && _third == _first)
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
			pictureBox3.Image = (Bitmap)cw1_familia.Properties.Resources.ResourceManager.GetObject(_thirdPic);
			labelLastResultValue.Text = _lastResult.ToString();
			labelScoreValue.Text = _score.ToString();
			if (_cntOf2Same % 10 == 0 ||
				_cntOf2Same % 10 == 1 ||
				_cntOf2Same % 10 == 5 ||
				_cntOf2Same % 10 == 6 ||
				_cntOf2Same % 10 == 7 ||
				_cntOf2Same % 10 == 8 ||
				_cntOf2Same % 10 == 9) _postFix = "раз";
			else _postFix = "раза";
			labelDropped2SameValue.Text = _cntOf2Same.ToString() + " " + _postFix;
			if (_cntOf3Same % 10 == 0 ||
				_cntOf3Same % 10 == 1 ||
				_cntOf3Same % 10 == 5 ||
				_cntOf3Same % 10 == 6 ||
				_cntOf3Same % 10 == 7 ||
				_cntOf3Same % 10 == 8 ||
				_cntOf3Same % 10 == 9) _postFix = "раз";
			else _postFix = "раза";
			labelDropped3SameValue.Text = _cntOf3Same.ToString() + " " + _postFix;
		}
	}
}