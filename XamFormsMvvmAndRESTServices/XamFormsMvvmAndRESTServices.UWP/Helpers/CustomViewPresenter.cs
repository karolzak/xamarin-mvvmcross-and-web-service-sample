using MvvmCross.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.WindowsUWP.Views;
using XamMvvmAndWebServices.ViewModels;
using Windows.UI.Xaml.Controls;

namespace XamMvvmAndWebServices.UWP.Helpers
{
    public class CustomViewPresenter : MvxWindowsViewPresenter
    {
        IMvxWindowsFrame _rootFrame;

        public CustomViewPresenter(IMvxWindowsFrame rootFrame)
            : base(rootFrame)
        {
            _rootFrame = rootFrame;

        }
        public override void Show(MvxViewModelRequest request)
        {

            base.Show(request);
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            if (hint is ClearBackStackHint)
            {
                ((Frame)_rootFrame.UnderlyingControl).BackStack.Clear();

            }

            base.ChangePresentation(hint);
        }
    }
}

