using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForteSdk;
using System.Resources;
using Newtonsoft.Json;

namespace ForteSdk
{
    public class ForteScheduleItemService : ForteService<ForteScheduleItem>
    {
        public ForteScheduleItemService(ForteOptions createOptions) : base(createOptions, "scheduleitems", "Scheduleitem") { }

        
    }
}
