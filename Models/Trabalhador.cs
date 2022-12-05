using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryDataTable.Models
{
    public class Trabalhador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }



    }
}