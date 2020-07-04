using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4381.eim.Lib
{
    public static class OfficePacksMethodProfit
    {

        public static OfficePacks Method (List<OfficePacks> packs)
        {
            if (packs == null)
                throw new Exception("Пусто");
            List<OfficePacks> officePacksList = packs;  

            int ratio = officePacksList[0].price/officePacksList[0].composition;
            OfficePacks lider = officePacksList[0]; 

            foreach (OfficePacks offer in officePacksList)
            {
                if ((offer.price / offer.composition) < ratio)
                {
                    ratio = offer.price / offer.composition;
                    lider = offer;                    
                }               
            }
            if (lider == null)
                throw new Exception("Чет код - говно");
            return lider;
            //MessageBox.Show(lider.vendor);
        }

    }
}
