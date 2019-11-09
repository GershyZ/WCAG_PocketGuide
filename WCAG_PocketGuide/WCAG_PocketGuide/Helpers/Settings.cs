using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using WCAG_PocketGuide.Models;
namespace WCAG_PocketGuide.Helpers
{

    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    /// 

    /*Hi, to store and save preferences in the app i'm using Xamarin Settings Plugin. Its a good nuget which makes everything 
     much easier.
     **/
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private const string CriteriaKey = "criteria_key";
        private static string CriteriaDefault
        {
            get
            {
                List<Criteria> list = new List<Criteria>();
                return JsonConvert.SerializeObject(list);
            }
        }

        #endregion 


        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

        public static string CriteriaSetting
        {
            get
            {
                return AppSettings.GetValueOrDefault(CriteriaKey, CriteriaDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(CriteriaKey, value);
            }
        }
    }
}

