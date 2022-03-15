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
    public partial class Sfetof_Page1 : ContentPage
    {
        BoxView redN, yellowN, greenN;
        bool on_off = false;
        Grid grid;
        Button btnn;
        public Sfetof_Page1()

        {
            grid = new Grid
            {
                 
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {

                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                      
                 }
            };
            redN = new BoxView
            {               
                Color = Color.Gray,
                CornerRadius = 60,
                WidthRequest = 500,
                HeightRequest = 500,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
                               
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            redN.GestureRecognizers.Add(tap);

            yellowN = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 60,
                WidthRequest = 300,
                HeightRequest = 500,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            TapGestureRecognizer tap1 = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped1;
            yellowN.GestureRecognizers.Add(tap1);

            greenN = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 60,
                WidthRequest = 300,
                HeightRequest = 500,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
               
            };
            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped2;
            redN.GestureRecognizers.Add(tap2);
            btnn = new Button
            {
                Text = "вкл!",
                TextColor = Color.Brown,
                BackgroundColor = Color.Aqua,
            };



            btnn.Clicked += Btnn_Clicked;
            grid.Children.Add(redN, 1, 0);
            grid.Children.Add(yellowN, 1, 1);
            grid.Children.Add(greenN, 1, 2);
            grid.Children.Add(btnn, 1, 3);
            Content = grid;
        }

        private void Tap_Tapped2(object sender, EventArgs e)
        {
            DisplayAlert("СТОЙ", "ВНИМАНИЕ", "ОК");
        }

        private void Tap_Tapped1(object sender, EventArgs e)
        {
            DisplayAlert("ИДИ", "НЕ ТОРОПИСЬ", "ОК");
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("СТОЙ", "ВНИМАНИЕ", "ОК");
        }

        private void Btnn_Clicked(object sender, EventArgs e)
        {

            if (on_off)
            {
                on_off = false;
                btnn.Text = "вкл";
            }
            else
            {
                on_off = true;
                btnn.Text = "выкл";
                Show();

            }
        }

        private async void Show()
        {
            
            while (on_off)
            {
                redN.Color = Color.Red;
                await Task.Delay(1000);
                for (int i = 0; i < 2; i++)
                {

                    redN.Color = Color.Red;
                    await Task.Delay(450);
                    redN.Color = Color.Gray;
                    await Task.Delay(450);
                    
                }
                if (on_off == false)
                {
                    break;
                }
                
                for (int i = 0; i < 3; i++)
                {
                    yellowN.Color = Color.Yellow;
                    await Task.Delay(450);
                    yellowN.Color = Color.Gray;
                    await Task.Delay(450);
                }
                if (on_off == false)
                {
                    break;
                }
                greenN.Color = Color.Green;
                await Task.Delay(2000);
                for (int i = 0; i < 2; i++)
                {
                    greenN.Color = Color.Green;
                    await Task.Delay(450);
                    greenN.Color = Color.Gray;
                    await Task.Delay(450);
                }
                if (on_off == false)
                {
                    break;
                }
                

                    
                
                
            }
        }

        




        }
    
        
  }
        
    

   