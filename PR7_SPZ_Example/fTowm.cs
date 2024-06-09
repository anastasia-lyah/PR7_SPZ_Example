using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PR7_SPZ_Example
{
    public partial class fTowm : Form
    {
        private Town town;
        public fTowm(ref Town town)
        {
            InitializeComponent();
            this.town = town;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fTowm_Load(object sender, EventArgs e)
        {
            tbName.Text = town.Name;
            tbCountry.Text = town.Country;
            tbRegion.Text = town.Region;
            tbPopulation.Text = town.Population.ToString();
            tbYearIncome.Text = town.YearIncome.ToString();
            tbSquare.Text = town.Square.ToString();
            cbHasPort.Checked = town.HasPort;
            cbHasAirport.Checked = town.HasAirport;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            town.Name = tbName.Text;
            town.Country = tbCountry.Text;
            town.Region = tbRegion.Text;
            town.Population = int.Parse(tbPopulation.Text);
            town.YearIncome = double.Parse(tbYearIncome.Text);
            town.Square = double.Parse(tbSquare.Text);
            town.HasPort = cbHasPort.Checked;
            town.HasAirport = cbHasAirport.Checked;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
