using AgricultureAutomation.HardwareControl.Control.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Control.Concrete
{
    class ControlRepository<THardware> : IControlRepository<THardware> where THardware : class,IHardware ,new()
    {


        public void Close()
        {
            
        }

        public void Open()
        {
            
        }


    }
}
