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
using Wever_s_miniMarket.Repository;
using Wever_s_miniMarket.Validators;
using Wever_s_miniMarket.ViewModel;

namespace Wever_s_miniMarket
{
    public partial class CategoryCrear : Form
    {
        private readonly CategoryRepos _categoryRepos;
        private readonly CategoryValid _validator = new CategoryValid();
        private readonly CategoryFrm _parentForm; // Para refrescar el DataGridView principal
        private bool _isUpdateMode;
        private string _rutaImagen;
        private Categoria? _categoriaToUpdate;

        public CategoryCrear(CategoryRepos categoryRepos, CategoryValid validator, CategoryFrm parentForm)
        {
            InitializeComponent();
            _categoryRepos = categoryRepos;
            _validator = validator;
            _parentForm = parentForm;
            _isUpdateMode = false;
            _rutaImagen = null;
            LoadDefaultValues();
        }

        private void LoadDefaultValues()
        {
            dateTimeCrear.Value = DateTime.Now;
            dateTimeUpdate.Value = DateTime.Now;
            StatuscCmbx.SelectedIndex = 0; // Asume que 0 es true para Activo.
        }

        public void SetUpdateMode(int categoriaId)
        {
            _isUpdateMode = true;
            _categoriaToUpdate = _categoryRepos.GetCategorias().FirstOrDefault(c => c.CategoriaId == categoriaId);
            if (_categoriaToUpdate != null)
            {
                Nametxt.Text = _categoriaToUpdate.Nombre;
                Descriptxt.Text = _categoriaToUpdate.Descripcion ?? string.Empty;
                dateTimeCrear.Value = _categoriaToUpdate.FechaCreacion;
                dateTimeUpdate.Value = _categoriaToUpdate.FechaModificacion ?? DateTime.Now;
                StatuscCmbx.SelectedIndex = _categoriaToUpdate.ActiveorDeleted ? 0 : 1; // 0 para Activo, 1 para Eliminado
                _rutaImagen = _categoriaToUpdate.RutaFoto;
                if (!string.IsNullOrEmpty(_rutaImagen) && System.IO.File.Exists(_rutaImagen))
                {
                    CategoryPic.Image = new Bitmap(_rutaImagen);
                }
                Text = "Update Category";
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            var categoryVM = new CategoryVM
            {
                CategoriaId = _isUpdateMode ? _categoriaToUpdate.CategoriaId : 0,
                Nombre = Nametxt.Text,
                Descripcion = Descriptxt.Text,
                RutaFoto = _rutaImagen,
                FechaCreacion = dateTimeCrear.Value,
                FechaModificacion = dateTimeUpdate.Value,
                ActiveorDeleted = StatuscCmbx.SelectedIndex == 0
            };

            var validationResult = _validator.Validate(categoryVM);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage)), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var categoria = new Categoria
            {
                CategoriaId = categoryVM.CategoriaId,
                Nombre = categoryVM.Nombre,
                Descripcion = categoryVM.Descripcion,
                RutaFoto = categoryVM.RutaFoto,
                FechaCreacion = categoryVM.FechaCreacion,
                FechaModificacion = categoryVM.FechaModificacion,
                ActiveorDeleted = categoryVM.ActiveorDeleted
            };

            if (_isUpdateMode)
            {
                _categoryRepos.UpdateCategoria(categoria);
            }
            else
            {
                _categoryRepos.AddCategoria(categoria);
            }

            _parentForm.RefreshDataGridView();
            Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtSubirPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Seleccionar imagen";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _rutaImagen = openFileDialog.FileName; // Guarda la ruta del archivo seleccionado
                    CategoryPic.Image = new Bitmap(_rutaImagen); // Carga la imagen en el PictureBox
                    CategoryPic.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta la imagen al tamaño del PictureBox
                }
            }
        }
    }
}
