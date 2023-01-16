using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]

    public class Aula
    {
        public int AulaID { get; set; }
        [Required]

        public int Capacidad { get; set; }
        [Column(TypeName = "char")] //Indico tipo de datos en SQL SERVER
        [StringLength(1)] //Asigno el long de la cadena
        [Required] // No acepta nulos
        public string Codigo { get; set; }
    }
}
