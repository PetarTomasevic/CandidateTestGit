using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestProject.Contracts.Entities
{
    public class Catalog:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CatalogName { get; set; }
        public string CatalogDescription { get; set; }

    }
}
