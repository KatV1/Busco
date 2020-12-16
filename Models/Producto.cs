using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Busco.Models
{
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese la URL de la imagen")]
        // [RegularExpression(@"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$", ErrorMessage = "No es una URL válida")]
        [Display(Name="URL de imagen")]
        [Column("URL")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese una descripción")]
        [Display(Name="Descripción")]
        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el precio del producto")]
        [Display(Name="Precio")]
        [Column("Precio")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese su número de teléfono")]
        [StringLength(9)]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "No es un número de teléfono válido")]
        [Display(Name="Teléfono de contacto")]
        [Column("Telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el lugar de compra")]
        [Display(Name="Lugar de compra")]
        [Column("Lugar")]
        public string Lugar { get; set; }

        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}