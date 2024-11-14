using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conecta.Models
{
    [Table("role")]
    public class Role
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(20)]
        [Required]
        public required string Name { get; set; }

        [Column("creation_date")]
        [DataType(DataType.DateTime)]
        public DateTime? CreationDate { get; set; }

        [Column("update_date")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }


    }
}