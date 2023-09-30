using System.ComponentModel.DataAnnotations;

namespace ShoppingStore_DlloSa.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name= "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener el maximo {1} caracteres.")]
        [Required(ErrorMessage ="El campo {0} es requerido.")]
        public string Name { get; set; }
    }
}
