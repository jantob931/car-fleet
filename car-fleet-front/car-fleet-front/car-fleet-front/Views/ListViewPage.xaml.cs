
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace car_fleet_front.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FirstPage : ContentPage
    {
        //lista samochodów jako obsreviblecllection
         public FirstPage()
        {
        InitializeComponent();
         
         }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
          var sendesBindingContext = ((Button)sender).BindingContext;
            var car = (Car)senderBindingContext;
            DisplayAlert("Wybrany samochód", car.Brand+car.model,"Ostatni przgląd" );
        }

        private void CarListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var car = e.SelectedItem as Car;
            DisplayAlert("Item Selected", car.Brand + car.model, "OK");
        }

        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var car = menuItem.CommandParameter as Car;
            DisplayAlert("Wybrany samochód", car.Brand + car.model, "Ostatni przgląd");
        }

        private void MenuItem_Clicked_1(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var car = menuItem.CommandParameter as car;
            CarListView.Remove(car)
        }
    }
}