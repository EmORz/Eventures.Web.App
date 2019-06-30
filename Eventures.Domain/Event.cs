using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Domain
{
    public class Event
    {
        public string Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Place { get; set; }

        [Required]
        [RegularExpression("^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[13-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$")]
        public DateTime Start { get; set; }

        [RegularExpression("^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[13-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$")]
        [Required]
        public DateTime End { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalTckets { get; set; }

        [Required]
        [Range(0.00, double.MaxValue)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid price")]
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