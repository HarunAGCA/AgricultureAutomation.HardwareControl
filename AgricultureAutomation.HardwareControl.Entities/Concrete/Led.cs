using Agca.Core.Entities;
using AgricultureAutomation.HardwareControl.Control.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Entities.Concrete
{
    public class Led : IEntity,IHardware
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public DateTime LastOpeningTime { get; set; }
        public int PublicId { get ; set; }
        public string Port { get; set; }
        public string PortName { get; set; }
    }
}
