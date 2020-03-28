using Employees.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "FirstName", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "FirstNameReqired")]
        [MaxLength(255,ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaxLength")]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "LastNameReqired")]
        [MaxLength(255, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaxLength")]
        public string LastName { get; set; }

        [Display(Name = "FullName", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "FullNameReqired")]
        [MaxLength(255, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaxLength")]
        public string FullName { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "EmailReqired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "CorrectEmail")]
        public string Email { get; set; }

        [Display(Name = "Password", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "PasswordReqired")]
        [MinLength(8,ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "CorrectPassword")]
        public string Password { get; set; }

        [Display(Name = "City", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "AddressReqired")]
        public City City { get; set; }

        [Display(Name = "Salary", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "SalaryReqired")]
        public int Salary { get; set; }

        [Display(Name = "JobTitle", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "JobTitleReqired")]
        public JobTitle JobTitle { get; set; }

        [Display(Name = "Branch", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "BranchReqired")]
        public Branch Branch { get; set; }

        [Display(Name = "Department", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "DepartmentReqired")]
        public Department Department { get; set; }

        [Display(Name = "BirthDate", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "BirthdateReqired")]
        public DateTime BirthDate { get; set; }
    }
}