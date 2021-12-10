using LogLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject
{
    public partial class ItemFrm : Form
    {
        public ItemFrm()
        {
            InitializeComponent();
        }
        Linqconnection linq1 = new Linqconnection();
        private void ItemFrm_Load(object sender, EventArgs e)
        {
            itemtxt.Text = " ";
            itemcatgcombox.DataSource= linq1.fill_data_grid_view("Catg");
            itemcatgcombox.DisplayMember = "Catg_Name";
            itemcatgcombox.ValueMember = "Catg_ID";
            itemview.DataSource = linq1.fill_data_grid_view("Item");
            itemtxt.Text = " ";
        }

        private void Btnadditem_Click(object sender, EventArgs e)
        {
            if (itemtxt.Text != null && itemcatgcombox.SelectedIndex>-1)
            {
                //MessageBox.Show(itemcatgcombox.ValueMember.Items[itemcatgcombox.SelectedIndex].ToString());
                //MessageBox.Show(itemtxt.Text+"  "+ itemcatgcombox.SelectedValue.ToString() + "  " + itemimage.Image);
                linq1.add_new_obj(new Item()
                {
                    Item_Name = itemtxt.Text,
                    Item_Image =  "not save",
                    Item_Catg_ID = int.Parse(itemcatgcombox.SelectedValue.ToString())
                });
                itemview.DataSource = linq1.fill_data_grid_view("Item");
                itemtxt.Text = "";
            }
        } 
        private void Btnitemimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images|*.jpg;*.png;*.gif;*.bmp;";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                itemimage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Btnupdateitem_Click(object sender, EventArgs e)
        {
            if (itemview.CurrentRow != null && itemtxt.Text != "" && itemcatgcombox.SelectedIndex > -1)
            {
                int cid = int.Parse(itemview.CurrentRow.Cells["Item_ID"].Value.ToString());
                 
                linq1.make_update(new Item
                {
                    Item_ID=cid,
                    Item_Name = itemtxt.Text,
                    Item_Image = "not save",
                    Item_Catg_ID = int.Parse(itemcatgcombox.SelectedValue.ToString())
                });
                itemtxt.Text = "";
                itemview.DataSource = linq1.fill_data_grid_view("Item");
                itemtxt.Text = " ";
            }
        }

        private void Itemview_SelectionChanged(object sender, EventArgs e)
        {
            if (itemview.CurrentRow != null)
            {
                itemtxt.Text = itemview.CurrentRow.Cells["Item_Name"].Value.ToString();
                itemcatgcombox.SelectedItem = int.Parse(itemview.CurrentRow.Cells["Item_Catg_ID"].Value.ToString());
            }
        }

        private void Btndeleteitem_Click(object sender, EventArgs e)
        {
            if (itemview.CurrentRow != null)
            {
                int cid = int.Parse(itemview.CurrentRow.Cells["Item_ID"].Value.ToString());
                linq1.make_delete(new Item { Item_ID = cid });
                itemview.DataSource = linq1.fill_data_grid_view("Item");
                itemtxt.Text = "";
            }
        }

        private void itemcatgcombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
