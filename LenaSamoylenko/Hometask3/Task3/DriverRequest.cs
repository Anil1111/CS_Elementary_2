using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DriverRequest : DispatchcerRequest
    {
        public DriverRequest(DispatchcerRequest request, bool completedWork, string vehicleCondition):base( request, completedWork, vehicleCondition)
        {

        }
    }
}
