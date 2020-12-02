using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment_Datebase.Modells
{
    public class Receipt
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Categore Categores { get; set; }
        public int CategoryID { get; set; }
        public string Ingredients { get; set; }
    }
}
