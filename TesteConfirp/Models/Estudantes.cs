using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TesteConfirp.Models
{
    public partial class Estudantes
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento  { get; set; }
        public string Telefone { get; set; }
        public int CursoId { get; set; }

        [ForeignKey("CursoId")]
        public virtual Cursos Cursos { get; set; }
    }
}