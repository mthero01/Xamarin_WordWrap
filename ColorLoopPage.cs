/** [!]. ABOUT
 * "ColorLoopPage"
 * by Matthew T. Theroux
 * for Baker College Online CS4010
 * Module 04 Assignment 02 .01
 * under Joan Zito
 * (c) 2018 February
 * -scrolls the list of colors
**/
/// [I]. HEAD
///  A] IMPORTS
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

///
namespace stack_scrolling
{
    ///
    class ColorLoopPage : ContentPage
    {
        /// constructor
        public ColorLoopPage()
        {
            // RAM saver
            double fontSizeLarge = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            /// a) Declare the colors, by name.
            var colors = new[]
            {
                new { value = Color.White, name = "White" },
                new { value = Color.Silver, name = "Silver" },
                new { value = Color.Gray, name = "Gray" },
                new { value = Color.Black, name = "Black" },
                new { value = Color.Red, name = "Red" },
                new { value = Color.Maroon, name = "Maroon" },
                new { value = Color.Yellow, name = "Yellow" },
                new { value = Color.Olive, name = "Olive" },
                new { value = Color.Lime, name = "Lime" },
                new { value = Color.Green, name = "Green" },
                new { value = Color.Aqua, name = "Aqua" },
                new { value = Color.Teal, name = "Teal" },
                new { value = Color.Blue, name = "Blue" },
                new { value = Color.Navy, name = "Navy" },
                new { value = Color.Pink, name = "Pink" },
                new { value = Color.Fuchsia, name = "Fuchsia" },
                new { value = Color.Purple, name = "Purple" }
              };// /dict 'colors'


            /// b) Fill a stack with colors.
            StackLayout stackLayoutOfColors = new StackLayout();
            foreach (var color in colors)
            {
                stackLayoutOfColors.Children.Add(new Label
                {
                    Text = color.name,
                    TextColor = color.value,
                    FontSize = fontSizeLarge
                };// /add  to stack
            }// next 'color'

            /// c) Create the Page.
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
            Content = stackLayoutOfColors;
        }// /cxtr (pg)

        /// O]
        protected override void OnStart() { }
        protected override void OnSleep() { }
        protected override void OnResume() { }

    }// /cla 'ColorLoopPage'
}// /ns 'stack_scrolling
/// [EoF].
