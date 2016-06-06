using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Framework.ConfigurationModel;

namespace HelloNancy
{
    public class Test
    {
 
        public void Configure(IConfigurationRoot config)
        {
            string aa = config["connection1"];
        }
    }
}
