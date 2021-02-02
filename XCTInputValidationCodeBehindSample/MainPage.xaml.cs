using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XCTInputValidationCodeBehindSample
{
    public partial class MainPage : ContentPage
    {
        private bool emailValid;

        public bool EmailValid
        {
            get => emailValid;
            set
            {
                emailValid = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        // Multi validation
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!myMultiValidation.IsValid)
            {
                var errorBuilder = new StringBuilder();

                foreach (var error in myMultiValidation.Errors)
                {
                    if (error is string)
                    {
                        errorBuilder.AppendLine(((string)error).ToString());
                    }

                    await DisplayAlert("Error", errorBuilder.ToString(), "OK");
                }
            }
            else
            {
                await DisplayAlert("Hooray", "All valid", "OK");
            }
        }

        // Email validation
        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            if (!myEmailValidation.IsValid)
            {
                await DisplayAlert("Error", "Email not valid", "OK");
            }
            else
            {
                await DisplayAlert("Hooray", "All valid", "OK");
            }
        }
    }
}
