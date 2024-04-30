﻿using System.ComponentModel.DataAnnotations;

namespace AdminApplication.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public EShopApplicationUser? CreatedBy { get; set; }
    }
}
