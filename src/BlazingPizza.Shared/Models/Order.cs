using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;

namespace BlazingPizza
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string TeamName { get; set; }

        public DateTime CreatedTime { get; set; }

        [Required, MaxLength(50)]
        public string City { get; set; }

        public bool IsOnline { get; set; }

        public string FIOTeam { get; set; }

        public string NameOfInstitution { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual int GenreId { get; set; }

        public virtual Nomination Nomination { get; set; }

        public string QuantityPeople { get; set; }

        public virtual int NominationId { get; set; }
        
        public Address DeliveryAddress { get; set; } = new Address();

        public LatLong DeliveryLocation { get; set; }
        
        public virtual Project Project { get; set; }

        public virtual int ProjectId { get; set; }
    }
}
