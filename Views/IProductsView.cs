using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductsView
    {
        string ProductsId { get; set; }
        string ProductsName { get; set; }
        int ProductsPrice { get; set; }
        int ProductsStock { get; set; }
        string ProductsIdCategories { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductsListBildingSource(BindingSource productsList);
        void Show();
    }
}
}
