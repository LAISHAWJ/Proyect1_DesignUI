using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wever_s_miniMarket.Repository;

namespace Wever_s_miniMarket.PrincipalForms
{
    public partial class SupplierFrm : Form
    {
        private readonly SupplierRepos _supplierRepos;
        public SupplierFrm(SupplierRepos supplierRepos)
        {
            InitializeComponent();
            _supplierRepos = supplierRepos;
        }

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            var suplidordvw = _supplierRepos.GetSuplidores();
            SupplierDGV.DataSource = suplidordvw;
        }
    }
}
