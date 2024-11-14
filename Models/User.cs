using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conecta.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(50)]
        [Required]
        public required string Name { get; set; }

        [Column("email")]
        [Required]
        public required string Email { get; set; }

        [Column("password")]
        [Required]
        public required string Password { get; set; }

        [Column("role_id")]
        public required int RoleId { get; set; }

        [Column("creation_date")]
        [DataType(DataType.DateTime)]
        public DateTime? CreationDate { get; set; }

        [Column("update_date")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }


        // Connection with another tables ---------------------------

        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; }

        public Profile? Profile { get; set; }



    }
}