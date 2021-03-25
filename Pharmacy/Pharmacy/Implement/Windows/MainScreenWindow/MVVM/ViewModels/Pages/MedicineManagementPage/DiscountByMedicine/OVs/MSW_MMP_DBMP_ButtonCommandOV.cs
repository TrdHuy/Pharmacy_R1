﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.UIEventHandler.Action;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.Utils;
using Pharmacy.Implement.Utils.InputCommand;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MedicineManagementPage.AddMedicine.OVs
{
    internal class MSW_MMP_DBMP_ButtonCommandOV : MSW_ButtonCommandOV
    {
        private static Logger L = new Logger("MSW_MMP_DBMP_ButtonCommandOV");
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
                    _keyActionListener.LockMSW_ActionFactory(false, FactoryStatus.Unlock);
                }
                InvalidateOwn();
            }
        }

        public RunInputCommand CancelButtonCommand { get; set; }
        public RunInputCommand CreateNewPromoButtonCommand { get; set; }
        public RunInputCommand SaveButtonCommand { get; set; }
        public RunInputCommand DeleteButtonCommand { get; set; }

        protected override Logger logger => L;
        public MSW_MMP_DBMP_ButtonCommandOV(BaseViewModel parentsModel) : base(parentsModel)
        {
            CancelButtonCommand = new RunInputCommand((paramaters) =>
            {
                OnKey(KeyFeatureTag.KEY_TAG_MSW_MMP_DBMP_CANCEL_BUTTON
                    , paramaters);
            });
            CreateNewPromoButtonCommand = new RunInputCommand((paramaters) =>
            {
                OnKey(KeyFeatureTag.KEY_TAG_MSW_MMP_DBMP_CREATE_NEW_PROMO_BUTTON
                    , paramaters);
            });
            DeleteButtonCommand = new RunInputCommand((paramaters) =>
            {
                OnKey(KeyFeatureTag.KEY_TAG_MSW_MMP_DBMP_DELETE_BUTTON
                    , paramaters);
            });
            SaveButtonCommand = new RunInputCommand((paramaters) =>
            {
                IsSaveButtonRunning = true;
                OnKey(KeyFeatureTag.KEY_TAG_MSW_MMP_DBMP_SAVE_BUTTON
                    , paramaters
                    , new FactoryLocker(FactoryStatus.TaskHandling, true));
            });

        }

    }
}
