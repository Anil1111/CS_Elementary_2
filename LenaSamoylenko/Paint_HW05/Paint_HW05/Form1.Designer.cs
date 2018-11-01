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
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Brown");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Red");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Green");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Outline", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Brown");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Red");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Green");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Filling", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46,
            treeNode47});
            this.button_Pencil = new System.Windows.Forms.Button();
            this.button_Line = new System.Windows.Forms.Button();
            this.button_Circle = new System.Windows.Forms.Button();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Pencil
            // 
            this.button_Pencil.Location = new System.Drawing.Point(637, 13);
            this.button_Pencil.Name = "button_Pencil";
            this.button_Pencil.Size = new System.Drawing.Size(50, 50);
            this.button_Pencil.TabIndex = 1;
            this.button_Pencil.Text = "Pencil";
            this.button_Pencil.UseVisualStyleBackColor = true;
            this.button_Pencil.Click += new System.EventHandler(this.button_Pencil_Click);
            // 
            // button_Line
            // 
            this.button_Line.Location = new System.Drawing.Point(693, 12);
            this.button_Line.Name = "button_Line";
            this.button_Line.Size = new System.Drawing.Size(50, 50);
            this.button_Line.TabIndex = 2;
            this.button_Line.Text = "Line";
            this.button_Line.UseVisualStyleBackColor = true;
            this.button_Line.Click += new System.EventHandler(this.button_Line_Click);
            // 
            // button_Circle
            // 
            this.button_Circle.Location = new System.Drawing.Point(636, 71);
            this.button_Circle.Name = "button_Circle";
            this.button_Circle.Size = new System.Drawing.Size(50, 50);
            this.button_Circle.TabIndex = 3;
            this.button_Circle.Text = "Circle";
            this.button_Circle.UseVisualStyleBackColor = true;
            this.button_Circle.Click += new System.EventHandler(this.button_Circle_Click);
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.Location = new System.Drawing.Point(693, 71);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(50, 50);
            this.button_Rectangle.TabIndex = 4;
            this.button_Rectangle.Text = "Rectangle";
            this.button_Rectangle.UseVisualStyleBackColor = true;
            this.button_Rectangle.Click += new System.EventHandler(this.button_Rectangle_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(636, 127);
            this.treeView1.Name = "treeView1";
            treeNode41.BackColor = System.Drawing.Color.White;
            treeNode41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode41.Name = "Brown";
            treeNode41.Text = "Brown";
            treeNode42.BackColor = System.Drawing.Color.White;
            treeNode42.ForeColor = System.Drawing.Color.Red;
            treeNode42.Name = "Red";
            treeNode42.Text = "Red";
            treeNode43.ForeColor = System.Drawing.Color.Green;
            treeNode43.Name = "Green";
            treeNode43.Text = "Green";
            treeNode44.Name = "Outline";
            treeNode44.Text = "Outline";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode44});
            this.treeView1.Size = new System.Drawing.Size(121, 70);
            this.treeView1.TabIndex = 5;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 537);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(636, 203);
            this.treeView2.Name = "treeView2";
            treeNode45.BackColor = System.Drawing.Color.White;
            treeNode45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode45.Name = "Brown";
            treeNode45.Text = "Brown";
            treeNode46.BackColor = System.Drawing.Color.White;
            treeNode46.ForeColor = System.Drawing.Color.Red;
            treeNode46.Name = "Red";
            treeNode46.Text = "Red";
            treeNode47.ForeColor = System.Drawing.Color.Green;
            treeNode47.Name = "Green";
            treeNode47.Text = "Green";
            treeNode48.Name = "Filling";
            treeNode48.Text = "Filling";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode48});
            this.treeView2.Size = new System.Drawing.Size(121, 70);
            this.treeView2.TabIndex = 7;
            this.treeView2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView2;
    }
}

