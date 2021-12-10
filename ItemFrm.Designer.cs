namespace StockProject
{
    partial class ItemFrm
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
            this.btnitemimage = new System.Windows.Forms.Button();
            this.itemcatgcombox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.itemimage = new System.Windows.Forms.PictureBox();
            this.itemview = new System.Windows.Forms.DataGridView();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.btnupdateitem = new System.Windows.Forms.Button();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadditem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnitemimage
            // 
            this.btnitemimage.Location = new System.Drawing.Point(563, 92);
            this.btnitemimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnitemimage.Name = "btnitemimage";
            this.btnitemimage.Size = new System.Drawing.Size(94, 35);
            this.btnitemimage.TabIndex = 26;
            this.btnitemimage.Text = "Select Iamge";
            this.btnitemimage.UseVisualStyleBackColor = true;
            this.btnitemimage.Click += new System.EventHandler(this.Btnitemimage_Click);
            // 
            // itemcatgcombox
            // 
            this.itemcatgcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcatgcombox.FormattingEnabled = true;
            this.itemcatgcombox.Location = new System.Drawing.Point(168, 106);
            this.itemcatgcombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemcatgcombox.Name = "itemcatgcombox";
            this.itemcatgcombox.Size = new System.Drawing.Size(129, 21);
            this.itemcatgcombox.TabIndex = 25;
            this.itemcatgcombox.SelectedIndexChanged += new System.EventHandler(this.itemcatgcombox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(58, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "catg Name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // itemimage
            // 
            this.itemimage.Location = new System.Drawing.Point(717, 61);
            this.itemimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemimage.Name = "itemimage";
            this.itemimage.Size = new System.Drawing.Size(110, 136);
            this.itemimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemimage.TabIndex = 23;
            this.itemimage.TabStop = false;
            // 
            // itemview
            // 
            this.itemview.AllowUserToAddRows = false;
            this.itemview.AllowUserToDeleteRows = false;
            this.itemview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemview.Location = new System.Drawing.Point(47, 214);
            this.itemview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemview.Name = "itemview";
            this.itemview.ReadOnly = true;
            this.itemview.RowTemplate.Height = 26;
            this.itemview.Size = new System.Drawing.Size(610, 241);
            this.itemview.TabIndex = 22;
            this.itemview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemview_CellContentClick);
            this.itemview.SelectionChanged += new System.EventHandler(this.Itemview_SelectionChanged);
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.Location = new System.Drawing.Point(563, 162);
            this.btndeleteitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(94, 35);
            this.btndeleteitem.TabIndex = 21;
            this.btndeleteitem.Text = "Delete";
            this.btndeleteitem.UseVisualStyleBackColor = true;
            this.btndeleteitem.Click += new System.EventHandler(this.Btndeleteitem_Click);
            // 
            // btnupdateitem
            // 
            this.btnupdateitem.Location = new System.Drawing.Point(449, 162);
            this.btnupdateitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdateitem.Name = "btnupdateitem";
            this.btnupdateitem.Size = new System.Drawing.Size(94, 35);
            this.btnupdateitem.TabIndex = 20;
            this.btnupdateitem.Text = "Update";
            this.btnupdateitem.UseVisualStyleBackColor = true;
            this.btnupdateitem.Click += new System.EventHandler(this.Btnupdateitem_Click);
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(168, 161);
            this.itemtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(129, 20);
            this.itemtxt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(58, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.Location = new System.Drawing.Point(326, 162);
            this.btnadditem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(94, 35);
            this.btnadditem.TabIndex = 17;
            this.btnadditem.Text = "Add new";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.Btnadditem_Click);
            // 
            // ItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.btnitemimage);
            this.Controls.Add(this.itemcatgcombox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.itemimage);
            this.Controls.Add(this.itemview);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.btnupdateitem);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnadditem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemFrm";
            this.Text = "ItemFrm";
            this.Load += new System.EventHandler(this.ItemFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnitemimage;
        private System.Windows.Forms.ComboBox itemcatgcombox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox itemimage;
        private System.Windows.Forms.DataGridView itemview;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.Button btnupdateitem;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadditem;
    }
}