﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController
    {
        [HttpGet]
        public string Index()
        {
            return "Running...";
        }
    }
}
