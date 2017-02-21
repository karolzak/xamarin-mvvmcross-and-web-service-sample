using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Droid.Views;
using XamMvvmAndWebServices.Interfaces;
using MvvmCross.Platform;
using XamMvvmAndWebServices.Droid.Services;

namespace XamMvvmAndWebServices.Droid
{
    //SHOW Mvx - Android setup
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            return base.CreateViewPresenter();

        }

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
