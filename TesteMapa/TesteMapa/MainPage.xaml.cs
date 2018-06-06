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
            var mapa = new CustomMap(MapSpan.FromCenterAndRadius(new Position(-29.6905709, -51.1040204), Distance.FromKilometers(3)));
            mapa.MapType = MapType.Street;

            mapa.CustomPins = new List<CustomPin> { };
            //Adicionando pinos
            AdicionaPinoPersonalizado(mapa, -29.688335, -51.100496, "Casa do Tiago", "Pedro Cunha 20, Canudos - NH");
            AdicionaPinoPersonalizado(mapa, -29.681473, -51.126370, "Ftec Faculdades", "Silveira Martins, Centro - NH");
            AdicionaPinoPersonalizado(mapa, -29.689392, -51.108252, "Parcão", "Barão de Santo Ângelo, Canudos - NH");

            MapContainer.Children.Add(mapa);

        }

        private static void AdicionaPinoPersonalizado(CustomMap mapa, double lat, double log, string label, string address)
        {
            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(lat, log),
                Label = label,
                Address = address,
                Id = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            mapa.CustomPins.Add(pin);
            mapa.Pins.Add(pin);
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
