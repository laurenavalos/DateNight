using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class MoneyPage : ContentPage
{
    public MoneyPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            LblDisplay.Text = App.DateCalc.GetTotalCost();
        }
        catch(Exception ex)
        {
            LblDisplay.Text = "$0.00";
            DisplayAlert("Error", ex.Message, "Ok?");
        }
    }
}