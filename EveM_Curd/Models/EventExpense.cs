using System.ComponentModel.DataAnnotations;

namespace EveM_Curd.Models
{
    public class EventExpense

    {
        

        [Key]
        public int Transac_id { get; set; }
        public string? Transac_name { get; set; }

        public string? Transac_type { get; set; }

        public string? Transac_date { get; set;}

        public int Transac_amount { get;set; }

        /*public int Event_id { get; set; }
        public EventDetail EventDetail { get; set; }*/

    }
}
