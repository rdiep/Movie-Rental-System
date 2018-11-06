namespace MovieRental
{
    partial class ActorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.GenderTextbox = new System.Windows.Forms.TextBox();
            this.AgeTextbox = new System.Windows.Forms.TextBox();
            this.actorEditButton = new System.Windows.Forms.Button();
            this.actorAddButton = new System.Windows.Forms.Button();
            this.actorSearchButton = new System.Windows.Forms.Button();
            this.actor_back_button = new System.Windows.Forms.Button();
            this.actorInfoGrid = new System.Windows.Forms.DataGridView();
            this.actorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new MovieRental.DatabaseDataSet1();
            this.actorDataTableAdapter = new MovieRental.DatabaseDataSet1TableAdapters.ActorDataTableAdapter();
            this.actInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actInTableAdapter = new MovieRental.DatabaseDataSet1TableAdapters.ActInTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Actin = new System.Windows.Forms.DataGridView();
            this.Movies = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Actorinmovies = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.actorInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actorinmovies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender (M/F)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age (Deceased=0)";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(121, 24);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(143, 20);
            this.NameTextbox.TabIndex = 3;
            // 
            // GenderTextbox
            // 
            this.GenderTextbox.Location = new System.Drawing.Point(121, 55);
            this.GenderTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.GenderTextbox.Name = "GenderTextbox";
            this.GenderTextbox.Size = new System.Drawing.Size(76, 20);
            this.GenderTextbox.TabIndex = 4;
            // 
            // AgeTextbox
            // 
            this.AgeTextbox.Location = new System.Drawing.Point(121, 81);
            this.AgeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.AgeTextbox.Name = "AgeTextbox";
            this.AgeTextbox.Size = new System.Drawing.Size(76, 20);
            this.AgeTextbox.TabIndex = 5;
            // 
            // actorEditButton
            // 
            this.actorEditButton.Location = new System.Drawing.Point(12, 115);
            this.actorEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.actorEditButton.Name = "actorEditButton";
            this.actorEditButton.Size = new System.Drawing.Size(56, 19);
            this.actorEditButton.TabIndex = 6;
            this.actorEditButton.Text = "Edit";
            this.actorEditButton.UseVisualStyleBackColor = true;
            this.actorEditButton.Click += new System.EventHandler(this.actorEditButton_Click);
            // 
            // actorAddButton
            // 
            this.actorAddButton.Location = new System.Drawing.Point(87, 115);
            this.actorAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.actorAddButton.Name = "actorAddButton";
            this.actorAddButton.Size = new System.Drawing.Size(56, 19);
            this.actorAddButton.TabIndex = 7;
            this.actorAddButton.Text = "Add";
            this.actorAddButton.UseVisualStyleBackColor = true;
            this.actorAddButton.Click += new System.EventHandler(this.actorAddButton_Click);
            // 
            // actorSearchButton
            // 
            this.actorSearchButton.Location = new System.Drawing.Point(164, 115);
            this.actorSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.actorSearchButton.Name = "actorSearchButton";
            this.actorSearchButton.Size = new System.Drawing.Size(56, 19);
            this.actorSearchButton.TabIndex = 8;
            this.actorSearchButton.Text = "Search";
            this.actorSearchButton.UseVisualStyleBackColor = true;
            this.actorSearchButton.Click += new System.EventHandler(this.actorSearchButton_Click);
            // 
            // actor_back_button
            // 
            this.actor_back_button.Location = new System.Drawing.Point(813, 11);
            this.actor_back_button.Margin = new System.Windows.Forms.Padding(2);
            this.actor_back_button.Name = "actor_back_button";
            this.actor_back_button.Size = new System.Drawing.Size(71, 19);
            this.actor_back_button.TabIndex = 9;
            this.actor_back_button.Text = "Back";
            this.actor_back_button.UseVisualStyleBackColor = true;
            this.actor_back_button.Click += new System.EventHandler(this.actor_back_button_Click);
            // 
            // actorInfoGrid
            // 
            this.actorInfoGrid.AllowUserToAddRows = false;
            this.actorInfoGrid.AllowUserToDeleteRows = false;
            this.actorInfoGrid.AutoGenerateColumns = false;
            this.actorInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorIDDataGridViewTextBoxColumn,
            this.actorNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.actorInfoGrid.DataSource = this.actorDataBindingSource;
            this.actorInfoGrid.Location = new System.Drawing.Point(12, 184);
            this.actorInfoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.actorInfoGrid.Name = "actorInfoGrid";
            this.actorInfoGrid.ReadOnly = true;
            this.actorInfoGrid.RowTemplate.Height = 24;
            this.actorInfoGrid.Size = new System.Drawing.Size(438, 241);
            this.actorInfoGrid.TabIndex = 10;
            this.actorInfoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.actorInfoGrid_CellClick);
            // 
            // actorIDDataGridViewTextBoxColumn
            // 
            this.actorIDDataGridViewTextBoxColumn.DataPropertyName = "ActorID";
            this.actorIDDataGridViewTextBoxColumn.HeaderText = "ActorID";
            this.actorIDDataGridViewTextBoxColumn.Name = "actorIDDataGridViewTextBoxColumn";
            this.actorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorNameDataGridViewTextBoxColumn
            // 
            this.actorNameDataGridViewTextBoxColumn.DataPropertyName = "ActorName";
            this.actorNameDataGridViewTextBoxColumn.HeaderText = "ActorName";
            this.actorNameDataGridViewTextBoxColumn.Name = "actorNameDataGridViewTextBoxColumn";
            this.actorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorDataBindingSource
            // 
            this.actorDataBindingSource.DataMember = "ActorData";
            this.actorDataBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actorDataTableAdapter
            // 
            this.actorDataTableAdapter.ClearBeforeFill = true;
            // 
            // actInBindingSource
            // 
            this.actInBindingSource.DataMember = "ActIn";
            this.actInBindingSource.DataSource = this.databaseDataSet1;
            // 
            // actInTableAdapter
            // 
            this.actInTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Actor Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Actor\'s Movies";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(241, 115);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 19);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Actin
            // 
            this.Actin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Actin.Location = new System.Drawing.Point(484, 184);
            this.Actin.Name = "Actin";
            this.Actin.Size = new System.Drawing.Size(309, 240);
            this.Actin.TabIndex = 15;
            // 
            // Movies
            // 
            this.Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movies.Location = new System.Drawing.Point(15, 468);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(435, 206);
            this.Movies.TabIndex = 16;
            this.Movies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Movies_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Movies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Genre";
            // 
            // MovieTitle
            // 
            this.MovieTitle.Location = new System.Drawing.Point(427, 21);
            this.MovieTitle.Margin = new System.Windows.Forms.Padding(2);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(143, 20);
            this.MovieTitle.TabIndex = 20;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(427, 49);
            this.Genre.Margin = new System.Windows.Forms.Padding(2);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(143, 20);
            this.Genre.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Movie\'s Actors";
            // 
            // Actorinmovies
            // 
            this.Actorinmovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Actorinmovies.Location = new System.Drawing.Point(484, 465);
            this.Actorinmovies.Name = "Actorinmovies";
            this.Actorinmovies.Size = new System.Drawing.Size(309, 209);
            this.Actorinmovies.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 44);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add to Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 44);
            this.button3.TabIndex = 26;
            this.button3.Text = "Remove From Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 109);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 44);
            this.button4.TabIndex = 27;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ActorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(895, 686);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Actorinmovies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.Actin);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.actorInfoGrid);
            this.Controls.Add(this.actor_back_button);
            this.Controls.Add(this.actorSearchButton);
            this.Controls.Add(this.actorAddButton);
            this.Controls.Add(this.actorEditButton);
            this.Controls.Add(this.AgeTextbox);
            this.Controls.Add(this.GenderTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActorPage";
            this.Text = "ActorPage";
            this.Load += new System.EventHandler(this.ActorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actorinmovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox GenderTextbox;
        private System.Windows.Forms.TextBox AgeTextbox;
        private System.Windows.Forms.Button actorEditButton;
        private System.Windows.Forms.Button actorAddButton;
        private System.Windows.Forms.Button actorSearchButton;
        private System.Windows.Forms.Button actor_back_button;
        private System.Windows.Forms.DataGridView actorInfoGrid;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource actorDataBindingSource;
        private DatabaseDataSet1TableAdapters.ActorDataTableAdapter actorDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actInBindingSource;
        private DatabaseDataSet1TableAdapters.ActInTableAdapter actInTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView Actin;
        private System.Windows.Forms.DataGridView Movies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MovieTitle;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Actorinmovies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}