﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.UIEventHandler.Action;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.Utils;
using Pharmacy.Implement.Utils.InputCommand;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.OtherPaymentsManagementPage.AddOtherPayment.OVs
{
    internal class MSW_OPMP_AOPP_ButtonCommandOV : MSW_ButtonCommandOV
    {
        private static Logger L = new Logger("MSW_OPMP_AOPP_ButtonCommandOV");
        private bool _isSaveButtonRunning;

        public bool IsSaveButtonRunning
        {
            get
            {
                return _isSaveButtonRunning;
            }
            set
            {
                _isSaveButtonRunning = value;
                if (!value)
                {
                    _keyActionListener.LockMSW_ActionFactory(false, BuilderStatus.Unlock);
                }
                InvalidateOwn();
            }
        }
        public CommandModel CancelButtonCommand { get; set; }
        public CommandModel SaveButtonCommand { get; set; }
        public CommandModel BrowseInvoiceButtonCommand { get; set; }

        protected override Logger logger => L;

        public MSW_OPMP_AOPP_ButtonCommandOV(BaseViewModel parentVM) : base(parentVM)
        {
            CancelButtonCommand = new CommandModel((paramaters) =>
            {
                OnKey(KeyFeatureTag.KEY_TAG_MSW_OPMP_AOPP_CANCEL_BUTTON
                , paramaters);
            });
            SaveButtonCommand = new CommandModel((paramaters) =>
            {
                IsSaveButtonRunning = true;
                OnKey(KeyFeatureTag.KEY_TAG_MSW_OPMP_AOPP_SAVE_BUTTON
                , paramaters
                , new BuilderLocker(BuilderStatus.TaskHandling, true));
            });
            BrowseInvoiceButtonCommand = new CommandModel((paramaters) =>
            {
                OnKey(KeyFeatureTag.KEY_TAG_MSW_OPMP_AOPP_BROWSE_INVOICE_IMAGE_BUTTON
                , paramaters);
            });
        }

    }
}
