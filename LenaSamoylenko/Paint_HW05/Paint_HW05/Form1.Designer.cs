namespace Paint_HW05
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
            this.button_Pencil = new System.Windows.Forms.Button();
            this.button_Line = new System.Windows.Forms.Button();
            this.button_Circle = new System.Windows.Forms.Button();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.COLOR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Pencil
            // 
            this.button_Pencil.Location = new System.Drawing.Point(605, 12);
            this.button_Pencil.Name = "button_Pencil";
            this.button_Pencil.Size = new System.Drawing.Size(83, 50);
            this.button_Pencil.TabIndex = 1;
            this.button_Pencil.Text = "Pencil";
            this.button_Pencil.UseVisualStyleBackColor = true;
            this.button_Pencil.Click += new System.EventHandler(this.button_Pencil_Click);
            // 
            // button_Line
            // 
            this.button_Line.Location = new System.Drawing.Point(694, 13);
            this.button_Line.Name = "button_Line";
            this.button_Line.Size = new System.Drawing.Size(78, 50);
            this.button_Line.TabIndex = 2;
            this.button_Line.Text = "Line";
            this.button_Line.UseVisualStyleBackColor = true;
            this.button_Line.Click += new System.EventHandler(this.button_Line_Click);
            // 
            // button_Circle
            // 
            this.button_Circle.Location = new System.Drawing.Point(605, 68);
            this.button_Circle.Name = "button_Circle";
            this.button_Circle.Size = new System.Drawing.Size(83, 50);
            this.button_Circle.TabIndex = 3;
            this.button_Circle.Text = "Circle";
            this.button_Circle.UseVisualStyleBackColor = true;
            this.button_Circle.Click += new System.EventHandler(this.button_Circle_Click);
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.Location = new System.Drawing.Point(694, 68);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(78, 50);
            this.button_Rectangle.TabIndex = 4;
            this.button_Rectangle.Text = "Rectangle";
            this.button_Rectangle.UseVisualStyleBackColor = true;
            this.button_Rectangle.Click += new System.EventHandler(this.button_Rectangle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 537);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // COLOR
            // 
            this.COLOR.Location = new System.Drawing.Point(606, 124);
            this.COLOR.Name = "COLOR";
            this.COLOR.Size = new System.Drawing.Size(82, 50);
            this.COLOR.TabIndex = 7;
            this.COLOR.Text = "COLOR";
            this.COLOR.UseVisualStyleBackColor = true;
            this.COLOR.Click += new System.EventHandler(this.COLOR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.COLOR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Rectangle);
            this.Controls.Add(this.button_Circle);
            this.Controls.Add(this.button_Line);
            this.Controls.Add(this.button_Pencil);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Pencil;
        private System.Windows.Forms.Button button_Line;
        private System.Windows.Forms.Button button_Circle;
        private System.Windows.Forms.Button button_Rectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button COLOR;
    }
}

