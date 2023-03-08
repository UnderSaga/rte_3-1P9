﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace rte_3_1P9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            using (var db = new DBContext())
            {
                db.Database.Delete();
            }
            User.CreateAdmin();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = User.LogIn(log_TextBox.Text, pass_PasswordBox.Password);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль!!!");
            }
            else
            {
                Hide();
                Journal journal = new Journal();
                journal.ShowDialog();
                Grop.CreateGrop();
                Show();
            }
        }
    }
}
