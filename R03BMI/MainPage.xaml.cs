using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A09 金賀　柊斗";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var height = heighit.Text;
            var weight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                if (h >= 100)
                {
                    h = h / 100;
                }
                double w = double.Parse(weight);
                if (w >= 1000)
                {
                    w = w / 1000;
                }

                double bmi = w / h / h;
                double bmi2 = Math.Round(bmi,1,MidpointRounding.AwayFromZero);

                if(bmi3 < 18.50)
                {
                    result.Text = "BMIが" + bmi3 + "の人は低体重（痩せ）です。";
                }
                else if(bmi >= 18.50 & bmi < 25.00)
                {
                    result.Text = "BMIが" + bmi3 + "の人は普通体重です。";
                }
                else if(bmi >= 25.00 & bmi < 30.00)
                {
                    result.Text = "BMIが" + bmi3 + "の人は肥満（１度）です。";
                }
                else if(bmi >= 30.00 & bmi < 35.00)
                {
                    result.Text = "BMIが" + bmi3 + "の人は肥満（２度）です。";
                }
                else if(bmi >= 35.00 & -bmi < 40.00)
                {
                    result.Text = "BMIが" + bmi3 + "の人は肥満（３度）です。";;
                }
                else
                {
                    result.Text = "BMIが" + bmi3 + "の人は肥満（４度）です。";
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "！！！";
            }
        }
    }
}
