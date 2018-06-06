using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace TesteMapa
{
    public class CustomMap : Map
    {
        public CustomMap(MapSpan region) : base(region)
        {
        }

        public List<CustomPin> CustomPins { get; set; }
    }
}
