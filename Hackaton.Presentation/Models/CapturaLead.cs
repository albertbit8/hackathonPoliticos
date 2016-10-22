using System;
using System.Collections.Generic;

namespace Hackaton.Presentation.Models
{
    public partial class CapturaLead
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public System.DateTime data { get; set; }
        public string ip { get; set; }
    }
}
