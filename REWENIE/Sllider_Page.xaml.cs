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
    public partial class Sllider_Page : ContentPage
    {
        BoxView boxView;
        Slider redSlider;
        Slider greenSlider;
        Slider blueSlider;
        private Button btn_nazad;
        public Sllider_Page()
        {
            Style labelStyle = new Style(typeof(Label))
            {
                Setters =
            {
                new Setter { Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }
            }
            };
            Resources.Add(labelStyle);
            Grid tGrid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition{Height=new GridLength(4,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
            },
                ColumnDefinitions =
                {
                    
                    new ColumnDefinition()
                }
            };
            boxView = new BoxView { Color = Color.Black };
            tGrid.Children.Add(boxView,0,0);
            //Grid childGrid = new Grid
            //{
            //    Margin = new Thickness(20),
            //    RowDefinitions =
            //{
            //    new RowDefinition(),
            //    new RowDefinition(),
            //    new RowDefinition(),
            //    new RowDefinition(),
            //    new RowDefinition(),
            //    new RowDefinition()
            //}
            //};
            DoubleToIntConverter doubleToInt = new DoubleToIntConverter();

            redSlider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                MinimumTrackColor=Color.Black,
                MaximumTrackColor=Color.White

            };
            redSlider.ValueChanged += OnSliderValueChanged;
            tGrid.Children.Add(redSlider, 0, 1);

            //Label redLabel = new Label();
            //redLabel.SetBinding(Label.TextProperty, new Binding("Value", converter: (IValueConverter)doubleToInt, converterParameter: "255", stringFormat: "Red = {0}", source: redSlider));
            //Grid.SetRow(redLabel, 1);
            //tGrid.Children.Add(boxView, 0, 0);

            greenSlider = new Slider();
            greenSlider.ValueChanged += OnSliderValueChanged;
            Grid.SetRow(greenSlider, 2);
            tGrid.Children.Add(greenSlider, 0, 2);

            //Label greenLabel = new Label();
            //greenLabel.SetBinding(Label.TextProperty, new Binding("Value", converter: (IValueConverter)doubleToInt, converterParameter: "255", stringFormat: "Green = {0}", source: greenSlider));
            //Grid.SetRow(greenLabel, 3);
            //tGrid.Children.Add(boxView, 0, 0);

            blueSlider = new Slider();
            blueSlider.ValueChanged += OnSliderValueChanged;
            Grid.SetRow(blueSlider, 4);
            tGrid.Children.Add(blueSlider, 0, 3);

            //Label blueLabel = new Label();
            //blueLabel.SetBinding(Label.TextProperty, new Binding("Value", converter: (IValueConverter)doubleToInt, converterParameter: "255", stringFormat: "Blue = {0}", source: blueSlider));
            //Grid.SetRow(blueLabel, 5);
            //childGrid.Children.Add(blueLabel);
            //tGrid.Children.Add(childGrid, 0, 0);

            Title = "ПОКАЗ";
            Content = tGrid;
            }
                    

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            boxView.Color = Color.FromRgb((int)redSlider.Value, 
                                          (int)greenSlider.Value, 
                                          (int)blueSlider.Value);
        }
    }
};