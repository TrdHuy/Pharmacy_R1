﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.UIEventHandler.Action;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.Utils;
using Pharmacy.Implement.Utils.InputCommand;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.ReportPage.OVs
{
    internal class MSW_RP_ButtonCommandOV : MSW_ButtonCommandOV
    {
        private static Logger L = new Logger("MSW_RP_ButtonCommandOV");
        private bool _isInitSellingReportButtonRunning;
        private bool _isInitComprehensiveReportButtonRunning;

        public CommandExecuterModel InitSellingReportButtonCommand { get; set; }
        public CommandExecuterModel InitComprehensiveReportButtonCommand { get; set; }
        public bool IsInitSellingReportButtonRunning
        {
            get
            {
                return _isInitSellingReportButtonRunning;
            }
            set
            {
                _isInitSellingReportButtonRunning = value;
                if (!value)
                {
                    _keyActionListener.LockMSW_ActionFactory(false, BuilderStatus.Unlock);
                }
                InvalidateOwn();
            }
        }
        public bool IsInitComprehensiveReportButtonRunning
        {
            get
            {
                return _isInitComprehensiveReportButtonRunning;
            }
            set
            {
                _isInitComprehensiveReportButtonRunning = value;
                if (!value)
                {
                    _keyActionListener.LockMSW_ActionFactory(false, BuilderStatus.Unlock);
                }
                InvalidateOwn();
            }
        }

        protected override Logger logger => L;

        public MSW_RP_ButtonCommandOV(BaseViewModel parentVM) : base(parentVM)
        {
            InitSellingReportButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                IsInitSellingReportButtonRunning = true;
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_RP_INIT_SELLING_REPORT_BUTTON
                , paramaters
                , new BuilderLocker(BuilderStatus.TaskHandling, true)) as ICommandExecuter;
            });
            InitComprehensiveReportButtonCommand = new CommandExecuterModel((paramaters) =>
            {
                IsInitComprehensiveReportButtonRunning = true;
                return OnKey(KeyFeatureTag.KEY_TAG_MSW_RP_INIT_COMPREHENSIVE_REPORT_BUTTON
                , paramaters
                , new BuilderLocker(BuilderStatus.TaskHandling, true)) as ICommandExecuter;
            });
        }

    }
}
