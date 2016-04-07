using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class ResearchManager
    {
        public List<ResearchDataEntry> DataEntries { get; set; }
        private String researchDataPath;
        public bool IsOriginalResearchLoaded { get; set; }

        public ResearchManager()
        {
        }

 
        public bool loadResearch(String originalResearchFilePath)
        {
            try
            {
                DataEntries = XMLSerializer.Deserialize<List<ResearchDataEntry>>(File.ReadAllText(originalResearchFilePath));
                researchDataPath = originalResearchFilePath;
                IsOriginalResearchLoaded = true;
                return IsOriginalResearchLoaded;
                
            }
            catch (Exception e)
            {
                researchDataPath = null;
                IsOriginalResearchLoaded = false;
                return IsOriginalResearchLoaded;
            }
        }
    }
}
