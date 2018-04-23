# How to select all detail rows when selecting a master row (CheckBoxRowSelection mode)


This example illustrates how to automatically make all detail rows selected when selecting a certain master row. For this purpose, the <strong>MasterDetailSelectionHelper</strong> is created on the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_ViewRegisteredtopic">GridControl.ViewRegistered</a> event. In this helper, <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_MasterRowExpandedtopic">GridView.MasterRowExpanded</a> and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_SelectionChangedtopic">ColumnView.SelectionChanged</a> events are handled to control selection within detail views and their parent views.

<br/>


