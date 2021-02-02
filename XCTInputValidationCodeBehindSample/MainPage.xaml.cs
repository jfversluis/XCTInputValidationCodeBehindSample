using System.Text;
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

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!myValidation.IsValid)
            {
                var errorBuilder = new StringBuilder();

                foreach (var error in myValidation.Errors)
                {
                    if (error is string)
                    {
                        errorBuilder.AppendLine(error.ToString());
                    }
                }

                DisplayAlert("Error", errorBuilder.ToString(), "OK");
            }
            else
            {
                DisplayAlert("Success", "All valid!", "OK");
            }
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            if (!myEmailValidation.IsValid)
            {
                DisplayAlert("Error", "Email not valid", "OK");
            }
            else
            {
                DisplayAlert("Success", "All valid!", "OK");
            }
        }
    }
}
