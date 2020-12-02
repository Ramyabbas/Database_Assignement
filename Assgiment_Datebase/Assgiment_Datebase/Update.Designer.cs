namespace Assgiment_Datebase
{
    partial class Update
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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Ingre = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(60, 71);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(198, 26);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(60, 236);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(198, 26);
            this.DescTextBox.TabIndex = 1;
            this.DescTextBox.TextChanged += new System.EventHandler(this.DescTextBox_TextChanged);
            // 
            // IngredientstextBox
            // 
            this.IngredientstextBox.Location = new System.Drawing.Point(310, 236);
            this.IngredientstextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngredientstextBox.Multiline = true;
            this.IngredientstextBox.Name = "IngredientstextBox";
            this.IngredientstextBox.Size = new System.Drawing.Size(278, 127);
            this.IngredientstextBox.TabIndex = 20;
            this.IngredientstextBox.TextChanged += new System.EventHandler(this.IngredientstextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(310, 71);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(198, 28);
            this.CategoryComboBox.TabIndex = 21;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(180, 385);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(78, 43);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Avbry";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(310, 385);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(78, 43);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Spara";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Ingre
            // 
            this.Ingre.AutoSize = true;
            this.Ingre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingre.Location = new System.Drawing.Point(305, 199);
            this.Ingre.Name = "Ingre";
            this.Ingre.Size = new System.Drawing.Size(120, 25);
            this.Ingre.TabIndex = 34;
            this.Ingre.Text = "Ingredienser\r\n";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(55, 199);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(113, 25);
            this.Description.TabIndex = 33;
            this.Description.Text = "Beskrivning";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(305, 33);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 25);
            this.Category.TabIndex = 32;
            this.Category.Text = "Kategori\r\n";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(55, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(49, 25);
            this.Title.TabIndex = 31;
            this.Title.Text = "Titel";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.Ingre);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.IngredientstextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox IngredientstextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Ingre;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Title;
    }
}