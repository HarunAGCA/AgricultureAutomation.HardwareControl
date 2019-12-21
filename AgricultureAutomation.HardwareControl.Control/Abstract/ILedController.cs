using System;
using System.Collections.Generic;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Control.Abstract
{
    public interface ILedController
    {
        void Open();
        void Close();
    }
}
