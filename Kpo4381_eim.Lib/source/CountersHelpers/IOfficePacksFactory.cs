using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    public interface IOfficePacksFactory
    {
        IOfficePacksListSaver CreateOfficePacksListSaver();
        IOfficePacksListLoader CreateOfficePacksListLoader();
    }
}
