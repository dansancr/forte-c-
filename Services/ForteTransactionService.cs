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
    /// Provides operations for creating, finding, updating, and deleting Transactions in the vault
    /// </summary>
    public class ForteTransactionService : ForteService<ForteTransaction>
    {
        public ForteTransactionService(ForteOptions createOptions) : base(createOptions, "transactions", "Transaction") { }

        
    }
}
