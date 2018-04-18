using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sklepvisualstudio
{
    public partial class LaptopDetails : Form
    {
        Laptop laptop;
        SKLEPEntitiesNew db;
        public LaptopDetails(Laptop laptop, SKLEPEntitiesNew db)
        {
            this.db = db;
            this.laptop = laptop;
            InitializeComponent();
        }

        private void LaptopDetails_Load(object sender, EventArgs e)
        {
            this.txtProcesor.Text = laptop.procesor.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            laptop.procesor = int.Parse(this.txtProcesor.Text);
            db.SaveChanges();
        }
    }
}
