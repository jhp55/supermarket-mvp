using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductsModel> productsList;

        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productsBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);

            loadAllProductsList();

            this.view.Show();
        }

        private void loadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductsId);
            products.Name = view.ProductsName;
            //products.Price = view.ProductsPrice;
            if (!string.IsNullOrEmpty(view.ProductsPrice))
            {
                products.Price = Convert.ToInt32(view.ProductsPrice);
            }
            //products.Stock = view.ProductsStock;
            if (!string.IsNullOrEmpty(view.ProductsStock))
            {
                products.Stock = Convert.ToInt32(view.ProductsStock);
            }
            //products.Id_Categories = view.ProductsIdCategories;
            if (!string.IsNullOrEmpty(view.ProductsIdCategories))
            {
                products.Id_Categories = Convert.ToInt32(view.ProductsIdCategories);
            }


            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Products edited successfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Products added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProductsList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductsId = "0";
            view.ProductsName = "";
            view.ProductsPrice = "";
            view.ProductsStock = "";
            view.ProductsIdCategories = "";
        }

        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                var products = (ProductsModel)productsBindingSource.Current;

                repository.Delete(products.Id);
                view.IsSuccessful = true;
                view.Message = "Products deleted successfully";
                loadAllProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error Ocurred, could not delete products";
            }
        }

        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var products = (ProductsModel)productsBindingSource.Current;

            view.ProductsId = products.Id.ToString();
            view.ProductsName = products.Name;
            view.ProductsPrice = products.Price.ToString();
            view.ProductsStock = products.Stock.ToString(); 
            view.ProductsIdCategories= products.Id_Categories.ToString();

            view.IsEdit = true;
        }

        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productsBindingSource.DataSource = productsList;
        }
    }
}
