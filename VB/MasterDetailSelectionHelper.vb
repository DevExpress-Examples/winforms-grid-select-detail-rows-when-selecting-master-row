Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace TestMasterDetailSelection
	Public Class MasterDetailSelectionHelper
		Public Sub New(ByVal gridView As GridView)
			_GridView = gridView
			AddHandler _GridView.MasterRowExpanded, AddressOf _GridView_MasterRowExpanded
			AddHandler _GridView.SelectionChanged, AddressOf _GridView_SelectionChanged
		End Sub

		Private Sub _GridView_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
			If _GridView.IsDetailView Then
				Dim masterRowHandle As Integer = _GridView.SourceRowHandle
				If _GridView.GetSelectedRows().Length = _GridView.RowCount Then
					TryCast(_GridView.ParentView, GridView).SelectRow(masterRowHandle)
				ElseIf _GridView.GetSelectedRows().Length = 0 Then
					TryCast(_GridView.ParentView, GridView).UnselectRow(masterRowHandle)
				End If
			End If
			If _GridView.IsMasterRow(e.ControllerRow) OrElse e.ControllerRow = GridControl.InvalidRowHandle Then
				UpdateSelection(e.ControllerRow)
			End If
			If e.Action = CollectionChangeAction.Refresh Then
				For Each view As BaseView In _GridView.GridControl.Views
					If view.IsDetailView Then
						Dim masterRowHandle As Integer = view.SourceRowHandle
						UpdateSelection(masterRowHandle)
					End If
				Next view
			End If
		End Sub

		Private Sub _GridView_MasterRowExpanded(ByVal sender As Object, ByVal e As CustomMasterRowEventArgs)
			UpdateSelection(e.RowHandle)
		End Sub

		Private Sub UpdateSelection(ByVal masterRowHandle As Integer)
			Dim detailView As GridView = TryCast(_GridView.GetDetailView(masterRowHandle, 0), GridView)
			If detailView IsNot Nothing Then
				If _GridView.IsRowSelected(masterRowHandle) Then
					detailView.SelectAll()
				Else
					detailView.ClearSelection()
				End If
			End If

		End Sub

		Private _GridView As GridView
	End Class
End Namespace
