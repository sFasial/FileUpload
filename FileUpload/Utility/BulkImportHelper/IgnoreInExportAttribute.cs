using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Utility.BulkImportHelper
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public class IgnoreInExportAttribute : Attribute
    {
        //Class Members
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public class IsExcelAttribute : Attribute
    {
        //Class Members
    }
}
