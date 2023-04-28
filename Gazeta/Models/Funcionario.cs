using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gazeta.Models
{
    public class Funcionario
    {
        public long Id { get; set; }
        public long CargoId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataAdmissao { get; set; }
        public bool UtilizaVT { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
