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
using Wever_s_miniMarket.Models;
using Wever_s_miniMarket.Repository;
using Wever_s_miniMarket.Validators;

namespace Wever_s_miniMarket.PrincipalForms
{
    public partial class ProductFrm : Form
    {
        private readonly ProductRepos _productRepos;
        private readonly CategoryRepos _categoryRepos;
        private readonly SupplierRepos _supplierRepos;
        private readonly ProductValid _validator;
        private Menufrm _menufrm;

        public ProductFrm(ProductRepos productRepos, CategoryRepos categoryRepos, SupplierRepos supplierRepos, ProductValid validator, Menufrm menufrm)
        {
            InitializeComponent();
            _productRepos = productRepos;
            _categoryRepos = categoryRepos;
            _supplierRepos = supplierRepos;
            _validator = validator;
            _menufrm = menufrm;
            LoadComboBoxData();
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (var productCrearadd = new ProductCrear(_productRepos, _categoryRepos, _supplierRepos, _validator, this))
            {
                productCrearadd.ShowDialog();
            }
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            if (ProductDGV.SelectedRows.Count > 0)
            {
                int productoId = (int)ProductDGV.SelectedRows[0].Cells["ProductoId"].Value;
                using (var productUpd = new ProductCrear(_productRepos, _categoryRepos, _supplierRepos, _validator, this))
                {
                    productUpd.SetUpdateMode(productoId);
                    productUpd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (ProductDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro que desea eliminarlo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int productoId = (int)ProductDGV.SelectedRows[0].Cells["ProductoId"].Value;
                    _productRepos.DeleteProducto(productoId);
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            _menufrm.Show();
            Close();
        }

        public void RefreshDataGridView()
        {
            var productodvw = _productRepos.GetProductos().ToList();
            ProductDGV.DataSource = productodvw;
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            int? categoriaId = CategFiltroCbx.SelectedIndex > 0 ? (int?)CategFiltroCbx.SelectedValue : null;
            int? suplidorId = SuppFiltroCbx.SelectedIndex > 0 ? (int?)SuppFiltroCbx.SelectedValue : null;

            var productos = _productRepos.GetProductos().ToList();
            if (categoriaId.HasValue)
            {
                productos = productos.Where(p => p.CategoriaId == categoriaId.Value).ToList();
            }
            if (suplidorId.HasValue)
            {
                productos = productos.Where(p => p.SuplidorId == suplidorId.Value).ToList();
            }
            ProductDGV.DataSource = productos;
        }

        private void LoadComboBoxData()
        {
            CategFiltroCbx.DataSource = new List<object> { new { Nombre = "Todas", CategoriaId = 0 } }
             .Concat(_categoryRepos.GetCategorias().Select(c => new { c.Nombre, c.CategoriaId }).ToList())
             .ToList();
            CategFiltroCbx.DisplayMember = "Nombre";
            CategFiltroCbx.ValueMember = "CategoriaId";

            SuppFiltroCbx.DataSource = new List<object> { new { NombreEmpresa = "Todos", SuplidorId = 0 } }
                .Concat(_supplierRepos.GetSuplidores().Select(s => new { s.NombreEmpresa, s.SuplidorId }).ToList())
                .ToList();
            SuppFiltroCbx.DisplayMember = "NombreEmpresa";
            SuppFiltroCbx.ValueMember = "SuplidorId";

            CategFiltroCbx.SelectedIndex = 0;
            SuppFiltroCbx.SelectedIndex = 0;
        }

    }
}
