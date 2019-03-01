using System;

namespace CRM_Alerts.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {

        #region Atributos
        private string pass;

        private Boolean isRunning;

        private Boolean isEnabled;
        #endregion

        #region Properties
        public string Email { get; set; }

        public string Pass
        {
            get { return this.pass; }
            set { this.SetValue(ref this.pass, value); }
        }

        public Boolean IsRunning
        {
            get { return this.isRunning; }
            set { this.SetValue(ref this.isRunning, value); }
        }

        public Boolean IsRemembered { get; set; }

        public Boolean IsEnabled
        {
            get { return this.isEnabled; }
            set { this.SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands Properties
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes de ingresar un correo",
                        "Aceptar"
                    );
                return;
            }
            if (string.IsNullOrEmpty(this.Pass))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes de ingresar una contraseña",
                        "Aceptar"
                    );
                this.Pass = string.Empty;
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "jesus" || this.Pass != "6060")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert
                (
                    "Error",
                    "Credenciales invalidas!!!!",
                    "Aceptar"
                );
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.DisplayAlert
            (
                "Ok",
                "Bienvenido jesus",
                "Aceptar"
            );



        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsRunning = false;
            this.IsEnabled = true;
        }
        #endregion
    }
}
