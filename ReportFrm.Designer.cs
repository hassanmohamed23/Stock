namespace StockProject
{
    partial class ReportFrm
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
            this.exportview = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.reportcombox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).BeginInit();
            this.SuspendLayout();
            // 
            // exportview
            // 
            this.exportview.AllowUserToAddRows = false;
            this.exportview.AllowUserToDeleteRows = false;
            this.exportview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportview.Location = new System.Drawing.Point(47, 192);
            this.exportview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportview.Name = "exportview";
            this.exportview.ReadOnly = true;
            this.exportview.RowTemplate.Height = 26;
            this.exportview.Size = new System.Drawing.Size(779, 279);
            this.exportview.TabIndex = 30;
            this.exportview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exportview_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(442, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "today date";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // reportcombox
            // 
            this.reportcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportcombox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.reportcombox.FormattingEnabled = true;
            this.reportcombox.Location = new System.Drawing.Point(151, 94);
            this.reportcombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportcombox.Name = "reportcombox";
            this.reportcombox.Size = new System.Drawing.Size(205, 27);
            this.reportcombox.TabIndex = 26;
            this.reportcombox.SelectedIndexChanged += new System.EventHandler(this.reportcombox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(47, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "select store";
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 535);
            this.Controls.Add(this.exportview);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reportcombox);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportFrm";
            this.Text = "ReportFrm";
            this.Load += new System.EventHandler(this.ReportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView exportview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox reportcombox;
        private System.Windows.Forms.Label label12;
    }
}