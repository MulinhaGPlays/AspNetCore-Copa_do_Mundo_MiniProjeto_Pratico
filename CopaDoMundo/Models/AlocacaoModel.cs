using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Copa_do_Mundo.Models
{
    public class AlocacaoModel
    {
        [Key]
        public int IDAlocacao { get; set; }

        [ForeignKey("area")]
        public int IDArea { get; set; }

        [ForeignKey("torcedor")]
        public int IDTor { get; set; }

        public TorcedorModel torcedor { get; set; }
        public AreaModel area { get; set; }
    }
}
