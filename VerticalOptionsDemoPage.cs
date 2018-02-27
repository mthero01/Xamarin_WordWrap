/** [!]. ABOUT
 * "Vertical Options Demo Page"
 * by Matthew T. Theroux
 * for Baker College Online CS4010
 * Module 04 Assignment 02 'c'
 * under Joan Zito
 * (c) 2018 February
 * -lists some VerticalOptions
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
    public class VerticalOptionsDemoPage : ContentPage
    {
        private static const double fontSizeMedium = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

        /// cxtr
        public VerticalOptionsDemoPage()
        {

            Color[] colors = { Color.Yellow, Color.Blue };
            int flipper = 0;

            /// Create Labels
            IEnumerable<Label> labels =
                // SQL
                from field in typeof(LayoutOptions).GetRuntimeFields()
                where field.isPublic && field.IsStatic
                orderby ((LayoutOptions)field.GetValue(null)).Alignment
                select new Label
                {
                    Text = "VerticalOptions = " + field.Name,
                    VerticalOptions = (LayoutOptions)field.GetValue(null),
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = fontSizeMedium,
                    TextColor = colors[flipper],
                    BackgroundColor = colors[flipper = 1 - flipper]
                };// /lbl (sel'td)

            StackLayout pageBody = new StackLayout();
            foreach(Label label in labels)
            {
                pageBody.Children.Add(label);
            }

            ///
            Content = pageBody;
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0, 0);
        }// /cxtr

        /// O]
        protected override void OnStart() { }
        protected override void OnSleep () { }
        protected override void OnResume() { }

    }// /cla 'VerticalOptionsDemoPage'
}// /ns 'stack_scrolling'
/// [EoF].