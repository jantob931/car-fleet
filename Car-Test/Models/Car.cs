using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Test.Models
{
    public class Car
    {
        public string id { get; set; }
        public string registration_number { get; set; }
        public string brand { get; set; }
        public string model { get; set; }

    }
}
