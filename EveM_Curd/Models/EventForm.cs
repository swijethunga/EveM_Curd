namespace EveM_Curd.Models
{
    public class EventForm
    {
        public int Id { get; set; }
        public string evTitle { get; set; }
        public string evDescription { get; set; }
        public string mainImgPth { get; set; }
        public string recSinEvnt { get; set; }
        public DateTime stDateTime { get; set; }
        public DateTime enDateTime { get; set; }
        public string phyOnlEvt { get; set; }
        public string locations { get; set; }
        public string dcmtPth { get; set; }
        public string cmteMbrs { get; set; }
    }
}
