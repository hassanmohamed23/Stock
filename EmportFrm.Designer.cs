namespace StockProject
{
    partial class EmportFrm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.importamounttxt = new System.Windows.Forms.TextBox();
            this.dataGridEmport = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.emportbtnadd = new System.Windows.Forms.Button();
            this.emportstorecombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmItemName = new System.Windows.Forms.ComboBox();
            this.emportudate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmport)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(324, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "amount ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(40, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "item name";
            // 
            // importamounttxt
            // 
            this.importamounttxt.Location = new System.Drawing.Point(409, 133);
            this.importamounttxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importamounttxt.Name = "importamounttxt";
            this.importamounttxt.Size = new System.Drawing.Size(134, 27);
            this.importamounttxt.TabIndex = 22;
            // 
            // dataGridEmport
            // 
            this.dataGridEmport.AllowUserToAddRows = false;
            this.dataGridEmport.AllowUserToDeleteRows = false;
            this.dataGridEmport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmport.Location = new System.Drawing.Point(153, 209);
            this.dataGridEmport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridEmport.Name = "dataGridEmport";
            this.dataGridEmport.ReadOnly = true;
            this.dataGridEmport.RowTemplate.Height = 26;
            this.dataGridEmport.Size = new System.Drawing.Size(652, 239);
            this.dataGridEmport.TabIndex = 21;
            this.dataGridEmport.SelectionChanged += new System.EventHandler(this.dataGridEmport_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(324, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "today date";
            // 
            // emportbtnadd
            // 
            this.emportbtnadd.Location = new System.Drawing.Point(589, 123);
            this.emportbtnadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emportbtnadd.Name = "emportbtnadd";
            this.emportbtnadd.Size = new System.Drawing.Size(98, 44);
            this.emportbtnadd.TabIndex = 18;
            this.emportbtnadd.Text = "Add";
            this.emportbtnadd.UseVisualStyleBackColor = true;
            this.emportbtnadd.Click += new System.EventHandler(this.emportbtnadd_Click);
            // 
            // emportstorecombobox
            // 
            this.emportstorecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emportstorecombobox.FormattingEnabled = true;
            this.emportstorecombobox.Location = new System.Drawing.Point(153, 42);
            this.emportstorecombobox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emportstorecombobox.Name = "emportstorecombobox";
            this.emportstorecombobox.Size = new System.Drawing.Size(138, 27);
            this.emportstorecombobox.TabIndex = 17;
            this.emportstorecombobox.SelectedIndexChanged += new System.EventHandler(this.emportstorecombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(40, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "select store";
            // 
            // cmItemName
            // 
            this.cmItemName.FormattingEnabled = true;
            this.cmItemName.Location = new System.Drawing.Point(153, 131);
            this.cmItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmItemName.Name = "cmItemName";
            this.cmItemName.Size = new System.Drawing.Size(138, 27);
            this.cmItemName.TabIndex = 25;
            this.cmItemName.SelectedIndexChanged += new System.EventHandler(this.cmItemName_SelectedIndexChanged);
            // 
            // emportudate
            // 
            this.emportudate.Location = new System.Drawing.Point(707, 123);
            this.emportudate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emportudate.Name = "emportudate";
            this.emportudate.Size = new System.Drawing.Size(98, 44);
            this.emportudate.TabIndex = 26;
            this.emportudate.Text = "Update";
            this.emportudate.UseVisualStyleBackColor = true;
            this.emportudate.Click += new System.EventHandler(this.emportudate_Click);
            // 
            // EmportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 535);
            this.Controls.Add(this.emportudate);
            this.Controls.Add(this.cmItemName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.importamounttxt);
            this.Controls.Add(this.dataGridEmport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emportbtnadd);
            this.Controls.Add(this.emportstorecombobox);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmportFrm";
            this.Text = "EmportFrm";
            this.Load += new System.EventHandler(this.EmportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox importamounttxt;
        private System.Windows.Forms.DataGridView dataGridEmport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button emportbtnadd;
        private System.Windows.Forms.ComboBox emportstorecombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmItemName;
        private System.Windows.Forms.Button emportudate;
    }
}