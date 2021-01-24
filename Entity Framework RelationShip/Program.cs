using Entity_Framework_RelationShip.Data;
using Entity_Framework_RelationShip.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entity_Framework_RelationShip
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ImmobileDbContext())
            {
                var addressOne = new Address()
                {
                    AddressId = Guid.Parse("dba2628a-3448-4101-a8d8-21c622b29df7"),
                    City = "Pancas",
                    Neighborhood = "Vila Nova",
                    State = "ES",
                    ZipCode = "29750-000",
                    StreetAddress = "rua crisoberilo, 676 apt 102"
                };

                var addressTwo = new Address()
                {
                    AddressId = Guid.Parse("786ffc50-763b-456a-9b0f-6556c6500612"),
                    City = "Rio de Janeiro",
                    Neighborhood = "Jacarepagua",
                    State = "RJ",
                    ZipCode = "21210-250",
                    StreetAddress = "rua almicar de castro, 150, apt303"
                };


                var immobileOne = new Immobile()
                {
                    ImmobileId = Guid.NewGuid(),
                    EType = EType.COMERCIAL,
                    AddressId = addressOne.AddressId,
                    Address = addressOne

                };
                var immobileTwo = new Immobile()
                {
                    ImmobileId = Guid.NewGuid(),
                    EType = EType.COMERCIAL,
                    AddressId = addressTwo.AddressId,
                    Address = addressTwo

                };
                db.Adresses.Add(addressOne);
                db.Immobiles.Add(immobileOne);
                db.Adresses.Add(addressTwo);
                db.Immobiles.Add(immobileTwo);

                db.SaveChanges();

                Console.WriteLine("ENDEREÇO");
                foreach (var item in db.Adresses)
                {
                    Console.WriteLine(
                        $"EnderecoId {item.AddressId} \n" +
                        $"ZipCode: {item.ZipCode}\n" +
                        $"Neighborhood: {item.Neighborhood}\n" +
                        $"StreetAddress: {item.StreetAddress}\n" +
                        $"City: {item.City}\n" +
                        $"State: {item.State}\n");
                }
                Console.WriteLine("IMOVEL");
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
