using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Materia")]
    internal class Materia
    {
        public int MateriaId { get; set; }

        [Column(TypeName = "varchar")] //Indico tipo de datos en SQL SERVER
        [StringLength(50)] //Asigno el long de la cadena
        [Required] // No acepta nulos
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")] //Indico tipo de datos en SQL SERVER
        [StringLength(50)] //Asigno el long de la cadena
        [Required] // No acepta nulos
        public string Programa { get; set; }

    }
}
