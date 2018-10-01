namespace DataBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CloseConnection = new System.Windows.Forms.Button();
            this.btn_OpenConnection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(317, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // btn_CloseConnection
            // 
            this.btn_CloseConnection.Location = new System.Drawing.Point(157, 403);
            this.btn_CloseConnection.Name = "btn_CloseConnection";
            this.btn_CloseConnection.Size = new System.Drawing.Size(134, 35);
            this.btn_CloseConnection.TabIndex = 1;
            this.btn_CloseConnection.Text = "Close Connection";
            this.btn_CloseConnection.UseVisualStyleBackColor = true;
            this.btn_CloseConnection.Click += new System.EventHandler(this.btn_CloseConnection_Click);
            // 
            // btn_OpenConnection
            // 
            this.btn_OpenConnection.Location = new System.Drawing.Point(17, 403);
            this.btn_OpenConnection.Name = "btn_OpenConnection";
            this.btn_OpenConnection.Size = new System.Drawing.Size(134, 35);
            this.btn_OpenConnection.TabIndex = 2;
            this.btn_OpenConnection.Text = "Open Connection";
            this.btn_OpenConnection.UseVisualStyleBackColor = true;
            this.btn_OpenConnection.Click += new System.EventHandler(this.btn_OpenConnection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 219);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 238);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 159);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_OpenConnection);
            this.Controls.Add(this.btn_CloseConnection);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CloseConnection;
        private System.Windows.Forms.Button btn_OpenConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

