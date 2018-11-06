namespace MovieRental
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.ManagerLogin = new System.Windows.Forms.Button();
            this.CustomerLogin = new System.Windows.Forms.Button();
            this.EmployeeLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerLogin
            // 
            this.ManagerLogin.Location = new System.Drawing.Point(101, 342);
            this.ManagerLogin.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerLogin.Name = "ManagerLogin";
            this.ManagerLogin.Size = new System.Drawing.Size(100, 28);
            this.ManagerLogin.TabIndex = 1;
            this.ManagerLogin.Text = "Manager";
            this.ManagerLogin.UseVisualStyleBackColor = true;
            this.ManagerLogin.Click += new System.EventHandler(this.ManagerLogin_Click);
            // 
            // CustomerLogin
            // 
            this.CustomerLogin.Location = new System.Drawing.Point(329, 342);
            this.CustomerLogin.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerLogin.Name = "CustomerLogin";
            this.CustomerLogin.Size = new System.Drawing.Size(100, 28);
            this.CustomerLogin.TabIndex = 2;
            this.CustomerLogin.Text = "Customer";
            this.CustomerLogin.UseVisualStyleBackColor = true;
            this.CustomerLogin.Click += new System.EventHandler(this.CustomerLogin_Click);
            // 
            // EmployeeLogin
            // 
            this.EmployeeLogin.Location = new System.Drawing.Point(577, 342);
            this.EmployeeLogin.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeLogin.Name = "EmployeeLogin";
            this.EmployeeLogin.Size = new System.Drawing.Size(100, 28);
            this.EmployeeLogin.TabIndex = 3;
            this.EmployeeLogin.Text = "Employee";
            this.EmployeeLogin.UseVisualStyleBackColor = true;
            this.EmployeeLogin.Click += new System.EventHandler(this.EmployeeLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "MOVIE RENTAL SYSTEM";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(776, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmployeeLogin);
            this.Controls.Add(this.CustomerLogin);
            this.Controls.Add(this.ManagerLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ManagerLogin;
        private System.Windows.Forms.Button CustomerLogin;
        private System.Windows.Forms.Button EmployeeLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

