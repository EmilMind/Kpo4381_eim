using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4381.eim.Lib.source
{
    public partial class FrmOfficePacks : Form
    {
        public FrmOfficePacks()
        {
            InitializeComponent();

            _officePacks = null;
        }

        private OfficePacks _officePacks = null;
        public OfficePacks officePacks
        {
            get { return _officePacks; }
        }
        public void SetOfficePacks(OfficePacks officePacks)
        {
            //инициализировать скрытое поля класса
            this._officePacks = officePacks;
            //присвоить значение данных сотрудника элементам редактирования
          //  this.txtboxFamily.Text = _employee.family;
        }
    }
}
