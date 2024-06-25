<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616584/12.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4337)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Document Manager - Create a web browser UI

The WinForms Document Manager allows you to select the type of a container for documents ([DocumentManager.View.FloatingDocumentContainer](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.Docking2010.Views.BaseView.FloatingDocumentContainer)):

* If the `FloatingDocumentContainer` property is set to `SingleDocument`, a floating document is hosted within its individual container.
* If the `FloatingDocumentContainer` property is set to `DocumentsHost`, floating documents are hosted within a container to which other documents can be docked. Documents docked to a floating container are displayed as tabs.

This example demonstrates how to use this feature to create a web browser UI:

![WinForms Document Manager - Create a web browser UI](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-tabs-with-a-browser-like-functionality-using-documentmanager-e4337/12.1.8%2B/media/winforms-documant-manager-browser-ui.png)


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyBrowser.cs](./CS/MyBrowser.cs) (VB: [MyBrowser.vb](./VB/MyBrowser.vb))


## Documentation

* [Application UI Manager](https://docs.devexpress.com/WindowsForms/11359/controls-and-libraries/application-ui-manager)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-document-manager-web-browser-ui&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-document-manager-web-browser-ui&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
