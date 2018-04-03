using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TesteMapa
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();

            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-29.6905709, -51.1040204), Distance.FromKilometers(2)));
            mapa.MapType = MapType.Satellite;
            MapContainer.Children.Add(mapa);

        }
    }
}
