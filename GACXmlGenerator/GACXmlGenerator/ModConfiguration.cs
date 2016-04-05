using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GACXmlGenerator
{
    //[XmlRoot(ElementName = "sgr")]
    public class ModConfiguration : IMemberValidation
    {
        private String id = null;

        [XmlIgnoreAttribute]
        public String Location { get; set; }

        public String ID {
            get { return id; }
            set
            {
                id = value;
                if (!String.IsNullOrEmpty(value) && value.Contains("."))
                {
                    Author = value.Split('.')[0];
                }
            }
        }
        public String Name { get; set; }
        public String Version { get; set; }

        [XmlIgnoreAttribute]
        public String Author { get; set; }
        public bool isModLocal { get; set; }
        public bool isServerOnlyMod { get; set; }

        public ModConfiguration()
        {
            /*
            Location = "C:\\FortressCraftModsTest";
            id = "Peacoq.ModTest";
            Name = "Test Mod for Peacoq";
            Version = "1";
            Author = "Peacoq";
            isModLocal = false;
            isServerOnlyMod = false;
            */
        }

        public Dictionary<String, ValidationInfo> ValidateMembers()
        {
            Dictionary<String, ValidationInfo> infosByName = new Dictionary<String, ValidationInfo>();

            if (Directory.Exists(Location))
            {
                infosByName.Add("Location", new ValidationInfo(ValidationInfo.StatusEnum.OK));
            }
            else
            {
                infosByName.Add("Location", new ValidationInfo(ValidationInfo.StatusEnum.Error, "Directory does not exist"));
            }

            if (String.IsNullOrEmpty(ID) || !ID.Contains("."))
            {
                infosByName.Add("ID", new ValidationInfo(ValidationInfo.StatusEnum.Error, "Invalid Mod ID. ID format: AuthorName.ModName"));
            }
            else
            {
                infosByName.Add("ID", new ValidationInfo(ValidationInfo.StatusEnum.OK));
            }

            if (String.IsNullOrEmpty(Name))
            {
                infosByName.Add("Name", new ValidationInfo(ValidationInfo.StatusEnum.Error, "Mod name should not me empty"));
            }
            else
            {
                infosByName.Add("Name", new ValidationInfo(ValidationInfo.StatusEnum.OK));
            }

            int versionNumber;
            if (int.TryParse(Version,out versionNumber))
            {
                if (versionNumber > 0)
                {
                    infosByName.Add("Version", new ValidationInfo(ValidationInfo.StatusEnum.OK));
                }
                else
                {
                    infosByName.Add("Version", new ValidationInfo(ValidationInfo.StatusEnum.Error, "Version number must be positive"));
                }
                
            }
            else
            {
                infosByName.Add("Version", new ValidationInfo(ValidationInfo.StatusEnum.Error, "Version number must be a positive number"));
            }


            return infosByName;
        }
    }
}
