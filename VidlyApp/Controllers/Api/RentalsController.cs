﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using VidlyApp.Dtos;
using VidlyApp.Models;

namespace VidlyApp.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private MyDBContext _context;

        public RentalsController()
        {
            _context = new MyDBContext();
        }

        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRentalDto) 
        {
            var customer = _context.Customers.Single(c => c.Id == newRentalDto.CustomerId);
            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                movie.NumberAvailable--; 

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
