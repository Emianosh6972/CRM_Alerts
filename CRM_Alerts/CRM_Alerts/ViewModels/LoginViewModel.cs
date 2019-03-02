using System;

namespace CRM_Alerts.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using CRM_Alerts.Views;

    public class LoginViewModel : BaseViewModel
    {

        #region Atributos
            private string email;
            private string pass;
            private Boolean isRunning;
            private Boolean isEnabled;
        #endregion

        #region Propiedades
            public string Email
            {
                get { return this.email; }
                set { this.SetValue(ref this.email, value); }
            }

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

        #region Propiedades de Comandos
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

                if (this.Email != "admin" || this.Pass != "6060")
                {
                    this.IsRunning = false;
                    this.IsEnabled = true;
                }

                this.IsRunning = false;
                this.IsEnabled = true;

                this.Email = string.Empty;
                this.Pass = string.Empty;

                MainViewModel.Getinstance().Dash = new DashboardViewModel();
                await Application.Current.MainPage.Navigation.PushAsync(new DashboardPage());
            }
        #endregion

        #region Constructores
            public LoginViewModel()
            {
                this.IsRemembered = true;
                this.IsRunning = false;
                this.IsEnabled = true;

                this.Email = "admin";
                this.Pass = "6060";
            }
        #endregion
    }
}
