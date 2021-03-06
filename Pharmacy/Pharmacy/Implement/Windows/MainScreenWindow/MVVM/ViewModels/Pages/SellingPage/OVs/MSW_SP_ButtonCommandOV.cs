﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.UIEventHandler.Action;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.Utils;
using Pharmacy.Implement.Utils.InputCommand;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.SellingPage.OVs
{
    internal class MSW_SP_ButtonCommandOV : MSW_ButtonCommandOV
    {
        private static Logger L = new Logger("MSW_SP_ButtonCommanOV");
        protected override Logger logger => L;

        private bool _isAddOrderDeatailButtonRunning = false;
        private bool _isInstantiateNewOrderButtonRunning = false;

        public bool IsInstantiateNewOrderButtonRunning
        {
            get
            {

                return _isInstantiateNewOrderButtonRunning;
            }
            set
            {
                _isInstantiateNewOrderButtonRunning = value;
                if (!value)
                {
                    _keyActionListener.LockMSW_ActionFactory(false, BuilderStatus.Unlock);
                }
                InvalidateOwn();
            }
        }
        public bool IsAddOrderDeatailButtonRunning
        {
            get
            {

                return _isAddOrderDeatailButtonRunning;
            }
            set
            {
                _isAddOrderDeatailButtonRunning = value;
                if (!value)
                {
                    _keyActionListener.LockMSW_ActionFactory(false, BuilderStatus.Unlock);
                }
                InvalidateOwn();
            }
        }

        public CommandExecuterModel AddOrderDetailCommand { get; set; }
        public CommandExecuterModel RemoveOrderDetailCommand { get; set; }
        public CommandExecuterModel InstantiateOrderCommand { get; set; }
        public CommandExecuterModel RefreshSellingPageCommand { get; set; }

        public MSW_SP_ButtonCommandOV(BaseViewModel parentsModel) : base(parentsModel)
        {
            AddOrderDetailCommand = new CommandExecuterModel((paramaters) =>
            {
                IsAddOrderDeatailButtonRunning = true;
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SP_ADD_BUTTON
                    , paramaters
                    , new BuilderLocker(BuilderStatus.TaskHandling, true)) as ICommandExecuter;
            });
            RemoveOrderDetailCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SP_REMOVE_BUTTON
                    , paramaters);
            });
            InstantiateOrderCommand = new CommandExecuterModel((paramaters) =>
            {
                IsInstantiateNewOrderButtonRunning = true;
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SP_INSTANTIATE_BUTTON
                    , paramaters
                    , new BuilderLocker(BuilderStatus.TaskHandling, true)) as ICommandExecuter;
            });
            RefreshSellingPageCommand = new CommandExecuterModel((paramaters) =>
            {
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_SP_REFRESH_BUTTON
                    , paramaters);
            });

        }
    }
}
