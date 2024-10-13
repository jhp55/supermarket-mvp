using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICustomersRepository
    {
        void Add(CustomersModel customersModel);
        void Edit(CustomersModel customersModel);
        void Delete(int id);
        IEnumerable<CustomersModel> GetAll();
        IEnumerable<CustomersModel> GetByValue(string value);
    }
}
