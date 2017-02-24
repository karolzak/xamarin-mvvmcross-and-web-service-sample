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
    public class EmployeeTableViewSource : MvxSimpleTableViewSource

    {
        //public EmployeeTableViewSource(UITableView tableView)

        //        : base(tableView, typeof(EmployeeCellView))

        //{
        //}
        public EmployeeTableViewSource(UITableView tableView)
                : base(tableView, "EmployeeCellView", "EmployeeCellView")
            {
        }
        
        
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            base.RowSelected(tableView, indexPath);
            
        }

        public override void AccessoryButtonTapped(UITableView tableView, NSIndexPath indexPath)
        {
            base.AccessoryButtonTapped(tableView, indexPath);
        }

        //One way to handle adding custom actions for rows
        //public override UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        //{
        //    UITableViewRowAction hiButton = UITableViewRowAction.Create(
        //       UITableViewRowActionStyle.Normal,
        //       "Edit",
        //       delegate {
        //           Console.WriteLine("Hello World!");
        //       });
        //    return new UITableViewRowAction[] { hiButton };

        //}
    }

    //public class EmployeeTableViewSource:UITableViewSource
    //{

    //    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
    //    {
    //        var conference = _employees[indexPath.Row];
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