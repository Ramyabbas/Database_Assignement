namespace Assgiment_Datebase
{
    partial class NewReceipt
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
            this.IngredientstextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Ingre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngredientstextBox
            // 
            this.IngredientstextBox.Location = new System.Drawing.Point(139, 229);
            this.IngredientstextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngredientstextBox.Multiline = true;
            this.IngredientstextBox.Name = "IngredientstextBox";
            this.IngredientstextBox.Size = new System.Drawing.Size(269, 127);
            this.IngredientstextBox.TabIndex = 21;
            this.IngredientstextBox.TextChanged += new System.EventHandler(this.IngredientstextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(139, 176);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(191, 28);
            this.CategoryComboBox.TabIndex = 22;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(139, 117);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(191, 26);
            this.DescTextBox.TabIndex = 23;
            this.DescTextBox.TextChanged += new System.EventHandler(this.DescTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(139, 53);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(191, 26);
            this.TitleTextBox.TabIndex = 24;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(268, 384);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(78, 43);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Spara";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(72, 384);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(78, 43);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Avbry";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(21, 57);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(49, 25);
            this.Title.TabIndex = 27;
            this.Title.Text = "Titel";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(12, 182);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 25);
            this.Category.TabIndex = 28;
            this.Category.Text = "Kategori\r\n";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(12, 117);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(113, 25);
            this.Description.TabIndex = 29;
            this.Description.Text = "Beskrivning";
            // 
            // Ingre
            // 
            this.Ingre.AutoSize = true;
            this.Ingre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingre.Location = new System.Drawing.Point(12, 243);
            this.Ingre.Name = "Ingre";
            this.Ingre.Size = new System.Drawing.Size(120, 25);
            this.Ingre.TabIndex = 30;
            this.Ingre.Text = "Ingredienser\r\n";
            // 
            // NewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.Ingre);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.IngredientstextBox);
            this.Name = "NewReceipt";
            this.Text = "NewReceipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IngredientstextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Ingre;
    }
}