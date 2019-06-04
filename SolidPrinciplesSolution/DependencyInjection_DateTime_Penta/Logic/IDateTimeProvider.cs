using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_DateTime_Begin.Logic
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTime();
    }
}
