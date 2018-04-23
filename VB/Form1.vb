Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TestMasterDetailSelection
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = GetData(10, 10)
			Dim TempMasterDetailSelectionHelper As MasterDetailSelectionHelper = New MasterDetailSelectionHelper(gridView1)
		End Sub

		Private Function GetData(ByVal custCount As Integer, ByVal orderCount As Integer) As BindingList(Of Customer)
			Dim custList As New BindingList(Of Customer)()
			Dim r As New Random()
			For i As Integer = 0 To custCount - 1
				Dim cust As Customer = custList.AddNew()
				cust.ID = i
				cust.Name = "Name" & i
				For j As Integer = 0 To orderCount - 1
					cust.Orders.Add(New Order() With {.ID = j})
					Dim productCount As Integer = r.Next(10)
					For k As Integer = 0 To productCount - 1
						cust.Orders(j).Products.Add(New Product() With {.ID = k, .Name = "Product" & k, .Price = r.Next(100)})
					Next k
				Next j
			Next i
			Return custList
		End Function

		Private Sub gridControl1_ViewRegistered(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles gridControl1.ViewRegistered
			Dim TempMasterDetailSelectionHelper As MasterDetailSelectionHelper = New MasterDetailSelectionHelper(TryCast(e.View, GridView))
		End Sub
	End Class

	Public Class Customer
		Public Sub New()
			_Orders = New BindingList(Of Order)()
		End Sub
		Private _ID As Integer = 0
		Private _Name As String = ""
		Private _Orders As BindingList(Of Order)

		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property
		Public Property Orders() As BindingList(Of Order)
			Get
				Return _Orders
			End Get
			Set(ByVal value As BindingList(Of Order))
				_Orders = value
			End Set
		End Property
	End Class

	Public Class Order
		Public Sub New()
			_Products = New BindingList(Of Product)()
		End Sub

		Private _ID As Integer = 0
		Private _Products As BindingList(Of Product)

		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property
		Public ReadOnly Property Sum() As Integer
			Get
'INSTANT VB NOTE: The local variable sum was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
				Dim sum_Renamed As Integer = 0
				For Each product As Product In _Products
					sum_Renamed += product.Price
				Next product
				Return sum_Renamed
			End Get
		End Property
		Public Property Products() As BindingList(Of Product)
			Get
				Return _Products
			End Get
			Set(ByVal value As BindingList(Of Product))
				_Products = value
			End Set
		End Property
	End Class

	Public Class Product
		Public Sub New()
		End Sub
		Private _ID As Integer = 0
		Private _Name As String = ""
		Private _Price As Integer = 0
		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property
		Public Property Price() As Integer
			Get
				Return _Price
			End Get
			Set(ByVal value As Integer)
				_Price = value
			End Set
		End Property


	End Class
End Namespace
