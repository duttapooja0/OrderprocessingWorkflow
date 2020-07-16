using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OrderProcessingWorkflow.Models
{
    public class ProductMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public ICollection<PaymentTaskMaster> PaymentTaskMasters { get; set; }

    }
}