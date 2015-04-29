using DAL.Models;
using DAL.Repository;
using DAL.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BusinessService<T> : IBuisnessService<T> where T : class
    {
        IRepository<T> repository = new JsonRepository<T>();

        public List<T> GetAll()
        {
            return (repository.GetAll().ToList());
        }
    }
}
