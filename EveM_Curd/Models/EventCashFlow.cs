using System.ComponentModel.DataAnnotations;

namespace EveM_Curd.Models
{
    public class EventCashFlow
    {
        
        [Key]
        public int Cex_id { get; set; }
        public String? Cex_name { get; set; }

        public String? Cex_type { get; set; }

        public String? Cex_date { get; set; }

        public int Cex_amount { get; set; }

       /* public int Event_id { get; set; }
        public EventDetail EventDetail { get; set; }*/

    }
}
