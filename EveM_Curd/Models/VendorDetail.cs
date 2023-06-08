using System.ComponentModel.DataAnnotations;

namespace EveM_Curd.Models
{
    public class VendorDetail
    {
        [Key]
        public int Vendor_id { get; set; }
        public string? Vendor_name { get; set;}
        public string? Contact_person { get; set;}
        public string? Contact_no { get; set; }
        public string? Contact_email { get; set; }
        public string? Service_offered { get; set; }
        public string? Add_info { get; set; }
    }
}
