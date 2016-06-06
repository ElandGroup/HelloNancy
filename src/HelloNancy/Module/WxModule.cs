using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;

namespace HelloNancy.Module
{
    public class WxModule : NancyModule
    {
        public WxModule() : base("/api/v1/wx")
        {
            Get["/ping"] = _ =>
            {
                return "pong";
            };

            Get["/openid"] = _ =>
            {

                return null;
            };
        }
    }
}
