using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.VehicleElements
{
    public enum EngineType
    {
        [Description("Diesel")]
        Diesel,
        [Description("Gasoline")]
        Gasoline,
        [Description("Electric")]
        Electric
    }
}
