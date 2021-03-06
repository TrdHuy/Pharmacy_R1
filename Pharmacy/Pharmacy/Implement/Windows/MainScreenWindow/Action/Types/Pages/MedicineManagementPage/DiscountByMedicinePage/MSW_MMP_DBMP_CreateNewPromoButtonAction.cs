﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.Utils;

namespace Pharmacy.Implement.Windows.MainScreenWindow.Action.Types.Pages.MedicineManagementPage.DiscountByMedicinePage
{
    internal class MSW_MMP_DBMP_CreateNewPromoButtonAction : MSW_MMP_DBMP_ButtonAction
    {
        public MSW_MMP_DBMP_CreateNewPromoButtonAction(string actionID, string builderID, BaseViewModel viewModel, ILogger logger) : base(actionID, builderID, viewModel, logger) { }

        protected override void ExecuteCommand()
        {
            DBMPViewModel.PromoDescription = "";
            DBMPViewModel.PromoPercent = 0;
            DBMPViewModel.SelectedCustomer = -1;
        }
    }
}
