using ArtBooking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtBooking.Core.Model
{
    public class Event : MetaEntity
    {
        [Required]
        public int EventId { get; set; }

        public int OrganizationId { get; set; }
        [Required]
        [MaxLength(80)]
        public string? EventName { get; set; }
        public string? Description { get; set; }
        [Required]
        public Address? Address { get; set; }
    }
}
