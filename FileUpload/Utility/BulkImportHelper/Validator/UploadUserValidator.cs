using FileUpload.Models.Models.User.UserDto;
using FluentValidation;
using System.Collections.Generic;

namespace FileUpload.Utility.BulkImportHelper.Validator
{
    public class UploadUserValidator : AbstractValidator<UploadUserErrorDto>
    {
        public UploadUserValidator(IEnumerable<UploadUserErrorDto> value)
        {
            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage(LanguageContentLoader.ReturnLanguageData("EMP302"));
        }
    }
}
