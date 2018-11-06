﻿namespace MovieRental
{
    partial class ManagerSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerSalesReport));
            this.label1 = new System.Windows.Forms.Label();
            this.SalesReportGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalSalesGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PopMovie = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TopEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Report";
            // 
            // SalesReportGrid
            // 
            this.SalesReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesReportGrid.Location = new System.Drawing.Point(16, 76);
            this.SalesReportGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalesReportGrid.Name = "SalesReportGrid";
            this.SalesReportGrid.Size = new System.Drawing.Size(496, 132);
            this.SalesReportGrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Per Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // TotalSalesGrid
            // 
            this.TotalSalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalSalesGrid.Location = new System.Drawing.Point(16, 270);
            this.TotalSalesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalSalesGrid.Name = "TotalSalesGrid";
            this.TotalSalesGrid.Size = new System.Drawing.Size(496, 132);
            this.TotalSalesGrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Most Popular Movie of Month";
            // 
            // PopMovie
            // 
            this.PopMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopMovie.Location = new System.Drawing.Point(16, 481);
            this.PopMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopMovie.Name = "PopMovie";
            this.PopMovie.Size = new System.Drawing.Size(496, 132);
            this.PopMovie.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 645);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Top Employee of the Month";
            // 
            // TopEmployee
            // 
            this.TopEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopEmployee.Location = new System.Drawing.Point(16, 679);
            this.TopEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopEmployee.Name = "TopEmployee";
            this.TopEmployee.Size = new System.Drawing.Size(496, 132);
            this.TopEmployee.TabIndex = 9;
            // 
            // ManagerSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(720, 843);
            this.Controls.Add(this.TopEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PopMovie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalSalesGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalesReportGrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerSalesReport";
            this.Text = "Manager Sales Report Page";
            this.Load += new System.EventHandler(this.ManagerSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SalesReportGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TotalSalesGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView PopMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TopEmployee;
    }
}