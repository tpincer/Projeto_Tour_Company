using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourCompany.Models
{
    public class PontosTuristicos
    {
        [Display(Name = "Id")]
        [Column("Id")]

        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]

        public string Name { get; set; }

        [Display(Name = "Descrição")]
        [Column("Descricao")]

        public string Description { get; set; }

        [Display(Name = "Referência")]
        [Column("Referencia")]

        public string Reference { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]

        public string City { get; set; }

          public void GenerateNewGuid()
        {
            Id = Guid.NewGuid();
        }
    }
}
