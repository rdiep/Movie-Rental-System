namespace MovieRental
{
    partial class ManagerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainPage));
            this.ManagerTitle = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MovieButton = new System.Windows.Forms.Button();
            this.RentalButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TopEmployeeGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TopCustomerGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TopMovieGrid = new System.Windows.Forms.DataGridView();
            this.SalesReportButton = new System.Windows.Forms.Button();
            this.actorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopEmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopMovieGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerTitle
            // 
            this.ManagerTitle.AutoSize = true;
            this.ManagerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerTitle.Location = new System.Drawing.Point(16, 11);
            this.ManagerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManagerTitle.Name = "ManagerTitle";
            this.ManagerTitle.Size = new System.Drawing.Size(108, 29);
            this.ManagerTitle.TabIndex = 0;
            this.ManagerTitle.Text = "Manager";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(837, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 28);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MovieButton
            // 
            this.MovieButton.Location = new System.Drawing.Point(21, 82);
            this.MovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(100, 28);
            this.MovieButton.TabIndex = 2;
            this.MovieButton.Text = "Movie";
            this.MovieButton.UseVisualStyleBackColor = true;
            this.MovieButton.Click += new System.EventHandler(this.MovieButton_Click);
            // 
            // RentalButton
            // 
            this.RentalButton.Location = new System.Drawing.Point(163, 82);
            this.RentalButton.Margin = new System.Windows.Forms.Padding(4);
            this.RentalButton.Name = "RentalButton";
            this.RentalButton.Size = new System.Drawing.Size(100, 28);
            this.RentalButton.TabIndex = 3;
            this.RentalButton.Text = "Rental";
            this.RentalButton.UseVisualStyleBackColor = true;
            this.RentalButton.Click += new System.EventHandler(this.RentalButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(301, 82);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(100, 28);
            this.EmployeeButton.TabIndex = 4;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top Employee";
            // 
            // TopEmployeeGrid
            // 
            this.TopEmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopEmployeeGrid.Location = new System.Drawing.Point(16, 156);
            this.TopEmployeeGrid.Margin = new System.Windows.Forms.Padding(4);
            this.TopEmployeeGrid.Name = "TopEmployeeGrid";
            this.TopEmployeeGrid.Size = new System.Drawing.Size(827, 166);
            this.TopEmployeeGrid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top Customer";
            // 
            // TopCustomerGrid
            // 
            this.TopCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopCustomerGrid.Location = new System.Drawing.Point(16, 346);
            this.TopCustomerGrid.Margin = new System.Windows.Forms.Padding(4);
            this.TopCustomerGrid.Name = "TopCustomerGrid";
            this.TopCustomerGrid.Size = new System.Drawing.Size(827, 166);
            this.TopCustomerGrid.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 516);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Top Movie";
            // 
            // TopMovieGrid
            // 
            this.TopMovieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopMovieGrid.Location = new System.Drawing.Point(16, 535);
            this.TopMovieGrid.Margin = new System.Windows.Forms.Padding(4);
            this.TopMovieGrid.Name = "TopMovieGrid";
            this.TopMovieGrid.Size = new System.Drawing.Size(827, 166);
            this.TopMovieGrid.TabIndex = 10;
            // 
            // SalesReportButton
            // 
            this.SalesReportButton.Location = new System.Drawing.Point(435, 82);
            this.SalesReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.SalesReportButton.Name = "SalesReportButton";
            this.SalesReportButton.Size = new System.Drawing.Size(135, 28);
            this.SalesReportButton.TabIndex = 11;
            this.SalesReportButton.Text = "Sales Report";
            this.SalesReportButton.UseVisualStyleBackColor = true;
            this.SalesReportButton.Click += new System.EventHandler(this.SalesReportButton_Click);
            // 
            // actorButton
            // 
            this.actorButton.Location = new System.Drawing.Point(602, 82);
            this.actorButton.Margin = new System.Windows.Forms.Padding(4);
            this.actorButton.Name = "actorButton";
            this.actorButton.Size = new System.Drawing.Size(135, 28);
            this.actorButton.TabIndex = 12;
            this.actorButton.Text = "Actors";
            this.actorButton.UseVisualStyleBackColor = true;
            this.actorButton.Click += new System.EventHandler(this.actorButton_Click);
            // 
            // ManagerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(953, 768);
            this.Controls.Add(this.actorButton);
            this.Controls.Add(this.SalesReportButton);
            this.Controls.Add(this.TopMovieGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopCustomerGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopEmployeeGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.RentalButton);
            this.Controls.Add(this.MovieButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ManagerTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerMainPage";
            this.Text = "Manager Main Page";
            this.Load += new System.EventHandler(this.ManagerMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopEmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopMovieGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManagerTitle;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.Button RentalButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TopEmployeeGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TopCustomerGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TopMovieGrid;
        private System.Windows.Forms.Button SalesReportButton;
        private System.Windows.Forms.Button actorButton;
    }
}