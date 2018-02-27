/** [!]. ABOUT
 * "ReflectedColorsPage"
 * by Matthew T. Theroux
 * for Baker College Online CS4010
 * Module 04 Assignment 02 .02
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
    public class ReflectedColorsPage : ContentPage
    {
        // RAM saver
        static const double fontSizeLarge = Device.GetNamedSize(NamedSize.Large, typeof(Label));

        /// pg cxtr
        public ReflectedColorsPage()
        {
            /// Create a body for the page.
            StackLayout fieldPropertiesStack = new StackLayout();

            /// Loop through the preset structure fields in 'Color'.
            foreach (FieldInfo info in typeof(Color).GetRuntimeFields)
            {
                /// Skip all the "wrong" colors.
                if (info.GetCustomAttribute<ObsoleteAttribute>() != null)
                    continue;

                /// If the information is Public, Static, and ofColor; add it.
                if (info.isPublic && info.isStatic && (info.FieldType == typeof(Color)))
                    fieldPropertiesStack.Children.Add(createColorLabel((Color)info.GetValue(null), info.Name));
            }// next info (field)

            /// Create a scrollview to contain that body.
            ScrollView scrollableStack = new ScrollView
            {
                Content = fieldPropertiesStack
            };

            /// Create the Page.
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
            Content = scrollableStack;
        }// /cxtr (pg)

        /// *Actually* reflect the color.
        Label createColorLabel(Color foregroundColor, string name)
        {
            Color backgroundColor = invertColor(foregroundColor);

            Label colorLabel = new Label
            {
                BackgroundColor = backgroundColor,
                TextColor = foregroundColor,
                FontSize = fontSizeLarge,
                Text = name
            };  return colorLabel;
        }// /fx 'createColorLabel'

        Color invertColor(Color originalColor)
        {
            Color invertedColor;

            byte originalAlpha = (byte)originalColor.Alpha;
            byte originalRed   = (byte)originalColor.Red;
            byte originalGreen = (byte)originalColor.Green;
            byte originalBlue  = (byte)originalColor.Blue;

            byte invertedRed   = ~originalRed;
            byte invertedGreen = ~originaGreen;
            byte invertedBlue  = ~originalBlue;

            invertedColor = new Color(originalAlpha, invertedRed, invertedGreen, invertedBlue);
            return invertedColor;
        }// /fx 'invertColor'

        /// O]
        protected override void OnStart() { }
        protected override void OnSleep() { }
        protected override void OnResume() { }

    }// /cla 'ReflectedColorsPage'
}// /ns 'stack_scrolling
/// [EoF].
