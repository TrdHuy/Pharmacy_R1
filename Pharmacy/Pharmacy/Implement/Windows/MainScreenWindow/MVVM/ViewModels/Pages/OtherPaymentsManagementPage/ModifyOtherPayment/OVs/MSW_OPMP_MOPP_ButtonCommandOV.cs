﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.UIEventHandler.Action;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.Utils;
using Pharmacy.Implement.Utils.InputCommand;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.OtherPaymentsManagementPage.ModifyOtherPayment.OVs
{
    internal class MSW_OPMP_MOPP_ButtonCommandOV : MSW_ButtonCommandOV
    {
        private static Logger L = new Logger("MSW_OPMP_MOPP_ButtonCommandOV");
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
        public CommandExecuterModel CancelButtonCommand { get; set; }
        public CommandExecuterModel SaveButtonCommand { get; set; }
        public CommandExecuterModel BrowseInvoiceButtonCommand { get; set; }

        protected override Logger logger => L;

        public MSW_OPMP_MOPP_ButtonCommandOV(BaseViewModel parentVM) : base(parentVM)
        {
            CancelButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_OPMP_MOPP_CANCEL_BUTTON
                , paramaters);
            });
            SaveButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                IsSaveButtonRunning = true;
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_OPMP_MOPP_SAVE_BUTTON
                , paramaters
                , new BuilderLocker(BuilderStatus.TaskHandling, true)) as ICommandExecuter;
            });
            BrowseInvoiceButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_OPMP_MOPP_BROWSE_INVOICE_IMAGE_BUTTON
                , paramaters);
            });
        }

    }
}

