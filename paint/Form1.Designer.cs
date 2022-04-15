namespace paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonColorLine = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonLineDraw = new System.Windows.Forms.Button();
            this.buttonCircleDraw = new System.Windows.Forms.Button();
            this.buttonEllipseDraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(-2, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 513);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14"});
            this.comboBox1.Location = new System.Drawing.Point(115, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "8";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonColorLine
            // 
            this.buttonColorLine.Location = new System.Drawing.Point(194, 10);
            this.buttonColorLine.Name = "buttonColorLine";
            this.buttonColorLine.Size = new System.Drawing.Size(102, 23);
            this.buttonColorLine.TabIndex = 2;
            this.buttonColorLine.UseVisualStyleBackColor = true;
            this.buttonColorLine.Click += new System.EventHandler(this.buttonColorLine_Click);
            // 
            // buttonLineDraw
            // 
            this.buttonLineDraw.Location = new System.Drawing.Point(302, 10);
            this.buttonLineDraw.Name = "buttonLineDraw";
            this.buttonLineDraw.Size = new System.Drawing.Size(50, 23);
            this.buttonLineDraw.TabIndex = 3;
            this.buttonLineDraw.Text = "Line";
            this.buttonLineDraw.UseVisualStyleBackColor = true;
            this.buttonLineDraw.Click += new System.EventHandler(this.buttonLineDraw_Click);
            // 
            // buttonCircleDraw
            // 
            this.buttonCircleDraw.Location = new System.Drawing.Point(358, 12);
            this.buttonCircleDraw.Name = "buttonCircleDraw";
            this.buttonCircleDraw.Size = new System.Drawing.Size(50, 23);
            this.buttonCircleDraw.TabIndex = 4;
            this.buttonCircleDraw.Text = "Circle";
            this.buttonCircleDraw.UseVisualStyleBackColor = true;
            this.buttonCircleDraw.Click += new System.EventHandler(this.buttonCircleDraw_Click);
            // 
            // buttonEllipseDraw
            // 
            this.buttonEllipseDraw.Location = new System.Drawing.Point(414, 10);
            this.buttonEllipseDraw.Name = "buttonEllipseDraw";
            this.buttonEllipseDraw.Size = new System.Drawing.Size(50, 23);
            this.buttonEllipseDraw.TabIndex = 5;
            this.buttonEllipseDraw.Text = "Ellipse";
            this.buttonEllipseDraw.UseVisualStyleBackColor = true;
            this.buttonEllipseDraw.Click += new System.EventHandler(this.buttonEllipseDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(194, 39);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 21);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(7, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 21);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 768);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEllipseDraw);
            this.Controls.Add(this.buttonCircleDraw);
            this.Controls.Add(this.buttonLineDraw);
            this.Controls.Add(this.buttonColorLine);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonColorLine;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonLineDraw;
        private System.Windows.Forms.Button buttonCircleDraw;
        private System.Windows.Forms.Button buttonEllipseDraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}

