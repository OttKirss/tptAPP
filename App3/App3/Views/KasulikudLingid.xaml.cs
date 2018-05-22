using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App3.Models;
using App3.Views;
using App3.ViewModels;

namespace App3.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KasulikudLingid : ContentPage
	{
        public KasulikudLingid()
        {
            InitializeComponent();
        }

        async void RaamatukoguEvent(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tptlive.ee/kool/raamatukogu/"));
        }
        async void SiseveebEvent(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tpt.siseveeb.ee/"));
        }
    }
}