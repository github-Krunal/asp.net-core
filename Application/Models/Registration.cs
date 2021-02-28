using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    [Table("Registration")]
    public class Registration
    {
        [Key]
        public Guid RecordID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
