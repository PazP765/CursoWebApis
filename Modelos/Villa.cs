using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos
{
    public class Villa
    {
        //contiene todas las variables, con base a esto se crea la tabla en la BD, las clases en el directorio dto..
        //..son para cada uno de los modelos ejem: crear no ocupa Id ya que es auto incremental por eso se crea una clase personalizada
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Detalle { get; set; }
        
        [Required]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public double MetrosCuadrados { get; set; }

        public string ImageUrl { get; set; }

        public string Amenidad { get; set; }

        public DateTime  FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }
    }
}
