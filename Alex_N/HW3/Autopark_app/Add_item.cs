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
    public partial class Add_item : Form
    {
        private int whatChoise;//символизирует выбранную опцию
        private autopark_form masta;
        private List<string> avalDrivers;
        private List<string> avalCars;



        public Add_item(int coef, List<string> d, List<string> c)//констркутор в который передается цифра операции
        {
            whatChoise = coef;
            InitializeComponent();
            masta = this.Owner as autopark_form;
            avalDrivers = d;
            avalCars = c;
            FormModification();
        }
        public Add_item()//конструктор по умолчанию
        {

            InitializeComponent();
        }


        private void FormModification()
        {
            masta = this.Owner as autopark_form;
            switch (whatChoise)
            {
                case 1://подстройка формы под запонение бланка водителя
                    label_1.Text = "ФИО водителя";
                    driverChose.Visible = false;
                    carChose.Visible = false;
                    label_2.Visible = false;
                    label_3.Visible = false;
                    label_4.Visible = false;
                    input_2.Visible = false;
                    input_3.Visible = false;
                    input_4.Visible = false;
                    break;
                case 2://подстройка формы под заполнение бланка авто
                    label_1.Text = "Марка авто:";
                    label_2.Text = "Номер авто:";
                    label_3.Text = "КМ до ТО:";
                    label_4.Text = "Средняя скорость:";
                    driverChose.Visible = false;
                    carChose.Visible = false;
                    break;
                case 3://подстройка формы под заполнение заказа 
                    FillAvaliableResources(driverChose, avalDrivers);
                    FillAvaliableResources(carChose, avalCars);
                    label_1.Text = "Номер сделки";
                    label_2.Text = "Водитель";
                    label_3.Text = "Авто";
                    label_4.Text = "Расстояние";
                    driverChose.Visible = true;
                    carChose.Visible = true;
                    input_2.Visible = false;
                    input_3.Visible = false;                    
                    break;

            }
        }

        private void FillAvaliableResources(ComboBox targetBox, List<string> targetList)
        {
            if (targetList.Count !=  0)
            {
                foreach (string s in targetList)
                {
                    targetBox.Items.Add(s);
                }
            }
        }

        //
        //КНОПКА ОТМЕНА
        //
        private void cancelBTN_Click(object sender, EventArgs e)//закрытие формы по отмене 
        {
            this.Close();
        }
        //
        //ПЕРЕДАЧА ДАННЫХ ОБРАТНО В РОДИТЕЛЬСКУЮ ФОРМУ
        //
        private void Actions(int targetAction)//воид передает в хазяйскую форму инфу из полей ввода этой формы в зависимости от типа заполняемой формы
        {
            autopark_form masta = this.Owner as autopark_form; // указание формы-хазяина

            switch (targetAction)
            {

                case 1:
                    masta.AddDriver(input_1.Text);
                    break;
                case 2:
                    masta.AddCar(input_1.Text, input_2.Text, Int32.Parse(input_3.Text), Int32.Parse(input_4.Text));
                    break;
                case 3:
                    masta.AddDeal(input_1.Text, driverChose.SelectedItem.ToString(), carChose.SelectedItem.ToString(), input_4.Text);
                    break;
                default:
                    break;
            }
        }
        //
        //КНОПКА ПОДТВЕРЖДЕНИЯ
        //
        private void createBTN_Click(object sender, EventArgs e)//принажатии кнопки "создать" запуск метода 
        {
            Actions(whatChoise);

            this.Close();
        }
       

        private void Add_item_Load(object sender, EventArgs e)
        {

        }
    }
}
