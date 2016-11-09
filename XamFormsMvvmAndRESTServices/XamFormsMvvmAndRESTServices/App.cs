using Microsoft.WindowsAzure.MobileServices;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using XamMvvmAndWebServices.Interfaces;
using XamMvvmAndWebServices.ViewModels;

namespace XamMvvmAndWebServices
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {

            //search for all classes (ending with 'Service') and register them as LazySingleton
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            //Register API Service
            //Mvx.RegisterSingleton<IXamarinMVVMSampleWebAPIService>(new XamarinMVVMSampleWebAPIService());
            //*alernative - useful when the registered type requires constructor dependency injection
            //Mvx.ConstructAndRegisterSingleton<IXamarinMVVMSampleWebAPIService,XamarinMVVMSampleWebAPIService>();

            //*lazy singleton - not created untill someone asks for it
            //Mvx.RegisterSingleton<IXamarinMVVMSampleWebAPIService>(() => new XamarinMVVMSampleWebAPIService());
            //*lazy singleton registration - useful when the registered type requires constructor dependency injection
            //Mvx.LazyConstructAndRegisterSingleton<IXamarinMVVMSampleWebAPIService, XamarinMVVMSampleWebAPIService>();


            // every time someone needs an IFoo they will get a new one
            //Mvx.RegisterType<IFoo, Foo>();
            

            

            // Construct custom application start object
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();

            // request a reference to the constructed appstart object 
            var appStart = Mvx.Resolve<IMvxAppStart>();

            // register the appstart object
            RegisterAppStart(appStart);
        }
    }

    /// <summary>
    /// A class that implements the IMvxAppStart interface and can be used to customise
    /// the way an application is initialised
    /// </summary>
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        /// <summary>
        /// The login service.
        /// </summary>
        private readonly ILoginService _loginService;

        public AppStart(ILoginService loginService)
        {
            _loginService = loginService;
        }

        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public void Start(object hint = null)
        {
            // If your application uses a secure API this first call attempts to log the user into the application
            // using any credentials stored from a previous session.  If there are
            // none stored we should present the login screen, else go straight into the app
            if (_loginService.Login())
            {
                ShowViewModel<FirstViewModel>();
            }
            else
            {
                ShowViewModel<LoginViewModel>();
            }
        }
    }
}
