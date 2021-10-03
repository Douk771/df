using System;
using System.Collections.Generic;

namespace BlazingPizza
{
    /// <summary>
    /// Represents a pre-configured template for a pizza a user can order
    /// </summary>
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDatetime { get; set; }

        public string Description { get; set; }

        public string DescriptionLite { get; set; }

        public string ImageUrl { get; set; }

        public virtual List<Order> Orders { get; set; }
        

        public string GetFormattedBaseDate() => $"{StartDateTime.Date:dd.MM.yyyy} - {EndDatetime.Date:dd.MM.yyyy}";
    }
}
