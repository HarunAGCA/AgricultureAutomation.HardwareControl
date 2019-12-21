using AgricultureAutomation.HardwareControl.Business.Abstract;
using AgricultureAutomation.HardwareControl.Control.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Business.Concrete
{
    public class LedManager : ILedService
    {
        private ILedController _LedController;

        public LedManager(ILedController ledController)
        {
            _LedController = ledController;
        }

        public void Close()
        {
            _LedController.Close();
        }

        public void Open()
        {
            _LedController.Open();
        }
    }
}
