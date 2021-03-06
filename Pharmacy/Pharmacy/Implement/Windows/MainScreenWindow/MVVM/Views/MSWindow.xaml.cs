﻿using Pharmacy.Implement.Utils.CustomControls;
using Pharmacy.Implement.Utils.Definitions;
using Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels;
using Pharmacy.Implement.Windows.MainScreenWindow.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MSWindow : Implement.Utils.CustomControls.DashboardWindow
    {
        public MSWindow()
        {
            InitializeComponent();
        }

        private void DashboardWindow_PreviewPageNavigate(object sender, PreviewPageNavigateArgs e)
        {
            (DataContext as MainScreenWindowViewModel).PagePreviewNavigateEventCommand.Execute(sender, e, this);
        }
    }
}
