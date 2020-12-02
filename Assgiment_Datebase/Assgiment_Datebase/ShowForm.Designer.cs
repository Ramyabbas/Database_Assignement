namespace Assgiment_Datebase
{
    partial class ShowForm
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
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.IngredientstextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.Ingre = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(144, 36);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(189, 26);
            this.TitleTextBox.TabIndex = 24;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(144, 98);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(189, 26);
            this.DescTextBox.TabIndex = 25;
            this.DescTextBox.TextChanged += new System.EventHandler(this.DescTextBox_TextChanged);
            // 
            // IngredientstextBox
            // 
            this.IngredientstextBox.Location = new System.Drawing.Point(144, 222);
            this.IngredientstextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngredientstextBox.Multiline = true;
            this.IngredientstextBox.Name = "IngredientstextBox";
            this.IngredientstextBox.Size = new System.Drawing.Size(278, 127);
            this.IngredientstextBox.TabIndex = 26;
            this.IngredientstextBox.TextChanged += new System.EventHandler(this.IngredientstextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(144, 397);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 50);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Avbry";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(144, 163);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(189, 26);
            this.CategoryTextBox.TabIndex = 30;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // Ingre
            // 
            this.Ingre.AutoSize = true;
            this.Ingre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingre.Location = new System.Drawing.Point(12, 223);
            this.Ingre.Name = "Ingre";
            this.Ingre.Size = new System.Drawing.Size(120, 25);
            this.Ingre.TabIndex = 34;
            this.Ingre.Text = "Ingredienser\r\n";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(12, 97);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(113, 25);
            this.Description.TabIndex = 33;
            this.Description.Text = "Beskrivning";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(12, 162);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 25);
            this.Category.TabIndex = 32;
            this.Category.Text = "Kategori\r\n";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(21, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(49, 25);
            this.Title.TabIndex = 31;
            this.Title.Text = "Titel";
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 462);
            this.Controls.Add(this.Ingre);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.IngredientstextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "ShowForm";
            this.Text = "ShowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.TextBox DescTextBox;
        public System.Windows.Forms.TextBox IngredientstextBox;
        public System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label Ingre;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Title;
    }
}