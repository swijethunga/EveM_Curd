using System.ComponentModel.DataAnnotations;

namespace EveM_Curd.Models
{
    public class EventDetail
    {
        [Key]
        public int Event_id { get; set; }

        public string? Event_name { get; set; }

      
       /* public ICollection<EventIncome> EventIncomes { get; set; }

        public ICollection<EventExpense> EventExpenses { get; set; }*/
        
    }

}
