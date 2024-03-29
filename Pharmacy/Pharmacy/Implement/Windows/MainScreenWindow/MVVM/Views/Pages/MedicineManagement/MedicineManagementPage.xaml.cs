﻿using Pharmacy.Implement.Utils.CustomControls.QuotableEventPage;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MedicineManagementPage.MedicineManagement;
using System.Windows.Controls;
using System.Windows.Input;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.Views.Pages.MedicineManagement
{
    /// <summary>
    /// Interaction logic for MedicineManagementPage.xaml
    /// </summary>
    public partial class MedicineManagementPage : QuotableEventPage
    {
        public MedicineManagementPage()
        {
            InitializeComponent();
            //DataContext = new MedicineManagementPageViewModel();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((MedicineManagementPageViewModel)DataContext).SearchTextChangedCommand.Execute(sender, e, DataGrid, this);
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ((MedicineManagementPageViewModel)DataContext).ShowMedicineInfoCommand.Execute(sender, e, DataGrid, this);
        }
    }
}
