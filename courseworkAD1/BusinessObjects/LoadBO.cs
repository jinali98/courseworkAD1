using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseworkAD1.BusinessObjects
{
    public class LoadBO
    {
        private string loadid;
        private string userid;
        private string jobid;
        private string unitid;

        public string Loadid { get => loadid; set => loadid = value; }
        public string Userid { get => userid; set => userid = value; }
        public string Jobid { get => jobid; set => jobid = value; }
        public string Unitid { get => unitid; set => unitid = value; }
    }
}
