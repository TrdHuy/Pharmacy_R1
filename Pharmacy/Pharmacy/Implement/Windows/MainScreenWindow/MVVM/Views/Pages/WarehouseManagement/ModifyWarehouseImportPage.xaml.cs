﻿using Pharmacy.Implement.Utils.CustomControls.QuotableEventPage;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.WarehouseManagementPage.ModifyWarehouseImport;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.Views.Pages.WarehouseManagement
{
    /// <summary>
    /// Interaction logic for ModifyWarehouseImportPage.xaml
    /// </summary>
    public partial class ModifyWarehouseImportPage : QuotableEventPage
    {
        public ModifyWarehouseImportPage()
        {
            InitializeComponent();
            DataContext = new ModifyWarehouseImportPageViewModel();
        }
    }
}
