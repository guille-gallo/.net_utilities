using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVCTemplate.EntityFramework.Models
{
    [DisplayColumn("nombre")]
    public class Jugador
    {
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }
        [Required]
        [Display(Name = "Nombre del jugador")]
        public string nombre { get; set; }
        public int posicionNro { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        //Mostrará el nombre del equipo al que pertenece
        public virtual Equipo Equipo { get; set; }
    }
}
