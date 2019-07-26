using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using myWrappingButton.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Oigo.CustomButton), typeof(CustomButton))]
namespace myWrappingButton.iOS
{
    public class CustomButton : ButtonRenderer
    {
        public CustomButton()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TitleLabel.LineBreakMode = UILineBreakMode.WordWrap;
                Control.TitleLabel.Lines = 0;
                Control.TitleLabel.TextAlignment = UITextAlignment.Center;
            }
        }
    }
}