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
        public static ILoginDAL CreateStudenDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ILoginDAL, LoginDAL>();
            return ioc.Resolve<ILoginDAL>();
        }

        public static ILoginBLL CreateStudentBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<ILoginBLL>("LoginBLL");
        }

        private static UnityContainer CreateIOC(string name)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"E:\QQ文件\hr一\HR\HR\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection use = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(use, name);
            return ioc;
        }

        public static Ipublic_charDAL Createpublic_charDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Ipublic_charDAL, public_charDAL>();
            return ioc.Resolve<Ipublic_charDAL>();
        }

        public static Ipublic_charBLL Createpublic_charBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<Ipublic_charBLL>("public_charBLL");
        }


        public static Iconfig_file_third_kindDAL Createconfig_file_third_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_third_kindDAL, config_file_third_kindDAL>();
            return ioc.Resolve<Iconfig_file_third_kindDAL>();
        }

        public static Iconfig_file_third_kindBLL Createconfig_file_third_kindBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<Iconfig_file_third_kindBLL>("config_file_third_kindBLL");
        }



        public static Imajor_changeDAL Createmajor_changeDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Imajor_changeDAL, major_changeDAL>();
            return ioc.Resolve<Imajor_changeDAL>();
        }

        public static Imajor_changeBLL Createmajor_changeBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<Imajor_changeBLL>("major_changeBLL");
        }
    }
}
