using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTodoList
{

    public class Work
    {
   
        public string ID { get; set; }
        public string MyJob { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDate { get; set; }
        public string Content { get; set; }
    }
}
