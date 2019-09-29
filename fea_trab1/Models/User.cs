using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fea_trab1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Role { get; set; }
        [StringLength(150)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
