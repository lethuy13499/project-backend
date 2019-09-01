using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual Sliders Category { get; set; }
    }
}
