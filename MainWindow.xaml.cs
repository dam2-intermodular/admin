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

namespace admin {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void loginClicked(object sender, MouseButtonEventArgs e) {
            if (email.Text.Length == 0 || password.Password.Length == 0)
                MessageBox.Show("Debes introducir un correo y una contraseña.", "Error");
            else {
                HomeScreen hv = new HomeScreen();
                hv.Show();
                Close();
            }
        }
    }
}
