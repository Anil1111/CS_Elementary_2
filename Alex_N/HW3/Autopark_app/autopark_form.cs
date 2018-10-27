using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autopark_app
{
    public partial class autopark_form : Form
    {
        //
        //ОБЪЯВА ЛИСТОВ-ХРАНИЛИЩ
        //
        private List<Driver> driverList;
        private List<Car> carList;
        private List<Deal> dealsList;
        private List<RepairBlank> repairBlanksList;
        private int numberOfRBlanks;

        public List<string> driverBase;
        public List<string> carsBase;

        public autopark_form()
        {
            InitializeComponent();

            numberOfRBlanks = 0;
            driverList = new List<Driver>();
            carList = new List<Car>();
            dealsList = new List<Deal>();
            repairBlanksList = new List<RepairBlank>();
        }
        //
        //СОБЫТИЯ ПО НАЖАИЮ
        //
        private void autopark_form_Load(object sender, EventArgs e)
        {
            driverBase = new List<string>();
            carsBase = new List<string>();
            mainTimer.Enabled = true;
            
        }

        private void addDriverBTN_Click(object sender, EventArgs e)
        {
            
            Add_item addItem = new Add_item(1,driverBase,carsBase);
            addItem.Owner = this;
            addItem.ShowDialog();            
            
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            
            Add_item addItem = new Add_item(2, driverBase, carsBase);
            addItem.Owner = this;
            addItem.ShowDialog();
            
        }

        private void addDealBtn_Click(object sender, EventArgs e)
        {
            FillDriversList();
            FillCarsList();
            Add_item addItem = new Add_item(3, driverBase, carsBase);
            addItem.Owner = this;
            addItem.ShowDialog();
        }        
        //
        //АПРУВ ЗАЯВКИ НА РЕМОНТ
        //
        private void approveRequestBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repairBlanksList.Count; i++)
            {
                if (repairBlanksList[i].BlankNumber == (string)RPList.SelectedItem)
                {
                    repairBlanksList[i].GetCar.IsOnRepair = true;
                    repairBlanksList[i].Approve = true;
                }
            }
        }
        //
        //ВОИД ЗАПОЛНЕНИЯ СДЕЛОК
        //
        public void AddDeal(string dealNumber, string driver, string car, string length)
        {
            Driver targetDriver = null;
            Car targetCar = null;

            foreach (Driver dr in driverList)
            {
                if (dr.Name == driver)
                {
                    targetDriver = dr;
                }
            }
            foreach (Car dr in carList)
            {
                if (dr.ID == car)
                {
                    targetCar = dr;
                }
            }

            dealsList.Add(new Deal(targetDriver,targetCar,dealNumber,Int32.Parse(length)));

            dealList.Items.Add(dealsList[dealsList.Count - 1].DealNumber);

            targetDriver.SetCar = targetCar;
            RefreshAll();
        }
        //
        //ВОИД ЗАПОЛНЕНИЯ СПИСКА АВТО
        //
        public void AddCar(string a, string b, int w, int ave)
        {
            carList.Add(new Car(a, b, w, ave));
            carsList.Items.Add(carList[carList.Count - 1].ID);
            FillCarsList();
            RefreshAll();
        }
        //
        //ВОИД ЗАПОЛНЕНИЯ СПИСКА ВОДИТЕЛЕЙ
        //
        public void AddDriver(string a)
        {
            driverList.Add(new Driver(a));
            driversList.Items.Add(driverList[driverList.Count -1].Name);
            FillDriversList();
            RefreshAll();
        }
        //
        //ВОИД ЗАПОЛНЕНИЯ СПИСКА РЕКВЕСТОВ НА РЕМОНТ
        //
        private void AddRepairRequest(Driver askedDriver, Car askedCar)
        {
            repairBlanksList.Add(new RepairBlank(askedDriver, askedCar, numberOfRBlanks.ToString()));
            RPList.Items.Add(repairBlanksList[repairBlanksList.Count - 1].BlankNumber);
            RefreshAll();
            numberOfRBlanks++;
            
        }
        //
        //ПЕРЕНОС ИМЕН ДРАЙВЕРОВ В ОТДЕЛЬНЫЙ СПИСОК
        //
        private void FillDriversList()
        {
            driverBase.Clear();
            for (int i = 0; i < driverList.Count; i++)
            {
                
                driverBase.Add(driverList[i].Name);
            }
            
        }
        //
        //ПЕРЕНОС НОМЕРОВ АВТО В ОТДЕЛЬНЫЙ СПИСОК
        //
        private void FillCarsList()
        {
            carsBase.Clear();
            for (int i = 0; i < carList.Count; i++)
            {
                carsBase.Add(carList[i].ID);
            }

        }               
        //
        //СОБЫТИЯ ОТОБРАЖЕНИЯ ИНФОРМАЦИИ О ВЫДЕЛЕННЫХ ОБЪЕКТАХ
        //
        private void driversList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Driver selectedDriver in driverList)
            {
                if (selectedDriver.Name ==(string)driversList.SelectedItem)
                {
                    infoOutput.Text = selectedDriver.Info();
                }
            }
        }

        private void carsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Car selectedCar in carList)
            {
                if (selectedCar.ID ==(string)carsList.SelectedItem)
                {
                    infoOutput.Text = selectedCar.Info();
                }
            }
        }

        private void dealList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Deal deal in dealsList)
            {
                if (deal.DealNumber == (string)dealList.SelectedItem)
                {
                    infoOutput.Text = deal.Info();
                }
            }
        }

        private void RPList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < repairBlanksList.Count; i++)
            {
                if (repairBlanksList[i].BlankNumber == (string)RPList.SelectedItem)
                {
                    infoOutput.Text = repairBlanksList[i].Info();
                }
            }
        }
        //
        //ТАЙМЕР ТИКАЕТ
        //
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (dealsList.Count != 0)
            {
                for (int i = 0; i < dealsList.Count; i++)
                {
                    dealsList[i].Process();
                    if (dealsList[i].IsDone)
                    {
                        dealList.Items.RemoveAt(dealList.Items.IndexOf(dealsList[i].DealNumber));
                        dealsList.Remove(dealsList[i]);
                        RefreshAll();
                    }
                }                
            }
            if (carList.Count != 0)
            {
                for (int i = 0; i < carList.Count; i++)
                {
                    carList[i].Condition();
                }
            }

            if (driverList.Count>0)
            {

                for (int i = 0; i < driverList.Count; i++)
                {
                    bool trigger = false;
                    driverList[i].CarCheck();

                    for (int j = 0; j < repairBlanksList.Count; j++)
                    {
                        if (repairBlanksList[j].GetDriver == driverList[i])
                        {
                            trigger = true;
                        }
                    }
                    if (driverList[i].RepairRequest & !trigger)
                    {
                        
                        AddRepairRequest(driverList[i], driverList[i].GetCar);                        
                        
                    }
                }
            }
            if (repairBlanksList.Count != 0)
            {
                for (int i = 0; i < repairBlanksList.Count; i++)
                {
                    repairBlanksList[i].statusChange();
                    if (repairBlanksList[i].IsDone)
                    {
                        RPList.Items.Remove(repairBlanksList[i].BlankNumber);
                        repairBlanksList.RemoveAt(i);
                        RefreshAll();
                    } 
                }
            }

            //RefreshAll();
        }
        //
        //ОБНОВЛЕНИЕ ДАННЫХ ВО ВСЕХ СТОЛБИКАХ
        //
        void RefreshAll()
        {
            if (driverList.Count!=0)
            {                
                driversList.Items.Clear();
                foreach (Driver driver in driverList) { driversList.Items.Add(driver.Name); }
            }
            if (carList.Count != 0)
            {
                carsList.Items.Clear();
                foreach (Car car in carList) { carsList.Items.Add(car.ID); }
            }
            if (dealsList.Count!=0)
            {
                dealList.Items.Clear();
                foreach (Deal deal in dealsList) { dealList.Items.Add(deal.DealNumber); }
            }
            if (repairBlanksList.Count!=0)
            {
                RPList.Items.Clear();
                foreach (RepairBlank repairBlank in repairBlanksList) { RPList.Items.Add(repairBlank.BlankNumber); }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
