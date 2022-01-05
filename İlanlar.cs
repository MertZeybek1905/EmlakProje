using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakProje.Models
{
    public class İlanlar
    {
        public int Id { get; set; }
        public int MetreKare { get; set; }
        public int Kira { get; set; }
        public int OdaSayı { get; set; }
        public string Semt { get; set; }
        public int EvId { get; set; }
        public int EkleyenId { get; set; }
    }
}
