using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBuisnessService<T> where T : class
    {
        public List<T> GetAll();
    }
}
