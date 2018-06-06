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

            //criando mapa em uma localização especifica
            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-29.6905709, -51.1040204), Distance.FromKilometers(3)));
            mapa.MapType = MapType.Street;


            //Adicionando pinos
            AdicionaPino(mapa, -29.688335, -51.100496, "Casa do Tiago", "Pedro Cunha 20, Canudos - NH");
            AdicionaPino(mapa, -29.681473, -51.126370, "Ftec Faculdades", "Silveira Martins, Centro - NH");

            MapContainer.Children.Add(mapa);

        }

        private static void AdicionaPino(Map mapa, double lat, double log, string label, string address)
        {
            var position = new Position(lat, log); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = label,
                Address = address
            };
            mapa.Pins.Add(pin);
        }

    }
}
