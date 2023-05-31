﻿using Ticketize.Domain.Common;

namespace Ticketize.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EnventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string? Artist { get; set; }
        public DateTime Date { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
