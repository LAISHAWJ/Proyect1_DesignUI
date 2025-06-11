namespace Wever_s_miniMarket.PrincipalForms
{
    partial class ProductFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ProductDGV = new DataGridView();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            BtClose = new FontAwesome.Sharp.IconMenuItem();
            BtDelete = new FontAwesome.Sharp.IconMenuItem();
            BtUpdate = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 74);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(685, 8);
            label1.Name = "label1";
            label1.Size = new Size(285, 58);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(ProductDGV);
            panel2.Location = new Point(-1, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 474);
            panel2.TabIndex = 2;
            // 
            // ProductDGV
            // 
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.Dock = DockStyle.Fill;
            ProductDGV.Location = new Point(0, 0);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowHeadersWidth = 51;
            ProductDGV.Size = new Size(980, 474);
            ProductDGV.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuStrip1);
            panel3.Location = new Point(1, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 38);
            panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem3, BtUpdate, BtDelete, BtClose });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtClose
            // 
            BtClose.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtClose.IconColor = Color.Black;
            BtClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtClose.Name = "BtClose";
            BtClose.Size = new Size(105, 31);
            BtClose.Text = "Cerrar";
            // 
            // BtDelete
            // 
            BtDelete.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtDelete.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            BtDelete.IconColor = Color.Black;
            BtDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(124, 31);
            BtDelete.Text = "Eliminar";
            // 
            // BtUpdate
            // 
            BtUpdate.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtUpdate.IconChar = FontAwesome.Sharp.IconChar.Upload;
            BtUpdate.IconColor = Color.Black;
            BtUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtUpdate.Name = "BtUpdate";
            BtUpdate.Size = new Size(142, 31);
            BtUpdate.Text = "Actualizar";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(124, 31);
            iconMenuItem3.Text = "Agregar";
            // 
            // ProductFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(976, 610);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "ProductFrm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView ProductDGV;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem BtClose;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem BtUpdate;
        private FontAwesome.Sharp.IconMenuItem BtDelete;
    }
}