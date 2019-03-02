using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Alerts.ViewModels
{
    public class MainViewModel
    {
        #region ViewModel
        public LoginViewModel Login { get; set; }

        public DashboardViewModel Dash { get; set; }
        #endregion

        #region Contructores
            public MainViewModel() { this.Login = new LoginViewModel(); }

        #endregion

        #region Singleton
            private static MainViewModel instance;
            public static MainViewModel Getinstance()
            {
                if (instance == null)
                {
                return new MainViewModel();
                }
                return instance;
            }
        #endregion

    }
}
