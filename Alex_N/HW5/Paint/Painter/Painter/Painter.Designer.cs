namespace Painter
{
    partial class Painter
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
            this.cDialog = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.bSizeBar = new System.Windows.Forms.TrackBar();
            this.sizeIndicator = new System.Windows.Forms.Label();
            this.FillCheckBox = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ellipsButton = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            this.SuspendLayout();
            // 
            // cDialog
            // 
            this.cDialog.FullOpen = true;
            // 
            // colorButton
            // 
            this.colorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorButton.FlatAppearance.BorderSize = 0;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.Location = new System.Drawing.Point(300, 495);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(50, 50);
            this.colorButton.TabIndex = 1;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            this.colorButton.MouseLeave += new System.EventHandler(this.colorButton_MouseLeave);
            this.colorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorButton_MouseMove);
            // 
            // bSizeBar
            // 
            this.bSizeBar.AutoSize = false;
            this.bSizeBar.BackColor = System.Drawing.Color.White;
            this.bSizeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSizeBar.Location = new System.Drawing.Point(43, 495);
            this.bSizeBar.Maximum = 250;
            this.bSizeBar.Minimum = 1;
            this.bSizeBar.Name = "bSizeBar";
            this.bSizeBar.Size = new System.Drawing.Size(214, 49);
            this.bSizeBar.TabIndex = 2;
            this.bSizeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bSizeBar.Value = 1;
            this.bSizeBar.Scroll += new System.EventHandler(this.bSizeBar_Scroll);
            // 
            // sizeIndicator
            // 
            this.sizeIndicator.AutoSize = true;
            this.sizeIndicator.BackColor = System.Drawing.Color.White;
            this.sizeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeIndicator.Location = new System.Drawing.Point(138, 516);
            this.sizeIndicator.Name = "sizeIndicator";
            this.sizeIndicator.Size = new System.Drawing.Size(17, 17);
            this.sizeIndicator.TabIndex = 5;
            this.sizeIndicator.Text = "1\r\n";
            this.sizeIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FillCheckBox
            // 
            this.FillCheckBox.AutoSize = true;
            this.FillCheckBox.BackColor = System.Drawing.Color.White;
            this.FillCheckBox.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillCheckBox.Location = new System.Drawing.Point(487, 512);
            this.FillCheckBox.Name = "FillCheckBox";
            this.FillCheckBox.Size = new System.Drawing.Size(95, 24);
            this.FillCheckBox.TabIndex = 6;
            this.FillCheckBox.Text = "Fill Figure";
            this.FillCheckBox.UseVisualStyleBackColor = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.saveBtn.BackgroundImage = global::Painter.Properties.Resources.save_ico;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(764, 494);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(50, 50);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveBtn_MouseClick);
            // 
            // ellipsButton
            // 
            this.ellipsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ellipsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ellipsButton.BackgroundImage = global::Painter.Properties.Resources.circle_ico;
            this.ellipsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipsButton.FlatAppearance.BorderSize = 0;
            this.ellipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipsButton.Location = new System.Drawing.Point(412, 495);
            this.ellipsButton.Name = "ellipsButton";
            this.ellipsButton.Size = new System.Drawing.Size(50, 50);
            this.ellipsButton.TabIndex = 4;
            this.ellipsButton.UseVisualStyleBackColor = false;
            this.ellipsButton.Click += new System.EventHandler(this.ellipsButton_Click);
            // 
            // recBtn
            // 
            this.recBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.recBtn.BackgroundImage = global::Painter.Properties.Resources.rect_ico;
            this.recBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recBtn.FlatAppearance.BorderSize = 0;
            this.recBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recBtn.Location = new System.Drawing.Point(356, 495);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(50, 50);
            this.recBtn.TabIndex = 3;
            this.recBtn.UseVisualStyleBackColor = false;
            this.recBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recBtn_MouseClick);
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paper.Location = new System.Drawing.Point(0, 0);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(826, 556);
            this.paper.TabIndex = 0;
            this.paper.TabStop = false;
            this.paper.DoubleClick += new System.EventHandler(this.paper_DoubleClick);
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paper_MouseMove);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(826, 556);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.FillCheckBox);
            this.Controls.Add(this.sizeIndicator);
            this.Controls.Add(this.ellipsButton);
            this.Controls.Add(this.recBtn);
            this.Controls.Add(this.bSizeBar);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.paper);
            this.Name = "Painter";
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.ColorDialog cDialog;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar bSizeBar;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Button ellipsButton;
        private System.Windows.Forms.Label sizeIndicator;
        private System.Windows.Forms.CheckBox FillCheckBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

