namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.newPict = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.polyline = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 436);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line
            // 
            this.line.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.line.Location = new System.Drawing.Point(3, 3);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(75, 23);
            this.line.TabIndex = 2;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 541);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.newPict, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.save, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.open, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(442, 45);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // newPict
            // 
            this.newPict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPict.Location = new System.Drawing.Point(12, 11);
            this.newPict.Name = "newPict";
            this.newPict.Size = new System.Drawing.Size(75, 23);
            this.newPict.TabIndex = 0;
            this.newPict.Text = "New";
            this.newPict.UseVisualStyleBackColor = true;
            this.newPict.Click += new System.EventHandler(this.newPict_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Location = new System.Drawing.Point(354, 11);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.open.Location = new System.Drawing.Point(112, 11);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 1;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.line, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.polyline, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Circle, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rectangle, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(451, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(106, 436);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // polyline
            // 
            this.polyline.Location = new System.Drawing.Point(3, 112);
            this.polyline.Name = "polyline";
            this.polyline.Size = new System.Drawing.Size(75, 23);
            this.polyline.TabIndex = 3;
            this.polyline.Text = "Polyline";
            this.polyline.UseVisualStyleBackColor = true;
            this.polyline.Click += new System.EventHandler(this.polyline_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(3, 221);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 4;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(3, 330);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(75, 23);
            this.rectangle.TabIndex = 5;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);




        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button newPict;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button polyline;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button rectangle;
    }
}

