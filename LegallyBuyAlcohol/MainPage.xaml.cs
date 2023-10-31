using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LegallyBuyAlcohol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, System.EventArgs e)
        {
            //TimeSpan timeSpan = DateTime.Now - birthDate.Date;
            double UsAge = DateTime.Now.Year - birthDate.Date.Year;
            Out_text.Text = UsAge.ToString();
            if (UsAge >= 21 || UsAge == 0)
            {
                Out_text.Text = "It's legal to drink in the United States.";
            }
            else
            {
                Out_text.Text = "You've got " + (DateTime.Now.Year - birthDate.Date.Year) + " Year(s) to go";
                //Out_text.Text = timeSpan.TotalDays.ToString() + " + " + timeSpan.Days.ToString();
            }
            //Out_text.Text = birthDate.Date.Year.ToString();

            //Out_text.Text = $"Hello {DateTime.Now - birthDate.Date}";

        }
    }
}
