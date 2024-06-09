namespace Herbzhub.Data.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string State { get; set; }
        public ICollection<ManufacturerDispensary> ManufacturerDispensaries { get; set; }
    }
}
