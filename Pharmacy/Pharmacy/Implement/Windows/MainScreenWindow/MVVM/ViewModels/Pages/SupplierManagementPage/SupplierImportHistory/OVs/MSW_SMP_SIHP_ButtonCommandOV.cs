﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.Utils;
using Pharmacy.Implement.Utils.InputCommand;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs;


namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.SupplierManagementPage.SupplierImportHistory.OVs
{
    internal class MSW_SMP_SIHP_ButtonCommandOV : MSW_ButtonCommandOV
    {
        private static Logger L = new Logger("MSW_SMP_SIHP_ButtonCommandOV");

        public CommandExecuterModel CancelButtonCommand { get; set; }
        public CommandExecuterModel ShowDebtButtonCommand { get; set; }
        public CommandExecuterModel ShowInvoiceButtonCommand { get; set; }

        protected override Logger logger => L;

        public MSW_SMP_SIHP_ButtonCommandOV(BaseViewModel parentVM) : base(parentVM)
        {
            ShowDebtButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SMP_SIHP_SHOW_DEBT_BUTTON
                , paramaters);
            });
            CancelButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SMP_SIHP_CANCEL_BUTTON
                , paramaters);
            });
            ShowInvoiceButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SMP_SIHP_SHOW_INVOICE_BUTTON
                , paramaters);
            });
        }

    }
}
