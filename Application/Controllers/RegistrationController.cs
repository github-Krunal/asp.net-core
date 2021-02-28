using System;
using System.Collections.Generic;
using Application.Interface;
using Application.Models;
using Application.Routes;
using Microsoft.AspNetCore.Mvc;



namespace Application.Controllers
{
    
    public class RegistrationController : Controller
    {
        // GET: api/<controller>
        private readonly IRegistration _registration;
        public RegistrationController(IRegistration registration)
        {
            _registration = registration ?? throw new ArgumentNullException(nameof(IRegistration));
        }

        [HttpPost]
        [Route(CustomRoutes._registration)]
        public IActionResult Registration([FromBody] Registration registration)
        {
            return Ok(_registration.RegisterUser(registration));
        }
        [HttpGet]
        [Route(CustomRoutes._registrationGetAll)]
        public IActionResult GetRegistrations()
        {
            return Ok(_registration.GetRegisteredsUser());
        }
    }
}
