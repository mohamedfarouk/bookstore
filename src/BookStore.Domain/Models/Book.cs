using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }
        
        public string CoverImageUri { get; set; }

        [Required]
        [Range(Double.Epsilon, 1000)]
        public decimal Price { get; set; }

    }
}