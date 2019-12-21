using System;
using System.Collections.Generic;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Business.Abstract
{
    public interface ILedService
    {
        void Open();//TODO will be open with publicID
        void Close();
    }
}
