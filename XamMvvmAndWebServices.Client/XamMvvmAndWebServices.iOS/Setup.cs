using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using UIKit;
using XamMvvmAndWebServices;
using XamMvvmAndWebServices.Interfaces;
using XamMvvmAndWebServices.iOS.Helpers;
using XamMvvmAndWebServices.iOS.Services;

namespace XamMvvmAndWebServices.iOS
{
    public class Setup : MvxIosSetup
    {
        MvxApplicationDelegate applicationDelegate;
        UIWindow window;
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
            this.applicationDelegate = applicationDelegate;
            this.window = window;
        }
        
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
            this.applicationDelegate = applicationDelegate;
        }
        
        protected override IMvxIosViewPresenter CreatePresenter()
        {
            //custom view presenter to gain better control over navigation
            var presenter = new CustomViewPresenter(applicationDelegate,window);

            return presenter;
        }
       
        //    return base.CreatePresenter();
        //}

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
        
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            //SHOW IDialogService - register Adroid implementation
            Mvx.RegisterSingleton<IDialogService>(() => new DialogService());
        }
    }
}
