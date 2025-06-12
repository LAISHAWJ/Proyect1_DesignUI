using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wever_s_miniMarket.PrincipalForms;
using Wever_s_miniMarket.Repository;
using Wever_s_miniMarket.Validators;

namespace Wever_s_miniMarket
{
    public partial class CategoryFrm : Form
    {
        private readonly CategoryRepos _categoryRepos;
        private readonly CategoryValid _validator = new CategoryValid();
        private Menufrm _menufrm;


        public CategoryFrm(CategoryRepos categoryRepos, CategoryValid validator, Menufrm menufrm )
        {
            InitializeComponent();
            _categoryRepos = categoryRepos;
            _validator = validator;
            _menufrm = menufrm;
        }

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            _menufrm.Show();
            Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (var categorycrearadd = new CategoryCrear(_categoryRepos, _validator, this))
            {
                categorycrearadd.ShowDialog();
            }
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            if (CategoryDGV.SelectedRows.Count > 0)
            {
                int categoriaId = (int)CategoryDGV.SelectedRows[0].Cells["CategoriaId"].Value;
                using (var categoryCrearup = new CategoryCrear(_categoryRepos, _validator, this))
                {
                    categoryCrearup.SetUpdateMode(categoriaId);
                    categoryCrearup.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (CategoryDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro que desea eliminarlo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int categoriaId = (int)CategoryDGV.SelectedRows[0].Cells["CategoriaId"].Value;
                    _categoryRepos.DeleteCategoria(categoriaId);
                    RefreshDataGridView();
                }
                      
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RefreshDataGridView()
        {
            var categoriadvw = _categoryRepos.GetCategorias();
            CategoryDGV.DataSource = categoriadvw.ToList();

            // Asegurarse de que la columna de imagen esté configurada
            if (CategoryDGV.Columns["RutaFoto"] != null)
            {
                CategoryDGV.Columns["RutaFoto"].Visible = false; // Ocultar la ruta como texto
                if (CategoryDGV.Columns["Imagen"] == null)
                {
                    var imageColumn = new DataGridViewImageColumn
                    {
                        Name = "Imagen",
                        HeaderText = "Imagen",
                        ImageLayout = DataGridViewImageCellLayout.Zoom
                    };
                    CategoryDGV.Columns.Add(imageColumn);
                }

                foreach (DataGridViewRow row in CategoryDGV.Rows)
                {
                    var rutaFoto = row.Cells["RutaFoto"].Value as string;
                    if (!string.IsNullOrEmpty(rutaFoto) && System.IO.File.Exists(rutaFoto))
                    {
                        row.Cells["Imagen"].Value = Image.FromFile(rutaFoto);
                    }
                    else
                    {
                        row.Cells["Imagen"].Value = null;
                    }
                }
            }
        }

    }
}
