namespace WindowsFormsApp1
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
			this.LabelSurname = new System.Windows.Forms.Label();
			this.LabelName = new System.Windows.Forms.Label();
			this.LabelFootLength = new System.Windows.Forms.Label();
			this.LabelGrowth = new System.Windows.Forms.Label();
			this.LabelYear = new System.Windows.Forms.Label();
			this.LabelAge = new System.Windows.Forms.Label();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.textBoxGrowth = new System.Windows.Forms.TextBox();
			this.textBoxFootLength = new System.Windows.Forms.TextBox();
			this.panelSex = new System.Windows.Forms.Panel();
			this.radioButtonFemale = new System.Windows.Forms.RadioButton();
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.buttonOutput = new System.Windows.Forms.Button();
			this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.panelSex.SuspendLayout();
			this.SuspendLayout();
			// 
			// LabelSurname
			// 
			this.LabelSurname.AutoSize = true;
			this.LabelSurname.Font = new System.Drawing.Font("Hack Nerd Font Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelSurname.Location = new System.Drawing.Point(12, 28);
			this.LabelSurname.Name = "LabelSurname";
			this.LabelSurname.Size = new System.Drawing.Size(87, 22);
			this.LabelSurname.TabIndex = 0;
			this.LabelSurname.Text = "Фамилия";
			// 
			// LabelName
			// 
			this.LabelName.AutoSize = true;
			this.LabelName.Font = new System.Drawing.Font("Hack Nerd Font Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelName.Location = new System.Drawing.Point(12, 60);
			this.LabelName.Name = "LabelName";
			this.LabelName.Size = new System.Drawing.Size(43, 22);
			this.LabelName.TabIndex = 1;
			this.LabelName.Text = "Имя";
			// 
			// LabelFootLength
			// 
			this.LabelFootLength.AutoSize = true;
			this.LabelFootLength.Font = new System.Drawing.Font("Hack Nerd Font Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelFootLength.Location = new System.Drawing.Point(128, 219);
			this.LabelFootLength.Name = "LabelFootLength";
			this.LabelFootLength.Size = new System.Drawing.Size(131, 22);
			this.LabelFootLength.TabIndex = 2;
			this.LabelFootLength.Text = "Длина стопы";
			// 
			// LabelGrowth
			// 
			this.LabelGrowth.AutoSize = true;
			this.LabelGrowth.Font = new System.Drawing.Font("Hack Nerd Font Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelGrowth.Location = new System.Drawing.Point(27, 219);
			this.LabelGrowth.Name = "LabelGrowth";
			this.LabelGrowth.Size = new System.Drawing.Size(54, 22);
			this.LabelGrowth.TabIndex = 3;
			this.LabelGrowth.Text = "Рост";
			// 
			// LabelYear
			// 
			this.LabelYear.AutoSize = true;
			this.LabelYear.Font = new System.Drawing.Font("Hack Nerd Font Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelYear.Location = new System.Drawing.Point(191, 98);
			this.LabelYear.Name = "LabelYear";
			this.LabelYear.Size = new System.Drawing.Size(43, 22);
			this.LabelYear.TabIndex = 4;
			this.LabelYear.Text = "Год";
			// 
			// LabelAge
			// 
			this.LabelAge.AutoSize = true;
			this.LabelAge.Font = new System.Drawing.Font("Hack Nerd Font Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelAge.Location = new System.Drawing.Point(12, 98);
			this.LabelAge.Name = "LabelAge";
			this.LabelAge.Size = new System.Drawing.Size(87, 22);
			this.LabelAge.TabIndex = 5;
			this.LabelAge.Text = "Возраст";
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Location = new System.Drawing.Point(122, 28);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(137, 20);
			this.textBoxSurname.TabIndex = 6;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(122, 64);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(137, 20);
			this.textBoxName.TabIndex = 7;
			// 
			// numericUpDownAge
			// 
			this.numericUpDownAge.Location = new System.Drawing.Point(12, 123);
			this.numericUpDownAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.numericUpDownAge.Name = "numericUpDownAge";
			this.numericUpDownAge.Size = new System.Drawing.Size(83, 20);
			this.numericUpDownAge.TabIndex = 8;
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(176, 123);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericUpDownYear.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(83, 20);
			this.numericUpDownYear.TabIndex = 9;
			this.numericUpDownYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
			// 
			// textBoxGrowth
			// 
			this.textBoxGrowth.Location = new System.Drawing.Point(12, 244);
			this.textBoxGrowth.Name = "textBoxGrowth";
			this.textBoxGrowth.Size = new System.Drawing.Size(87, 20);
			this.textBoxGrowth.TabIndex = 10;
			// 
			// textBoxFootLength
			// 
			this.textBoxFootLength.Location = new System.Drawing.Point(147, 244);
			this.textBoxFootLength.Name = "textBoxFootLength";
			this.textBoxFootLength.Size = new System.Drawing.Size(87, 20);
			this.textBoxFootLength.TabIndex = 11;
			// 
			// panelSex
			// 
			this.panelSex.Controls.Add(this.radioButtonFemale);
			this.panelSex.Controls.Add(this.radioButtonMale);
			this.panelSex.Location = new System.Drawing.Point(12, 169);
			this.panelSex.Name = "panelSex";
			this.panelSex.Size = new System.Drawing.Size(260, 28);
			this.panelSex.TabIndex = 12;
			// 
			// radioButtonFemale
			// 
			this.radioButtonFemale.AutoSize = true;
			this.radioButtonFemale.Font = new System.Drawing.Font("Hack Nerd Font Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButtonFemale.Location = new System.Drawing.Point(164, 3);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new System.Drawing.Size(89, 22);
			this.radioButtonFemale.TabIndex = 1;
			this.radioButtonFemale.TabStop = true;
			this.radioButtonFemale.Text = "Женский";
			this.radioButtonFemale.UseVisualStyleBackColor = true;
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.Font = new System.Drawing.Font("Hack Nerd Font Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButtonMale.Location = new System.Drawing.Point(8, 3);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(89, 22);
			this.radioButtonMale.TabIndex = 0;
			this.radioButtonMale.TabStop = true;
			this.radioButtonMale.Text = "Мужской";
			this.radioButtonMale.UseVisualStyleBackColor = true;
			// 
			// buttonOutput
			// 
			this.buttonOutput.Location = new System.Drawing.Point(12, 283);
			this.buttonOutput.Name = "buttonOutput";
			this.buttonOutput.Size = new System.Drawing.Size(260, 37);
			this.buttonOutput.TabIndex = 13;
			this.buttonOutput.Text = "Вывести";
			this.buttonOutput.UseVisualStyleBackColor = true;
			this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
			// 
			// richTextBoxOutput
			// 
			this.richTextBoxOutput.Location = new System.Drawing.Point(12, 342);
			this.richTextBoxOutput.Name = "richTextBoxOutput";
			this.richTextBoxOutput.Size = new System.Drawing.Size(260, 96);
			this.richTextBoxOutput.TabIndex = 14;
			this.richTextBoxOutput.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(284, 461);
			this.Controls.Add(this.richTextBoxOutput);
			this.Controls.Add(this.buttonOutput);
			this.Controls.Add(this.panelSex);
			this.Controls.Add(this.textBoxFootLength);
			this.Controls.Add(this.textBoxGrowth);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.numericUpDownAge);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.LabelAge);
			this.Controls.Add(this.LabelYear);
			this.Controls.Add(this.LabelGrowth);
			this.Controls.Add(this.LabelFootLength);
			this.Controls.Add(this.LabelName);
			this.Controls.Add(this.LabelSurname);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.panelSex.ResumeLayout(false);
			this.panelSex.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelSurname;
		private System.Windows.Forms.Label LabelName;
		private System.Windows.Forms.Label LabelFootLength;
		private System.Windows.Forms.Label LabelGrowth;
		private System.Windows.Forms.Label LabelYear;
		private System.Windows.Forms.Label LabelAge;
		private System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.NumericUpDown numericUpDownAge;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.TextBox textBoxGrowth;
		private System.Windows.Forms.TextBox textBoxFootLength;
		private System.Windows.Forms.Panel panelSex;
		private System.Windows.Forms.RadioButton radioButtonFemale;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private System.Windows.Forms.Button buttonOutput;
		private System.Windows.Forms.RichTextBox richTextBoxOutput;
	}
}

