using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoGalery.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GaleryPage : ContentPage
    {
        public GaleryPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            this.Title = "Камера";
        }

        [Obsolete]
        private async void BtnCam_Clicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions()
                {
                    DefaultCamera = CameraDevice.Rear,
                    Directory = "Xamarin",
                    SaveToAlbum = true
                });

                if (photo != null)
                    imgCam.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
    }
}