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

        public static ISecondKindDAL CreateSKDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ISecondKindDAL, SecondKindDAL>();
            return ioc.Resolve<ISecondKindDAL>();
        }

        public static ISecondKindBLL CreateSKBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<ISecondKindBLL>("SecondKindBLL");
        }

        public static IFirstKindDAL CreateFKDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IFirstKindDAL, FirstKindDAL>();
            return ioc.Resolve<IFirstKindDAL>();
        }

        public static IFirstKindBLL CreateFKBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<IFirstKindBLL>("FirstKindBLL");
        }

        private static UnityContainer CreateIOC(string name)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\vs文件\HR\HR - 副本\HR\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection use = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(use, name);
            return ioc;


        }
        public static IThirdKindDAL CreateTKDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IThirdKindDAL, ThirdKindDAL>();
            return ioc.Resolve<IThirdKindDAL>();
        }

        public static IThirdKindBLL CreateTKBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<IThirdKindBLL>("ThirdKindBLL");
        }

        public static IEngageResumeDAL CreateERDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IEngageResumeDAL, EngageResumeDAL>();
            return ioc.Resolve<IEngageResumeDAL>();
        }

        public static IEngageResumeBLL CreateERBLL()
        {
            UnityContainer ioc = CreateIOC("containerTwo");
            return ioc.Resolve<IEngageResumeBLL>("EngageResumeBLL");
        }
    }
}
