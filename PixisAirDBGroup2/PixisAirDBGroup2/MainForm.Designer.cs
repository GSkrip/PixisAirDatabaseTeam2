namespace PixisAirDBGroup2
{
    partial class MainForm
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
            this.btnTomSql = new System.Windows.Forms.Button();
            this.btnTomIBM = new System.Windows.Forms.Button();
            this.btnJordanSql = new System.Windows.Forms.Button();
            this.btnJordanIBM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportDB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTomSql
            // 
            this.btnTomSql.Location = new System.Drawing.Point(559, 108);
            this.btnTomSql.Name = "btnTomSql";
            this.btnTomSql.Size = new System.Drawing.Size(106, 57);
            this.btnTomSql.TabIndex = 0;
            this.btnTomSql.Text = "Tom Airport SQL";
            this.btnTomSql.UseVisualStyleBackColor = true;
            this.btnTomSql.Click += new System.EventHandler(this.btnTomSql_Click);
            // 
            // btnTomIBM
            // 
            this.btnTomIBM.Location = new System.Drawing.Point(559, 183);
            this.btnTomIBM.Name = "btnTomIBM";
            this.btnTomIBM.Size = new System.Drawing.Size(106, 54);
            this.btnTomIBM.TabIndex = 1;
            this.btnTomIBM.Text = "Tom Airport IBM";
            this.btnTomIBM.UseVisualStyleBackColor = true;
            this.btnTomIBM.Click += new System.EventHandler(this.btnTomIBM_Click);
            // 
            // btnJordanSql
            // 
            this.btnJordanSql.Location = new System.Drawing.Point(346, 108);
            this.btnJordanSql.Name = "btnJordanSql";
            this.btnJordanSql.Size = new System.Drawing.Size(113, 57);
            this.btnJordanSql.TabIndex = 2;
            this.btnJordanSql.Text = "Jordan Airplane SQL";
            this.btnJordanSql.UseVisualStyleBackColor = true;
            this.btnJordanSql.Click += new System.EventHandler(this.btnJordanSql_Click);
            // 
            // btnJordanIBM
            // 
            this.btnJordanIBM.Location = new System.Drawing.Point(346, 183);
            this.btnJordanIBM.Name = "btnJordanIBM";
            this.btnJordanIBM.Size = new System.Drawing.Size(113, 54);
            this.btnJordanIBM.TabIndex = 3;
            this.btnJordanIBM.Text = "Jordan Airplane IBM";
            this.btnJordanIBM.UseVisualStyleBackColor = true;
            this.btnJordanIBM.Click += new System.EventHandler(this.btnJordanIBM_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "Greg Route IBM and SQL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeToolStripMenuItem,
            this.airplaneToolStripMenuItem,
            this.airportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeToolStripMenuItem1});
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.routeToolStripMenuItem.Text = "Route";
            // 
            // airplaneToolStripMenuItem
            // 
            this.airplaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airplaneSQLToolStripMenuItem,
            this.airplaneDB2ToolStripMenuItem});
            this.airplaneToolStripMenuItem.Name = "airplaneToolStripMenuItem";
            this.airplaneToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.airplaneToolStripMenuItem.Text = "Airplane";
            // 
            // airportToolStripMenuItem
            // 
            this.airportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airportSQLToolStripMenuItem,
            this.airportDB2ToolStripMenuItem});
            this.airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            this.airportToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.airportToolStripMenuItem.Text = "Airport";
            // 
            // airplaneSQLToolStripMenuItem
            // 
            this.airplaneSQLToolStripMenuItem.Name = "airplaneSQLToolStripMenuItem";
            this.airplaneSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.airplaneSQLToolStripMenuItem.Text = "Airplane SQL";
            this.airplaneSQLToolStripMenuItem.Click += new System.EventHandler(this.airplaneSQLToolStripMenuItem_Click);
            // 
            // airplaneDB2ToolStripMenuItem
            // 
            this.airplaneDB2ToolStripMenuItem.Name = "airplaneDB2ToolStripMenuItem";
            this.airplaneDB2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.airplaneDB2ToolStripMenuItem.Text = "Airplane DB2";
            this.airplaneDB2ToolStripMenuItem.Click += new System.EventHandler(this.airplaneDB2ToolStripMenuItem_Click);
            // 
            // airportSQLToolStripMenuItem
            // 
            this.airportSQLToolStripMenuItem.Name = "airportSQLToolStripMenuItem";
            this.airportSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.airportSQLToolStripMenuItem.Text = "Airport SQL";
            this.airportSQLToolStripMenuItem.Click += new System.EventHandler(this.airportSQLToolStripMenuItem_Click);
            // 
            // airportDB2ToolStripMenuItem
            // 
            this.airportDB2ToolStripMenuItem.Name = "airportDB2ToolStripMenuItem";
            this.airportDB2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.airportDB2ToolStripMenuItem.Text = "Airport DB2";
            this.airportDB2ToolStripMenuItem.Click += new System.EventHandler(this.airportDB2ToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem1
            // 
            this.routeToolStripMenuItem1.Name = "routeToolStripMenuItem1";
            this.routeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.routeToolStripMenuItem1.Text = "Route";
            this.routeToolStripMenuItem1.Click += new System.EventHandler(this.routeToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnJordanIBM);
            this.Controls.Add(this.btnJordanSql);
            this.Controls.Add(this.btnTomIBM);
            this.Controls.Add(this.btnTomSql);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTomSql;
        private System.Windows.Forms.Button btnTomIBM;
        private System.Windows.Forms.Button btnJordanSql;
        private System.Windows.Forms.Button btnJordanIBM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem airplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airplaneSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airplaneDB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportDB2ToolStripMenuItem;
    }
}