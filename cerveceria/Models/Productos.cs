using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cerveceria.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string producto { get; set; }

        [Required]
        public string descripcion { get; set; }

        public int idCategoria { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public Decimal precio { get; set; }


        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public Decimal precioxmayor { get; set; }
    }
}
