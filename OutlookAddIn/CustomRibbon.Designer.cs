﻿namespace OutlookAddIn
{
    partial class CustomRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CustomRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = this.Factory.CreateRibbonTab();
            this.group = this.Factory.CreateRibbonGroup();
            this.btnSendMessage = this.Factory.CreateRibbonButton();
            this.tab.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Groups.Add(this.group);
            this.tab.Label = "Extra Send Message";
            this.tab.Name = "tab";
            // 
            // group
            // 
            this.group.Items.Add(this.btnSendMessage);
            this.group.Name = "group";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSendMessage.Image = global::OutlookAddIn.Properties.Resources.send_message;
            this.btnSendMessage.Label = "Send message";
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.ShowImage = true;
            this.btnSendMessage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSendMessage_Click);
            // 
            // CustomRibbon
            // 
            this.Name = "CustomRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibbon_Load);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSendMessage;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibbon CustomRibbon
        {
            get { return this.GetRibbon<CustomRibbon>(); }
        }
    }
}
