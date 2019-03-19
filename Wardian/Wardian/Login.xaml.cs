using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wardian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnMenu(object sender, EventArgs e)
        {
            if (Navigation != null)
            {

                var psl = new Menu();
                await Navigation.PushAsync(psl);
            }
        }
    }
}
