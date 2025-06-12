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
    public partial class SupplierCrear : Form
    {
        private readonly SupplierRepos _supplierRepos;
        private readonly SupplierValid _validator;
        private readonly SupplierFrm _parentForm;
        private Suplidor? _suplidorToUpdate;
        private bool _isUpdateMode;
        public SupplierCrear(SupplierRepos supplierRepos, SupplierValid validator, SupplierFrm parentForm)
        {
            InitializeComponent();
            _supplierRepos = supplierRepos;
            _validator = validator;
            _parentForm = parentForm;
            _isUpdateMode = false;
            LoadDefaultValues();
        }
        private void LoadDefaultValues()
        {
            dateTimeCrear.Value = DateTime.Now;
            dateTimeUpdate.Value = DateTime.Now;
            StatuscCmbx.SelectedIndex = 0;
        }

        public void SetUpdateMode(int suplidorId)
        {
            _isUpdateMode = true;
            _suplidorToUpdate = _supplierRepos.GetSuplidores().FirstOrDefault(s => s.SuplidorId == suplidorId);
            if (_suplidorToUpdate != null)
            {
                NameEmprtxt.Text = _suplidorToUpdate.NombreEmpresa;
                NameContxt.Text = _suplidorToUpdate.NombreContacto ?? string.Empty;
                Teltxt.Text = _suplidorToUpdate.Telefono ?? string.Empty;
                Correotxt.Text = _suplidorToUpdate.CorreoElectronico ?? string.Empty;
                Webtxt.Text = _suplidorToUpdate.SitioWeb ?? string.Empty;
                dateTimeCrear.Value = _suplidorToUpdate.FechaCreacion;
                dateTimeUpdate.Value = _suplidorToUpdate.FechaModificacion ?? DateTime.Now;
                StatuscCmbx.SelectedIndex = _suplidorToUpdate.ActiveorDeleted ? 0 : 1;
                Text = "Update Supplier";
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            var supplierVM = new SupplierVM
            {
                SuplidorId = _isUpdateMode ? _suplidorToUpdate.SuplidorId : 0,
                NombreEmpresa = NameEmprtxt.Text,
                NombreContacto = NameContxt.Text,
                Telefono = Teltxt.Text,
                CorreoElectronico = Correotxt.Text,
                SitioWeb = Webtxt.Text,
                FechaCreacion = dateTimeCrear.Value,
                FechaModificacion = dateTimeUpdate.Value,
                ActiveorDeleted = StatuscCmbx.SelectedIndex == 0
            };

            var validationResult = _validator.Validate(supplierVM);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage)), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var suplidor = new Suplidor
            {
                SuplidorId = supplierVM.SuplidorId,
                NombreEmpresa = supplierVM.NombreEmpresa,
                NombreContacto = supplierVM.NombreContacto,
                Telefono = supplierVM.Telefono,
                CorreoElectronico = supplierVM.CorreoElectronico,
                SitioWeb = supplierVM.SitioWeb,
                FechaCreacion = supplierVM.FechaCreacion,
                FechaModificacion = supplierVM.FechaModificacion,
                ActiveorDeleted = supplierVM.ActiveorDeleted
            };

            if (_isUpdateMode && _suplidorToUpdate != null)
            {
                _supplierRepos.UpdateSuplidor(suplidor);
            }
            else
            {
                _supplierRepos.AddSuplidor(suplidor);
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
