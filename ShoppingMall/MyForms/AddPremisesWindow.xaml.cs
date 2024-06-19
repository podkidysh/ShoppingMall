using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ShoppingMall.MyForms
{
    /// <summary>
    /// Логика взаимодействия для AddPremisesWindow.xaml
    /// </summary>
    public partial class AddPremisesWindow : Window
    {
        public AddPremisesWindow()
        {
            InitializeComponent();
        }

        private void btAddPremises_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumber.Text))
            {
                MessageBox.Show("Введите номер помещения");
            }
            if (string.IsNullOrEmpty(tbSquare.Text))
            {
                MessageBox.Show("Введите площадь помещения");
            }
            if (string.IsNullOrEmpty(tbFloor.Text))
            {
                MessageBox.Show("Введите этаж помещения");
            }
            if (string.IsNullOrEmpty(tbLocation.Text))
            {
                MessageBox.Show("Введите расположение помещения");
            }
            if (string.IsNullOrEmpty(tbFinishingType.Text))
            {
                MessageBox.Show("Введите тип оттделки помещения");
            }
            if (string.IsNullOrEmpty(tbCommunication.Text))
            {
                MessageBox.Show("Введите коммуникации помещения");
            }
            if (string.IsNullOrEmpty(tbStatus.Text))
            {
                MessageBox.Show("Введите статус помещения");
            }

            DB.Premises myNewPremises = new DB.Premises();

            myNewPremises.Number = tbNumber.Text;
            myNewPremises.Squre = tbSquare.Text;
            myNewPremises.Floor = tbFloor.Text;
            myNewPremises.Location = tbLocation.Text;
            myNewPremises.FinishingType = tbFinishingType.Text;
            myNewPremises.Communication = tbCommunication.Text;
            myNewPremises.Status = tbStatus.Text;

            try
            {
                using DB.MySqlContext mySqlContext = new DB.MySqlContext();
                mySqlContext.Premises.Add(myNewPremises);
                mySqlContext.SaveChanges();
                MessageBox.Show("Вы успешно добавили запись");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
