using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4381.eim.Lib;
using Kpo4381.eim.Lib.source;
using Castle.Windsor;

namespace Kpo4381.eim.Main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private List<OfficePacks> officePacksList = null;
        private BindingSource bsOfficePacks = new BindingSource();
        private void updateStatus(LoadStatus status)
        {
            SSlblStatus.Text = status.ToString();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                IOCcontainer.container.Resolve<IOfficePacksListLoader>().SetOnStatusChanged(updateStatus); 
                IOfficePacksListLoader loader = IOCcontainer.container.Resolve<IOfficePacksListLoader>();                
                loader.Execute();
                officePacksList = loader.officePacksList;
                bsOfficePacks.DataSource = officePacksList;
                dgvMockOfficePacksListCommand.DataSource = bsOfficePacks;
            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }

        private void mnOpenOfficePacks_Click(object sender, EventArgs e)
        {
            FrmOfficePacks frmOfficePacks = new FrmOfficePacks();
            //Задать сылка на текущий объект в таблицы
            OfficePacks officePacks = (bsOfficePacks.Current as OfficePacks);
            frmOfficePacks.SetOfficePacks(officePacks);
            frmOfficePacks.ShowDialog();
        }

        private void mnLogPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppGlobalSettings.logPath);
        }

        private void mnDataFileName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppGlobalSettings.dataFileName);
        }

        private void nmSaver_Click(object sender, EventArgs e)
        {
            IOfficePacksListSaver saver = IOCcontainer.container.Resolve<IOfficePacksListSaver>();
            saver.SaveFile(officePacksList);
        }
    }
}
