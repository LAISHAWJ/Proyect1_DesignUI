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

namespace Wever_s_miniMarket
{
    public partial class CategoryFrm : Form
    {
        private readonly CategoryRepos _categoryRepos;
  

        public CategoryFrm(CategoryRepos categoryRepos)
        {
            InitializeComponent();
            _categoryRepos = categoryRepos;
           
        }

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            var categoriadvw = _categoryRepos.GetCategorias();
            CategoryDGV.DataSource = categoriadvw;
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
           
        }
    }
}
