using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace XamFormsMvvmAndRESTServices.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.PageTitle);
            set.Bind(TextField).To(vm => vm.PageTitle);
           
            set.Apply();
        }
    }
}
