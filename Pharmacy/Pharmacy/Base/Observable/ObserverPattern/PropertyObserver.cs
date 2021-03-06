using Pharmacy.Base.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Base.Observable.ObserverPattern
{
    public class PropertyObserver : BaseObserver<ObservableProperty>
    {
        public Type PropType { get; }
        public string PropName { get; }
        public BaseViewModel ViewModel { get; }
        public PropertyObserver(BaseViewModel viewModel, Type propType, string propName, Action<object> onPropUpdate = null) : base()
        {
            OnUpdate = onPropUpdate ?? new Action<object>(OnPropUpdate);
            PropType = propType;
            PropName = propName;
            ViewModel = viewModel;
        }

        public object Value { get; set; }

        public void OnPropUpdate(object value)
        {
            Value = ((ObservableProperty)value).Value;
            ViewModel.OnChanged(ViewModel, PropName);
        }
    }
}