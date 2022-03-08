using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REWENIE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxViev_Page : ContentPage
    {
        BoxView box;
        public BoxViev_Page()
        {
            box = new BoxView
            {
                Color=Color.Red,
                CornerRadius=10,
                WidthRequest=150, HeightRequest=300,
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.CenterAndExpand
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            StackLayout st = new StackLayout
            {
                Children = { box }
            };
            Content = st;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            try
            {
                var dur = TimeSpan.FromSeconds(0.3);
                Vibration.Vibrate();
                box.Rotation += 10;
            }
            catch (Exception exp)
            {
              
            }
            box.Rotation += 10;
        }
    }
}