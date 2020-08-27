using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa03.Models
{
    public class Fcclasse
    {
        [Key]
        public int id_classe { get; set; }
        public string nm_classe { get; set; }
    }

}