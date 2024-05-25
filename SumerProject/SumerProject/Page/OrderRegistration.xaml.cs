﻿using SumerProject.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SumerProject.Assets;

namespace SumerProject.Page
{
    /// <summary>
    /// Логика взаимодействия для OrderRegistration.xaml
    /// </summary>
    public partial class OrderRegistration : Window
    {
        public ObservableCollection<CartProduct> Products { get; set; }

        public OrderRegistration(List<CartProduct> cartProducts)
        {
            InitializeComponent();
            Products = new ObservableCollection<CartProduct>(cartProducts);
            DataContext = this;
        }
    }
}
