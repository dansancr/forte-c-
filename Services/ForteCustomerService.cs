using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForteSdk;
using System.Resources;
using Newtonsoft.Json;

namespace ForteSdk
{
    /// <summary>
    /// Provides operations for creating, finding, updating, and deleting Customers in the vault
    /// </summary>
    public class ForteCustomerService : ForteService<ForteCustomer>
    {
        public ForteCustomerService(ForteOptions createOptions) : base(createOptions, "customers", "Customer") { }
        

    }
}
