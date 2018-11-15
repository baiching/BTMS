using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMS.Entity.UserModels
{
    public class AdminTicketTime
    {
        [Key]
        public Guid Id { get; set; }

        public string TechnicianId { get; set; }

        public Guid TicketId { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}
