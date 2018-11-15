using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTMS.Entity.UserModels
{
    public class Ticket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //Client ID who owns the ticket
        public Guid ClientId { get; set; }

        public string Title { get; set; }

        /// The description for this ticket
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// The complexity (1-3) of this ticket
        public int Complexity { get; set; }

        /// Defines if this ticket is urgent
        public bool IsUrgent { get; set; }

        /// Notes for this ticket
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        /// The date added
        public DateTime DateAdded { get; set; }

        /// The date closed
        public DateTime DateClosed { get; set; }

        /// True if the ticket is open
        public bool Open { get; set; }

    }
}
