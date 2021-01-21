using System;
using System.Configuration;

namespace QRWebCMS.Web.Islemler.Helpers
{
    public class ConfigHelper
    {
        public static T Get<T>(string key)
        {
            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
        }

        //public static bool Set<T>(string key, string value)
        //{
        //    //return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
        //    ConfigurationManager.AppSettings.Get(key).Replace()

        //    return false;
        //}
    }
}