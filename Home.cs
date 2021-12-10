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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            StockFrm sf = new StockFrm();
            sf.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            CatgFrm cf = new CatgFrm();
            cf.Show();
        
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ItemFrm iff = new ItemFrm();
            iff.Show();
           
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            EmportFrm emf = new EmportFrm();
            emf.Show();
        
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            ExportFrm exf = new ExportFrm();
            exf.Show(); 
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            ReportFrm repf = new ReportFrm();
            repf.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
