using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [DisplayName("Customers Id")]
        public int Id { get; set; }

        [DisplayName("Customers Document")]
        [Required(ErrorMessage = ("Customers Document is required"))]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customers Document must be between 3 and 100 characters")]
        public int Document { get; set; }

        [DisplayName("Customers First_Name")]
        [Required(ErrorMessage = ("Customers First_Name is required"))]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customers First_Name must be between 3 and 100 characters")]
        public string FirstName { get; set; }

        [DisplayName("Customers Last_Name")]
        [Required(ErrorMessage = ("Customers Last_Name is required"))]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customers Last_Name must be between 3 and 100 characters")]
        public string LastName { get; set; }

        [DisplayName("Customers Address")]
        [Required(ErrorMessage = ("Customers Address is required"))]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Customers Address must be between 3 and 80 characters")]
        public string Address { get; set; }

        [DisplayName("Customers Birthday")]
        [Required(ErrorMessage = ("Customers Birthday is required"))]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers Birthday must be between 3 and 50 characters")]
        public string Birthday { get; set; }

        [DisplayName("Customers Phone_Number")]
        [Required(ErrorMessage = ("Customers Phone_Number is required"))]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers Phone_Number must be between 3 and 50 characters")]
        public string PhoneNumber { get; set; }

        [DisplayName("Customers Email")]
        [Required(ErrorMessage = ("Customers Email is required"))]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customers Email must be between 3 and 100 characters")]
        public string Email { get; set; }


    }
}
