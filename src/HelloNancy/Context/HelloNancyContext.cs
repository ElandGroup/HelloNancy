using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HelloNancy.Context
{
    public class HelloNancyContext
    {
        private HelloNancyContext() { }
        private static HelloNancyContext current
            ;
        public static HelloNancyContext Current
        {
            get
            {
                if (current == null)
                    current = new HelloNancyContext();
                return current;
            }
        }
        public IConfigurationRoot Configuration { get; set; }
    }
}
