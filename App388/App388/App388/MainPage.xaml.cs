using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App388
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            // access switch
            var Switch_ToggledHandler = (mySwitch)sender;

            // access Parent Layout for Sender  
            StackLayout ParentStackLayout = (StackLayout)Switch_ToggledHandler.Parent;

            // access the Label "configLabel"  
            Label configLabel = (Label)ParentStackLayout.Children[0];


            if (Switch_ToggledHandler.IsToggled)
            {
                switch (Switch_ToggledHandler.name)
                {
                    case "wifi":
                        configLabel.Text = "wifi open";
                        break;
                    case "sound":
                        configLabel.Text = "sound is open";
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }
            else {

                switch (Switch_ToggledHandler.name)
                {
                    case "wifi":
                        configLabel.Text = "wifi off";
                        break;
                    case "sound":
                        configLabel.Text = "sound is off";
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }

    public class mySwitch : Switch
    {

        public static readonly BindableProperty nameProperty =
  BindableProperty.Create("name", typeof(string), typeof(MainPage), null);

        public string name
        {
            get { return (string)GetValue(nameProperty); }
            set { SetValue(nameProperty, value); }
        }
    }
}
