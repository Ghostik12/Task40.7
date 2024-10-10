using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoGalery.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PineCodePage : ContentPage
    {
        private const string PIN_KEY = "pinecode";
        private string pinecode;

        public PineCodePage()
        {
            InitializeComponent();

            if (Preferences.Get(PIN_KEY, null) != null)
            {
                MessageLabel.Text = "";
                SavePinButton.IsVisible = false;
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            pinecode = PineEntry.Text;

            if (string.IsNullOrEmpty(pinecode) || pinecode.Length < 5)
            {
                MessageLabel.Text = "Пин код должен быть больше 5 цифр.";
                return;
            }

            Preferences.Set(PIN_KEY, pinecode);
            SavePinButton.IsVisible = false;
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (PineEntry.Text == Preferences.Get(PIN_KEY, pinecode))
            {
                Navigation.PushAsync(new GaleryPage());
            }
            else
            {
                MessageLabel.Text = "Неправильный пароль!";
            }
        }
    }
}