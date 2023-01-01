using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models.Models.User
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? RoleId { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
