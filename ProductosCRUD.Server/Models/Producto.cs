using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductosCRUD.Server.Models
{
    public class Producto
    {
        [Key]
        public int idActividad { get; set; }

        [MaxLength(256, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Display(Name = "Nombre de la Actividad...............")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string nombreActividad { get; set; } = null!;

        [Column(TypeName = "decimal(4,2)")]
        [Display(Name = "Conocimiento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal conocimientoActividad { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        [Display(Name = "Relacionamiento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal relacionamientoActividad { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        [Display(Name = "Condicion Trabajo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal condicionTrabajoActividad { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        [Display(Name = "Impacto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal impactoActividad { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        [Display(Name = "Responsabilidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal responsabilidadActividad { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        [Display(Name = "Ponderacion")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal ponderacionActividad { get; set; }

        [MaxLength(32, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Display(Name = "Ponderacion Nivel")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string ponderacionNivelActividad { get; set; } = null!;

        [MaxLength(32, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Display(Name = "Grupo Ocupacional")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string grupoOcupacionalActividad { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [Display(Name = "Observacion Actividad")]
        [MaxLength(256, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? observacionActividad { get; set; }


    }
}
