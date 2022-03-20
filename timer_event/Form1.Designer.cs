namespace timer_event
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
			if (disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			this.timerChangeBackColor = new System.Windows.Forms.Timer(this.components);
			this.buttonStart = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.buttonChangeBackColor = new System.Windows.Forms.Button();
			this.listNames = new System.Windows.Forms.ListBox();
			this.buttonStartNameDisaster = new System.Windows.Forms.Button();
			this.timerNameDisaster = new System.Windows.Forms.Timer(this.components);
			this.richTextBoxNameDisaster = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.timerNameDisaster2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timerChangeBackColor
			// 
			this.timerChangeBackColor.Tick += new System.EventHandler(this.timerChangeBackColor_Tick);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(632, 31);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(132, 51);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonChangeBackColor
			// 
			this.buttonChangeBackColor.Location = new System.Drawing.Point(474, 31);
			this.buttonChangeBackColor.Name = "buttonChangeBackColor";
			this.buttonChangeBackColor.Size = new System.Drawing.Size(132, 51);
			this.buttonChangeBackColor.TabIndex = 1;
			this.buttonChangeBackColor.Text = "BackColor";
			this.buttonChangeBackColor.UseVisualStyleBackColor = true;
			this.buttonChangeBackColor.Click += new System.EventHandler(this.buttonChangeBackColor_Click);
			// 
			// listNames
			// 
			this.listNames.FormattingEnabled = true;
			this.listNames.Items.AddRange(new object[] {
            "Дезмонд",
            "Афелий",
            "Кратус",
            "Корки",
            "Уильям"});
			this.listNames.Location = new System.Drawing.Point(90, 67);
			this.listNames.Name = "listNames";
			this.listNames.Size = new System.Drawing.Size(120, 95);
			this.listNames.TabIndex = 3;
			// 
			// buttonStartNameDisaster
			// 
			this.buttonStartNameDisaster.Location = new System.Drawing.Point(225, 67);
			this.buttonStartNameDisaster.Name = "buttonStartNameDisaster";
			this.buttonStartNameDisaster.Size = new System.Drawing.Size(132, 51);
			this.buttonStartNameDisaster.TabIndex = 5;
			this.buttonStartNameDisaster.Text = "Start Disaster";
			this.buttonStartNameDisaster.UseVisualStyleBackColor = true;
			this.buttonStartNameDisaster.Click += new System.EventHandler(this.buttonStartNameDisaster_Click);
			// 
			// timerNameDisaster
			// 
			this.timerNameDisaster.Tick += new System.EventHandler(this.timerNameDisaster_Tick);
			// 
			// richTextBoxNameDisaster
			// 
			this.richTextBoxNameDisaster.Location = new System.Drawing.Point(90, 201);
			this.richTextBoxNameDisaster.Name = "richTextBoxNameDisaster";
			this.richTextBoxNameDisaster.Size = new System.Drawing.Size(120, 237);
			this.richTextBoxNameDisaster.TabIndex = 6;
			this.richTextBoxNameDisaster.Text = "";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(381, 88);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(328, 350);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// timerNameDisaster2
			// 
			this.timerNameDisaster2.Enabled = true;
			this.timerNameDisaster2.Interval = 2000;
			this.timerNameDisaster2.Tick += new System.EventHandler(this.timerNameDisaster2_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.richTextBoxNameDisaster);
			this.Controls.Add(this.buttonStartNameDisaster);
			this.Controls.Add(this.listNames);
			this.Controls.Add(this.buttonChangeBackColor);
			this.Controls.Add(this.buttonStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timerChangeBackColor;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button buttonChangeBackColor;
		private System.Windows.Forms.ListBox listNames;
		private System.Windows.Forms.Button buttonStartNameDisaster;
		private System.Windows.Forms.Timer timerNameDisaster;
		private System.Windows.Forms.RichTextBox richTextBoxNameDisaster;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Timer timerNameDisaster2;
	}
}

