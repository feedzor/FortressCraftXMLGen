using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GACXmlGenerator
{
    public partial class XmlGenerator : Form
    {
        Boolean isFCEDataFolderValid = false;
        Boolean isGlobalSectionDataValid;
        FilesLocations filesLocations;
        ModConfiguration modConfiguration;
        ResearchManager researchManager = new ResearchManager();
        ItemsManager itemsManager;
        
        

        public String FCEFolderLocation { get; set; }

        public XmlGenerator()
        {
            InitializeComponent();
        }

        private void updateGlobalTabBindings()
        {
            //Generic 
            modFCEDataLocation.DataBindings.Clear();
            modFCEDataLocation.DataBindings.Add("Text", this, "FCEFolderLocation", false, DataSourceUpdateMode.OnPropertyChanged);

            //For modConfigurationObject
            modLocationTxt.DataBindings.Clear();
            modLocationTxt.DataBindings.Add("Text", modConfiguration, "Location", false, DataSourceUpdateMode.OnPropertyChanged);
            modIDTxt.DataBindings.Clear();
            modIDTxt.DataBindings.Add("Text", modConfiguration, "ID", false, DataSourceUpdateMode.OnPropertyChanged);
            modNameTxt.DataBindings.Clear();
            modNameTxt.DataBindings.Add("Text", modConfiguration, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            modVersionTxt.DataBindings.Clear();
            modVersionTxt.DataBindings.Add("Text", modConfiguration, "Version", false, DataSourceUpdateMode.OnPropertyChanged);
            modAuthorLbl.DataBindings.Clear();
            modAuthorLbl.DataBindings.Add("Text", modConfiguration, "Author", false, DataSourceUpdateMode.OnPropertyChanged);
            modIsLocalChk.DataBindings.Clear();
            modIsLocalChk.DataBindings.Add("Checked", modConfiguration, "isModLocal", false, DataSourceUpdateMode.OnPropertyChanged);
            modIsServerOnlyChk.DataBindings.Clear();
            modIsServerOnlyChk.DataBindings.Add("Checked", modConfiguration, "isServerOnlyMod", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void updateItemsTabBindings()
        {
            itemTypeCmb.DataSource = itemsManager.ItemTypes;
            itemObjectCmb.DataSource = itemsManager.ItemObjects;
            itemSpriteCmb.DataSource = itemsManager.ItemSprites;
            itemCategoryCmb.DataSource = itemsManager.ItemCategories;

            rebindItemsToCurrentItem();
        }

        private void rebindItemsToCurrentItem()
        {
            itemTypeCmb.DataBindings.Clear();
            itemTypeCmb.DataBindings.Add("Text", itemsManager.CurrentItem, "Type", false, DataSourceUpdateMode.OnPropertyChanged);
            itemObjectCmb.DataBindings.Add("Text", itemsManager.CurrentItem, "Object", false, DataSourceUpdateMode.OnPropertyChanged);
            itemSpriteCmb.DataBindings.Add("Text", itemsManager.CurrentItem, "Sprite", false, DataSourceUpdateMode.OnPropertyChanged);
            itemCategoryCmb.DataBindings.Add("Text", itemsManager.CurrentItem, "Category", false, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void XmlGenerator_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Program Files (x86)\Steam\steamapps\common\FortressCraft\64\Default"))
            {
                FCEFolderLocation = @"C:\Program Files (x86)\Steam\steamapps\common\FortressCraft\64\Default";
                researchManager.loadResearch(Path.Combine(FCEFolderLocation, "Data", "Research.xml"));
            }

            

            modConfiguration = new ModConfiguration();
            filesLocations = new FilesLocations(modConfiguration);
            itemsManager = new ItemsManager();


            // Data bindings
            updateGlobalTabBindings();
            updateItemsTabBindings();
        }

        public void loadFCEdataFolder(String fceDataFolderDirectory)
        {
            if (Directory.Exists(fceDataFolderDirectory))
            {
                FCEFolderLocation = @"C:\Program Files (x86)\Steam\steamapps\common\FortressCraft\64\Default";
                if (researchManager.loadResearch(Path.Combine(FCEFolderLocation, "Data", "Research.xml")))
                {
                    isFCEDataFolderValid = true;
                }
                else
                {
                    isFCEDataFolderValid = false;
                    DisplayValidationStatus(FCEFolderLocationStatus, new ValidationInfo(ValidationInfo.StatusEnum.Error, "Invalid FCE data folder location\n." +
                        " The folder should looks something like: \"C:\\Program Files (x86)\\Steam\\steamapps\\common\\FortressCraft\\64\\Default \".\n Research.xml"));
                }
            }
        }

        private void UpdateTabsAccess()
        {
            
        }

        private void modLocationTxt_Click(object sender, EventArgs e)
        {
            projectPathSelector.SelectedPath = modConfiguration.Location;
            projectPathSelector.ShowNewFolderButton = true;
            projectPathSelector.ShowDialog();
            modConfiguration.Location = projectPathSelector.SelectedPath;
            modLocationTxt.Text = modConfiguration.Location;
        }

        private void modLocationTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateModProperties();
        }

        private void modIDTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateModProperties();
        }

        private void modNameTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateModProperties();
        }

        private void modVersionTxt_Validating(object sender, CancelEventArgs e)
        {
            ValidateModProperties();
        }

        private void ValidateModProperties()
        {
            isGlobalSectionDataValid = true;
            Dictionary<String, ValidationInfo> infosByName = modConfiguration.ValidateMembers();
            DisplayValidationStatus(modLocationStatus, infosByName["Location"]);
            DisplayValidationStatus(modIDStatus, infosByName["ID"]);
            DisplayValidationStatus(modNameStatus, infosByName["Name"]);
            DisplayValidationStatus(modVersionStatus, infosByName["Version"]);
            
        }

        public void DisplayValidationStatus(Label label, ValidationInfo info)
        {
            switch (info.Status)
            {
                case ValidationInfo.StatusEnum.OK:
                    label.ForeColor = Color.Green;
                    break;
                case ValidationInfo.StatusEnum.Error:
                    label.ForeColor = Color.Red;
                    isGlobalSectionDataValid = false;
                    break;
                case ValidationInfo.StatusEnum.Warning:
                    label.ForeColor = Color.Yellow;
                    break;
            }
            label.Text = info.Message;
        }

        private void modVersionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateXMLBtn_Click(object sender, EventArgs e)
        {
            ValidateModProperties();

            if (isGlobalSectionDataValid && isFCEDataFolderValid)
            {
                String serializedProperties = XMLSerializer.Serialize<ModConfiguration>(modConfiguration,false);
                Directory.CreateDirectory(filesLocations.VersionedRootPath);
                System.IO.File.WriteAllText(filesLocations.ModConfigFilePath,serializedProperties);
            }
            else
            {
                MessageBox.Show("Error, fix errors (RED Status messages) before attempting to generate files.", "Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            projectPathSelector.ShowDialog();
            String versionFolderPath = projectPathSelector.SelectedPath;
            String modConfigFilePath = Path.Combine(versionFolderPath, "mod.config");
            if (File.Exists(modConfigFilePath))
            {

                modConfiguration = XMLSerializer.Deserialize<ModConfiguration>(File.ReadAllText(modConfigFilePath));
                String idFolderPath = (Directory.GetParent(versionFolderPath)).FullName;
                String rootFolderPath = (Directory.GetParent(idFolderPath)).FullName;
                modConfiguration.Location = rootFolderPath;
                filesLocations = new FilesLocations(modConfiguration);
                updateGlobalTabBindings();
            }
            else
            {
                MessageBox.Show("Failed to load, because could not find mod.config in selected directory", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }


        private void modFCEDataLocation_Click(object sender, EventArgs e)
        {
            projectPathSelector.SelectedPath = FCEFolderLocation;
            projectPathSelector.ShowNewFolderButton = false;
            projectPathSelector.ShowDialog();
            FCEFolderLocation = projectPathSelector.SelectedPath;
            modLocationTxt.Text = FCEFolderLocation;
        }

        private void modFCEDataLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
