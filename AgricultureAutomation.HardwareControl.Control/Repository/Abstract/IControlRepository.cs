using System;
using System.Collections.Generic;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Control.Repository.Abstract
{
    public interface IControlRepository<THardware> where THardware:class,new()
    {
        void Open();
        void Close();

    }
}
