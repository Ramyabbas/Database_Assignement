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
    public partial class ShowForm : Form
    {
        public ShowForm(Receipt receipt)
        {
            InitializeComponent();
            TitleTextBox.Text = receipt.Title;
            DescTextBox.Text = receipt.Description;
            CategoryTextBox.Text = receipt.Categores.Name;
            IngredientstextBox.Text = receipt.Ingredients;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void IngredientstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
