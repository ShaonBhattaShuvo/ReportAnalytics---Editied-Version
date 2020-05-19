namespace DV_ReportAnalytics.App.Presenters
{
    public class EPTPresenterProxy
    {
        public string GetSurfaceHTML(string filePath)
        {
            // Shaon
            EPTPresenter presenter = new EPTPresenter();
            presenter.InitModelFromFile(filePath);
            return presenter.GetHtmlTable();
        }
        public void SaveExcel(string filePath) {
            EPTPresenter presenter = new EPTPresenter();
            presenter.InitModelFromFile(filePath);
            presenter.DrawTablesCLI(filePath);
            //presenter.Export(filePath);
        }
    }
}
 