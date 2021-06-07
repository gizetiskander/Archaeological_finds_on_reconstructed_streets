using System;
using System.Collections.Generic;
using System.Text;

namespace Archaeological_finds_on_reconstructed_streets
{
    public class Photo
    {
        public string Photos { get; set; }
    }

    public class GeoData
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class GeodataCenter
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Root
    {
        public int ID { get; set; }
        public string DescriptionOfFinding { get; set; }
        public string DateOfDiscovery { get; set; }
        public string DuringProgram { get; set; }
        public List<Photo> Photo { get; set; }
        public int global_id { get; set; }
        public GeoData geoData { get; set; }
        public GeodataCenter geodata_center { get; set; }
    }
}
