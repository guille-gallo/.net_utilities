using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AngularMVCTemplate.EntityFramework.Models
{
    
    [DisplayColumn("nombre")]
    public class Equipo
    {
        public int EquipoId { get; set; }
        [Required]
        [Display(Name = "Nombre del equipo")]
        public string nombre { get; set; }
        public string ciudad { get; set; }

        //Mostrará la cantidad de jugadores para ese equipo
        public virtual ICollection<Jugador> Jugadores { get; set; }
    }
    
}
