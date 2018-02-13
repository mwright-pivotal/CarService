using BookService.Models;
using BookService2017.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace BookService2017.Controllers
{
    public class CarCommandController : ApiController
    {
        private static readonly Logger Nlog = LogManager.GetCurrentClassLogger();

        private BookServiceContext db = new BookServiceContext();

        // GET: api/CarCommand
        public IEnumerable<CarCommand> Get()
        {
            return new CarCommand[] { new CarCommand()};
        }

        // GET: api/CarCommand/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CarCommand
        public string Post([FromBody]CarCommand value)
        {
            Nlog.Trace("received command " + value.SourceType);

            return "Car Command Received from Source Type: " + value.SourceType;
        }

        // PUT: api/CarCommand/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CarCommand/5
        public void Delete(int id)
        {
        }
    }
}
