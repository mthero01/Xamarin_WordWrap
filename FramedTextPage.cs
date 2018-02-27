/** [!]. ABOUT
 * "Framed Text"
 * by Matthew T. Theroux
 * for Baker College Online CS4010
 * Module 04 Assignment 02 'd'
 * under Joan Zito
 * (c) 2018 February
 * -creates a page with a frame with a label.
**/
/// [I]. HEAD
///  A] IMPORTS
using System;
using System.Text;
using System.Collections.Generic;
using Systems.Linq;

using Xamarin.Forms;

///
namespace stack_scrolling
{
    ///
    public class FramedTextPage : ContentPage
    {
        private static const double fontSizeMedium = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
        private static const double fontSizeLarge = Device.GetNamedSize(NamedSize.Large, typeof(Label));

        ///
        public FramedTextPage()
        {
            Padding = new Thickness(20);
            Content = new Frame
            {
                OutlineColor = Color.Accent,
                BackgroundColor = Color.Teal,
                Content = new Label
                {
                    Text = "I've been *Framed!*",
                    TextColor = Color.Blue,
                    FontSize = fontSizeLarge,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                }// /lbl
            };// /fra
        }// /cxtr

         /// O]
        protected override void OnStart() { }
        protected override void OnSleep() { }
        protected override void OnResume() { }

    }// /cla 'FramedTextPage'
}// /ns 'stack_scrolling'
 /// [EoF].