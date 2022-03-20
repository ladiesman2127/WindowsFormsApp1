namespace cw1_familia
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.buttonMain = new System.Windows.Forms.Button();
			this.labelLastResult = new System.Windows.Forms.Label();
			this.labelScore = new System.Windows.Forms.Label();
			this.labelStats = new System.Windows.Forms.Label();
			this.labelDropped2Same = new System.Windows.Forms.Label();
			this.labelDropped3Same = new System.Windows.Forms.Label();
			this.labelDropped2SameValue = new System.Windows.Forms.Label();
			this.labelDropped3SameValue = new System.Windows.Forms.Label();
			this.labelLastResultValue = new System.Windows.Forms.Label();
			this.labelScoreValue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = global::cw1_familia.Properties.Resources.suit5;
			this.pictureBox1.Location = new System.Drawing.Point(6, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 97);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Image = global::cw1_familia.Properties.Resources.suit2;
			this.pictureBox2.Location = new System.Drawing.Point(90, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(73, 97);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Image = global::cw1_familia.Properties.Resources.suit6;
			this.pictureBox3.Location = new System.Drawing.Point(179, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(71, 97);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// buttonMain
			// 
			this.buttonMain.BackgroundImage = global::cw1_familia.Properties.Resources.handleUp;
			this.buttonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonMain.Location = new System.Drawing.Point(271, 12);
			this.buttonMain.Name = "buttonMain";
			this.buttonMain.Size = new System.Drawing.Size(103, 284);
			this.buttonMain.TabIndex = 3;
			this.buttonMain.UseVisualStyleBackColor = true;
			this.buttonMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseDown);
			this.buttonMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseUp);
			// 
			// labelLastResult
			// 
			this.labelLastResult.AutoSize = true;
			this.labelLastResult.Location = new System.Drawing.Point(6, 137);
			this.labelLastResult.Name = "labelLastResult";
			this.labelLastResult.Size = new System.Drawing.Size(120, 13);
			this.labelLastResult.TabIndex = 4;
			this.labelLastResult.Text = "Последний результат:";
			// 
			// labelScore
			// 
			this.labelScore.AutoSize = true;
			this.labelScore.Location = new System.Drawing.Point(6, 160);
			this.labelScore.Name = "labelScore";
			this.labelScore.Size = new System.Drawing.Size(86, 13);
			this.labelScore.TabIndex = 5;
			this.labelScore.Text = "Набрано очков:";
			// 
			// labelStats
			// 
			this.labelStats.AutoSize = true;
			this.labelStats.Location = new System.Drawing.Point(6, 184);
			this.labelStats.Name = "labelStats";
			this.labelStats.Size = new System.Drawing.Size(68, 13);
			this.labelStats.TabIndex = 6;
			this.labelStats.Text = "Статистика:";
			// 
			// labelDropped2Same
			// 
			this.labelDropped2Same.AutoSize = true;
			this.labelDropped2Same.Location = new System.Drawing.Point(63, 207);
			this.labelDropped2Same.Name = "labelDropped2Same";
			this.labelDropped2Same.Size = new System.Drawing.Size(110, 13);
			this.labelDropped2Same.TabIndex = 7;
			this.labelDropped2Same.Text = "Выпало 2 одиновых:";
			// 
			// labelDropped3Same
			// 
			this.labelDropped3Same.AutoSize = true;
			this.labelDropped3Same.Location = new System.Drawing.Point(63, 231);
			this.labelDropped3Same.Name = "labelDropped3Same";
			this.labelDropped3Same.Size = new System.Drawing.Size(110, 13);
			this.labelDropped3Same.TabIndex = 8;
			this.labelDropped3Same.Text = "Выпало 3 одиновых:";
			// 
			// labelDropped2SameValue
			// 
			this.labelDropped2SameValue.AutoSize = true;
			this.labelDropped2SameValue.Location = new System.Drawing.Point(219, 207);
			this.labelDropped2SameValue.Name = "labelDropped2SameValue";
			this.labelDropped2SameValue.Size = new System.Drawing.Size(0, 13);
			this.labelDropped2SameValue.TabIndex = 11;
			// 
			// labelDropped3SameValue
			// 
			this.labelDropped3SameValue.AutoSize = true;
			this.labelDropped3SameValue.Location = new System.Drawing.Point(219, 231);
			this.labelDropped3SameValue.Name = "labelDropped3SameValue";
			this.labelDropped3SameValue.Size = new System.Drawing.Size(0, 13);
			this.labelDropped3SameValue.TabIndex = 12;
			// 
			// labelLastResultValue
			// 
			this.labelLastResultValue.AutoSize = true;
			this.labelLastResultValue.Location = new System.Drawing.Point(154, 137);
			this.labelLastResultValue.Name = "labelLastResultValue";
			this.labelLastResultValue.Size = new System.Drawing.Size(0, 13);
			this.labelLastResultValue.TabIndex = 9;
			// 
			// labelScoreValue
			// 
			this.labelScoreValue.AutoSize = true;
			this.labelScoreValue.Location = new System.Drawing.Point(154, 160);
			this.labelScoreValue.Name = "labelScoreValue";
			this.labelScoreValue.Size = new System.Drawing.Size(0, 13);
			this.labelScoreValue.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 301);
			this.Controls.Add(this.labelDropped3SameValue);
			this.Controls.Add(this.labelDropped2SameValue);
			this.Controls.Add(this.labelScoreValue);
			this.Controls.Add(this.labelLastResultValue);
			this.Controls.Add(this.labelDropped3Same);
			this.Controls.Add(this.labelDropped2Same);
			this.Controls.Add(this.labelStats);
			this.Controls.Add(this.labelScore);
			this.Controls.Add(this.labelLastResult);
			this.Controls.Add(this.buttonMain);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Однорукий бандит";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button buttonMain;
		private System.Windows.Forms.Label labelLastResult;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Label labelStats;
		private System.Windows.Forms.Label labelDropped2Same;
		private System.Windows.Forms.Label labelDropped3Same;
		private System.Windows.Forms.Label labelDropped2SameValue;
		private System.Windows.Forms.Label labelDropped3SameValue;
		private System.Windows.Forms.Label labelLastResultValue;
		private System.Windows.Forms.Label labelScoreValue;
	}
}

