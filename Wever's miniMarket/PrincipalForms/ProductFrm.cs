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
    public partial class ProductFrm : Form
    {
        private readonly ProductRepos _productRepos;

        public ProductFrm(ProductRepos productRepos)
        {
            InitializeComponent();
            _productRepos = productRepos;
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            var productodvw = _productRepos.GetProductos();
            ProductDGV.DataSource = productodvw;
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
