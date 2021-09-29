
using System.ComponentModel.DataAnnotations;


namespace TesteConfirp.Models
{
    [MetadataType(typeof(CursosMetadata))]
    public partial class Cursos
    {

    }
    public class CursosMetadata
    {
        [Required (ErrorMessage ="É Obrigatório informar a descrição do curso")]
        [StringLength(30, ErrorMessage ="A descrição do curso deve conter no máximo 30 caracteres")]
        public string Descricao { get; set; }
    }
}