using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models.BulkImportModels
{
    public class UploadUserErrorDto
    {
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class UploadUserSuccessErrorDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
