using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseworkAD1.BusinessObjects
{
    public class JobBO
    {
        private string pickupLocation;
        private string dropOffLocation;
        private int numberOfLoads;
        private string productName;
        private string productId;
        private string jobStatus;
        private DateTime date;
        private string contactNumber;
        private string jobId;
        private string userid;

        public string PickupLocation { get => pickupLocation; set => pickupLocation = value; }
        public string DropOffLocation { get => dropOffLocation; set => dropOffLocation = value; }
        public int NumberOfLoads { get => numberOfLoads; set => numberOfLoads = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }
        public DateTime Date { get => date; set => date = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string JobId { get => jobId; set => jobId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string Userid { get => userid; set => userid = value; }
    }
}
