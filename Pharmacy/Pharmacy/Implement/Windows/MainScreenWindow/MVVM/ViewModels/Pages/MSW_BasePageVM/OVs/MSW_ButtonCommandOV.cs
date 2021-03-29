﻿using Pharmacy.Base.MVVM.ViewModels;
using Pharmacy.Base.UIEventHandler.Action;
using Pharmacy.Implement.UIEventHandler;
using Pharmacy.Implement.UIEventHandler.Listener;
using Pharmacy.Implement.Utils;
using System.Diagnostics;

namespace Pharmacy.Implement.Windows.MainScreenWindow.MVVM.ViewModels.Pages.MSW_BasePageVM.OVs
{
    internal abstract class MSW_ButtonCommandOV : BaseViewModel
    {
        protected abstract Logger logger { get; }

        protected KeyActionListener _keyActionListener = KeyActionListener.Current;

        protected MSW_ButtonCommandOV(BaseViewModel parentsModel) : base(parentsModel) { }

        protected IAction OnKey(string keyTag, object paramaters, bool isViewModelOnKey = true, string windowTag = WindowTag.WINDOW_TAG_MAIN_SCREEN)
        {
            logger.I("OnKey: keyTag = " + keyTag + " windowTag = " + windowTag);

#if DEBUG
            Stopwatch onKeyWatcher = Stopwatch.StartNew();
#endif
            object[] dataTransfer = new object[2];
            dataTransfer[0] = this.ParentsModel;
            dataTransfer[1] = paramaters;

            var action = _keyActionListener.OnKey(isViewModelOnKey ? ParentsModel : null
                                , logger
                                , windowTag
                                , keyTag
                                , dataTransfer);

#if DEBUG
            onKeyWatcher.Stop();
            var timeExecuted = onKeyWatcher.ElapsedMilliseconds;
            logger.D("Time executed on key = " + timeExecuted + "(ms)");
#endif
            logger.I("Done: keyTag = " + keyTag + " windowTag = " + windowTag);

            return action;
        }

        protected IAction OnKey(string keyTag, object paramaters, BuilderLocker locker, bool isViewModelOnKey = true, string windowTag = WindowTag.WINDOW_TAG_MAIN_SCREEN)
        {
            logger.I("OnKey: keyTag = " + keyTag + " windowTag = " + windowTag);

#if DEBUG
            Stopwatch onKeyWatcher = Stopwatch.StartNew();
#endif
            object[] dataTransfer = new object[2];
            dataTransfer[0] = this.ParentsModel;
            dataTransfer[1] = paramaters;

            var action = _keyActionListener.OnKey(isViewModelOnKey ? ParentsModel : null
                                , logger
                                , windowTag
                                , keyTag
                                , dataTransfer
                                , locker);
#if DEBUG
            onKeyWatcher.Stop();
            var timeExecuted = onKeyWatcher.ElapsedMilliseconds;
            logger.D("Time executed on key = " + timeExecuted + "(ms)");
#endif
            logger.I("Done: keyTag = " + keyTag + " windowTag = " + windowTag);

            return action;
        }

        protected void OnKeyDestroy(string windowTag, string keyTag)
        {
            logger.I("OnKeyDestroy: keyTag = " + keyTag + " windowTag = " + windowTag);

#if DEBUG
            Stopwatch onKeyWatcher = Stopwatch.StartNew();
#endif

            _keyActionListener.OnKeyDestroy(windowTag, keyTag);

#if DEBUG
            onKeyWatcher.Stop();
            var timeExecuted = onKeyWatcher.ElapsedMilliseconds;
            logger.D("Time executed on key destroy = " + timeExecuted + "(ms)");
#endif
            logger.I("OnKeyDestroy done: keyTag = " + keyTag + " windowTag = " + windowTag);
        }
    }
}