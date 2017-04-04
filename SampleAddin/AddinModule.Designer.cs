namespace SampleAddin
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
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
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adxWordTaskPanesManager1 = new AddinExpress.WD.ADXWordTaskPanesManager(this.components);
            this.adxWordTaskPanesCollectionItem1 = new AddinExpress.WD.ADXWordTaskPanesCollectionItem(this.components);
            // 
            // adxWordTaskPanesManager1
            // 
            this.adxWordTaskPanesManager1.Items.Add(this.adxWordTaskPanesCollectionItem1);
            this.adxWordTaskPanesManager1.SetOwner(this);
            // 
            // adxWordTaskPanesCollectionItem1
            // 
            this.adxWordTaskPanesCollectionItem1.AlwaysShowHeader = true;
            this.adxWordTaskPanesCollectionItem1.Position = AddinExpress.WD.ADXWordTaskPanePosition.Right;
            this.adxWordTaskPanesCollectionItem1.TaskPaneClassName = "SampleAddin.ADXWordTaskPane1";
            // 
            // AddinModule
            // 
            this.AddinName = "SampleAddin";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaWord;

        }
        #endregion

        private AddinExpress.WD.ADXWordTaskPanesManager adxWordTaskPanesManager1;
        private AddinExpress.WD.ADXWordTaskPanesCollectionItem adxWordTaskPanesCollectionItem1;
    }
}

