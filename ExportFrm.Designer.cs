namespace StockProject
{
    partial class ExportFrm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.exportamounttxt = new System.Windows.Forms.TextBox();
            this.exportview = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.exportbtnadd = new System.Windows.Forms.Button();
            this.exportstorecombox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmboxitemexport = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(389, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "amount ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(47, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "item name";
            // 
            // exportamounttxt
            // 
            this.exportamounttxt.Location = new System.Drawing.Point(482, 119);
            this.exportamounttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportamounttxt.Name = "exportamounttxt";
            this.exportamounttxt.Size = new System.Drawing.Size(136, 20);
            this.exportamounttxt.TabIndex = 31;
            // 
            // exportview
            // 
            this.exportview.AllowUserToAddRows = false;
            this.exportview.AllowUserToDeleteRows = false;
            this.exportview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportview.Location = new System.Drawing.Point(51, 178);
            this.exportview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportview.Name = "exportview";
            this.exportview.ReadOnly = true;
            this.exportview.RowTemplate.Height = 26;
            this.exportview.Size = new System.Drawing.Size(726, 282);
            this.exportview.TabIndex = 30;
            this.exportview.SelectionChanged += new System.EventHandler(this.exportview_SelectionChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(389, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "today date";
            // 
            // exportbtnadd
            // 
            this.exportbtnadd.Location = new System.Drawing.Point(669, 117);
            this.exportbtnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportbtnadd.Name = "exportbtnadd";
            this.exportbtnadd.Size = new System.Drawing.Size(64, 32);
            this.exportbtnadd.TabIndex = 27;
            this.exportbtnadd.Text = "Add";
            this.exportbtnadd.UseVisualStyleBackColor = true;
            this.exportbtnadd.Click += new System.EventHandler(this.exportbtnadd_Click);
            // 
            // exportstorecombox
            // 
            this.exportstorecombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exportstorecombox.FormattingEnabled = true;
            this.exportstorecombox.Location = new System.Drawing.Point(163, 47);
            this.exportstorecombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportstorecombox.Name = "exportstorecombox";
            this.exportstorecombox.Size = new System.Drawing.Size(141, 21);
            this.exportstorecombox.TabIndex = 26;
            this.exportstorecombox.SelectedIndexChanged += new System.EventHandler(this.exportstorecombox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(47, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "select store";
            // 
            // cmboxitemexport
            // 
            this.cmboxitemexport.FormattingEnabled = true;
            this.cmboxitemexport.Location = new System.Drawing.Point(163, 115);
            this.cmboxitemexport.Name = "cmboxitemexport";
            this.cmboxitemexport.Size = new System.Drawing.Size(141, 21);
            this.cmboxitemexport.TabIndex = 34;
            // 
            // ExportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 535);
            this.Controls.Add(this.cmboxitemexport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.exportamounttxt);
            this.Controls.Add(this.exportview);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.exportbtnadd);
            this.Controls.Add(this.exportstorecombox);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExportFrm";
            this.Text = "ExportFrm";
            this.Load += new System.EventHandler(this.ExportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox exportamounttxt;
        private System.Windows.Forms.DataGridView exportview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button exportbtnadd;
        private System.Windows.Forms.ComboBox exportstorecombox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmboxitemexport;
    }
}