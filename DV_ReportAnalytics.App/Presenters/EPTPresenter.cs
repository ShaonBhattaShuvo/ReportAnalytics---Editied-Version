using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_ReportAnalytics.App
{
    internal class EPTPresenter : IWorkspacePresenter<IEPTWorkspaceView, IEPTSettingsView, IEPTDisplayView>
    {
        #region Fields
        private IEPTSettingsView _settingsView;
        private IEPTDisplayView _displayView;
        private IEPTWorkspaceView _workspaceView;
        private IWorkspaceViewsProvider<IEPTWorkspaceView, IEPTSettingsView, IEPTDisplayView> _viewsProvider; 
        #endregion

        #region IWorkspacePresenter members
        public IEPTSettingsView SettingsView => GetSettingsView();
        public IEPTDisplayView DisplayView => GetDisplayiew();
        public IEPTWorkspaceView WorkspaceView => GetWorkspaceView(); 
        public IWorkspaceViewsProvider<IEPTWorkspaceView, IEPTSettingsView, IEPTDisplayView> ViewsProvider
        {
            set { _viewsProvider = value; }
        }
        #endregion

        public EPTPresenter(IWorkspaceViewsProvider<IEPTWorkspaceView, IEPTSettingsView, IEPTDisplayView> viewsProvider)
        {
            _viewsProvider = viewsProvider;
        }

        #region Private methods
        private IEPTSettingsView GetSettingsView()
        {
            if (_settingsView == null)
            {
                // TODO: do some bindings
                _settingsView = _viewsProvider.CreateSettingsView();
            }

            return _settingsView;
        }

        private IEPTDisplayView GetDisplayiew()
        {
            if (_displayView == null)
            {
                // do some bindings
                _displayView = _viewsProvider.CreateDisplayView();
            }

            return _displayView;
        }

        private IEPTWorkspaceView GetWorkspaceView()
        {
            if (_workspaceView == null)
            {
                // TODO: do some bindings
                _workspaceView = _viewsProvider.CreateWorkspaceView();
            }

            return _workspaceView;
        } 
        #endregion
    }
}
