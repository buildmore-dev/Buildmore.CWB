using Buildmore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buildmore.CWB
{
    public interface ICWBService
    {
        Task<IList<DataItemForCWB>> Get(string cityId);
    }
}
