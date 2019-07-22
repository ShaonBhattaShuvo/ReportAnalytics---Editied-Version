namespace DV_ReportAnalytics.App.Interfaces
{
    public interface IEPTSettingsView : IView
    {
        //string ReportName { get; set; }
        //string InputSheetName { get; set; }
        //string OutputSheetName { get; set; }
        //string Parameter { get; set; }
        //string ParameterColumn { get; set; }
        //string ValueColumn { get; set; }
        //char Delimiter { get; set; }
    }

    public interface IEPTDisplayView : IView
    {
        //int RowInterpolation { get; set; }
        //int ColumnInterpolation { get; set; }
        //int MaximumItemsPerRow { get; set; }
    }

    public interface IEPTWorkspaceView : IView
    {
        System.Windows.Forms.Control WorkbookView { get; }
    }

    public interface IEPTViewsProvider : IWorkspaceViewsProvider
    {
    }
}
