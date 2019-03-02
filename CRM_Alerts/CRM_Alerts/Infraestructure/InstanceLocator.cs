using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Alerts.Infraestructure
{
    using CRM_Alerts.ViewModels;
    public class InstanceLocator
    {
        #region Propiedades
       
        public MainViewModel Main { get; set; }
        #endregion

        #region Contructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
