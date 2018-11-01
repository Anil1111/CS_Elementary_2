namespace Autopark_app
{
    partial class Add_item
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
            this.createBTN = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.input_1 = new System.Windows.Forms.TextBox();
            this.input_2 = new System.Windows.Forms.TextBox();
            this.input_3 = new System.Windows.Forms.TextBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.input_4 = new System.Windows.Forms.TextBox();
            this.label_4 = new System.Windows.Forms.Label();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.driverChose = new System.Windows.Forms.ComboBox();
            this.carChose = new System.Windows.Forms.ComboBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBTN
            // 
            this.createBTN.Location = new System.Drawing.Point(98, 153);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(75, 23);
            this.createBTN.TabIndex = 0;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(12, 22);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(28, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "Test";
            // 
            // input_1
            // 
            this.input_1.Location = new System.Drawing.Point(99, 20);
            this.input_1.Name = "input_1";
            this.input_1.Size = new System.Drawing.Size(156, 20);
            this.input_1.TabIndex = 2;
            // 
            // input_2
            // 
            this.input_2.Location = new System.Drawing.Point(99, 46);
            this.input_2.Name = "input_2";
            this.input_2.Size = new System.Drawing.Size(156, 20);
            this.input_2.TabIndex = 2;
            // 
            // input_3
            // 
            this.input_3.Location = new System.Drawing.Point(99, 72);
            this.input_3.Name = "input_3";
            this.input_3.Size = new System.Drawing.Size(156, 20);
            this.input_3.TabIndex = 2;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(12, 48);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(28, 13);
            this.label_2.TabIndex = 1;
            this.label_2.Text = "Test";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(12, 74);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(28, 13);
            this.label_3.TabIndex = 1;
            this.label_3.Text = "Test";
            // 
            // input_4
            // 
            this.input_4.Location = new System.Drawing.Point(99, 98);
            this.input_4.Name = "input_4";
            this.input_4.Size = new System.Drawing.Size(156, 20);
            this.input_4.TabIndex = 2;
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(12, 100);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(28, 13);
            this.label_4.TabIndex = 1;
            this.label_4.Text = "Test";
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(180, 153);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 0;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // driverChose
            // 
            this.driverChose.FormattingEnabled = true;
            this.driverChose.Location = new System.Drawing.Point(99, 45);
            this.driverChose.Name = "driverChose";
            this.driverChose.Size = new System.Drawing.Size(121, 21);
            this.driverChose.TabIndex = 4;
            // 
            // carChose
            // 
            this.carChose.FormattingEnabled = true;
            this.carChose.Location = new System.Drawing.Point(99, 72);
            this.carChose.Name = "carChose";
            this.carChose.Size = new System.Drawing.Size(121, 21);
            this.carChose.TabIndex = 4;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(12, 131);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 5;
            this.testLabel.Text = "label1";
            // 
            // Add_item
            // 
            this.ClientSize = new System.Drawing.Size(274, 188);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.carChose);
            this.Controls.Add(this.driverChose);
            this.Controls.Add(this.input_4);
            this.Controls.Add(this.input_3);
            this.Controls.Add(this.input_2);
            this.Controls.Add(this.input_1);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.createBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_item";
            this.Text = "Create Item";
            this.Load += new System.EventHandler(this.Add_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox input_1;
        private System.Windows.Forms.TextBox input_2;
        private System.Windows.Forms.TextBox input_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.TextBox input_4;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.ComboBox driverChose;
        private System.Windows.Forms.ComboBox carChose;
        private System.Windows.Forms.Label testLabel;
    }
}