using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using XamMvvmAndWebServices.Models;
using XamMvvmAndWebServices.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using XamMvvmAndWebServices.iOS.Views.Cells;

namespace XamMvvmAndWebServices.iOS.Helpers
{
    public class CustomerTableViewSource : MvxSimpleTableViewSource

    {
        //public CustomerTableViewSource(UITableView tableView)

        //        : base(tableView, typeof(CustomerCellView))

        //{
        //}

            
        public CustomerTableViewSource(UITableView tableView)
                : base(tableView, "CustomerCellView", "CustomerCellView")
            {
        }
        

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            base.RowSelected(tableView, indexPath);
          
        }

    }

    //public class CustomerTableViewSource:UITableViewSource
    //{

    //    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
    //    {
    //        var conference = _Customers[indexPath.Row];
    //        var cell = (MyCustomCell)tableView.DequeueReusableCell(MyCustomCell.Key);
    //        if (cell == null)
    //        {
    //            cell = MyCustomCell.Create();
    //        }
    //        cell.Model = conference;

    //        return cell;
    //    }

    //    public override nint RowsInSection(UITableView tableview, nint section)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}