﻿using Pharmacy.Implement.Utils.CustomControls.QuotableEventPage;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MedicineManagementPage.AddMedicine;
using System.Windows.Controls;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.Views.Pages.MedicineManagement
{
    /// <summary>
    /// Interaction logic for AddMedicinePage.xaml
    /// </summary>
    public partial class AddMedicinePage : QuotableEventPage
    {
        public AddMedicinePage()
        {
            InitializeComponent();
            DataContext = new AddMedicinePageViewModel();

        }
    }
}
