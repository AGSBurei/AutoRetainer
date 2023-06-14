using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenturePlannerSolver.Internal.DefaultConfig
{
    internal class User
    {
        public User(int cid, string name)
        {
            this.cid = cid;
            this.name = name;
        }

        public int cid { get; set; }
        public string name { get; set; }

    }
}
