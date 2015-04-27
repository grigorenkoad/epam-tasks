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
        private IQueryable<T> ReadFile()
        {
            string text = System.IO.File.ReadAllText(typeof(T).Name + ".txt");
            var jsonObj = JsonConvert.DeserializeObject<List<T>>(text);
            return jsonObj.AsQueryable();
        }

        private void WriteFile(List<T> listObj)
        {
            var text = JsonConvert.SerializeObject(listObj);
            System.IO.File.WriteAllText(typeof(T).Name + ".txt", text);
            
        }

        public IQueryable<T> GetAll()
        {
            return ReadFile();
            
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ReadFile().Where(predicate);
        }

        public T FirstBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ReadFile().Where(predicate).FirstOrDefault();
        }

        public void Add(T obj)
        {
            ReadFile().ToList().Add(obj);
            Save();
        }

        public void Delete(T obj)
        {
            ReadFile().ToList().Remove(obj);
            Save();
        }

        public void SaveOrUpdate(T obj)
        {
            WriteFile(ReadFile().ToList());
        }

        private void Save()
        {
            WriteFile(ReadFile().ToList());
        }
    }
}
