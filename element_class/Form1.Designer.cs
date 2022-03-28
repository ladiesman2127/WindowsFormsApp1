namespace element_class
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
			this.buttonEnter = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.textBoxCountOfButton = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonEnter
			// 
			this.buttonEnter.Location = new System.Drawing.Point(335, 13);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(66, 25);
			this.buttonEnter.TabIndex = 0;
			this.buttonEnter.Text = "Enter";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.Color.LemonChiffon;
			this.panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelMain.Location = new System.Drawing.Point(13, 44);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(775, 100);
			this.panelMain.TabIndex = 1;
			// 
			// textBoxCountOfButton
			// 
			this.textBoxCountOfButton.Location = new System.Drawing.Point(229, 16);
			this.textBoxCountOfButton.Name = "textBoxCountOfButton";
			this.textBoxCountOfButton.Size = new System.Drawing.Size(100, 20);
			this.textBoxCountOfButton.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxCountOfButton);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.buttonEnter);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonEnter;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.TextBox textBoxCountOfButton;
	}
}

