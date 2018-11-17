using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity
{
    public class Traffic
    {
        public int Id { get; set; }

        public int JourneyId { get; set; }

        public int TicketId { get; set; }

        public virtual Journey Journey { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
