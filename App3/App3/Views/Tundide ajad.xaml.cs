﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TundideAjad : ContentPage
	{
		public TundideAjad ()
		{
			InitializeComponent ();
            pilt.Source = ImageSource.FromFile("asd.png");
        }
	}
}