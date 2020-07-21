using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForteSdk;
using System.Resources;
using Newtonsoft.Json;

namespace ForteSdk
{
    public class ForteScheduleService : ForteService<ForteSchedule>
    {
        public ForteScheduleService(ForteOptions createOptions) : base(createOptions, "schedules", "Schedule") { }

        
    }
}
