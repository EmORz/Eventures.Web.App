using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models.BindingModels
{
    public class EventCreateBindingModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Place")]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Start")]
        public DateTime Start { get; set; }
        [Required]
        [Display(Name = "End")]
        public DateTime End { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Total tickets must be a positive number.")]
        [Display(Name = "TotalTickets")]

        public int TotalTickets { get; set; }

        [Required]
        [Display(Name = "PricePerTicket")]
        [Range(0.00, double.MaxValue, ErrorMessage = "Total tickets must be a positive number.")]

        public decimal PricePerTicket { get; set; }


    }
}