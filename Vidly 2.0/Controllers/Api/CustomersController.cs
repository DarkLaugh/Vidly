﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_2._0.Models;
using Vidly_2._0.Dtos;
using AutoMapper;

namespace Vidly_2._0.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET  /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
            {
                customersQuery = customersQuery.Where(c => c.FirstName.Contains(query) || c.LastName.Contains(query));
            }

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<CustomerModel, CustomerDto>);

            return Ok(customerDtos);
        }

        //GET  /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(Mapper.Map<CustomerModel, CustomerDto>(customer));
            }
        }

        //POST api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            else
            {
                var customer = Mapper.Map<CustomerDto, CustomerModel>(customerDto);
                _context.Customers.Add(customer);
                _context.SaveChanges();

                customerDto.Id = customer.Id;

                return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
            }
        }

        //PUT  api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                return NotFound();
            }

            else
            {
                Mapper.Map(customerDto, customerInDb);

                _context.SaveChanges();

                return Ok();
            }
        }

        //DELETE api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                return NotFound();
            }

            else
            {
                _context.Customers.Remove(customerInDb);
                _context.SaveChanges();

                return Ok();
            }
        }
    }
}