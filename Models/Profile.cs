using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Conecta.Models
{
    [Table("profiles")]
    public class Profile
    {
        [Key, ForeignKey(nameof(User))]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("image_url")]
        public string? ImageUrl { get; set; }

        [Column("biography")]
        public string? Biography { get; set; }

        [Column("other_details")]
        public string? OtherDetails { get; set; }

        [JsonIgnore]
        public User? User { get; set; }
    }
}