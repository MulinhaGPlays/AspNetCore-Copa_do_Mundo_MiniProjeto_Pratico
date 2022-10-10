using System.ComponentModel.DataAnnotations;

namespace Copa_do_Mundo.Models
{
    public class AreaModel
    {
        [Key]
        public int IDArea { get; set; }

        public string ValorIngresso { get; set; }
    }
}
