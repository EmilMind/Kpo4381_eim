using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    public class MockOfficePacksListCommand
    {
        public MockOfficePacksListCommand()
        {
            this._officepacksList = new List<OfficePacks>();

        }
        private readonly string _dataFileName = "";
        private List<OfficePacks> _officepacksList = null;

        public List<OfficePacks> officepacksList
        {
            get { return _officepacksList; }
        }
        public void Execute()
        {
           // throw new NotImplementedException();
           // throw new Exception("Неправильные входные параметры");

            //Фигурная скобка для ограничения области видимости переменной employee
            {
                OfficePacks officepacks = new OfficePacks()
                //данная констуркция позволяет инициализировать объект при его создании
                {
                    name = "Office",
                    vendor = "Microsoft",
                    composition = 4,
                    price = 870
                };
                _officepacksList.Add(officepacks);
            }

            {
                OfficePacks officepacks = new OfficePacks()
                {
                    name = "SmartSuite",
                    vendor = "Lotus",
                    composition = 5,
                    price = 1020
                };
                _officepacksList.Add(officepacks);

            }
            {
                OfficePacks officepacks = new OfficePacks()
                {
                    name = "StarOffice",
                    vendor = "Sun",
                    composition =4,
                    price = 9
                };
                _officepacksList.Add(officepacks);
            }
        }
    }
}
