using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Herbzhub.Data.Models
{
    public class PersonalIdentification : BaseEntity
    {
        [ForeignKey("User")]
        public int userId { get; set; }
        public User User { get; set; }

        [Required(ErrorMessage = "First Name Field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Field is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Address Field is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone NumberField is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="City Field is required")]
        public int CityId { get; set; }
        public City City { get; set; }

        [Required(ErrorMessage ="State Field is required")]
        public int StateId {get; set; }
        public State State {get; set; }

        [Required(ErrorMessage ="Zipcode Field is required")]
        public string ZipCode {  get; set; }
        

        public int CountiesId { get; set; }
        public Counties counties { get; set; }

        public ICollection<ManufacturerDispensary> ManufacturerDispensary { get; set; }
     }


     


 }

