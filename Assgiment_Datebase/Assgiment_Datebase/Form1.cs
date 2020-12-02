using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assgiment_Datebase.Modells;

namespace Assgiment_Datebase
{
    public partial class Form1 : Form
    {
        private static string
           ConnectionString = "Data Source = localhost; Initial Catalog = Receipt; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategorytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            var r = new ReceiptRepository();

            string title = TitleTextBox.Text;
            string category = CategoretextBox1.Text;
            var search = r.Select(title, category);
            dataGridView1.DataSource = search.Select(
                n => new
            {
                    Id = n.Id,
                    Titel = n.Title,
            }).ToArray();
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            var repo = new ReceiptRepository();
            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Ta bort receipt", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                repo.Delete(dataGridView1);
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
            

        }

        private void New_Click(object sender, EventArgs e)
        {
            var newReceipt = new NewReceipt();
            newReceipt.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var repository = new ReceiptRepository();
            var item = dataGridView1.SelectedRows[0].Cells["Id"].Value;
            var receips = repository.GetAllByID(Convert.ToInt32(item));

            var show = new ShowForm(receips);
            show.ShowDialog();
        }

        private void CategoretextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var repository = new ReceiptRepository();
            var item = dataGridView1.SelectedRows[0].Cells["Id"].Value;
            var receips = repository.GetAllByID(Convert.ToInt32(item));

            var update = new Update(receips);
            update.Show();
        }
    }
}
