using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_ReportAnalytics.App.Interfaces;

namespace DV_ReportAnalytics.App
{
    internal class EPTPresenter : IWorkspacePresenter
    {
        #region Fields
        private IEPTSettingsView _settingsView;
        private IEPTDisplayView _displayView;
        private IEPTWorkspaceView _workspaceView;
        private IEPTViewsProvider _viewsProvider;
        #endregion

        #region IWorkspacePresenter members
        public IView SettingsView
        {
            get
            {
                if (_settingsView == null)
                {
                    // TODO: do some bindings
                    _settingsView = _viewsProvider.CreateSettingsView();
                }

                return _settingsView;
            }
        }
        public IView DisplayView
        {
            get
            {
                if (_displayView == null)
                {
                    // do some bindings
                    _displayView = _viewsProvider.CreateDisplayView();
                }

                return _displayView;
            }
        }
        public IView WorkspaceView
        {
            get
            {
                if (_workspaceView == null)
                {
                    // TODO: do some bindings
                    _workspaceView = _viewsProvider.CreateWorkspaceView();
                }

                return _workspaceView;
            }
        }

        public void Export()
        {

        }
        #endregion

        #region Constructor
        public EPTPresenter(IEPTViewsProvider viewsProvider)
        {
            _viewsProvider = viewsProvider;
        } 
        #endregion
    }
}
