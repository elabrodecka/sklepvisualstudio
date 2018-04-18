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
    public partial class LaptopyLista : Form
    {
        SKLEPEntitiesNew db; //do otwierania formularza Laptopy
        public LaptopyLista (SKLEPEntitiesNew sklepEntities) //do otwierania formularza Laptopy
        {
            db = sklepEntities; //do otwierania formularza Laptopy
            InitializeComponent(); //do otwierania formularza Laptopy
        }

        private void LaptopyLista_Load(object sender, EventArgs e) 
        {
            this.gridLaptopy.DataSource = db.Laptop.ToList(); //wyswietlanie pol z tabeli Laptopy
        }

        private void gridLaptopy_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Laptop selectedLaptop= (Laptop)((DataGridView)sender).CurrentRow.DataBoundItem;
            LaptopDetails laptopDetails = new LaptopDetails(selectedLaptop, db);
            laptopDetails.Show();
        }
    }
}
