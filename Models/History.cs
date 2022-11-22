using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class History
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string CarMake { get; set; }
        public string CarModel {get;set;}
        public string CarRegNumber { get; set; }
        public DateTime DealTime { get; set; }
        public DealState DealState{ get; set; }


    }
}
