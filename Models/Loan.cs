using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTestWeb.Models
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public int LoanAmount { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool LoanStatus { get; set; }
        public DateTime StartDate { get; set; }
    }
}
