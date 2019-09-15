using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime? DateOfOrder { get; set; }
        public string Adress { get; set; }
        public string PaymentStatus { get; set; }
        public string createBy { get; set; }
        public bool Status { get; set; }
      
       // public virtual ICollection<User> User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
