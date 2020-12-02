namespace Assgiment_Datebase
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CategoretextBox1 = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(77, 34);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(130, 26);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(536, 26);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(84, 39);
            this.Search.TabIndex = 2;
            this.Search.Text = "Sök";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(644, 393);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 45);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Ta bort";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(645, 210);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(108, 53);
            this.New.TabIndex = 5;
            this.New.Text = "Lägg till";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 345);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.Click += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategoretextBox1
            // 
            this.CategoretextBox1.Location = new System.Drawing.Point(345, 34);
            this.CategoretextBox1.Name = "CategoretextBox1";
            this.CategoretextBox1.Size = new System.Drawing.Size(166, 26);
            this.CategoretextBox1.TabIndex = 8;
            this.CategoretextBox1.TextChanged += new System.EventHandler(this.CategoretextBox1_TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(644, 307);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(108, 45);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Ändra ";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 100);
            this.label1.TabIndex = 12;
            this.label1.Text = "Välj ett av \r\nalternativen :\r\n\r\n\r\n";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(22, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(49, 25);
            this.Title.TabIndex = 28;
            this.Title.Text = "Titel";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(254, 34);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 25);
            this.Category.TabIndex = 29;
            this.Category.Text = "Kategori\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 457);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CategoretextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CategoretextBox1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Category;
    }
}

