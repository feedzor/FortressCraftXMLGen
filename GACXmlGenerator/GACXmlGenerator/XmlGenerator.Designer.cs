namespace GACXmlGenerator
{
    partial class XmlGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button addItemBtn;
            System.Windows.Forms.Button deleteItemBtn;
            System.Windows.Forms.Button itemRRAddBtn;
            System.Windows.Forms.Button itemRRDeleteBtn;
            System.Windows.Forms.Button itemSRDeleteBtn;
            System.Windows.Forms.Button itemSRAddBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlGenerator));
            this.configurationTab = new System.Windows.Forms.TabControl();
            this.globalTabPage = new System.Windows.Forms.TabPage();
            this.modIsServerOnlyChk = new System.Windows.Forms.CheckBox();
            this.modIsLocalChk = new System.Windows.Forms.CheckBox();
            this.modAuthorLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modVersionStatus = new System.Windows.Forms.Label();
            this.modVersionTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modIDStatus = new System.Windows.Forms.Label();
            this.modIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modNameStatus = new System.Windows.Forms.Label();
            this.modLocationStatus = new System.Windows.Forms.Label();
            this.modLocationTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.searchItems = new System.Windows.Forms.TextBox();
            this.itemsAttributesPanel = new System.Windows.Forms.Panel();
            this.itemCategoryCmb = new System.Windows.Forms.ComboBox();
            this.itemSpriteCmb = new System.Windows.Forms.ComboBox();
            this.itemPluralTxt = new System.Windows.Forms.TextBox();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.itemKeyTxt = new System.Windows.Forms.TextBox();
            this.itemSRLst = new System.Windows.Forms.ListBox();
            this.itemSRSearchCmb = new System.Windows.Forms.ComboBox();
            this.itemRRLst = new System.Windows.Forms.ListBox();
            this.itemRRSearchCmb = new System.Windows.Forms.ComboBox();
            this.itemOverrideChk = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.itemObjectCmb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.itemTypeCmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemsLst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectPathSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.generateXMLBtn = new System.Windows.Forms.Button();
            this.modFCEDataLocation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.FCEFolderLocationStatus = new System.Windows.Forms.Label();
            addItemBtn = new System.Windows.Forms.Button();
            deleteItemBtn = new System.Windows.Forms.Button();
            itemRRAddBtn = new System.Windows.Forms.Button();
            itemRRDeleteBtn = new System.Windows.Forms.Button();
            itemSRDeleteBtn = new System.Windows.Forms.Button();
            itemSRAddBtn = new System.Windows.Forms.Button();
            this.configurationTab.SuspendLayout();
            this.globalTabPage.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.itemsAttributesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            addItemBtn.Location = new System.Drawing.Point(7, 372);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new System.Drawing.Size(53, 32);
            addItemBtn.TabIndex = 2;
            addItemBtn.Text = "Add";
            this.toolTips.SetToolTip(addItemBtn, "Creates a new item. Entries will automatically be created for both handbook and r" +
        "esearch.");
            addItemBtn.UseVisualStyleBackColor = true;
            // 
            // deleteItemBtn
            // 
            deleteItemBtn.Location = new System.Drawing.Point(81, 371);
            deleteItemBtn.Name = "deleteItemBtn";
            deleteItemBtn.Size = new System.Drawing.Size(58, 32);
            deleteItemBtn.TabIndex = 3;
            deleteItemBtn.Text = "Delete";
            deleteItemBtn.UseVisualStyleBackColor = true;
            // 
            // itemRRAddBtn
            // 
            itemRRAddBtn.Location = new System.Drawing.Point(456, 42);
            itemRRAddBtn.Name = "itemRRAddBtn";
            itemRRAddBtn.Size = new System.Drawing.Size(53, 21);
            itemRRAddBtn.TabIndex = 14;
            itemRRAddBtn.Text = "Add";
            this.toolTips.SetToolTip(itemRRAddBtn, "Creates a new item. Entries will automatically be created for both handbook and r" +
        "esearch.");
            itemRRAddBtn.UseVisualStyleBackColor = true;
            // 
            // itemRRDeleteBtn
            // 
            itemRRDeleteBtn.Location = new System.Drawing.Point(456, 67);
            itemRRDeleteBtn.Name = "itemRRDeleteBtn";
            itemRRDeleteBtn.Size = new System.Drawing.Size(53, 28);
            itemRRDeleteBtn.TabIndex = 15;
            itemRRDeleteBtn.Text = "Delete";
            itemRRDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // itemSRDeleteBtn
            // 
            itemSRDeleteBtn.Location = new System.Drawing.Point(456, 234);
            itemSRDeleteBtn.Name = "itemSRDeleteBtn";
            itemSRDeleteBtn.Size = new System.Drawing.Size(53, 28);
            itemSRDeleteBtn.TabIndex = 19;
            itemSRDeleteBtn.Text = "Delete";
            itemSRDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // itemSRAddBtn
            // 
            itemSRAddBtn.Location = new System.Drawing.Point(456, 209);
            itemSRAddBtn.Name = "itemSRAddBtn";
            itemSRAddBtn.Size = new System.Drawing.Size(53, 21);
            itemSRAddBtn.TabIndex = 18;
            itemSRAddBtn.Text = "Add";
            this.toolTips.SetToolTip(itemSRAddBtn, "Creates a new item. Entries will automatically be created for both handbook and r" +
        "esearch.");
            itemSRAddBtn.UseVisualStyleBackColor = true;
            // 
            // configurationTab
            // 
            this.configurationTab.Controls.Add(this.globalTabPage);
            this.configurationTab.Controls.Add(this.itemsTabPage);
            this.configurationTab.Location = new System.Drawing.Point(13, 40);
            this.configurationTab.Name = "configurationTab";
            this.configurationTab.SelectedIndex = 0;
            this.configurationTab.Size = new System.Drawing.Size(755, 451);
            this.configurationTab.TabIndex = 0;
            // 
            // globalTabPage
            // 
            this.globalTabPage.Controls.Add(this.FCEFolderLocationStatus);
            this.globalTabPage.Controls.Add(this.modFCEDataLocation);
            this.globalTabPage.Controls.Add(this.label17);
            this.globalTabPage.Controls.Add(this.modIsServerOnlyChk);
            this.globalTabPage.Controls.Add(this.modIsLocalChk);
            this.globalTabPage.Controls.Add(this.modAuthorLbl);
            this.globalTabPage.Controls.Add(this.label4);
            this.globalTabPage.Controls.Add(this.modVersionStatus);
            this.globalTabPage.Controls.Add(this.modVersionTxt);
            this.globalTabPage.Controls.Add(this.label6);
            this.globalTabPage.Controls.Add(this.modIDStatus);
            this.globalTabPage.Controls.Add(this.modIDTxt);
            this.globalTabPage.Controls.Add(this.label5);
            this.globalTabPage.Controls.Add(this.modNameStatus);
            this.globalTabPage.Controls.Add(this.modLocationStatus);
            this.globalTabPage.Controls.Add(this.modLocationTxt);
            this.globalTabPage.Controls.Add(this.label3);
            this.globalTabPage.Controls.Add(this.modNameTxt);
            this.globalTabPage.Controls.Add(this.label2);
            this.globalTabPage.Location = new System.Drawing.Point(4, 22);
            this.globalTabPage.Name = "globalTabPage";
            this.globalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.globalTabPage.Size = new System.Drawing.Size(747, 425);
            this.globalTabPage.TabIndex = 0;
            this.globalTabPage.Text = "Global";
            this.globalTabPage.UseVisualStyleBackColor = true;
            // 
            // modIsServerOnlyChk
            // 
            this.modIsServerOnlyChk.AutoSize = true;
            this.modIsServerOnlyChk.Location = new System.Drawing.Point(104, 196);
            this.modIsServerOnlyChk.Name = "modIsServerOnlyChk";
            this.modIsServerOnlyChk.Size = new System.Drawing.Size(110, 17);
            this.modIsServerOnlyChk.TabIndex = 15;
            this.modIsServerOnlyChk.Text = "IsServerOnlyMod ";
            this.modIsServerOnlyChk.UseVisualStyleBackColor = true;
            // 
            // modIsLocalChk
            // 
            this.modIsLocalChk.AutoSize = true;
            this.modIsLocalChk.Location = new System.Drawing.Point(104, 172);
            this.modIsLocalChk.Name = "modIsLocalChk";
            this.modIsLocalChk.Size = new System.Drawing.Size(80, 17);
            this.modIsLocalChk.TabIndex = 14;
            this.modIsLocalChk.Text = "isLocalMod";
            this.modIsLocalChk.UseVisualStyleBackColor = true;
            // 
            // modAuthorLbl
            // 
            this.modAuthorLbl.AutoSize = true;
            this.modAuthorLbl.Location = new System.Drawing.Point(145, 98);
            this.modAuthorLbl.Name = "modAuthorLbl";
            this.modAuthorLbl.Size = new System.Drawing.Size(0, 13);
            this.modAuthorLbl.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Author: ";
            // 
            // modVersionStatus
            // 
            this.modVersionStatus.AutoSize = true;
            this.modVersionStatus.Location = new System.Drawing.Point(323, 148);
            this.modVersionStatus.Name = "modVersionStatus";
            this.modVersionStatus.Size = new System.Drawing.Size(22, 13);
            this.modVersionStatus.TabIndex = 11;
            this.modVersionStatus.Text = "";
            // 
            // modVersionTxt
            // 
            this.modVersionTxt.Location = new System.Drawing.Point(104, 145);
            this.modVersionTxt.Name = "modVersionTxt";
            this.modVersionTxt.Size = new System.Drawing.Size(201, 20);
            this.modVersionTxt.TabIndex = 10;
            this.modVersionTxt.TextChanged += new System.EventHandler(this.modVersionTxt_TextChanged);
            this.modVersionTxt.Validating += new System.ComponentModel.CancelEventHandler(this.modVersionTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Version";
            this.toolTips.SetToolTip(this.label6, "Unique id for this mods, it must start with your author id followed by a period a" +
        "nd should ideally be descriptive of the mods purpose.  For example: Example.Farm" +
        "ingMachines ");
            // 
            // modIDStatus
            // 
            this.modIDStatus.AutoSize = true;
            this.modIDStatus.Location = new System.Drawing.Point(323, 74);
            this.modIDStatus.Name = "modIDStatus";
            this.modIDStatus.Size = new System.Drawing.Size(22, 13);
            this.modIDStatus.TabIndex = 8;
            this.modIDStatus.Text = "";
            // 
            // modIDTxt
            // 
            this.modIDTxt.Location = new System.Drawing.Point(104, 71);
            this.modIDTxt.Name = "modIDTxt";
            this.modIDTxt.Size = new System.Drawing.Size(201, 20);
            this.modIDTxt.TabIndex = 7;
            this.modIDTxt.Validating += new System.ComponentModel.CancelEventHandler(this.modIDTxt_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            this.toolTips.SetToolTip(this.label5, "Unique id for this mods, it must start with your author id followed by a period a" +
        "nd should ideally be descriptive of the mods purpose.  For example: Example.Farm" +
        "ingMachines ");
            // 
            // modNameStatus
            // 
            this.modNameStatus.AutoSize = true;
            this.modNameStatus.Location = new System.Drawing.Point(323, 122);
            this.modNameStatus.Name = "modNameStatus";
            this.modNameStatus.Size = new System.Drawing.Size(22, 13);
            this.modNameStatus.TabIndex = 5;
            this.modNameStatus.Text = "";
            // 
            // modLocationStatus
            // 
            this.modLocationStatus.AutoSize = true;
            this.modLocationStatus.Location = new System.Drawing.Point(323, 48);
            this.modLocationStatus.Name = "modLocationStatus";
            this.modLocationStatus.Size = new System.Drawing.Size(22, 13);
            this.modLocationStatus.TabIndex = 4;
            this.modLocationStatus.Text = "";
            // 
            // modLocationTxt
            // 
            this.modLocationTxt.Location = new System.Drawing.Point(104, 45);
            this.modLocationTxt.Name = "modLocationTxt";
            this.modLocationTxt.Size = new System.Drawing.Size(201, 20);
            this.modLocationTxt.TabIndex = 3;
            this.modLocationTxt.Click += new System.EventHandler(this.modLocationTxt_Click);
            this.modLocationTxt.Validating += new System.ComponentModel.CancelEventHandler(this.modLocationTxt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mod Location";
            this.toolTips.SetToolTip(this.label3, "Your Mod Files will be generated under this directory");
            // 
            // modNameTxt
            // 
            this.modNameTxt.Location = new System.Drawing.Point(104, 119);
            this.modNameTxt.Name = "modNameTxt";
            this.modNameTxt.Size = new System.Drawing.Size(201, 20);
            this.modNameTxt.TabIndex = 1;
            this.modNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.modNameTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.toolTips.SetToolTip(this.label2, "Unique id for this mods, it must start with your author id followed by a period a" +
        "nd should ideally be descriptive of the mods purpose.  For example: Example.Farm" +
        "ingMachines ");
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.AutoScroll = true;
            this.itemsTabPage.Controls.Add(this.label16);
            this.itemsTabPage.Controls.Add(this.searchItems);
            this.itemsTabPage.Controls.Add(deleteItemBtn);
            this.itemsTabPage.Controls.Add(addItemBtn);
            this.itemsTabPage.Controls.Add(this.itemsAttributesPanel);
            this.itemsTabPage.Controls.Add(this.itemsLst);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(747, 425);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Filter items";
            // 
            // searchItems
            // 
            this.searchItems.Location = new System.Drawing.Point(7, 36);
            this.searchItems.Name = "searchItems";
            this.searchItems.Size = new System.Drawing.Size(132, 20);
            this.searchItems.TabIndex = 4;
            // 
            // itemsAttributesPanel
            // 
            this.itemsAttributesPanel.Controls.Add(this.itemCategoryCmb);
            this.itemsAttributesPanel.Controls.Add(this.itemSpriteCmb);
            this.itemsAttributesPanel.Controls.Add(this.itemPluralTxt);
            this.itemsAttributesPanel.Controls.Add(this.itemNameTxt);
            this.itemsAttributesPanel.Controls.Add(this.itemKeyTxt);
            this.itemsAttributesPanel.Controls.Add(itemSRDeleteBtn);
            this.itemsAttributesPanel.Controls.Add(itemSRAddBtn);
            this.itemsAttributesPanel.Controls.Add(this.itemSRLst);
            this.itemsAttributesPanel.Controls.Add(this.itemSRSearchCmb);
            this.itemsAttributesPanel.Controls.Add(itemRRDeleteBtn);
            this.itemsAttributesPanel.Controls.Add(itemRRAddBtn);
            this.itemsAttributesPanel.Controls.Add(this.itemRRLst);
            this.itemsAttributesPanel.Controls.Add(this.itemRRSearchCmb);
            this.itemsAttributesPanel.Controls.Add(this.itemOverrideChk);
            this.itemsAttributesPanel.Controls.Add(this.label15);
            this.itemsAttributesPanel.Controls.Add(this.label14);
            this.itemsAttributesPanel.Controls.Add(this.label13);
            this.itemsAttributesPanel.Controls.Add(this.itemObjectCmb);
            this.itemsAttributesPanel.Controls.Add(this.label12);
            this.itemsAttributesPanel.Controls.Add(this.itemTypeCmb);
            this.itemsAttributesPanel.Controls.Add(this.label11);
            this.itemsAttributesPanel.Controls.Add(this.label10);
            this.itemsAttributesPanel.Controls.Add(this.label9);
            this.itemsAttributesPanel.Controls.Add(this.label8);
            this.itemsAttributesPanel.Controls.Add(this.label7);
            this.itemsAttributesPanel.Location = new System.Drawing.Point(161, 36);
            this.itemsAttributesPanel.Name = "itemsAttributesPanel";
            this.itemsAttributesPanel.Size = new System.Drawing.Size(562, 368);
            this.itemsAttributesPanel.TabIndex = 1;
            // 
            // itemCategoryCmb
            // 
            this.itemCategoryCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemCategoryCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemCategoryCmb.FormattingEnabled = true;
            this.itemCategoryCmb.Location = new System.Drawing.Point(91, 186);
            this.itemCategoryCmb.Name = "itemCategoryCmb";
            this.itemCategoryCmb.Size = new System.Drawing.Size(179, 21);
            this.itemCategoryCmb.TabIndex = 24;
            // 
            // itemSpriteCmb
            // 
            this.itemSpriteCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemSpriteCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemSpriteCmb.FormattingEnabled = true;
            this.itemSpriteCmb.Location = new System.Drawing.Point(91, 162);
            this.itemSpriteCmb.Name = "itemSpriteCmb";
            this.itemSpriteCmb.Size = new System.Drawing.Size(179, 21);
            this.itemSpriteCmb.TabIndex = 23;
            // 
            // itemPluralTxt
            // 
            this.itemPluralTxt.Location = new System.Drawing.Point(91, 91);
            this.itemPluralTxt.Name = "itemPluralTxt";
            this.itemPluralTxt.Size = new System.Drawing.Size(179, 20);
            this.itemPluralTxt.TabIndex = 22;
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(91, 69);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(179, 20);
            this.itemNameTxt.TabIndex = 21;
            // 
            // itemKeyTxt
            // 
            this.itemKeyTxt.Location = new System.Drawing.Point(91, 47);
            this.itemKeyTxt.Name = "itemKeyTxt";
            this.itemKeyTxt.Size = new System.Drawing.Size(179, 20);
            this.itemKeyTxt.TabIndex = 20;
            // 
            // itemSRLst
            // 
            this.itemSRLst.FormattingEnabled = true;
            this.itemSRLst.Location = new System.Drawing.Point(330, 234);
            this.itemSRLst.Name = "itemSRLst";
            this.itemSRLst.Size = new System.Drawing.Size(120, 95);
            this.itemSRLst.TabIndex = 17;
            // 
            // itemSRSearchCmb
            // 
            this.itemSRSearchCmb.FormattingEnabled = true;
            this.itemSRSearchCmb.Location = new System.Drawing.Point(329, 209);
            this.itemSRSearchCmb.Name = "itemSRSearchCmb";
            this.itemSRSearchCmb.Size = new System.Drawing.Size(121, 21);
            this.itemSRSearchCmb.TabIndex = 16;
            // 
            // itemRRLst
            // 
            this.itemRRLst.FormattingEnabled = true;
            this.itemRRLst.Location = new System.Drawing.Point(330, 67);
            this.itemRRLst.Name = "itemRRLst";
            this.itemRRLst.Size = new System.Drawing.Size(120, 95);
            this.itemRRLst.TabIndex = 13;
            // 
            // itemRRSearchCmb
            // 
            this.itemRRSearchCmb.FormattingEnabled = true;
            this.itemRRSearchCmb.Location = new System.Drawing.Point(329, 42);
            this.itemRRSearchCmb.Name = "itemRRSearchCmb";
            this.itemRRSearchCmb.Size = new System.Drawing.Size(121, 21);
            this.itemRRSearchCmb.TabIndex = 12;
            // 
            // itemOverrideChk
            // 
            this.itemOverrideChk.AutoSize = true;
            this.itemOverrideChk.Location = new System.Drawing.Point(91, 26);
            this.itemOverrideChk.Name = "itemOverrideChk";
            this.itemOverrideChk.Size = new System.Drawing.Size(134, 17);
            this.itemOverrideChk.TabIndex = 11;
            this.itemOverrideChk.Text = "Override Existing Item?";
            this.toolTips.SetToolTip(this.itemOverrideChk, "Check this if you want to override an existing item");
            this.itemOverrideChk.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "ScanRequirements";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "ResearchRequirements";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Category";
            this.toolTips.SetToolTip(this.label13, "This controls which category this item appears under in the handbook.");
            // 
            // itemObjectCmb
            // 
            this.itemObjectCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemObjectCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemObjectCmb.FormattingEnabled = true;
            this.itemObjectCmb.Location = new System.Drawing.Point(91, 138);
            this.itemObjectCmb.Name = "itemObjectCmb";
            this.itemObjectCmb.Size = new System.Drawing.Size(179, 21);
            this.itemObjectCmb.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Sprite";
            this.toolTips.SetToolTip(this.label12, "This is the icon to be used for this item in the UI.  \r\nIt is not possible to add" +
        " custom icons through the official API at this time. ");
            // 
            // itemTypeCmb
            // 
            this.itemTypeCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemTypeCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemTypeCmb.FormattingEnabled = true;
            this.itemTypeCmb.Location = new System.Drawing.Point(91, 114);
            this.itemTypeCmb.Name = "itemTypeCmb";
            this.itemTypeCmb.Size = new System.Drawing.Size(179, 21);
            this.itemTypeCmb.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Object";
            this.toolTips.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Type";
            this.toolTips.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Plural";
            this.toolTips.SetToolTip(this.label9, "Plural display name for this item");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            this.toolTips.SetToolTip(this.label8, "Display name for this item");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Key";
            this.toolTips.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // itemsLst
            // 
            this.itemsLst.FormattingEnabled = true;
            this.itemsLst.Location = new System.Drawing.Point(7, 62);
            this.itemsLst.Name = "itemsLst";
            this.itemsLst.Size = new System.Drawing.Size(132, 303);
            this.itemsLst.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fill general tab first. If you need more help, hover over labels, they have toolt" +
    "ips.";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(508, 509);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 26);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.toolTips.SetToolTip(this.btnLoad, "Select the version folder containing your xml files");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // generateXMLBtn
            // 
            this.generateXMLBtn.Location = new System.Drawing.Point(633, 509);
            this.generateXMLBtn.Name = "generateXMLBtn";
            this.generateXMLBtn.Size = new System.Drawing.Size(131, 26);
            this.generateXMLBtn.TabIndex = 2;
            this.generateXMLBtn.Text = "Generate";
            this.generateXMLBtn.UseVisualStyleBackColor = true;
            this.generateXMLBtn.Click += new System.EventHandler(this.generateXMLBtn_Click);
            // 
            // modFCEDataLocation
            // 
            this.modFCEDataLocation.Location = new System.Drawing.Point(104, 19);
            this.modFCEDataLocation.Name = "modFCEDataLocation";
            this.modFCEDataLocation.Size = new System.Drawing.Size(201, 20);
            this.modFCEDataLocation.TabIndex = 17;
            this.toolTips.SetToolTip(this.modFCEDataLocation, "\"Location of FCE installation. Only need to supply if it is empty, or you want to" +
        " use a custom location.\"");
            this.modFCEDataLocation.Click += new System.EventHandler(this.modFCEDataLocation_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "FCE Data Folder";
            this.toolTips.SetToolTip(this.label17, "Your Mod Files will be generated under this directory");
            // 
            // FCEFolderLocationStatus
            // 
            this.FCEFolderLocationStatus.AutoSize = true;
            this.FCEFolderLocationStatus.Location = new System.Drawing.Point(323, 22);
            this.FCEFolderLocationStatus.Name = "FCEFolderLocationStatus";
            this.FCEFolderLocationStatus.Size = new System.Drawing.Size(22, 13);
            this.FCEFolderLocationStatus.TabIndex = 18;
            this.FCEFolderLocationStatus.Text = "";
            // 
            // XmlGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(793, 547);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.generateXMLBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configurationTab);
            this.Name = "XmlGenerator";
            this.Text = "XMLGenerator";
            this.Load += new System.EventHandler(this.XmlGenerator_Load);
            this.configurationTab.ResumeLayout(false);
            this.globalTabPage.ResumeLayout(false);
            this.globalTabPage.PerformLayout();
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            this.itemsAttributesPanel.ResumeLayout(false);
            this.itemsAttributesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl configurationTab;
        private System.Windows.Forms.TabPage globalTabPage;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.FolderBrowserDialog projectPathSelector;
        private System.Windows.Forms.TextBox modLocationTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label modNameStatus;
        private System.Windows.Forms.Label modLocationStatus;
        private System.Windows.Forms.Label modIDStatus;
        private System.Windows.Forms.TextBox modIDTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label modVersionStatus;
        private System.Windows.Forms.TextBox modVersionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label modAuthorLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox modIsServerOnlyChk;
        private System.Windows.Forms.CheckBox modIsLocalChk;
        private System.Windows.Forms.Button generateXMLBtn;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox searchItems;
        private System.Windows.Forms.Panel itemsAttributesPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox itemsLst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox itemSRLst;
        private System.Windows.Forms.ComboBox itemSRSearchCmb;
        private System.Windows.Forms.ListBox itemRRLst;
        private System.Windows.Forms.ComboBox itemRRSearchCmb;
        private System.Windows.Forms.CheckBox itemOverrideChk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox itemObjectCmb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox itemTypeCmb;
        private System.Windows.Forms.ComboBox itemCategoryCmb;
        private System.Windows.Forms.ComboBox itemSpriteCmb;
        private System.Windows.Forms.TextBox itemPluralTxt;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.TextBox itemKeyTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox modFCEDataLocation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label FCEFolderLocationStatus;
    }
}

