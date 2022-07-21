using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Organisation")]
    public class Organisation
    {
        [Key]
        public string OrganisationNumber { get; set; }
        public string OrganisationName { get; set; }
        public string AddressLine1 { get; set; }        
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}