<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631349/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T130639)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MasterDetailSelectionHelper.cs](./CS/MasterDetailSelectionHelper.cs) (VB: [MasterDetailSelectionHelper.vb](./VB/MasterDetailSelectionHelper.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to select all detail rows when selecting a master row (CheckBoxRowSelection mode)


This example illustrates how to automatically make all detail rows selected when selecting a certain master row. For this purpose, the <strong>MasterDetailSelectionHelper</strong> is created on the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_ViewRegisteredtopic">GridControl.ViewRegistered</a> event. In this helper, <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_MasterRowExpandedtopic">GridView.MasterRowExpanded</a> and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_SelectionChangedtopic">ColumnView.SelectionChanged</a> events are handled to control selection within detail views and their parent views.

<br/>


