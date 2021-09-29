using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteConfirp.Models
{
    public partial class  Cursos
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Estudantes> Estudantes { get; set; }
    }
}