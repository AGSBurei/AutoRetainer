using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenturePlannerSolver.Internal.DefaultConfig
{
    internal class Retainer
    {
        public Retainer(string name, int level, int job, int iLevel, int gathering, int perception, int displayOrder)
        {
            this.name = name;
            this.level = level;
            this.job = job;
            this.iLevel = iLevel;
            this.gathering = gathering;
            this.perception = perception;
            this.displayOrder = displayOrder;
        }

        private string name { get; set; }
        private int level { get; set; }
        private int job { get; set; }
        private int iLevel { get; set; }
        private int gathering { get; set; }
        private int perception { get; set; }
        private int displayOrder { get; set; }
    }
}
