using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMasterDetailSelection
{
    public class MasterDetailSelectionHelper
    {
        public MasterDetailSelectionHelper(GridView gridView)
        {
            _GridView = gridView;
            _GridView.MasterRowExpanded += _GridView_MasterRowExpanded;
            _GridView.SelectionChanged += _GridView_SelectionChanged;
        }

        void _GridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (_GridView.IsDetailView)
            {
                int masterRowHandle = _GridView.SourceRowHandle;
                if (_GridView.GetSelectedRows().Length == _GridView.RowCount)
                {
                    (_GridView.ParentView as GridView).SelectRow(masterRowHandle);
                }
                else if (_GridView.GetSelectedRows().Length == 0)
                    (_GridView.ParentView as GridView).UnselectRow(masterRowHandle);
            }
            if (_GridView.IsMasterRow(e.ControllerRow) || e.ControllerRow == GridControl.InvalidRowHandle)
            {
                UpdateSelection(e.ControllerRow);
            }
            if (e.Action == CollectionChangeAction.Refresh)
            {
                foreach (BaseView view in _GridView.GridControl.Views)
                {
                    if (view.IsDetailView)
                    {
                        int masterRowHandle = view.SourceRowHandle;
                        UpdateSelection(masterRowHandle);
                    }
                }
            }
        }

        void _GridView_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            UpdateSelection(e.RowHandle);
        }

        void UpdateSelection(int masterRowHandle)
        {
            GridView detailView = _GridView.GetDetailView(masterRowHandle, 0) as GridView;
            if (detailView != null)
            {
                if (_GridView.IsRowSelected(masterRowHandle))
                {
                    detailView.SelectAll();
                }
                else
                {
                    detailView.ClearSelection();
                }
            }

        }

        GridView _GridView;
    }
}
