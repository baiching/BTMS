using System;

namespace BTMS.Entity.TicketModels
{
    public class TicketTime
    {
        // Relates time and ticket information.
        public string TicketTitle { get; set; }

        public Guid TicketId { get; set; }

        //Start time
        public DateTime Start { get; set; }

        //End time
        public DateTime End { get; set; }

    }
}
