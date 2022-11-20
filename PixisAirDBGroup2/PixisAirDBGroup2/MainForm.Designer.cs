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
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTomSql;
        private System.Windows.Forms.Button btnTomIBM;
        private System.Windows.Forms.Button btnJordanSql;
        private System.Windows.Forms.Button btnJordanIBM;
        private System.Windows.Forms.Button button4;
    }
}