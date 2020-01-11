﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServiceA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceAController : ControllerBase
    {

        public ServiceAController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "This is resultset from Service-A";
        }
    }
}
