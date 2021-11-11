using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [DisplayName("Expense")]
        public string ExpenseName { get; set; }
        public int Amount { get; set; }
    }
}
