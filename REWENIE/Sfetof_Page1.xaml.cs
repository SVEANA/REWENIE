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
                
                Color = Color.Red,
                CornerRadius = 50,
                WidthRequest = 150,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
                
                
            };
            yellowN = new BoxView
            {
                Color = Color.Yellow,
                CornerRadius = 50,
                WidthRequest = 150,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            greenN = new BoxView
            {
                Color = Color.Green,
                CornerRadius = 50,
                WidthRequest = 150,
                HeightRequest = 300,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
               
            };

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
    
        
            
        
            
        
                
            

            };
        
    

   