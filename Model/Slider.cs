using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Slider
    {

        [Key]
        public int SliderId { get; set; }
        public string SliderName { get; set; }
        public string Slogan { get; set; }
        public string Image { get; set; }
        public DateTime? CreatedDate { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
