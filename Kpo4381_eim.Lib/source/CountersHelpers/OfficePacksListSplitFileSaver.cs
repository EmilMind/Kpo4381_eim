using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    internal class OfficePacksListSplitFileSaver : IOfficePacksListSaver
    {
        private List<OfficePacks> _officePacksList = null;
        private string _saveFileName = "";

        public void SaveFile(List<OfficePacks> officePacksList)
        {
            _officePacksList = officePacksList;
            _saveFileName = AppGlobalSettings.saveFileName;
            List<string> newinfo = new List<string>();
            foreach (OfficePacks i in _officePacksList)
            {
                string officePacks = i.name + "|" + i.vendor + "|" + i.composition + "|" + i.price;
                newinfo.Add(officePacks);

            }
            File.AppendAllLines(_saveFileName,newinfo);

        }
    }
}
