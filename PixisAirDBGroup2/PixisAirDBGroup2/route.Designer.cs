namespace PixisAirDBGroup2
{
    partial class route
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
            System.Windows.Forms.Label rTIDLabel;
            System.Windows.Forms.Label rTARDEPARTLabel;
            System.Windows.Forms.Label rTARARRIVLLabel;
            System.Windows.Forms.Label rTDISTANCELabel;
            System.Windows.Forms.Label rTESTTMLabel;
            System.Windows.Forms.Label rTBASECOSTLabel;
            System.Windows.Forms.Label rTACTDTLabel;
            System.Windows.Forms.Label rTIACTDTLabel;
            System.Windows.Forms.Label rTNOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(route));
            this.routeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pixisAirDataSet = new PixisAirDBGroup2.PixisAirDataSet();
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
            this.routeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rTIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTARDEPARTTextBox = new System.Windows.Forms.TextBox();
            this.rTARARRIVLTextBox = new System.Windows.Forms.TextBox();
            this.rTDISTANCETextBox = new System.Windows.Forms.TextBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.rTESTTMTextBox = new System.Windows.Forms.TextBox();
            this.rTBASECOSTTextBox = new System.Windows.Forms.TextBox();
            this.rTACTDTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rTIACTDTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rTNOTextBox = new System.Windows.Forms.TextBox();
            this.routeTableAdapter = new PixisAirDBGroup2.PixisAirDataSetTableAdapters.RouteTableAdapter();
            this.tableAdapterManager = new PixisAirDBGroup2.PixisAirDataSetTableAdapters.TableAdapterManager();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.sqlSearchButton = new System.Windows.Forms.Button();
            this.db2SearchButton = new System.Windows.Forms.Button();
            this.db2UpdateButton = new System.Windows.Forms.Button();
            rTIDLabel = new System.Windows.Forms.Label();
            rTARDEPARTLabel = new System.Windows.Forms.Label();
            rTARARRIVLLabel = new System.Windows.Forms.Label();
            rTDISTANCELabel = new System.Windows.Forms.Label();
            rTESTTMLabel = new System.Windows.Forms.Label();
            rTBASECOSTLabel = new System.Windows.Forms.Label();
            rTACTDTLabel = new System.Windows.Forms.Label();
            rTIACTDTLabel = new System.Windows.Forms.Label();
            rTNOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingNavigator)).BeginInit();
            this.routeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixisAirDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rTIDLabel
            // 
            rTIDLabel.AutoSize = true;
            rTIDLabel.Location = new System.Drawing.Point(12, 31);
            rTIDLabel.Name = "rTIDLabel";
            rTIDLabel.Size = new System.Drawing.Size(36, 13);
            rTIDLabel.TabIndex = 1;
            rTIDLabel.Text = "RTID:";
            // 
            // rTARDEPARTLabel
            // 
            rTARDEPARTLabel.AutoSize = true;
            rTARDEPARTLabel.Location = new System.Drawing.Point(285, 29);
            rTARDEPARTLabel.Name = "rTARDEPARTLabel";
            rTARDEPARTLabel.Size = new System.Drawing.Size(84, 13);
            rTARDEPARTLabel.TabIndex = 5;
            rTARDEPARTLabel.Text = "RTARDEPART:";
            // 
            // rTARARRIVLLabel
            // 
            rTARARRIVLLabel.AutoSize = true;
            rTARARRIVLLabel.Location = new System.Drawing.Point(546, 31);
            rTARARRIVLLabel.Name = "rTARARRIVLLabel";
            rTARARRIVLLabel.Size = new System.Drawing.Size(79, 13);
            rTARARRIVLLabel.TabIndex = 7;
            rTARARRIVLLabel.Text = "RTARARRIVL:";
            // 
            // rTDISTANCELabel
            // 
            rTDISTANCELabel.AutoSize = true;
            rTDISTANCELabel.Location = new System.Drawing.Point(12, 57);
            rTDISTANCELabel.Name = "rTDISTANCELabel";
            rTDISTANCELabel.Size = new System.Drawing.Size(79, 13);
            rTDISTANCELabel.TabIndex = 9;
            rTDISTANCELabel.Text = "RTDISTANCE:";
            // 
            // rTESTTMLabel
            // 
            rTESTTMLabel.AutoSize = true;
            rTESTTMLabel.Location = new System.Drawing.Point(307, 55);
            rTESTTMLabel.Name = "rTESTTMLabel";
            rTESTTMLabel.Size = new System.Drawing.Size(62, 13);
            rTESTTMLabel.TabIndex = 11;
            rTESTTMLabel.Text = "RTESTTM:";
            // 
            // rTBASECOSTLabel
            // 
            rTBASECOSTLabel.AutoSize = true;
            rTBASECOSTLabel.Location = new System.Drawing.Point(546, 57);
            rTBASECOSTLabel.Name = "rTBASECOSTLabel";
            rTBASECOSTLabel.Size = new System.Drawing.Size(82, 13);
            rTBASECOSTLabel.TabIndex = 13;
            rTBASECOSTLabel.Text = "RTBASECOST:";
            // 
            // rTACTDTLabel
            // 
            rTACTDTLabel.AutoSize = true;
            rTACTDTLabel.Location = new System.Drawing.Point(14, 95);
            rTACTDTLabel.Name = "rTACTDTLabel";
            rTACTDTLabel.Size = new System.Drawing.Size(61, 13);
            rTACTDTLabel.TabIndex = 15;
            rTACTDTLabel.Text = "RTACTDT:";
            // 
            // rTIACTDTLabel
            // 
            rTIACTDTLabel.AutoSize = true;
            rTIACTDTLabel.Location = new System.Drawing.Point(291, 93);
            rTIACTDTLabel.Name = "rTIACTDTLabel";
            rTIACTDTLabel.Size = new System.Drawing.Size(64, 13);
            rTIACTDTLabel.TabIndex = 17;
            rTIACTDTLabel.Text = "RTIACTDT:";
            // 
            // rTNOLabel
            // 
            rTNOLabel.AutoSize = true;
            rTNOLabel.Location = new System.Drawing.Point(584, 92);
            rTNOLabel.Name = "rTNOLabel";
            rTNOLabel.Size = new System.Drawing.Size(41, 13);
            rTNOLabel.TabIndex = 19;
            rTNOLabel.Text = "RTNO:";
            // 
            // routeBindingNavigator
            // 
            this.routeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.routeBindingNavigator.BindingSource = this.routeBindingSource;
            this.routeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.routeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.routeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.routeBindingNavigatorSaveItem});
            this.routeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.routeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.routeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.routeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.routeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.routeBindingNavigator.Name = "routeBindingNavigator";
            this.routeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.routeBindingNavigator.Size = new System.Drawing.Size(1087, 25);
            this.routeBindingNavigator.TabIndex = 0;
            this.routeBindingNavigator.Text = "bindingNavigator1";
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
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.pixisAirDataSet;
            // 
            // pixisAirDataSet
            // 
            this.pixisAirDataSet.DataSetName = "PixisAirDataSet";
            this.pixisAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // routeBindingNavigatorSaveItem
            // 
            this.routeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.routeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("routeBindingNavigatorSaveItem.Image")));
            this.routeBindingNavigatorSaveItem.Name = "routeBindingNavigatorSaveItem";
            this.routeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.routeBindingNavigatorSaveItem.Text = "Save Data";
            this.routeBindingNavigatorSaveItem.Click += new System.EventHandler(this.routeBindingNavigatorSaveItem_Click);
            // 
            // rTIDTextBox
            // 
            this.rTIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTID", true));
            this.rTIDTextBox.Location = new System.Drawing.Point(97, 28);
            this.rTIDTextBox.Name = "rTIDTextBox";
            this.rTIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTIDTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Routes by City:";
            // 
            // rTARDEPARTTextBox
            // 
            this.rTARDEPARTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTARDEPART", true));
            this.rTARDEPARTTextBox.Location = new System.Drawing.Point(375, 28);
            this.rTARDEPARTTextBox.Name = "rTARDEPARTTextBox";
            this.rTARDEPARTTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTARDEPARTTextBox.TabIndex = 6;
            // 
            // rTARARRIVLTextBox
            // 
            this.rTARARRIVLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTARARRIVL", true));
            this.rTARARRIVLTextBox.Location = new System.Drawing.Point(631, 28);
            this.rTARARRIVLTextBox.Name = "rTARARRIVLTextBox";
            this.rTARARRIVLTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTARARRIVLTextBox.TabIndex = 8;
            // 
            // rTDISTANCETextBox
            // 
            this.rTDISTANCETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTDISTANCE", true));
            this.rTDISTANCETextBox.Location = new System.Drawing.Point(97, 54);
            this.rTDISTANCETextBox.Name = "rTDISTANCETextBox";
            this.rTDISTANCETextBox.Size = new System.Drawing.Size(100, 20);
            this.rTDISTANCETextBox.TabIndex = 10;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(0, 120);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(820, 368);
            this.displayListBox.TabIndex = 11;
            // 
            // rTESTTMTextBox
            // 
            this.rTESTTMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTESTTM", true));
            this.rTESTTMTextBox.Location = new System.Drawing.Point(375, 54);
            this.rTESTTMTextBox.Name = "rTESTTMTextBox";
            this.rTESTTMTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTESTTMTextBox.TabIndex = 12;
            // 
            // rTBASECOSTTextBox
            // 
            this.rTBASECOSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTBASECOST", true));
            this.rTBASECOSTTextBox.Location = new System.Drawing.Point(631, 58);
            this.rTBASECOSTTextBox.Name = "rTBASECOSTTextBox";
            this.rTBASECOSTTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTBASECOSTTextBox.TabIndex = 14;
            // 
            // rTACTDTDateTimePicker
            // 
            this.rTACTDTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "RTACTDT", true));
            this.rTACTDTDateTimePicker.Location = new System.Drawing.Point(81, 91);
            this.rTACTDTDateTimePicker.Name = "rTACTDTDateTimePicker";
            this.rTACTDTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rTACTDTDateTimePicker.TabIndex = 16;
            // 
            // rTIACTDTDateTimePicker
            // 
            this.rTIACTDTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "RTIACTDT", true));
            this.rTIACTDTDateTimePicker.Location = new System.Drawing.Point(361, 89);
            this.rTIACTDTDateTimePicker.Name = "rTIACTDTDateTimePicker";
            this.rTIACTDTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rTIACTDTDateTimePicker.TabIndex = 18;
            // 
            // rTNOTextBox
            // 
            this.rTNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "RTNO", true));
            this.rTNOTextBox.Location = new System.Drawing.Point(631, 89);
            this.rTNOTextBox.Name = "rTNOTextBox";
            this.rTNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTNOTextBox.TabIndex = 20;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplaneTableAdapter = null;
            this.tableAdapterManager.AIRPORTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.UpdateOrder = PixisAirDBGroup2.PixisAirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(869, 184);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(149, 20);
            this.cityTextBox.TabIndex = 21;
            // 
            // sqlSearchButton
            // 
            this.sqlSearchButton.Location = new System.Drawing.Point(869, 210);
            this.sqlSearchButton.Name = "sqlSearchButton";
            this.sqlSearchButton.Size = new System.Drawing.Size(149, 93);
            this.sqlSearchButton.TabIndex = 22;
            this.sqlSearchButton.Text = "SQL Search";
            this.sqlSearchButton.UseVisualStyleBackColor = true;
            this.sqlSearchButton.Click += new System.EventHandler(this.sqlSearchButton_Click);
            // 
            // db2SearchButton
            // 
            this.db2SearchButton.Location = new System.Drawing.Point(869, 309);
            this.db2SearchButton.Name = "db2SearchButton";
            this.db2SearchButton.Size = new System.Drawing.Size(149, 82);
            this.db2SearchButton.TabIndex = 23;
            this.db2SearchButton.Text = "DB2 Search";
            this.db2SearchButton.UseVisualStyleBackColor = true;
            this.db2SearchButton.Click += new System.EventHandler(this.db2SearchButton_Click);
            // 
            // db2UpdateButton
            // 
            this.db2UpdateButton.Location = new System.Drawing.Point(869, 58);
            this.db2UpdateButton.Name = "db2UpdateButton";
            this.db2UpdateButton.Size = new System.Drawing.Size(149, 40);
            this.db2UpdateButton.TabIndex = 25;
            this.db2UpdateButton.Text = "DB2 Update";
            this.db2UpdateButton.UseVisualStyleBackColor = true;
            this.db2UpdateButton.Click += new System.EventHandler(this.db2UpdateButton_Click);
            // 
            // route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 500);
            this.Controls.Add(this.db2UpdateButton);
            this.Controls.Add(this.db2SearchButton);
            this.Controls.Add(this.sqlSearchButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(rTNOLabel);
            this.Controls.Add(this.rTNOTextBox);
            this.Controls.Add(rTIACTDTLabel);
            this.Controls.Add(this.rTIACTDTDateTimePicker);
            this.Controls.Add(rTACTDTLabel);
            this.Controls.Add(this.rTACTDTDateTimePicker);
            this.Controls.Add(rTBASECOSTLabel);
            this.Controls.Add(this.rTBASECOSTTextBox);
            this.Controls.Add(rTESTTMLabel);
            this.Controls.Add(this.rTESTTMTextBox);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(rTDISTANCELabel);
            this.Controls.Add(this.rTDISTANCETextBox);
            this.Controls.Add(rTARARRIVLLabel);
            this.Controls.Add(this.rTARARRIVLTextBox);
            this.Controls.Add(rTARDEPARTLabel);
            this.Controls.Add(this.rTARDEPARTTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(rTIDLabel);
            this.Controls.Add(this.rTIDTextBox);
            this.Controls.Add(this.routeBindingNavigator);
            this.Name = "route";
            this.Text = "route";
            this.Load += new System.EventHandler(this.route_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingNavigator)).EndInit();
            this.routeBindingNavigator.ResumeLayout(false);
            this.routeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixisAirDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PixisAirDataSet pixisAirDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private PixisAirDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private PixisAirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator routeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton routeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rTIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rTARDEPARTTextBox;
        private System.Windows.Forms.TextBox rTARARRIVLTextBox;
        private System.Windows.Forms.TextBox rTDISTANCETextBox;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.TextBox rTESTTMTextBox;
        private System.Windows.Forms.TextBox rTBASECOSTTextBox;
        private System.Windows.Forms.DateTimePicker rTACTDTDateTimePicker;
        private System.Windows.Forms.DateTimePicker rTIACTDTDateTimePicker;
        private System.Windows.Forms.TextBox rTNOTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button sqlSearchButton;
        private System.Windows.Forms.Button db2SearchButton;
        private System.Windows.Forms.Button db2UpdateButton;
    }
}