/** [!]. ABOUT
 * "Sized Box View"
 * by Matthew T. Theroux
 * for Baker College Online CS4010
 * Module 04 Assignment 02 'E'
 * under Joan Zito
 * (c) 2018 February
 * -creates a 'BoxView'.
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
    public class SizedBoxViewPage : ContentPage
    {
        private static const double fontSizeMedium = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
        private static const double fontSizeLarge = Device.GetNamedSize(NamedSize.Large, typeof(Label));

        ///
        public SizedBoxViewPage()
        {
            Padding = new Thickness(20);
            Content = new BoxView
            {
                /// Sizes
                WidthRequest = 200,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

                /// Colors
                OutlineColor = Color.Accent,
                BackgroundColor = Color.Teal,
                Color = Color.Navy
            };// /bxVw
        }// /cxtr

        /// O]
        protected override void OnStart() { }
        protected override void OnSleep() { }
        protected override void OnResume() { }

    }// /cla 'SizedBoxViewPage'
}// /ns 'stack_scrolling'
 /// [EoF].