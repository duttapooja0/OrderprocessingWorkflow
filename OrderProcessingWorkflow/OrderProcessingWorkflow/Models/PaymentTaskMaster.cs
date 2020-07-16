using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OrderProcessingWorkflow.Models
{
    public class PaymentTaskMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TaskID { get; set; }
        public string TaskName { get; set; }
        public Guid? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public ProductMaster ProductMaster { get; set; }
    }
}