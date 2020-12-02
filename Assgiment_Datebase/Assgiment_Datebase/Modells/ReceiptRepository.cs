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

namespace Assgiment_Datebase.Modells
{
    class ReceiptRepository
    {

        private static string
            ConnectionString = "Data Source = localhost; Initial Catalog = Receipt; Integrated Security = True";

        public IEnumerable<Receipt> Select(string title, string categroe)
        {
            IEnumerable<Receipt> receipts;
            if (string.IsNullOrWhiteSpace(title))
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    receipts = conn.Query<Receipt>(
                        @"select 
                           R.Id, Title, CategoryID, C.Name From Receipt as R
                           JOIN Categore as C on R.CategoryID = C.Id
                           Where C.Name like '%'+@Category+'%'", new { Category = categroe });
                }
            }
            else if (string.IsNullOrWhiteSpace(categroe))
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    receipts = conn.Query<Receipt>(
                        @"Select * from Receipt
                        Where Title Like '%'+@Title+'%'", new { Title = title });
                }
            }
            else
            {
                return GetAllReceips();
            }

            foreach (var r in receipts)
            {
                r.Categores = GetAllCategorys().FirstOrDefault(c => c.Id == r.CategoryID);
            }

            return receipts;
        }


        public void Insert(string title, string description, int categoryid, string ingredients)
        {
            string insert =
               @"Insert into.[Receipt]
               ([Title]
                ,[Description]
                ,[CategoryID]
                ,[Ingredients])
                 VALUES
                (@Title
                ,@Description
                ,@CategoryID
                , @Ingredients)";
                

            var add = new
            {
                Title = title,
                Description = description,
                CategoryID = categoryid,
                Ingredients = ingredients
            };

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                conn.Execute(insert, add);
            }

        }
        public void Delete(System.Windows.Forms.DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string sqlquery;
                var conn = new SqlConnection(ConnectionString);
                conn.Open();
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                sqlquery = "DELETE FROM Receipt WHERE Id = " + rowID;

                try
                {
                    var command = new SqlCommand(sqlquery, conn);
                    command.ExecuteNonQuery();
                    string CmdString = "SELECT Title FROM Receipt where Id = " + rowID;
                    SqlDataAdapter sda = new SqlDataAdapter(CmdString, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    MessageBox.Show("Receipt har tagits bort");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Något gick fel");
                }
            }
        }

        public void Uppdate(Receipt receipt)
        {
            var uppdate = @"Update Receipt
                            Set[Title] =@Title
                            ,[Description] =@Description
                            ,[CategoryID] =@CategoryID
                            ,[Ingredients] =@Ingredients
                            where Id =@Id";

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                conn.Execute(uppdate, receipt);
            }
        }

        public IEnumerable<Receipt> GetAllReceips()
        {

            var Categorys = GetAllCategorys();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var lista = conn.Query<Receipt>(
                    @"Select 
                    Id,
                    Title, 
                    Description,
                    CategoryID,
                    Ingredients 
                    FROM 
                    Receipt").ToList();

                foreach (var r in lista)
                {
                    r.Categores = Categorys.FirstOrDefault(c => c.Id == r.CategoryID);
                }

                return lista;
            }
        }

        public IEnumerable<Categore> GetAllCategorys()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var lista = conn.Query<Categore>(
                    @"select * From Categore"
                    ).ToList();
                return lista;
            }
        }

        public Receipt GetAllByID(int id)
        {
            return GetAllReceips().FirstOrDefault(r => r.Id == id);
        }


    }
}
