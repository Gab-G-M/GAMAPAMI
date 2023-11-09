using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections;

namespace MVCBasico.Models
{
    public class Cliente : Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TarjetaDeCredito { get; set; }

        public ArrayList Compras = new ArrayList();

        public ArrayList Carritos = new ArrayList();
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Foto Foto { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Fecha alta")]
        public DateTime FechaAlta { get; set; }

    }
}