using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Newtonsoft.Json;
using System.IO;
using ClassLibrary1.Repository.Contracts;
using ClassLibrary1.Repository;
using ClassLibrary1;



namespace example
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            IRepository<User> repository = new JsonRepository<User>();
            IRepository<Project> repository1 = new JsonRepository<Project>();


            IEnumerable<User> users = repository.GetAll();
            IEnumerable<Project> projects = repository1.GetAll();
            foreach (var item in users)
            {
                Console.Write(item.FirstName + "\n");
            }
            foreach (var item in projects)
            {
                Console.Write(item.Name + "\n");
            }
            User user666 = new User(5, "grigorenkoad", "12345678", "Artiom", "Grigorenko",
                                    DateTimeOffset.Now, Role.User, "ru", TimeSpan.MinValue);
            
            
            foreach (var item in users)
            {
                //if (item.FirstName == "Artiom")
                //    repository.Delete(item);
                //else
                Console.Write(item.FirstName + "\n");
            }
            Console.ReadLine();
        }
    }
}
