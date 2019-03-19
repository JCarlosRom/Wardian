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
	public partial class BotonPanico : ContentPage
	{
		public BotonPanico ()
		{
			InitializeComponent ();
		}

        private async void btnPanico_click(object sender, EventArgs e)
        {
            StartAnimation();
        }

        private async void StartAnimation()
        {
            
            await Task.Delay(200);
            await btnPanico.FadeTo(0, 250);
            await Task.Delay(200);
            await btnPanico.FadeTo(1, 250);
        }
    }
}