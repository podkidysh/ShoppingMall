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

namespace ShoppingMall.MyForms
{
    /// <summary>
    /// Логика взаимодействия для PremisesWindow.xaml
    /// </summary>
    public partial class PremisesWindow : Window
    {
        public PremisesWindow()
        {
            InitializeComponent();
            Loaded += PremisesWindow_Loaded;
        }

        private void PremisesWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MySqlContext context = new DB.MySqlContext();
                var premises = context.Premises.ToList();
                dgContentPremises.ItemsSource = premises;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddPremises_Click(object sender, RoutedEventArgs e)
        {
            AddPremisesWindow addPremisesWindow = new AddPremisesWindow();
            addPremisesWindow.ShowDialog();
            PremisesWindow_Loaded(sender, e);
        }

        private void btExitInMenu_Click(object sender, RoutedEventArgs e)
        {
            ManuWindow manuWindow = new ManuWindow();
            manuWindow.Show();
            Close();
        }
    }
}
