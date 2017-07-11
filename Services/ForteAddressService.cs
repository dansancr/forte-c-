using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForteSdk;
using System.Resources;
using Newtonsoft.Json;

namespace ForteSdk
{
    /// <summary>
    /// Provides operations for creating, finding, updating, and deleting Addresses in the vault, Customer_token is mandatory.
    /// </summary>
    public class ForteAddressService : ForteService<ForteAddress>
    {
        public ForteAddressService(ForteOptions createOptions) : base(createOptions, "addresses", "Address") { }

        
    }
}
