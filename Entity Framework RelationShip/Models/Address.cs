using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework_RelationShip.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string ZipCode { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
