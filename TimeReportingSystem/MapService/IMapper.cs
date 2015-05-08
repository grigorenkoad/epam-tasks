using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeReportingSystem.MapService
{
    public interface IMapper
    {
        object Map(object source, Type sourceTipe, Type destinationType);
    }
}
