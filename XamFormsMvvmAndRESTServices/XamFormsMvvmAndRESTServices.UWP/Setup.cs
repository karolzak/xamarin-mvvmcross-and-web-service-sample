using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsUWP.Platform;
using Windows.UI.Xaml.Controls;
using XamFormsMvvmAndRESTServices;

namespace XamFormsMvvmAndRESTServices.UWP
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override void InitializeFirstChance()
        {
            //register platform specific implementations
            //example:
            //Mvx.RegisterSingleton<IScreenSize>(new WindowsPhoneScreenSize());

            base.InitializeFirstChance();
        }
        protected override IMvxApplication CreateApp()
        {
            return new XamFormsMvvmAndRESTServices.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        protected override IMvxIoCProvider CreateIocProvider()
        {
            return base.CreateIocProvider();
        }
    }
}