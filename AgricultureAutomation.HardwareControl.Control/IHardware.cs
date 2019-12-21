using System;
using System.Collections.Generic;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Control.Repository.Abstract
{
    public interface IHardware
    {
        public int PublicId { get; set; }
        public string PortName { get; set; }
    }
}
