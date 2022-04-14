namespace grades
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
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonStats = new System.Windows.Forms.Button();
			this.panelGradeButtons = new System.Windows.Forms.Panel();
			this.panelCountGrades = new System.Windows.Forms.Panel();
			this.labelStats = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(12, 467);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(243, 51);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Начать";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(272, 467);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(247, 51);
			this.buttonClear.TabIndex = 1;
			this.buttonClear.Text = "Очистить";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonStats
			// 
			this.buttonStats.Location = new System.Drawing.Point(272, 410);
			this.buttonStats.Name = "buttonStats";
			this.buttonStats.Size = new System.Drawing.Size(247, 51);
			this.buttonStats.TabIndex = 2;
			this.buttonStats.Text = "Статистика";
			this.buttonStats.UseVisualStyleBackColor = true;
			this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
			// 
			// panelGradeButtons
			// 
			this.panelGradeButtons.Location = new System.Drawing.Point(12, 12);
			this.panelGradeButtons.Name = "panelGradeButtons";
			this.panelGradeButtons.Size = new System.Drawing.Size(243, 382);
			this.panelGradeButtons.TabIndex = 3;
			// 
			// panelCountGrades
			// 
			this.panelCountGrades.Location = new System.Drawing.Point(272, 12);
			this.panelCountGrades.Name = "panelCountGrades";
			this.panelCountGrades.Size = new System.Drawing.Size(247, 382);
			this.panelCountGrades.TabIndex = 4;
			// 
			// labelStats
			// 
			this.labelStats.AutoSize = true;
			this.labelStats.Location = new System.Drawing.Point(13, 410);
			this.labelStats.Name = "labelStats";
			this.labelStats.Size = new System.Drawing.Size(0, 13);
			this.labelStats.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 530);
			this.Controls.Add(this.labelStats);
			this.Controls.Add(this.panelCountGrades);
			this.Controls.Add(this.panelGradeButtons);
			this.Controls.Add(this.buttonStats);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonStats;
		private System.Windows.Forms.Panel panelGradeButtons;
		private System.Windows.Forms.Panel panelCountGrades;
		private System.Windows.Forms.Label labelStats;
	}
}

