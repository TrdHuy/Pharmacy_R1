﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.Utils;
using Pharmacy.Implement.Windows.BaseWindow.Action.Types;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.AppInfoPage;

namespace Pharmacy.Implement.Windows.MainScreenWindow.Action.Types.Pages.AppInfoPage
{
    internal class MSW_AIP_ButtonAction : BaseViewModelCommandExecuter
    {
        protected AppInfoPageViewModel AIPViewmodel
        {
            get
            {
                return ViewModel as AppInfoPageViewModel;
            }
        }

        public MSW_AIP_ButtonAction(string actionID, string builderID, BaseViewModel viewModel, ILogger logger) : base(actionID, builderID, viewModel, logger) { }

        protected override void ExecuteCommand()
        {
            base.ExecuteCommand();
        }

        protected override void ExecuteOnDestroy()
        {
            base.ExecuteOnDestroy();
        }
    }
}
