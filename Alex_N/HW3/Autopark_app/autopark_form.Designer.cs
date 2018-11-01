namespace Autopark_app
{
    partial class autopark_form
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
            this.components = new System.ComponentModel.Container();
            this.addDriverBTN = new System.Windows.Forms.Button();
            this.driversList = new System.Windows.Forms.ListBox();
            this.infoOutput = new System.Windows.Forms.Label();
            this.carsList = new System.Windows.Forms.ListBox();
            this.dealList = new System.Windows.Forms.ListBox();
            this.RPList = new System.Windows.Forms.ListBox();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.addDealBtn = new System.Windows.Forms.Button();
            this.approveRequestBtn = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.DRIVERS = new System.Windows.Forms.Label();
            this.CARS = new System.Windows.Forms.Label();
            this.DEALS = new System.Windows.Forms.Label();
            this.REPAIRBLANKS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addDriverBTN
            // 
            this.addDriverBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(106)))), ((int)(((byte)(161)))));
            this.addDriverBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.addDriverBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDriverBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.addDriverBTN.Location = new System.Drawing.Point(37, 286);
            this.addDriverBTN.Name = "addDriverBTN";
            this.addDriverBTN.Size = new System.Drawing.Size(75, 23);
            this.addDriverBTN.TabIndex = 2;
            this.addDriverBTN.Text = "Add";
            this.addDriverBTN.UseVisualStyleBackColor = false;
            this.addDriverBTN.Click += new System.EventHandler(this.addDriverBTN_Click);
            // 
            // driversList
            // 
            this.driversList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.driversList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driversList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driversList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driversList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.driversList.FormattingEnabled = true;
            this.driversList.Location = new System.Drawing.Point(16, 33);
            this.driversList.Name = "driversList";
            this.driversList.Size = new System.Drawing.Size(120, 234);
            this.driversList.TabIndex = 1;
            this.driversList.SelectedIndexChanged += new System.EventHandler(this.driversList_SelectedIndexChanged);
            // 
            // infoOutput
            // 
            this.infoOutput.AutoSize = true;
            this.infoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.infoOutput.Location = new System.Drawing.Point(12, 388);
            this.infoOutput.Name = "infoOutput";
            this.infoOutput.Size = new System.Drawing.Size(0, 13);
            this.infoOutput.TabIndex = 2;
            // 
            // carsList
            // 
            this.carsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.carsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.carsList.FormattingEnabled = true;
            this.carsList.Location = new System.Drawing.Point(156, 32);
            this.carsList.Name = "carsList";
            this.carsList.Size = new System.Drawing.Size(120, 234);
            this.carsList.TabIndex = 3;
            this.carsList.SelectedIndexChanged += new System.EventHandler(this.carsList_SelectedIndexChanged);
            // 
            // dealList
            // 
            this.dealList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.dealList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dealList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dealList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.dealList.FormattingEnabled = true;
            this.dealList.Location = new System.Drawing.Point(297, 32);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(120, 234);
            this.dealList.TabIndex = 5;
            this.dealList.SelectedIndexChanged += new System.EventHandler(this.dealList_SelectedIndexChanged);
            // 
            // RPList
            // 
            this.RPList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(212)))));
            this.RPList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RPList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RPList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RPList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.RPList.FormattingEnabled = true;
            this.RPList.Location = new System.Drawing.Point(438, 33);
            this.RPList.Name = "RPList";
            this.RPList.Size = new System.Drawing.Size(120, 234);
            this.RPList.TabIndex = 7;
            this.RPList.SelectedIndexChanged += new System.EventHandler(this.RPList_SelectedIndexChanged);
            // 
            // addCarBtn
            // 
            this.addCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(106)))), ((int)(((byte)(161)))));
            this.addCarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.addCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.addCarBtn.Location = new System.Drawing.Point(179, 286);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 4;
            this.addCarBtn.Text = "Add";
            this.addCarBtn.UseVisualStyleBackColor = false;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // addDealBtn
            // 
            this.addDealBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(106)))), ((int)(((byte)(161)))));
            this.addDealBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.addDealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDealBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.addDealBtn.Location = new System.Drawing.Point(317, 286);
            this.addDealBtn.Name = "addDealBtn";
            this.addDealBtn.Size = new System.Drawing.Size(75, 23);
            this.addDealBtn.TabIndex = 6;
            this.addDealBtn.Text = "Add";
            this.addDealBtn.UseVisualStyleBackColor = false;
            this.addDealBtn.Click += new System.EventHandler(this.addDealBtn_Click);
            // 
            // approveRequestBtn
            // 
            this.approveRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(106)))), ((int)(((byte)(161)))));
            this.approveRequestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.approveRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveRequestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.approveRequestBtn.Location = new System.Drawing.Point(460, 286);
            this.approveRequestBtn.Name = "approveRequestBtn";
            this.approveRequestBtn.Size = new System.Drawing.Size(75, 23);
            this.approveRequestBtn.TabIndex = 8;
            this.approveRequestBtn.Text = "Approve";
            this.approveRequestBtn.UseVisualStyleBackColor = false;
            this.approveRequestBtn.Click += new System.EventHandler(this.approveRequestBtn_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // DRIVERS
            // 
            this.DRIVERS.AutoSize = true;
            this.DRIVERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DRIVERS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.DRIVERS.Location = new System.Drawing.Point(44, 12);
            this.DRIVERS.Name = "DRIVERS";
            this.DRIVERS.Size = new System.Drawing.Size(62, 13);
            this.DRIVERS.TabIndex = 6;
            this.DRIVERS.Text = "DRIVERS";
            this.DRIVERS.Click += new System.EventHandler(this.label1_Click);
            // 
            // CARS
            // 
            this.CARS.AutoSize = true;
            this.CARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CARS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.CARS.Location = new System.Drawing.Point(194, 12);
            this.CARS.Name = "CARS";
            this.CARS.Size = new System.Drawing.Size(40, 13);
            this.CARS.TabIndex = 6;
            this.CARS.Text = "CARS";
            this.CARS.Click += new System.EventHandler(this.label1_Click);
            // 
            // DEALS
            // 
            this.DEALS.AutoSize = true;
            this.DEALS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DEALS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.DEALS.Location = new System.Drawing.Point(335, 12);
            this.DEALS.Name = "DEALS";
            this.DEALS.Size = new System.Drawing.Size(47, 13);
            this.DEALS.TabIndex = 6;
            this.DEALS.Text = "DEALS";
            this.DEALS.Click += new System.EventHandler(this.label1_Click);
            // 
            // REPAIRBLANKS
            // 
            this.REPAIRBLANKS.AutoSize = true;
            this.REPAIRBLANKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.REPAIRBLANKS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(2)))), ((int)(((byte)(109)))));
            this.REPAIRBLANKS.Location = new System.Drawing.Point(444, 12);
            this.REPAIRBLANKS.Name = "REPAIRBLANKS";
            this.REPAIRBLANKS.Size = new System.Drawing.Size(105, 13);
            this.REPAIRBLANKS.TabIndex = 6;
            this.REPAIRBLANKS.Text = "REPAIR BLANKS";
            this.REPAIRBLANKS.Click += new System.EventHandler(this.label1_Click);
            // 
            // autopark_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(108)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(570, 625);
            this.Controls.Add(this.REPAIRBLANKS);
            this.Controls.Add(this.DEALS);
            this.Controls.Add(this.CARS);
            this.Controls.Add(this.DRIVERS);
            this.Controls.Add(this.approveRequestBtn);
            this.Controls.Add(this.addDealBtn);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.infoOutput);
            this.Controls.Add(this.RPList);
            this.Controls.Add(this.dealList);
            this.Controls.Add(this.carsList);
            this.Controls.Add(this.driversList);
            this.Controls.Add(this.addDriverBTN);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "autopark_form";
            this.Text = "Autopark";
            this.Load += new System.EventHandler(this.autopark_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDriverBTN;
        private System.Windows.Forms.ListBox driversList;
        private System.Windows.Forms.Label infoOutput;
        private System.Windows.Forms.ListBox carsList;
        private System.Windows.Forms.ListBox dealList;       
        private System.Windows.Forms.ListBox RPList;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button addDealBtn;
        private System.Windows.Forms.Button approveRequestBtn;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label DRIVERS;
        private System.Windows.Forms.Label CARS;
        private System.Windows.Forms.Label DEALS;
        private System.Windows.Forms.Label REPAIRBLANKS;
    }
}

