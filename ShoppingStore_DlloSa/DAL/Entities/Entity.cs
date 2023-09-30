using System.ComponentModel.DataAnnotations;

namespace ShoppingStore_DlloSa.DAL.Entities
{
    public class Entity
    {
        [Required]
        public Guid Id { get; set; } // Pk en todos los proyectos

        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedDate { get; set; }    //El "?" significa que este campo es nulleable

        [Display(Name = "Fecha de modificacion")]
        public DateTime? ModifiedDate { get; set; }
    }
}
