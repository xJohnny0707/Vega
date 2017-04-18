using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("VehiclesFeatures")]
    public class VehicleFeature
    {
        public int Vehicleid { get; set; }
        public int FeatureId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Feature Feature { get; set; }
    }
}