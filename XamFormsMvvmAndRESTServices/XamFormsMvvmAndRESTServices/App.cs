using Microsoft.WindowsAzure.MobileServices;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace XamFormsMvvmAndRESTServices
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
            


            RegisterAppStart<ViewModels.FirstViewModel>();
            
            
        }
    }
}
