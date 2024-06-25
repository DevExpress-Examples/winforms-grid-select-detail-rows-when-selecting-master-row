<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631349/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T130639)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Select all detail rows when selecting a master row (Web style selection)

This example shows how to select all detail rows (within all nesting levels) when selecting a master row.

![WinForms Data Grid - Select all detail rows when selecting a master row](https://raw.githubusercontent.com/DevExpress-Examples/how-to-select-all-detail-rows-when-selecting-a-master-row-checkboxrowselection-mode-t130639/14.1.3%2B/media/winforms-grid-select-detail-rows.png)

The example handles the [GridControl.ViewRegistered](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.ViewRegistered) event to create a `MasterDetailSelectionHelper` object. The helper class handles [MasterRowExpanded](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.MasterRowExpanded) and [SelectionChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.SelectionChanged) events to select rows within detail views.


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MasterDetailSelectionHelper.cs](./CS/MasterDetailSelectionHelper.cs) (VB: [MasterDetailSelectionHelper.vb](./VB/MasterDetailSelectionHelper.vb))


## Documentation

* [Multiple Row and Cell Selection](https://docs.devexpress.com/WindowsForms/711/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-and-cell-selection)
* [Master-Detail Relationships](https://docs.devexpress.com/WindowsForms/3473/controls-and-libraries/data-grid/master-detail-relationships)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-select-detail-rows-when-selecting-master-row&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-select-detail-rows-when-selecting-master-row&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
