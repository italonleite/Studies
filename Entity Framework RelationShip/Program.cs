using Entity_Framework_RelationShip.Data;
using Entity_Framework_RelationShip.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Entity_Framework_RelationShip
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ImmobileDbContext())
            {

                var address = new Address()
                {
                    AddressId = Guid.NewGuid(),
                    City = "Pancas",
                    Neighborhood = "Vila Nova",
                    State = "ES",
                    ZipCode = "29750-000",
                    StreetAddress = "rua crisoberilo, 676 apt 102"
                };

                var immobile = new Immobile()
                {
                    ImmobileId = Guid.NewGuid(),
                    EType = EType.COMERCIAL,
                    AddressId = address.AddressId,
                    Address = address

                };

                db.Addresses.Add(address);
                db.Immobiles.Add(immobile);

                db.SaveChanges();

                //Console.WriteLine(
                //db.Addresses
                //  .Where(a => a.City == "Pancas")
                //  .ToQueryString());

                Console.WriteLine("-----RESULTADO ENDEREÇOS-----");
                foreach (var item in db.Addresses)
                {

                    Console.WriteLine(
                        $"EnderecoId {item.AddressId} \n" +
                        $"ZipCode: {item.ZipCode}\n" +
                        $"Neighborhood: {item.Neighborhood}\n" +
                        $"StreetAddress: {item.StreetAddress}\n" +
                        $"City: {item.City}\n" +
                        $"State: {item.State}\n");
                }
                Console.WriteLine("-----RESULTADO IMÓVEIS-----");
                foreach (var item in db.Immobiles)
                {
                    Console.WriteLine(
                   $"ImóvelId:  {item.ImmobileId} \n" +
                   $"Tipo: {item.EType}\n" +
                   $"EndereçoId: {item.AddressId}\n");

                }

            }
        }
    }
}
