using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Alerts.ModelViews
{
    public class MainViewModel
    {
        #region ViewModel
        public LoginViewModel Login { get; set; }
        #endregion

        #region Contructores
        public MainViewModel() { this.Login = new LoginViewModel(); }

        #endregion

    }
}
