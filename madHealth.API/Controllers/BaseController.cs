﻿using madHealth.API.Models;
using madHealth.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace madHealth.API.Controllers
{
    public class BaseController : ApiController
    {
        private UnitOfWork _unitOfWork;
        private Factory _factory;

        protected UnitOfWork UnitOfWork
        {
            get { return _unitOfWork ?? (_unitOfWork = new UnitOfWork()); }
        }

        protected Factory Factory
        {
            get { return _factory ?? (_factory = new Factory(UnitOfWork)); }
        }

    }
}
