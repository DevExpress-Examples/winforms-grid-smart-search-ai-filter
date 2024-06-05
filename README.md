<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/810333307/24.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1236349)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Smart Search AI Filter

This example integrates semantic similarity search (powered by [.NET Smart Components](https://devblogs.microsoft.com/dotnet/introducing-dotnet-smart-components/)) in the DevExpress Winforms Data Grid control. For example, you can search for the word "furniture" within the Data Grid, and the implementation returns records such as "chair", "table", "sofa", "wardrobe", etc. 

![](https://community.devexpress.com/blogs/winforms/Smart_AI_Filter_iHEYORqKb0.gif)

Implemented [Local Embeddings](https://github.com/dotnet-smartcomponents/smartcomponents/blob/main/docs/local-embeddings.md) allow you to run this project locally without external AI services. It downloads an ML model when you first build your application (you can configure which model is downloaded). Refer to the following blog post for more information and the complete tutorial: [WinForms — How to Integrate Semantic Similarity Search in the Grid Control (Powered by Embedding Models)](https://community.devexpress.com/blogs/winforms/archive/2024/06/04/winforms-how-to-integrate-semantic-similarity-search-in-the-grid-control-powered-by-smartcomponents-local-embeddings.aspx).

## Files to Review

- [MainForm.cs](./CS/MainForm.cs)
- [Item.cs](./CS/Item.cs)

## Documentation

- [WinForms — How to Integrate Semantic Similarity Search in the Grid Control (Powered by Embedding Models)](https://community.devexpress.com/blogs/winforms/archive/2024/06/04/winforms-how-to-integrate-semantic-similarity-search-in-the-grid-control-powered-by-smartcomponents-local-embeddings.aspx)
- [Introducing .NET Smart Components – AI-powered UI controls](https://devblogs.microsoft.com/dotnet/introducing-dotnet-smart-components/)
- [Local Embeddings](https://github.com/dotnet-smartcomponents/smartcomponents/blob/main/docs/local-embeddings.md)
- [ColumnView.CustomRowFilter](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomRowFilter)
