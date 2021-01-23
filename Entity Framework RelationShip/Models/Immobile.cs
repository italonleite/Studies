using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_RelationShip.Models
{
    public class Immobile
    {
        public Guid ImmobileId { get; set; }
        public EType EType { get; set; }
        public Address AddressId { get; set; }
        public Address Address { get; set; }

    }
}
