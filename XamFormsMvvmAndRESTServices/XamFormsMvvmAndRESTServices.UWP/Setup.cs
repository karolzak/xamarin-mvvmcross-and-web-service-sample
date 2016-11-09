using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsUWP.Platform;
using MvvmCross.WindowsUWP.Views;
using Windows.UI.Xaml.Controls;
using XamMvvmAndWebServices;
using XamMvvmAndWebServices.Interfaces;
using XamMvvmAndWebServices.UWP.Helpers;
using XamMvvmAndWebServices.UWP.Services;

namespace XamMvvmAndWebServices.UWP
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {

            var presenter = new CustomViewPresenter(rootFrame);

            return presenter;
        }
       

        protected override void InitializeFirstChance()
        {
           
            base.InitializeFirstChance();

            //register platform specific implementations
            //example:
            //Mvx.RegisterSingleton<IScreenSize>(new WindowsPhoneScreenSize());
            Mvx.RegisterSingleton<IDialogService>(() => new DialogService());
        }
        protected override IMvxApplication CreateApp()
        {
            return new XamMvvmAndWebServices.App();
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