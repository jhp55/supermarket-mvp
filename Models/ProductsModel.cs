using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductsModel
    {
        [DisplayName("Products Id")]
        public int Id { get; set; }

        [DisplayName("Products Name")]
        [Required(ErrorMessage = ("Products name is required"))]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Products name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Producst Price")]
        [Required(ErrorMessage = "Products Price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Products Price must be a positive number")]
        public int Price { get; set; }

        [DisplayName("Producst Stock")]
        [Required(ErrorMessage = "Products Stock is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Products Stock must be a positive number")]
        public int Stock { get; set; }

        [DisplayName("Products Id_Categories")]
        public int Id_Categories { get; set; }
    }
}
