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
    public partial class NewReceipt : Form
    {
        public NewReceipt()
        {
            InitializeComponent();
            var repo = new ReceiptRepository();

            CategoryComboBox.DataSource = repo.GetAllCategorys();
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "Id";
        }

        private void IngredientstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var repository = new ReceiptRepository();
            repository.Insert(TitleTextBox.Text, DescTextBox.Text, Convert.ToInt32(CategoryComboBox.SelectedValue), IngredientstextBox.Text);
            MessageBox.Show("Receipt har sparat");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DescTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
