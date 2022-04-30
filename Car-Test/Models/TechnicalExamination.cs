namespace Car_Test.Models
{
    public class TechnicalExamination
    {
       public DateTime affected_date { get; set; }
        public DateTime next_examination_date { get; set; }
        public bool is_checked { get; set; }
        public string id { get; set; }
        public string carid { get; set; }
        public Car car { get; set; }
    }
    
}
