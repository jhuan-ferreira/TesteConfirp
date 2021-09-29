using System;
using System.ComponentModel.DataAnnotations;

namespace TesteConfirp.Migrations
{
    [MetadataType(typeof(EstudantesMetadata))]
    public partial class Estudantes
    {

    }
    public class EstudantesMetadata
    {
        [Required (ErrorMessage ="É obrigatório informar o nome do estudante")]
        [StringLength (30, ErrorMessage ="O nome do estudante deve conter no máximo 30 caracteres")]
        public string Nome { get; set; }

        [Required (ErrorMessage ="É obrigatório informar a data de nascimento do estudante")]
        public DateTime Idade { get; set; }
        [Required(ErrorMessage ="É Obrigatório informar um telefone para contato")]
        [StringLength(11, ErrorMessage ="O telefone deve conter no máximo 11 caracteres")]
        public string Telefone { get; set; }
    }
}