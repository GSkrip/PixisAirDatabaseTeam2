namespace PixisAirDBGroup2
{
    partial class Form1
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
            System.Windows.Forms.Label planeNoLabel;
            System.Windows.Forms.Label mAXDISTLabel;
            System.Windows.Forms.Label fCLASSLabel;
            System.Windows.Forms.Label cCLASSLabel;
            System.Windows.Forms.Label pAVAILLabel;
            System.Windows.Forms.Label mAINTMILESLabel;
            System.Windows.Forms.Label pLANEMODELLabel;
            System.Windows.Forms.Label pMAKELabel;
            System.Windows.Forms.Label aPARCDLabel;
            System.Windows.Forms.Label aPACDTLabel;
            System.Windows.Forms.Label aPIACDDTLabel;
            System.Windows.Forms.Label sTATUSLabel;
            System.Windows.Forms.Label dATEMAINTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pixisAirDataSet = new PixisAirDBGroup2.PixisAirDataSet();
            this.airplaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplaneTableAdapter = new PixisAirDBGroup2.PixisAirDataSetTableAdapters.AirplaneTableAdapter();
            this.tableAdapterManager = new PixisAirDBGroup2.PixisAirDataSetTableAdapters.TableAdapterManager();
            this.airplaneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.airplaneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.planeNoTextBox = new System.Windows.Forms.TextBox();
            this.mAXDISTTextBox = new System.Windows.Forms.TextBox();
            this.fCLASSTextBox = new System.Windows.Forms.TextBox();
            this.cCLASSTextBox = new System.Windows.Forms.TextBox();
            this.pAVAILTextBox = new System.Windows.Forms.TextBox();
            this.mAINTMILESTextBox = new System.Windows.Forms.TextBox();
            this.pLANEMODELTextBox = new System.Windows.Forms.TextBox();
            this.pMAKETextBox = new System.Windows.Forms.TextBox();
            this.aPARCDTextBox = new System.Windows.Forms.TextBox();
            this.aPACDTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aPIACDDTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sTATUSTextBox = new System.Windows.Forms.TextBox();
            this.dATEMAINTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            planeNoLabel = new System.Windows.Forms.Label();
            mAXDISTLabel = new System.Windows.Forms.Label();
            fCLASSLabel = new System.Windows.Forms.Label();
            cCLASSLabel = new System.Windows.Forms.Label();
            pAVAILLabel = new System.Windows.Forms.Label();
            mAINTMILESLabel = new System.Windows.Forms.Label();
            pLANEMODELLabel = new System.Windows.Forms.Label();
            pMAKELabel = new System.Windows.Forms.Label();
            aPARCDLabel = new System.Windows.Forms.Label();
            aPACDTLabel = new System.Windows.Forms.Label();
            aPIACDDTLabel = new System.Windows.Forms.Label();
            sTATUSLabel = new System.Windows.Forms.Label();
            dATEMAINTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pixisAirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingNavigator)).BeginInit();
            this.airplaneBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // planeNoLabel
            // 
            planeNoLabel.AutoSize = true;
            planeNoLabel.Location = new System.Drawing.Point(8, 31);
            planeNoLabel.Name = "planeNoLabel";
            planeNoLabel.Size = new System.Drawing.Size(54, 13);
            planeNoLabel.TabIndex = 4;
            planeNoLabel.Text = "Plane No:";
            // 
            // mAXDISTLabel
            // 
            mAXDISTLabel.AutoSize = true;
            mAXDISTLabel.Location = new System.Drawing.Point(179, 31);
            mAXDISTLabel.Name = "mAXDISTLabel";
            mAXDISTLabel.Size = new System.Drawing.Size(58, 13);
            mAXDISTLabel.TabIndex = 6;
            mAXDISTLabel.Text = "MAXDIST:";
            // 
            // fCLASSLabel
            // 
            fCLASSLabel.AutoSize = true;
            fCLASSLabel.Location = new System.Drawing.Point(357, 31);
            fCLASSLabel.Name = "fCLASSLabel";
            fCLASSLabel.Size = new System.Drawing.Size(50, 13);
            fCLASSLabel.TabIndex = 8;
            fCLASSLabel.Text = "FCLASS:";
            // 
            // cCLASSLabel
            // 
            cCLASSLabel.AutoSize = true;
            cCLASSLabel.Location = new System.Drawing.Point(520, 31);
            cCLASSLabel.Name = "cCLASSLabel";
            cCLASSLabel.Size = new System.Drawing.Size(51, 13);
            cCLASSLabel.TabIndex = 10;
            cCLASSLabel.Text = "CCLASS:";
            // 
            // pAVAILLabel
            // 
            pAVAILLabel.AutoSize = true;
            pAVAILLabel.Location = new System.Drawing.Point(686, 34);
            pAVAILLabel.Name = "pAVAILLabel";
            pAVAILLabel.Size = new System.Drawing.Size(47, 13);
            pAVAILLabel.TabIndex = 12;
            pAVAILLabel.Text = "PAVAIL:";
            // 
            // mAINTMILESLabel
            // 
            mAINTMILESLabel.AutoSize = true;
            mAINTMILESLabel.Location = new System.Drawing.Point(7, 57);
            mAINTMILESLabel.Name = "mAINTMILESLabel";
            mAINTMILESLabel.Size = new System.Drawing.Size(76, 13);
            mAINTMILESLabel.TabIndex = 14;
            mAINTMILESLabel.Text = "MAINTMILES:";
            // 
            // pLANEMODELLabel
            // 
            pLANEMODELLabel.AutoSize = true;
            pLANEMODELLabel.Location = new System.Drawing.Point(206, 57);
            pLANEMODELLabel.Name = "pLANEMODELLabel";
            pLANEMODELLabel.Size = new System.Drawing.Size(83, 13);
            pLANEMODELLabel.TabIndex = 16;
            pLANEMODELLabel.Text = "PLANEMODEL:";
            // 
            // pMAKELabel
            // 
            pMAKELabel.AutoSize = true;
            pMAKELabel.Location = new System.Drawing.Point(418, 60);
            pMAKELabel.Name = "pMAKELabel";
            pMAKELabel.Size = new System.Drawing.Size(47, 13);
            pMAKELabel.TabIndex = 18;
            pMAKELabel.Text = "PMAKE:";
            // 
            // aPARCDLabel
            // 
            aPARCDLabel.AutoSize = true;
            aPARCDLabel.Location = new System.Drawing.Point(584, 60);
            aPARCDLabel.Name = "aPARCDLabel";
            aPARCDLabel.Size = new System.Drawing.Size(54, 13);
            aPARCDLabel.TabIndex = 20;
            aPARCDLabel.Text = "APARCD:";
            // 
            // aPACDTLabel
            // 
            aPACDTLabel.AutoSize = true;
            aPACDTLabel.Location = new System.Drawing.Point(14, 87);
            aPACDTLabel.Name = "aPACDTLabel";
            aPACDTLabel.Size = new System.Drawing.Size(53, 13);
            aPACDTLabel.TabIndex = 22;
            aPACDTLabel.Text = "APACDT:";
            // 
            // aPIACDDTLabel
            // 
            aPIACDDTLabel.AutoSize = true;
            aPIACDDTLabel.Location = new System.Drawing.Point(290, 87);
            aPIACDDTLabel.Name = "aPIACDDTLabel";
            aPIACDDTLabel.Size = new System.Drawing.Size(64, 13);
            aPIACDDTLabel.TabIndex = 24;
            aPIACDDTLabel.Text = "APIACDDT:";
            // 
            // sTATUSLabel
            // 
            sTATUSLabel.AutoSize = true;
            sTATUSLabel.Location = new System.Drawing.Point(573, 87);
            sTATUSLabel.Name = "sTATUSLabel";
            sTATUSLabel.Size = new System.Drawing.Size(53, 13);
            sTATUSLabel.TabIndex = 26;
            sTATUSLabel.Text = "STATUS:";
            // 
            // dATEMAINTLabel
            // 
            dATEMAINTLabel.AutoSize = true;
            dATEMAINTLabel.Location = new System.Drawing.Point(745, 88);
            dATEMAINTLabel.Name = "dATEMAINTLabel";
            dATEMAINTLabel.Size = new System.Drawing.Size(73, 13);
            dATEMAINTLabel.TabIndex = 28;
            dATEMAINTLabel.Text = "DATEMAINT:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(801, 277);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Airplanes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pixisAirDataSet
            // 
            this.pixisAirDataSet.DataSetName = "PixisAirDataSet";
            this.pixisAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplaneBindingSource
            // 
            this.airplaneBindingSource.DataMember = "Airplane";
            this.airplaneBindingSource.DataSource = this.pixisAirDataSet;
            // 
            // airplaneTableAdapter
            // 
            this.airplaneTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplaneTableAdapter = this.airplaneTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cars2TableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PixisAirDBGroup2.PixisAirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZIPPFTableAdapter = null;
            // 
            // airplaneBindingNavigator
            // 
            this.airplaneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.airplaneBindingNavigator.BindingSource = this.airplaneBindingSource;
            this.airplaneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.airplaneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.airplaneBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.airplaneBindingNavigatorSaveItem});
            this.airplaneBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.airplaneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.airplaneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.airplaneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.airplaneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.airplaneBindingNavigator.Name = "airplaneBindingNavigator";
            this.airplaneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.airplaneBindingNavigator.Size = new System.Drawing.Size(1044, 25);
            this.airplaneBindingNavigator.TabIndex = 3;
            this.airplaneBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // airplaneBindingNavigatorSaveItem
            // 
            this.airplaneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.airplaneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("airplaneBindingNavigatorSaveItem.Image")));
            this.airplaneBindingNavigatorSaveItem.Name = "airplaneBindingNavigatorSaveItem";
            this.airplaneBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.airplaneBindingNavigatorSaveItem.Text = "Save Data";
            this.airplaneBindingNavigatorSaveItem.Click += new System.EventHandler(this.airplaneBindingNavigatorSaveItem_Click_1);
            // 
            // planeNoTextBox
            // 
            this.planeNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "PlaneNo", true));
            this.planeNoTextBox.Location = new System.Drawing.Point(68, 28);
            this.planeNoTextBox.Name = "planeNoTextBox";
            this.planeNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.planeNoTextBox.TabIndex = 5;
            // 
            // mAXDISTTextBox
            // 
            this.mAXDISTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "MAXDIST", true));
            this.mAXDISTTextBox.Location = new System.Drawing.Point(243, 28);
            this.mAXDISTTextBox.Name = "mAXDISTTextBox";
            this.mAXDISTTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAXDISTTextBox.TabIndex = 7;
            // 
            // fCLASSTextBox
            // 
            this.fCLASSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "FCLASS", true));
            this.fCLASSTextBox.Location = new System.Drawing.Point(413, 28);
            this.fCLASSTextBox.Name = "fCLASSTextBox";
            this.fCLASSTextBox.Size = new System.Drawing.Size(100, 20);
            this.fCLASSTextBox.TabIndex = 9;
            // 
            // cCLASSTextBox
            // 
            this.cCLASSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "CCLASS", true));
            this.cCLASSTextBox.Location = new System.Drawing.Point(577, 28);
            this.cCLASSTextBox.Name = "cCLASSTextBox";
            this.cCLASSTextBox.Size = new System.Drawing.Size(100, 20);
            this.cCLASSTextBox.TabIndex = 11;
            // 
            // pAVAILTextBox
            // 
            this.pAVAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "PAVAIL", true));
            this.pAVAILTextBox.Location = new System.Drawing.Point(739, 31);
            this.pAVAILTextBox.Name = "pAVAILTextBox";
            this.pAVAILTextBox.Size = new System.Drawing.Size(100, 20);
            this.pAVAILTextBox.TabIndex = 13;
            // 
            // mAINTMILESTextBox
            // 
            this.mAINTMILESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "MAINTMILES", true));
            this.mAINTMILESTextBox.Location = new System.Drawing.Point(89, 54);
            this.mAINTMILESTextBox.Name = "mAINTMILESTextBox";
            this.mAINTMILESTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAINTMILESTextBox.TabIndex = 15;
            // 
            // pLANEMODELTextBox
            // 
            this.pLANEMODELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "PLANEMODEL", true));
            this.pLANEMODELTextBox.Location = new System.Drawing.Point(295, 54);
            this.pLANEMODELTextBox.Name = "pLANEMODELTextBox";
            this.pLANEMODELTextBox.Size = new System.Drawing.Size(100, 20);
            this.pLANEMODELTextBox.TabIndex = 17;
            // 
            // pMAKETextBox
            // 
            this.pMAKETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "PMAKE", true));
            this.pMAKETextBox.Location = new System.Drawing.Point(476, 57);
            this.pMAKETextBox.Name = "pMAKETextBox";
            this.pMAKETextBox.Size = new System.Drawing.Size(100, 20);
            this.pMAKETextBox.TabIndex = 19;
            // 
            // aPARCDTextBox
            // 
            this.aPARCDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "APARCD", true));
            this.aPARCDTextBox.Location = new System.Drawing.Point(649, 57);
            this.aPARCDTextBox.Name = "aPARCDTextBox";
            this.aPARCDTextBox.Size = new System.Drawing.Size(100, 20);
            this.aPARCDTextBox.TabIndex = 21;
            // 
            // aPACDTDateTimePicker
            // 
            this.aPACDTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplaneBindingSource, "APACDT", true));
            this.aPACDTDateTimePicker.Location = new System.Drawing.Point(73, 83);
            this.aPACDTDateTimePicker.Name = "aPACDTDateTimePicker";
            this.aPACDTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.aPACDTDateTimePicker.TabIndex = 23;
            // 
            // aPIACDDTDateTimePicker
            // 
            this.aPIACDDTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplaneBindingSource, "APIACDDT", true));
            this.aPIACDDTDateTimePicker.Location = new System.Drawing.Point(360, 83);
            this.aPIACDDTDateTimePicker.Name = "aPIACDDTDateTimePicker";
            this.aPIACDDTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.aPIACDDTDateTimePicker.TabIndex = 25;
            // 
            // sTATUSTextBox
            // 
            this.sTATUSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplaneBindingSource, "STATUS", true));
            this.sTATUSTextBox.Location = new System.Drawing.Point(632, 84);
            this.sTATUSTextBox.Name = "sTATUSTextBox";
            this.sTATUSTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTATUSTextBox.TabIndex = 27;
            // 
            // dATEMAINTDateTimePicker
            // 
            this.dATEMAINTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplaneBindingSource, "DATEMAINT", true));
            this.dATEMAINTDateTimePicker.Location = new System.Drawing.Point(824, 84);
            this.dATEMAINTDateTimePicker.Name = "dATEMAINTDateTimePicker";
            this.dATEMAINTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATEMAINTDateTimePicker.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 452);
            this.Controls.Add(dATEMAINTLabel);
            this.Controls.Add(this.dATEMAINTDateTimePicker);
            this.Controls.Add(sTATUSLabel);
            this.Controls.Add(this.sTATUSTextBox);
            this.Controls.Add(aPIACDDTLabel);
            this.Controls.Add(this.aPIACDDTDateTimePicker);
            this.Controls.Add(aPACDTLabel);
            this.Controls.Add(this.aPACDTDateTimePicker);
            this.Controls.Add(aPARCDLabel);
            this.Controls.Add(this.aPARCDTextBox);
            this.Controls.Add(pMAKELabel);
            this.Controls.Add(this.pMAKETextBox);
            this.Controls.Add(pLANEMODELLabel);
            this.Controls.Add(this.pLANEMODELTextBox);
            this.Controls.Add(mAINTMILESLabel);
            this.Controls.Add(this.mAINTMILESTextBox);
            this.Controls.Add(pAVAILLabel);
            this.Controls.Add(this.pAVAILTextBox);
            this.Controls.Add(cCLASSLabel);
            this.Controls.Add(this.cCLASSTextBox);
            this.Controls.Add(fCLASSLabel);
            this.Controls.Add(this.fCLASSTextBox);
            this.Controls.Add(mAXDISTLabel);
            this.Controls.Add(this.mAXDISTTextBox);
            this.Controls.Add(planeNoLabel);
            this.Controls.Add(this.planeNoTextBox);
            this.Controls.Add(this.airplaneBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "JordanSQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixisAirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneBindingNavigator)).EndInit();
            this.airplaneBindingNavigator.ResumeLayout(false);
            this.airplaneBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PixisAirDataSet pixisAirDataSet;
        private System.Windows.Forms.BindingSource airplaneBindingSource;
        private PixisAirDataSetTableAdapters.AirplaneTableAdapter airplaneTableAdapter;
        private PixisAirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator airplaneBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton airplaneBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox planeNoTextBox;
        private System.Windows.Forms.TextBox mAXDISTTextBox;
        private System.Windows.Forms.TextBox fCLASSTextBox;
        private System.Windows.Forms.TextBox cCLASSTextBox;
        private System.Windows.Forms.TextBox pAVAILTextBox;
        private System.Windows.Forms.TextBox mAINTMILESTextBox;
        private System.Windows.Forms.TextBox pLANEMODELTextBox;
        private System.Windows.Forms.TextBox pMAKETextBox;
        private System.Windows.Forms.TextBox aPARCDTextBox;
        private System.Windows.Forms.DateTimePicker aPACDTDateTimePicker;
        private System.Windows.Forms.DateTimePicker aPIACDDTDateTimePicker;
        private System.Windows.Forms.TextBox sTATUSTextBox;
        private System.Windows.Forms.DateTimePicker dATEMAINTDateTimePicker;
    }
}

