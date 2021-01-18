﻿using Pharmacy.Implement.Utils.DatabaseManager;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.SellingPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pharmacy.Implement.Windows.MainScreenWindow.Action.Types.Pages.SellingPage
{
    public class MSW_SP_InstantiateNewOrderAction : Base.UIEventHandler.Action.IAction
    {
        private SellingPageViewModel _viewModel;
        private DataGrid _ctrl;
        private tblOrder _newOrder;
        private SQLQueryCustodian _createNewOrderQueryObserver;

        public bool Execute(object[] dataTransfer)
        {
            _viewModel = dataTransfer[0] as SellingPageViewModel;
            _ctrl = dataTransfer[1] as DataGrid;

            if (!CanExecute())
            {
                return false;
            }
            GenerateOrder();

            return true;
        }

        private bool CanExecute()
        {
            if (_viewModel.CurrentSelectedCustomer == null)
            {
                var x = App.Current.ShowApplicationMessageBox("Vui lòng chọn khách hàng!",
                  HPSolutionCCDevPackage.netFramework.AnubisMessageBoxType.Default,
                  HPSolutionCCDevPackage.netFramework.AnubisMessageImage.Info,
                  OwnerWindow.MainScreen,
                  "Thông báo!!");
                return false;
            }
            if (_viewModel.CustomerOrderDetailItemSource == null
                || _viewModel.CustomerOrderDetailItemSource.Count == 0)
            {
                var x = App.Current.ShowApplicationMessageBox("Hóa đơn phải có ít nhất 1 sản phẩm!",
                  HPSolutionCCDevPackage.netFramework.AnubisMessageBoxType.Default,
                  HPSolutionCCDevPackage.netFramework.AnubisMessageImage.Info,
                  OwnerWindow.MainScreen,
                  "Thông báo!!");
                return false;
            }
            return true;
        }

        private void GenerateOrder()
        {
            _newOrder = new tblOrder();
            _newOrder.IsActive = true;
            _newOrder.OrderTime = DateTime.Now;
            _newOrder.UserID = App.Current.CurrentUser.Username;
            _newOrder.CustomerID = _viewModel.CurrentSelectedCustomer.CustomerID;

            foreach (OrderDetailVO vo in _viewModel.CustomerOrderDetailItemSource)
            {
                tblOrderDetail oD = new tblOrderDetail()
                {
                    IsActive = true,
                    Quantity = Convert.ToDouble(vo.Quantity),
                    TotalPrice = vo.TotalPrice,
                    UnitPrice = vo.UnitPrice
                };
                _newOrder.tblOrderDetails.Add(oD);
            }

            _createNewOrderQueryObserver = new SQLQueryCustodian(GenerateOrderCallback);
            DbManager.Instance.ExecuteQuery(SQLCommandKey.ADD_NEW_CUSTOMER_ORDER_CMD_KEY,
                _createNewOrderQueryObserver,
                _newOrder);
        }

        private void GenerateOrderCallback(SQLQueryResult queryResult)
        {
            if (queryResult.MesResult == MessageQueryResult.Done)
            {
                bool refreshCustomer = false;
                bool refreshMedicineBillBoard = true;

                _viewModel.RefreshViewModel(refreshCustomer, refreshMedicineBillBoard);

                App.Current.ShowApplicationMessageBox("Tạo hóa đơn mới thành công!",
                  HPSolutionCCDevPackage.netFramework.AnubisMessageBoxType.Default,
                  HPSolutionCCDevPackage.netFramework.AnubisMessageImage.Success,
                  OwnerWindow.MainScreen,
                  "Thông báo!!");
            }
            else
            {
                App.Current.ShowApplicationMessageBox("Lỗi tạo hóa đơn mới!",
                  HPSolutionCCDevPackage.netFramework.AnubisMessageBoxType.Default,
                  HPSolutionCCDevPackage.netFramework.AnubisMessageImage.Error,
                  OwnerWindow.MainScreen,
                  "Lỗi!!");
            }
        }

    }
}