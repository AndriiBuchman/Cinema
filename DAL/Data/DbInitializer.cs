using Cinema.Context;
using System;
using System.Linq;

namespace Models.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CinemaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Films.Any())
            {
                return;
            }

            var films = new Films[]
            {
            new Films{FilmName="Men in Black International", StartTime = DateTime.Now},
            new Films{FilmName="Venom", StartTime = DateTime.Now},
            new Films{FilmName="Spide-Man", StartTime = DateTime.Now},


            };
            foreach (Films f in films)
            {
                context.Films.Add(f);
            }
            context.SaveChanges();

            var customers = new Customers[]
            {
                new Customers {LastName="LS1",Name= "Andrew",Phone= "0639372632" , Email="da@gmail.com" },
                new Customers {LastName="LS2",Name= "Bob",Phone= "0639372632" , Email="fjvcxfsd@gmail.com" },
                new Customers {LastName="LS3",Name= "John",Phone= "0639372632" , Email="wqrf@gmail.com" },
                new Customers {LastName="LS4",Name= "Ivan",Phone= "0639372132" , Email="flmjsd@gmail.com" },
                new Customers {LastName="LS5",Name= "Yura",Phone= "0639372332" , Email="fndsjiqc@gmail.com" },
            };
            foreach (Customers c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var reservedPlaces = new ReservedPlaces[]
            {
            new ReservedPlaces{CustomerId = 1, FilmId = 1},
            new ReservedPlaces{CustomerId = 2, FilmId = 2},
            new ReservedPlaces{CustomerId = 4, FilmId = 3},
            new ReservedPlaces{CustomerId = 3, FilmId = 3},
            new ReservedPlaces{CustomerId = 5, FilmId = 2},
            new ReservedPlaces{CustomerId = 1, FilmId = 2},
            };
            foreach (ReservedPlaces e in reservedPlaces)
            {
                context.ReservedPlaces.Add(e);
            }
            context.SaveChanges();
        }
    }
}