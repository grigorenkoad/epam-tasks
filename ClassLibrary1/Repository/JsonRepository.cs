using DAL.Models;
using DAL.Repository.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL.Repository
{
    public class JsonRepository<T> : IRepository<T> where T : class

    {
        private List<T> ReadFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + typeof(T).Name + ".txt");
            string text = System.IO.File.ReadAllText(path);
            var jsonObj = JsonConvert.DeserializeObject<List<T>>(text);
            return jsonObj;
        }

        private void WriteFile(List<T> listObj)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + typeof(T).Name + ".txt");
            var text = JsonConvert.SerializeObject(listObj);
            System.IO.File.WriteAllText(path, text);
            
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
