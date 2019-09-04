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
        public double UnitCost { get; set; }
        public int ItemCount { get; set; }
        public double Subtotal { get; set; }
        [ForeignKey("Product")]
        [Column(Order = 0), Key]
        public int ProductId { get; set; }
        [ForeignKey("Orders")]
        [Column(Order = 1), Key]
        public int OrderId { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
