using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assgiment_Datebase.Modells;

namespace Assgiment_Datebase
{
    public partial class Update : Form
    {
        private Receipt Receip;

        public Update(Receipt receipt)
        {
            InitializeComponent();
            Receip = receipt;
            var r = new ReceiptRepository();

            CategoryComboBox.DataSource = r.GetAllCategorys();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "Id";

            TitleTextBox.Text = receipt.Title;
            DescTextBox.Text = receipt.Description;
            CategoryComboBox.Text = receipt.Categores.Name;
            IngredientstextBox.Text = receipt.Ingredients;

            
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngredientstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var repo = new ReceiptRepository();

            Receip.Title = TitleTextBox.Text;
            Receip.Description = DescTextBox.Text;
            Receip.CategoryID = Convert.ToInt32(CategoryComboBox.SelectedValue);
            Receip.Ingredients = IngredientstextBox.Text;
            

            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Ändra receipt", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                repo.Uppdate(Receip);
                MessageBox.Show("Receipt har ändrats");
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
