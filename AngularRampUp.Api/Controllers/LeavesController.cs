﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularRampUp.Api.Models;

namespace AngularRampUp.Api.Controllers
{
    [Route("api/[controller]")]
    public class LeavesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Leave> Get()
        {
            var l = new Leave();
            return new List<Leave> { l.GetLeave(1), l.GetLeave(2), l.GetLeave(3), l.GetLeave(4), l.GetLeave(5) };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}