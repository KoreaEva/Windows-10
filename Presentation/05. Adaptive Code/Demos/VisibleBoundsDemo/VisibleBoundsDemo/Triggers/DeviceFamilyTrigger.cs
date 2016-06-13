﻿using Windows.UI.Xaml;

namespace VisibleBoundsDemo.Triggers
{
    public class DeviceFamilyTrigger : StateTriggerBase
    {
        //private variables
        private string _deviceFamily;
 
        //Public property
        public string DeviceFamily
        {
            get
            {
                return _deviceFamily;
            }
            set
            {
                _deviceFamily = value;
                var qualifiers = Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().QualifierValues;
                if (qualifiers.ContainsKey("DeviceFamily"))
                    SetActive(qualifiers["DeviceFamily"] == _deviceFamily);
                else
                    SetActive(false);
            }
        }
    }
}
