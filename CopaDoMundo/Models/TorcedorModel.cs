using System.ComponentModel.DataAnnotations;

namespace Copa_do_Mundo.Models
{
    public class TorcedorModel
    {
        [Key]
        public int IDTor { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}
