﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text;
using System.Timers;
using Microsoft.Win32;

namespace NetOffice.DeveloperToolbox.ToolboxControls.AddinGuard
{
    class WatchController : INotifyPropertyChanged, IDisposable
    {
        #region Fields

        bool _readOnlyModeForMachineKeys;
        bool _isDisposed;
        bool _enabled;
        bool _firstRun;
        bool _stopFlag;
        bool _stopFlagAgreed;
        bool _restoreLastLoadBehavior;
        System.Timers.Timer _timer; 
        WatchNotify _notify;
        NotificationType _notifyType;
        int _activeLanguageID = 1031;
        AddinItems _addinItems;
        DisabledItems _disabledItems;

        #endregion

        #region Properties

        public bool ReadOnlyModeForMachineKeys
        {
            get
            {
                return _readOnlyModeForMachineKeys;
            }
            set
            {
                _readOnlyModeForMachineKeys = value;
            }
        }

        internal WatchNotify WatchNotify
        {
            get
            {
                return _notify;
            }
        }

        internal bool FirstRun
        {
            get
            {
                return _firstRun;
            }
        }

        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                RaisePropertyChanged(this);
            }
        }

        public NotificationType NotifyType
        {
            get
            {
                return _notifyType;
            }
            set
            {
                _notifyType = value;
                RaisePropertyChanged(this);
            }
        }

        public bool RestoreLastLoadBehavior
        {
            get
            {
                return _restoreLastLoadBehavior;
            }
            set
            {
                _restoreLastLoadBehavior = value;
                RaisePropertyChanged(this);
            }
        }

        public AddinItems AddinItems
        {
            get
            {
                return _addinItems;
            }
        }

        public int ActiveLanguageID
        {
            get
            {
                return _activeLanguageID;
            }
            set
            {
                _activeLanguageID = value;
            }
        }

        internal bool StopFlag
        {
            get
            {
                return _stopFlag;
            }
            set
            {
                _stopFlag = value;
                if (!_enabled)
                    _stopFlagAgreed = true;
            }
        }

        internal bool StopFlagAgreed
        {
            get
            {
                return _stopFlagAgreed;
            }
            set
            {
                _stopFlagAgreed = value;
            }
        }
    
        #endregion

        #region Construction

        public WatchController()
        {
            _notify = new WatchNotify(this);
            _addinItems = new AddinItems(this);
            _disabledItems = new DisabledItems(this);

            _timer = new System.Timers.Timer(2000);
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);

             // 32 Bit
            _addinItems.Add("Excel", Registry.LocalMachine, "Software\\Microsoft\\Office\\Excel\\Addins");
            _addinItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\Excel\\Addins");
            _addinItems.Add("Word", Registry.LocalMachine, "Software\\Microsoft\\Office\\Word\\Addins");
            _addinItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\Word\\Addins");
            _addinItems.Add("Outlook", Registry.LocalMachine, "Software\\Microsoft\\Office\\Outlook\\Addins");
            _addinItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\Outlook\\Addins");
            _addinItems.Add("PowerPoint", Registry.LocalMachine, "Software\\Microsoft\\Office\\PowerPoint\\Addins");
            _addinItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\PowerPoint\\Addins");
            _addinItems.Add("Access", Registry.LocalMachine, "Software\\Microsoft\\Office\\Access\\Addins");
            _addinItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\Access\\Addins");
            _addinItems.Add("MSProject", Registry.LocalMachine, "Software\\Microsoft\\Office\\MSProject\\Addins");
            _addinItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\MSProject\\Addins");
            _addinItems.Add("Visio", Registry.LocalMachine, "Software\\Microsoft\\Office\\Visio\\Addins");
            _addinItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\Visio\\Addins");

            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\9.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\10.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\11.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\12.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\14.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Microsoft\\Office\\15.0\\Visio\\Resiliency\\DisabledItems");

            // 64 Bit
            _addinItems.Add("Excel", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\Excel\\Addins");
            _addinItems.Add("Excel", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\Excel\\Addins");
            _addinItems.Add("Word", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\Word\\Addins");
            _addinItems.Add("Word", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\Word\\Addins");
            _addinItems.Add("Outlook", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\Outlook\\Addins");
            _addinItems.Add("Outlook", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\Outlook\\Addins");
            _addinItems.Add("PowerPoint", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\PowerPoint\\Addins");
            _addinItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\PowerPoint\\Addins");
            _addinItems.Add("Access", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\Access\\Addins");
            _addinItems.Add("Access", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\Access\\Addins");
            _addinItems.Add("MSProject", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\MSProject\\Addins");
            _addinItems.Add("MSProject", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\MSProject\\Addins");
            _addinItems.Add("Visio", Registry.LocalMachine, "Software\\Wow6432Node\\Microsoft\\Office\\Visio\\Addins");
            _addinItems.Add("Visio", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\Visio\\Addins");

            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Excel", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Excel\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Word", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Word\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Outlook", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("PowerPoint", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Outlook\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("Access", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Access\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("MSProject", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\MSProject\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\9.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\10.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\11.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Visio\\Resiliency\\DisabledItems");
            _disabledItems.Add("Visio", Registry.CurrentUser, "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Visio\\Resiliency\\DisabledItems");

            StartWatch();
        }

        #endregion

        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;

        internal void RaisePropertyChanged(WatchController item)
        {
            if (null != PropertyChanged)
                PropertyChanged(item, new PropertyChangedEventArgs(""));
        }

        internal void RaisePropertyChanged(DisabledKey item)
        {
            if (null != PropertyChanged)
                PropertyChanged(item, new PropertyChangedEventArgs(""));
        }

        internal void RaisePropertyChanged(AddinsKey item)
        {
            if (null != PropertyChanged)
                PropertyChanged(item, new PropertyChangedEventArgs(""));
        }

        internal void RaiseError(Exception exception)
        {
            if (null != PropertyChanged)
                PropertyChanged(exception, new PropertyChangedEventArgs(""));
        }

        #endregion

        #region Worker Trigger

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_isDisposed)
                return;

             try
             {
                 if (_enabled)
                 {
                     while (_stopFlag)
                         _stopFlagAgreed = true;
                     _stopFlagAgreed = false;

                     foreach (DisabledKey item in _disabledItems)
                     {
                         RegistryChangeInfo changeInfo = null;
                         NotifyKind kind = item.CheckChangedValueCount(ref changeInfo);
                         if (kind != NotifyKind.Nothing)
                             _notify.ShowNotification(item, kind, changeInfo);
                     }

                     foreach (AddinsKey addins in _addinItems)
                     {
                         RegistryChangeInfo changeInfo = null;
                         NotifyKind kind = addins.CheckChangedSubKeys(ref changeInfo);
                         if (kind != NotifyKind.Nothing)
                             _notify.ShowNotification(addins, kind, changeInfo);

                         foreach (AddinKey addin in addins.Addins)
                         {
                             kind = addin.CheckChangedValues(ref changeInfo);
                             if (kind != NotifyKind.Nothing)
                                 _notify.ShowNotification(addin, kind, changeInfo);
                         }
                     }

                     _firstRun = false;
                 }
             }
             catch (Exception exception)
             {
                 RaiseError(exception);
             }                          
        }

        #endregion

        #region Methods

        public void StartWatch()
        {
            if (!_timer.Enabled)
            { 
                _firstRun = true;
                _timer.Enabled = true;
            }
        }

        #endregion

        #region Private Methods

        private bool CompareValueKinds(AddinKey item, RegistryValueKind kindToCompare)
        {
            return true;
        }

        private void ChangeRegistryValue(AddinsKey item)
        {
            RegistryKey key = item.RootKey.OpenSubKey(item.RegistryPath, true);
            // key.SetValue(item.SpecificValueName, item.SpecificValueMustHave);
            key.Close();
        }

        private void DeleteRegistryValue(AddinsKey item)
        {
            RegistryKey key = item.RootKey.OpenSubKey(item.RegistryPath, true);
            //key.DeleteValue(item.SpecificValueName);
            key.Close();
        }

        private void CreateRegistryKey(AddinsKey item)
        {
            RegistryKey key = item.RootKey.CreateSubKey(item.RegistryPath);
            key.Close();

        }

        private void CreateRegistryValue(AddinsKey item)
        {
            RegistryKey key = item.RootKey.OpenSubKey(item.RegistryPath, true);
            //key.SetValue(item.SpecificValueName, item.SpecificValueMustHave, item.SpecificValueKindMustHave);
            key.Close();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            _isDisposed = true;
            _timer.Enabled = false;
        }

        #endregion
    }
}
