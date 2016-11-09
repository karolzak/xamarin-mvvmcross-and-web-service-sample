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

            Mvx.RegisterSingleton<IDialogService>(() => new DialogService());
        }
    }
}
