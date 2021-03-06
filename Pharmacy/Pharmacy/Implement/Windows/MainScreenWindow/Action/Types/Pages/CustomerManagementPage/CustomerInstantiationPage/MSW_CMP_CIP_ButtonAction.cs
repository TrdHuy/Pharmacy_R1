﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.Utils;
using Pharmacy.Implement.Windows.BaseWindow.Action.Types;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.CustomerManagementPage.CustomerInstantiation;
using Pharmacy.Implement.Windows.MainScreenWindow.Utils;

namespace Pharmacy.Implement.Windows.MainScreenWindow.Action.Types.Pages.CustomerManagementPage.CustomerInstantiationPage
{
    internal class MSW_CMP_CIP_ButtonAction : BaseViewModelCommandExecuter
    {
        protected CustomerInstantiationPageViewModel CIPViewModel
        {
            get
            {
                return ViewModel as CustomerInstantiationPageViewModel;
            }
        }
        protected MSW_PageController PageHost { get; } = MSW_PageController.Instance;


        public MSW_CMP_CIP_ButtonAction(string actionID, string builderID, BaseViewModel viewModel, ILogger logger) : base(actionID, builderID, viewModel, logger) { }

        protected override void ExecuteCommand()
        {
            base.ExecuteCommand();
        }
    }
}