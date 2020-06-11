using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    public class OfficePacksListTestSaver : IOfficePacksListSaver
    {
        private List<OfficePacks> _officePacksList = null;

        public void SaveFile(List<OfficePacks> officePacksList)
        {
            _officePacksList = officePacksList;

        }
    }
}
