using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseworkAD1.BusinessObjects
{
    public class UnitsBO
    {
        private string unitid;
        private string driverName;
        private string assistantName;
        private int lorryNumber;
        private int containerNumber;

        public string Unitid { get => unitid; set => unitid = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        public string AssistantName { get => assistantName; set => assistantName = value; }
        public int LorryNumber { get => lorryNumber; set => lorryNumber = value; }
        public int ContainerNumber { get => containerNumber; set => containerNumber = value; }
    }
}
