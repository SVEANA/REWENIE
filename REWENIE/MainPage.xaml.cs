using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace REWENIE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button sled_btn = new Button
            {
                Text = "Следующая страница!",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua,
            };
            sled_btn.Clicked += Sled_btn_Clicked;
            Button timer_btn = new Button
            {
                Text = "Timer!",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua,
            };
            timer_btn.Clicked += Timer_btn_Clicked;
            Button box_btn = new Button
            {
                Text = "BoxViev",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua,
            };
            box_btn.Clicked += Box_btn_Clicked;
            Button slider_btn = new Button
            {
                Text = "SLIDER",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua,
            };
            slider_btn.Clicked += Slider_btn_Clicked;
            Button sfetof_btn = new Button
            {
                Text = "LIGHTS",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua,
            };
            sfetof_btn.Clicked += sfetof_btn_Clicked;
            StackLayout st = new StackLayout
            {
                Children = { sled_btn, timer_btn, box_btn, slider_btn, sfetof_btn }
            };
            st.BackgroundColor = Color.FromRgb(50, 50, 50);
            Content = st;
        }

        private async void sfetof_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sfetof_Page1());
        }

        private async void Slider_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sllider_Page());
        }

        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxViev_Page());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Sled_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sled_Page());
        }
    }


    }
