using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REWENIE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sled_Page : ContentPage 
    {
        private Editor editor;
        Label lbl;
        private Button btn_nazad;
        public Sled_Page()
        {
            //InitializeComponent();
            editor = new Editor
            {
                Placeholder="Напиши",
                PlaceholderColor = Color.BlueViolet,
                BackgroundColor = Color.Black,
                TextColor = Color.AliceBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Editor)),
            };
            editor.TextChanged += Editor_TextChanged;
            lbl = new Label
            {
                Text = "Сколько букв О?",
                TextColor = Color.AliceBlue,
                FontSize=40
            };
            btn_nazad = new Button
            {
                Text = "Обратно",
                VerticalOptions=LayoutOptions.EndAndExpand
            };
            btn_nazad.Clicked += Btn_nazad_Clicked;
            StackLayout st = new StackLayout();
            st.BackgroundColor = Color.FromRgb(10, 50, 50);
            st.Children.Add(editor);
            st.Children.Add(lbl);
            st.Children.Add(btn_nazad);
            Content = st;
        }

        private async void Btn_nazad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        int i = 0;
        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            editor.TextChanged -= Editor_TextChanged;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';
            if (key =='O')
            {
                i++;
                lbl.Text = key.ToString() + ": " + i.ToString();

            }
            editor.TextChanged += Editor_TextChanged;
        }
    }
}