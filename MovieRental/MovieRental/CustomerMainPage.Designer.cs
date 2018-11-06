namespace MovieRental
{
    partial class CustomerMainPage
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
                try
                {
                    components.Dispose();
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("An error occured when disposing comments", e);
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainPage));
            this.Title = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.QueueGrid = new System.Windows.Forms.DataGridView();
            this.ActiveOrderGrid = new System.Windows.Forms.DataGridView();
            this.DatabaseTitle = new System.Windows.Forms.Label();
            this.QueueTitle = new System.Windows.Forms.Label();
            this.RentedTitle = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.MovieTitleTextbox = new System.Windows.Forms.TextBox();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.MovieGenre = new System.Windows.Forms.Label();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.CustomerIDText = new System.Windows.Forms.Label();
            this.AddtoQueue = new System.Windows.Forms.Button();
            this.DeleteQueue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllOrdersGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BestSellerGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.DataGridView();
            this.Actor = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ActorText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(31, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(51, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Customer";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1045, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DatabaseGrid
            // 
            this.DatabaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseGrid.Location = new System.Drawing.Point(31, 175);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.Size = new System.Drawing.Size(758, 201);
            this.DatabaseGrid.TabIndex = 2;
            // 
            // QueueGrid
            // 
            this.QueueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueGrid.Location = new System.Drawing.Point(31, 667);
            this.QueueGrid.Name = "QueueGrid";
            this.QueueGrid.Size = new System.Drawing.Size(220, 201);
            this.QueueGrid.TabIndex = 3;
            // 
            // ActiveOrderGrid
            // 
            this.ActiveOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveOrderGrid.Location = new System.Drawing.Point(257, 667);
            this.ActiveOrderGrid.Name = "ActiveOrderGrid";
            this.ActiveOrderGrid.Size = new System.Drawing.Size(247, 201);
            this.ActiveOrderGrid.TabIndex = 4;
            // 
            // DatabaseTitle
            // 
            this.DatabaseTitle.AutoSize = true;
            this.DatabaseTitle.Location = new System.Drawing.Point(31, 150);
            this.DatabaseTitle.Name = "DatabaseTitle";
            this.DatabaseTitle.Size = new System.Drawing.Size(53, 13);
            this.DatabaseTitle.TabIndex = 5;
            this.DatabaseTitle.Text = "Database";
            // 
            // QueueTitle
            // 
            this.QueueTitle.AutoSize = true;
            this.QueueTitle.Location = new System.Drawing.Point(28, 641);
            this.QueueTitle.Name = "QueueTitle";
            this.QueueTitle.Size = new System.Drawing.Size(39, 13);
            this.QueueTitle.TabIndex = 6;
            this.QueueTitle.Text = "Queue";
            // 
            // RentedTitle
            // 
            this.RentedTitle.AutoSize = true;
            this.RentedTitle.Location = new System.Drawing.Point(254, 641);
            this.RentedTitle.Name = "RentedTitle";
            this.RentedTitle.Size = new System.Drawing.Size(71, 13);
            this.RentedTitle.TabIndex = 7;
            this.RentedTitle.Text = "Active Orders";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(257, 875);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // MovieTitleTextbox
            // 
            this.MovieTitleTextbox.Location = new System.Drawing.Point(108, 389);
            this.MovieTitleTextbox.Name = "MovieTitleTextbox";
            this.MovieTitleTextbox.Size = new System.Drawing.Size(335, 20);
            this.MovieTitleTextbox.TabIndex = 9;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Location = new System.Drawing.Point(31, 392);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(59, 13);
            this.MovieTitle.TabIndex = 10;
            this.MovieTitle.Text = "Movie Title";
            // 
            // MovieGenre
            // 
            this.MovieGenre.AutoSize = true;
            this.MovieGenre.Location = new System.Drawing.Point(31, 418);
            this.MovieGenre.Name = "MovieGenre";
            this.MovieGenre.Size = new System.Drawing.Size(36, 13);
            this.MovieGenre.TabIndex = 11;
            this.MovieGenre.Text = "Genre";
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(108, 415);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(335, 20);
            this.GenreTextbox.TabIndex = 12;
            // 
            // CustomerIDText
            // 
            this.CustomerIDText.AutoSize = true;
            this.CustomerIDText.Location = new System.Drawing.Point(88, 50);
            this.CustomerIDText.Name = "CustomerIDText";
            this.CustomerIDText.Size = new System.Drawing.Size(18, 13);
            this.CustomerIDText.TabIndex = 15;
            this.CustomerIDText.Text = "ID";
            // 
            // AddtoQueue
            // 
            this.AddtoQueue.Location = new System.Drawing.Point(683, 386);
            this.AddtoQueue.Name = "AddtoQueue";
            this.AddtoQueue.Size = new System.Drawing.Size(106, 23);
            this.AddtoQueue.TabIndex = 16;
            this.AddtoQueue.Text = "Add to Queue";
            this.AddtoQueue.UseVisualStyleBackColor = true;
            this.AddtoQueue.Click += new System.EventHandler(this.AddtoQueue_Click);
            // 
            // DeleteQueue
            // 
            this.DeleteQueue.Location = new System.Drawing.Point(31, 875);
            this.DeleteQueue.Name = "DeleteQueue";
            this.DeleteQueue.Size = new System.Drawing.Size(75, 23);
            this.DeleteQueue.TabIndex = 17;
            this.DeleteQueue.Text = "Delete";
            this.DeleteQueue.UseVisualStyleBackColor = true;
            this.DeleteQueue.Click += new System.EventHandler(this.DeleteQueue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search by Title";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Search by Genre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "All Orders";
            // 
            // AllOrdersGrid
            // 
            this.AllOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllOrdersGrid.Location = new System.Drawing.Point(509, 667);
            this.AllOrdersGrid.Name = "AllOrdersGrid";
            this.AllOrdersGrid.Size = new System.Drawing.Size(272, 201);
            this.AllOrdersGrid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Best Sellers";
            // 
            // BestSellerGrid
            // 
            this.BestSellerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BestSellerGrid.Location = new System.Drawing.Point(809, 175);
            this.BestSellerGrid.Name = "BestSellerGrid";
            this.BestSellerGrid.Size = new System.Drawing.Size(283, 448);
            this.BestSellerGrid.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 24);
            this.button3.TabIndex = 24;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.help);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(792, 667);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(292, 201);
            this.dataGridView1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 641);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Movie Suggestions";
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerInfo.Location = new System.Drawing.Point(31, 66);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(1060, 51);
            this.CustomerInfo.TabIndex = 27;
            // 
            // Actor
            // 
            this.Actor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Actor.Location = new System.Drawing.Point(34, 503);
            this.Actor.Name = "Actor";
            this.Actor.Size = new System.Drawing.Size(755, 120);
            this.Actor.TabIndex = 28;
            this.Actor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Actor_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Actor";
            // 
            // ActorText
            // 
            this.ActorText.Location = new System.Drawing.Point(108, 446);
            this.ActorText.Name = "ActorText";
            this.ActorText.Size = new System.Drawing.Size(335, 20);
            this.ActorText.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Search by Actor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Actor Database";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 80);
            this.button5.TabIndex = 33;
            this.button5.Text = "Clear All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1132, 915);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ActorText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Actor);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BestSellerGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllOrdersGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteQueue);
            this.Controls.Add(this.AddtoQueue);
            this.Controls.Add(this.CustomerIDText);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.MovieGenre);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MovieTitleTextbox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RentedTitle);
            this.Controls.Add(this.QueueTitle);
            this.Controls.Add(this.DatabaseTitle);
            this.Controls.Add(this.ActiveOrderGrid);
            this.Controls.Add(this.QueueGrid);
            this.Controls.Add(this.DatabaseGrid);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerMainPage";
            this.Text = "Customer Main Page";
            this.Load += new System.EventHandler(this.CustomerMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView DatabaseGrid;
        private System.Windows.Forms.DataGridView QueueGrid;
        private System.Windows.Forms.DataGridView ActiveOrderGrid;
        private System.Windows.Forms.Label DatabaseTitle;
        private System.Windows.Forms.Label QueueTitle;
        private System.Windows.Forms.Label RentedTitle;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox MovieTitleTextbox;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label MovieGenre;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.Label CustomerIDText;
        private System.Windows.Forms.Button AddtoQueue;
        private System.Windows.Forms.Button DeleteQueue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllOrdersGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BestSellerGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CustomerInfo;
        private System.Windows.Forms.DataGridView Actor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ActorText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
    }
}