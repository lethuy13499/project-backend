using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public double UnitCost { get; set; }
        public int ItemCount { get; set; }
        public double Subtotal { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
