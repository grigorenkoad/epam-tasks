using ClassLibrary1.Models;
using ClassLibrary1.Repository.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class JsonRepository<T> : IRepository<T> where T : class

    {
        private List<T> ReadFile()
        {
            string text = System.IO.File.ReadAllText(typeof(T).Name + ".txt");
            var jsonObj = JsonConvert.DeserializeObject<List<T>>(text);
            return jsonObj;
        }

        private void WriteFile(List<T> listObj)
        {
            var text = JsonConvert.SerializeObject(listObj);
            System.IO.File.WriteAllText(typeof(T).Name + ".txt", text);
            
        }

        public IQueryable<T> GetAll()
        {
            return ReadFile().AsQueryable();
            
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ReadFile().AsQueryable().Where(predicate);
        }

        public T FirstBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ReadFile().AsQueryable().Where(predicate).FirstOrDefault();
        }

        public void Add(T obj)
        {
            var temp = ReadFile();
            temp.Add(obj);
            WriteFile(temp);
        }

        public void Delete(T obj)
        {
            var temp = ReadFile();
            temp.Remove(obj);
            WriteFile(temp);
        }

        public void SaveOrUpdate(T obj)
        {
            WriteFile(ReadFile());
        }
    }
}
