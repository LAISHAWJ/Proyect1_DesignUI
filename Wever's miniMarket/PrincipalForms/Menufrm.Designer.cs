namespace Wever_s_miniMarket
{
    partial class Menufrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menufrm));
            MenuInicial = new MenuStrip();
            BtCategory = new FontAwesome.Sharp.IconMenuItem();
            BtProducts = new FontAwesome.Sharp.IconMenuItem();
            BtSupplier = new FontAwesome.Sharp.IconMenuItem();
            BtExit = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            MenuInicial.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuInicial
            // 
            MenuInicial.BackColor = Color.SeaGreen;
            MenuInicial.ImageScalingSize = new Size(20, 20);
            MenuInicial.Items.AddRange(new ToolStripItem[] { BtCategory, BtProducts, BtSupplier, BtExit });
            MenuInicial.Location = new Point(0, 0);
            MenuInicial.Name = "MenuInicial";
            MenuInicial.RightToLeft = RightToLeft.No;
            MenuInicial.Size = new Size(1040, 92);
            MenuInicial.TabIndex = 0;
            // 
            // BtCategory
            // 
            BtCategory.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtCategory.ForeColor = SystemColors.ControlLightLight;
            BtCategory.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            BtCategory.IconColor = Color.White;
            BtCategory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtCategory.IconSize = 60;
            BtCategory.ImageScaling = ToolStripItemImageScaling.None;
            BtCategory.Name = "BtCategory";
            BtCategory.Size = new Size(128, 88);
            BtCategory.Text = "CATEGORIA";
            BtCategory.TextDirection = ToolStripTextDirection.Horizontal;
            BtCategory.TextImageRelation = TextImageRelation.ImageAboveText;
            BtCategory.Click += BtCategory_Click;
            // 
            // BtProducts
            // 
            BtProducts.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtProducts.ForeColor = SystemColors.ControlLightLight;
            BtProducts.IconChar = FontAwesome.Sharp.IconChar.Box;
            BtProducts.IconColor = Color.White;
            BtProducts.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtProducts.IconSize = 60;
            BtProducts.ImageScaling = ToolStripItemImageScaling.None;
            BtProducts.Name = "BtProducts";
            BtProducts.Size = new Size(137, 88);
            BtProducts.Text = "PRODUCTOS";
            BtProducts.TextDirection = ToolStripTextDirection.Horizontal;
            BtProducts.TextImageRelation = TextImageRelation.ImageAboveText;
            BtProducts.Click += BtProducts_Click;
            // 
            // BtSupplier
            // 
            BtSupplier.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtSupplier.ForeColor = SystemColors.ControlLightLight;
            BtSupplier.IconChar = FontAwesome.Sharp.IconChar.Truck;
            BtSupplier.IconColor = Color.White;
            BtSupplier.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtSupplier.IconSize = 60;
            BtSupplier.ImageScaling = ToolStripItemImageScaling.None;
            BtSupplier.Name = "BtSupplier";
            BtSupplier.Size = new Size(136, 88);
            BtSupplier.Text = "SUPLIDORES";
            BtSupplier.TextDirection = ToolStripTextDirection.Horizontal;
            BtSupplier.TextImageRelation = TextImageRelation.ImageAboveText;
            BtSupplier.Click += BtSupplier_Click;
            // 
            // BtExit
            // 
            BtExit.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtExit.ForeColor = Color.Red;
            BtExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtExit.IconColor = Color.Red;
            BtExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtExit.IconSize = 60;
            BtExit.ImageScaling = ToolStripItemImageScaling.None;
            BtExit.Name = "BtExit";
            BtExit.Size = new Size(75, 88);
            BtExit.Text = "SALIR";
            BtExit.TextDirection = ToolStripTextDirection.Horizontal;
            BtExit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtExit.Click += BtExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 562);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1040, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menufrm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1040, 654);
            Controls.Add(panel1);
            Controls.Add(MenuInicial);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = MenuInicial;
            Name = "Menufrm";
            StartPosition = FormStartPosition.CenterScreen;
            MenuInicial.ResumeLayout(false);
            MenuInicial.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuInicial;
        private FontAwesome.Sharp.IconMenuItem BtExit;
        private FontAwesome.Sharp.IconMenuItem BtCategory;
        private FontAwesome.Sharp.IconMenuItem BtProducts;
        private FontAwesome.Sharp.IconMenuItem BtSupplier;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
