using System;
using System.Collections.Generic;

namespace BackendApiDemo.Models
{
    public partial class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal? Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal EmployeeId { get; set; }
    }
}
