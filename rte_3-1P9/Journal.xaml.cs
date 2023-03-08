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
using System.Collections.ObjectModel;
using ClassLibrary1;

namespace rte_3_1P9
{
    /// <summary>
    /// Логика взаимодействия для Journal.xaml
    /// </summary>
    public partial class Journal : Window
    {
        public ObservableCollection<Grop> Grops;
        public Journal()
        {
            InitializeComponent();
            using (var db = new DBContext())
            {
                dataGrid1.ItemsSource = db.Grops.ToList();
            }
        }
    }
}
