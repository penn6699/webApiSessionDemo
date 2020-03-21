using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public dynamic set(string key="", string val="")
        {
            if (string.IsNullOrEmpty(key))
            {
                key = "key";
            }
            if (string.IsNullOrEmpty(val))
            {
                val = "value";
            }

            SessionHelper.Set(key, val);
            return SessionHelper.Get(key);
        }

        [HttpGet]
        public dynamic get(string key="")
        {
            if (string.IsNullOrEmpty(key))
            {
                key = "key";
            }
            return SessionHelper.Get(key);
        }



    }
}
