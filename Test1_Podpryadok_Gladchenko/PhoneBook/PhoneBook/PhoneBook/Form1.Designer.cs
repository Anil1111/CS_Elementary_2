namespace PhoneBook
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
            this.btn_add = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.skypeBox = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_skype = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(463, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nameBox
            // 
            this.nameBox.AccessibleDescription = "";
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(463, 55);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(249, 20);
            this.nameBox.TabIndex = 2;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneBox.Enabled = false;
            this.phoneBox.Location = new System.Drawing.Point(463, 94);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(250, 20);
            this.phoneBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailBox.Enabled = false;
            this.emailBox.Location = new System.Drawing.Point(463, 133);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(250, 20);
            this.emailBox.TabIndex = 4;
            // 
            // skypeBox
            // 
            this.skypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skypeBox.Enabled = false;
            this.skypeBox.Location = new System.Drawing.Point(463, 172);
            this.skypeBox.Name = "skypeBox";
            this.skypeBox.Size = new System.Drawing.Size(250, 20);
            this.skypeBox.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(638, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(462, 300);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(249, 20);
            this.SearchBox.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btn_search.Location = new System.Drawing.Point(462, 326);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(250, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delate
            // 
            this.btn_delate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delate.Enabled = false;
            this.btn_delate.Location = new System.Drawing.Point(551, 14);
            this.btn_delate.Name = "btn_delate";
            this.btn_delate.Size = new System.Drawing.Size(81, 23);
            this.btn_delate.TabIndex = 9;
            this.btn_delate.Text = "Delate";
            this.btn_delate.UseVisualStyleBackColor = true;
            this.btn_delate.Click += new System.EventHandler(this.btn_delate_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(445, 337);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(463, 39);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Name";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(463, 78);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(38, 13);
            this.label_phone.TabIndex = 12;
            this.label_phone.Text = "Phone";
            // 
            // label_email
            // 
            this.label_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(463, 117);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 13;
            this.label_email.Text = "Email";
            // 
            // label_skype
            // 
            this.label_skype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_skype.AutoSize = true;
            this.label_skype.Location = new System.Drawing.Point(463, 156);
            this.label_skype.Name = "label_skype";
            this.label_skype.Size = new System.Drawing.Size(37, 13);
            this.label_skype.TabIndex = 14;
            this.label_skype.Text = "Skype";
            // 
            // label_search
            // 
            this.label_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(463, 284);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(41, 13);
            this.label_search.TabIndex = 15;
            this.label_search.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 361);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.label_skype);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_delate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.skypeBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox skypeBox;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_skype;
        private System.Windows.Forms.Label label_search;
    }
}

