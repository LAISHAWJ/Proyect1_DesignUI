using Microsoft.Extensions.DependencyInjection;
using Wever_s_miniMarket.PrincipalForms;

namespace Wever_s_miniMarket
{
    public partial class Menufrm : Form
    {
        private readonly IServiceProvider _services;
        public Menufrm(IServiceProvider services)
        {
            InitializeComponent();
            _services = services;
        }

        private void BtCategory_Click(object sender, EventArgs e)
        {
            var categoryForm = _services.GetRequiredService<CategoryFrm>();
            this.Hide();
            categoryForm.Show();
        }

        private void BtProducts_Click(object sender, EventArgs e)
        {
            var formproduct = _services.GetRequiredService<ProductFrm>();
            this.Hide();
            formproduct.Show();
        }

        private void BtSupplier_Click(object sender, EventArgs e)
        {
            var formsupplier = _services.GetRequiredService<SupplierFrm>();
            this.Hide();
            formsupplier.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            DialogResult Opcionsalir = MessageBox.Show("¿Desea salir del Sistema de Inventario?", "SALIR", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (Opcionsalir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
