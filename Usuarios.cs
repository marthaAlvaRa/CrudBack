using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRecibos_VF.Models
{
    [Table("Usuario")]
    public class Usuarios
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string usuario { get; set; }
        public string passwd { get; set; }
    }

}
