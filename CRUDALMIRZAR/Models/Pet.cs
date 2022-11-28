using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDALMIRZAR.Models
{
    public class Pet
    {
        [Key]
        [Column(TypeName ="int")]
        public int PetId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Nome")]

        public string Nome { get; set; }

        [Column(TypeName ="int")]
        [DisplayName("Idade")]

        public int Idade { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Cor")]

        public string Cor { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Genero")]

        public string Genero { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Dono")]

        public string Dono { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Endereco")]

        public string Endereco { get; set; }

    }
}
