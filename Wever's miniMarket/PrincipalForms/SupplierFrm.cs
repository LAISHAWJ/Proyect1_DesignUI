using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wever_s_miniMarket.CreacionEntidadesForms;
using Wever_s_miniMarket.Repository;
using Wever_s_miniMarket.Validators;

namespace Wever_s_miniMarket.PrincipalForms
{
    public partial class SupplierFrm : Form
    {
        private readonly SupplierRepos _supplierRepos;
        private readonly SupplierValid _validator;
        private Menufrm _menufrm;
        public SupplierFrm(SupplierRepos supplierRepos, SupplierValid validator, Menufrm menufrm)
        {
            InitializeComponent();
            _supplierRepos = supplierRepos;
            _validator = validator;
            _menufrm = menufrm;
        }

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (var supplierCrearadd = new SupplierCrear(_supplierRepos, _validator, this))
            {
                supplierCrearadd.ShowDialog();
            }
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            if (SupplierDGV.SelectedRows.Count > 0)
            {
                int suplidorId = (int)SupplierDGV.SelectedRows[0].Cells["SuplidorId"].Value;
                using (var supplierCrearup = new SupplierCrear(_supplierRepos, _validator, this))
                {
                    supplierCrearup.SetUpdateMode(suplidorId);
                    supplierCrearup.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un suplidor para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (SupplierDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro que desea eliminarlo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int suplidorId = (int)SupplierDGV.SelectedRows[0].Cells["SuplidorId"].Value;
                    _supplierRepos.DeleteSuplidor(suplidorId);
                    RefreshDataGridView();
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione un suplidor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RefreshDataGridView()
        {
            var suplidordvw = _supplierRepos.GetSuplidores().ToList();
            SupplierDGV.DataSource = suplidordvw;
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            _menufrm.Show();
            Close();
        }
    }
}
