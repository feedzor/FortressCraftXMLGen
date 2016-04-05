using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class ResearchDataEntry
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public String IconName { get; set; }
        public String PreDescription { get; set; }
        public String PostDescription { get; set; }
        public List<String> ResearchRequirements { get; set; }
        public List<ResearchItemRequirement> ProjectItemRequirements { get; set; }
        public int ResearchCost { get; set; }

        public bool IsOverride { get; set; }
        public List<String> RemoveResearchRequirements { get; set; }
        public List<ResearchItemRequirement> RemoveScanRequirements { get; set; }
        // ProjectItemRequirements>Requirement->Delete 

        public List<String> OriginalResearchRequirements { get; set; }
        public List<ResearchItemRequirement> OriginalScanRequirements { get; set; }

    }
}



    