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
                double bmi = w / h / h;
                int bmi2 = (int)(bmi * 10);
                double bmi3 = (double)(bmi2 / 10.0);
                result.Text = "身長" + h + "、体重" + w + "の人のBMIは" + bmi3 + "です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "！！！";
            }
        }
    }
}
