using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public enum Branch
    {
        [Description("Egypt Branch")] EgyptBranch = 1,
        [Description("USA Branch")] USABranch = 2,
        [Description("UK Branch")] UKBranch = 3,
    }
}