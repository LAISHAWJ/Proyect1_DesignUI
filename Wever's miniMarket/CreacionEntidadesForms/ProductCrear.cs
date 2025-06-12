using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wever_s_miniMarket.Models;
using Wever_s_miniMarket.PrincipalForms;
using Wever_s_miniMarket.Repository;
using Wever_s_miniMarket.Validators;
using Wever_s_miniMarket.ViewModel;

namespace Wever_s_miniMarket.CreacionEntidadesForms
{
    public partial class ProductCrear : Form
    {
        private readonly ProductRepos _productRepos;
        private readonly CategoryRepos _categoryRepos;
        private readonly SupplierRepos _supplierRepos;
        private readonly ProductValid _validator;
        private readonly ProductFrm _parentForm;
        private Producto? _productoToUpdate;
        private bool _isUpdateMode;
        public ProductCrear(ProductRepos productRepos, CategoryRepos categoryRepos, SupplierRepos supplierRepos, ProductValid validator, ProductFrm parentForm)
        {
            InitializeComponent();
            _productRepos = productRepos;
            _categoryRepos = categoryRepos;
            _supplierRepos = supplierRepos;
            _validator = validator;
            _parentForm = parentForm;
            _isUpdateMode = false;
            LoadDefaultValues();
            LoadComboBoxData();
        }

        private void LoadDefaultValues()
        {
            dateTimeCrear.Value = DateTime.Now;
            dateTimeUpdate.Value = DateTime.Now;
            StatuscCmbx.SelectedIndex = 0;
        }

        private void LoadComboBoxData()
        {
            CategCmbx.DataSource = _categoryRepos.GetCategorias().ToList();
            CategCmbx.DisplayMember = "Nombre";
            CategCmbx.ValueMember = "CategoriaId";

            SuppCmbx.DataSource = _supplierRepos.GetSuplidores().ToList();
            SuppCmbx.DisplayMember = "NombreEmpresa";
            SuppCmbx.ValueMember = "SuplidorId";
        }

        public void SetUpdateMode(int productoId)
        {
            _isUpdateMode = true;
            _productoToUpdate = _productRepos.GetProductos().FirstOrDefault(p => p.ProductoId == productoId);
            if (_productoToUpdate != null)
            {
                Nametxt.Text = _productoToUpdate.Nombre;
                PrecioxUnitxt.Text = _productoToUpdate.PrecioUnitario.ToString();
                CategCmbx.SelectedValue = _productoToUpdate.CategoriaId;
                SuppCmbx.SelectedValue = _productoToUpdate.SuplidorId;
                dateTimeCrear.Value = _productoToUpdate.FechaCreacion;
                dateTimeUpdate.Value = _productoToUpdate.FechaModificacion ?? DateTime.Now;
                StatuscCmbx.SelectedIndex = _productoToUpdate.ActiveorDeleted ? 0 : 1;
                Text = "Update Product";
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(PrecioxUnitxt.Text, out decimal precioUnitario))
            {
                MessageBox.Show("El precio unitario debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productVM = new ProductVM
            {
                ProductoId = _isUpdateMode ? _productoToUpdate.ProductoId : 0,
                Nombre = Nametxt.Text,
                PrecioUnitario = precioUnitario,
                CategoriaId = (int)CategCmbx.SelectedValue,
                SuplidorId = (int)SuppCmbx.SelectedValue,
                FechaCreacion = dateTimeCrear.Value,
                FechaModificacion = dateTimeUpdate.Value,
                ActiveorDeleted = StatuscCmbx.SelectedIndex == 0
            };

            var validationResult = _validator.Validate(productVM);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage)), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = new Producto
            {
                ProductoId = productVM.ProductoId,
                Nombre = productVM.Nombre,
                PrecioUnitario = productVM.PrecioUnitario,
                CategoriaId = productVM.CategoriaId,
                SuplidorId = productVM.SuplidorId,
                FechaCreacion = productVM.FechaCreacion,
                FechaModificacion = productVM.FechaModificacion,
                ActiveorDeleted = productVM.ActiveorDeleted
            };

            if (_isUpdateMode && _productoToUpdate != null)
            {
                _productRepos.UpdateProducto(producto);
            }
            else
            {
                _productRepos.AddProducto(producto);
            }

            _parentForm.RefreshDataGridView();
            Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
