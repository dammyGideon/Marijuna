using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbzhub.Models.Request
{
    public class ManufactureRequest
    {

        public int roleId {  get; set; }
        public int CountiesId { get; set; }
        public string SerialNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }  
   
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public AddressRequest AddressRequest { get; set; }
       
        public string StateLicense { get; set; }
        public BusinessDetails BusinessDetails {  get; set; }
        

    }
}
    