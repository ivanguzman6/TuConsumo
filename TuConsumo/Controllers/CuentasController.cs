﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TuConsumo.Controllers
{
    [Route("api/[controller]")]
    public class CuentasController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {

        }
    }
}
