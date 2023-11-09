using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections;
namespace MVCBasico.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVigente { get; set; }
        public Categoria Categoria { get; set; }

        public ArrayList FotoProducto = new ArrayList();

    }
}