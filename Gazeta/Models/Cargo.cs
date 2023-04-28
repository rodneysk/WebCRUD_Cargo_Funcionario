using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gazeta.Models
{
    public class Cargo
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAlteracao { get; set; } //DateTime? indica que esses valores podem ser nulos no BD
        public DateTime? DataExclusao { get; set; }
    }
}
