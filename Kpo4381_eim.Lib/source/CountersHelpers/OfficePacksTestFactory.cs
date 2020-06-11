using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    public class OfficePacksTestFactory : IOfficePacksFactory
    {
        public IOfficePacksListLoader CreateOfficePacksListLoader()
        {
            return new OfficePacksListSplitFileLoader();
        }

        public IOfficePacksListSaver CreateOfficePacksListSaver()
        {
            return new OfficePacksListSplitFileSaver();

        }
    }
}
