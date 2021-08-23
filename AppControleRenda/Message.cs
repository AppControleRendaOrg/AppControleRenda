using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppControleRenda.Controllers
{
    public class Message
    {
        public int id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
