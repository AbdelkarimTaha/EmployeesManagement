using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public enum Department
    {
        [Description("HR Department")] HRDepartment = 1,
        [Description("Social Department")] SocialDepartment = 2,
        [Description("Development Department")] DevelopmentDepartment = 3,
        [Description("Network Department")] NetworkDepartment = 4
    }
}