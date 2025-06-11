using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wever_s_miniMarket
{
    public partial class CategoryCrear : Form
    {
        public CategoryCrear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (subir.ShowDialog() == DialogResult.OK)
            {
                CategoryPic.Image = Image.FromFile(subir.FileName);
            }
        }
    }
}
