using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRDAL;
using IHRBLL;
using IHRDAL;
using Unity;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;

namespace IOC
{
    public class IOCcotainer
    {

        public static Iconfig_public_charDAL Createconfig_public_charDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_public_charDAL, config_public_charDAL>();
            return ioc.Resolve<Iconfig_public_charDAL>();
        }

        public static Iconfig_public_charBLL Createconfig_public_charBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }
        
        public static Iconfig_major_kindDAL Createconfig_major_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_major_kindDAL, config_major_kindDAL>();
            return ioc.Resolve<Iconfig_major_kindDAL>();
        }

        public static Iconfig_major_kindBLL Createconfig_major_kindBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<Iconfig_major_kindBLL>("config_major_kindBLL");
        }

        public static Iconfig_majorDAL Createconfig_majorDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_majorDAL, config_majorDAL>();
            return ioc.Resolve<Iconfig_majorDAL>();
        }

        public static Iconfig_majorBLL Createconfig_majorBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<Iconfig_majorBLL>("config_majorBLL");
        }

        private static UnityContainer CreateIOC(string name)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\QQ\HR\HR\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection use = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(use, name);
            return ioc;
        }
    }
}
