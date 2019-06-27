using System;

namespace Eventures.Domain
{
    public class Event
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int TotalTckets { get; set; }

        public decimal PricePerTicket { get; set; }
        /*•	Id – a UUID.
           •	Name – a string.
           •	Place – a string.
           •	Start – a DateTime object.
           •	End – a DateTime object.
           •	Total Tickets – an integer.
           •	Price Per Ticket – a decimal value.
           */
    }
}