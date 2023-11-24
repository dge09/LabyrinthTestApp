using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthTestApp
{
    public class TargetField : MyPath
    {
        public int FinishField { get; set; }

        public TargetField(bool isPath, int finishField) : base(isPath)
        {
            FinishField = 38;
        }
    }
}
