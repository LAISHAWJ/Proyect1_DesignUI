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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFrm));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ProductDGV = new DataGridView();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            BtAdd = new FontAwesome.Sharp.IconMenuItem();
            BtUpdate = new FontAwesome.Sharp.IconMenuItem();
            BtDelete = new FontAwesome.Sharp.IconMenuItem();
            BtClose = new FontAwesome.Sharp.IconMenuItem();
            panel4 = new Panel();
            BtSearch = new Button();
            SuppFiltroCbx = new ComboBox();
            label2 = new Label();
            CategFiltroCbx = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 74);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(732, 9);
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
            panel2.Location = new Point(0, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(1031, 542);
            panel2.TabIndex = 2;
            // 
            // ProductDGV
            // 
            ProductDGV.AllowUserToAddRows = false;
            ProductDGV.AllowUserToDeleteRows = false;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.Dock = DockStyle.Fill;
            ProductDGV.Location = new Point(0, 0);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.ReadOnly = true;
            ProductDGV.RowHeadersWidth = 51;
            ProductDGV.Size = new Size(1031, 542);
            ProductDGV.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuStrip1);
            panel3.Location = new Point(1, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(1030, 38);
            panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtAdd, BtUpdate, BtDelete, BtClose });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtAdd
            // 
            BtAdd.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtAdd.IconColor = Color.Black;
            BtAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(124, 31);
            BtAdd.Text = "Agregar";
            BtAdd.Click += BtAdd_Click;
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
            BtUpdate.Click += BtUpdate_Click;
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
            BtDelete.Click += BtDelete_Click;
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
            BtClose.Click += BtClose_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.Controls.Add(BtSearch);
            panel4.Controls.Add(SuppFiltroCbx);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(CategFiltroCbx);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(1031, 48);
            panel4.TabIndex = 4;
            // 
            // BtSearch
            // 
            BtSearch.BackColor = Color.DarkSeaGreen;
            BtSearch.FlatStyle = FlatStyle.Flat;
            BtSearch.ForeColor = Color.DarkSeaGreen;
            BtSearch.Image = (Image)resources.GetObject("BtSearch.Image");
            BtSearch.Location = new Point(933, -1);
            BtSearch.Name = "BtSearch";
            BtSearch.Size = new Size(44, 48);
            BtSearch.TabIndex = 6;
            BtSearch.UseVisualStyleBackColor = false;
            BtSearch.Click += BtSearch_Click;
            // 
            // SuppFiltroCbx
            // 
            SuppFiltroCbx.FormattingEnabled = true;
            SuppFiltroCbx.Location = new Point(457, 11);
            SuppFiltroCbx.Name = "SuppFiltroCbx";
            SuppFiltroCbx.Size = new Size(252, 28);
            SuppFiltroCbx.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 12);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 4;
            label2.Text = "Suplidor";
            // 
            // CategFiltroCbx
            // 
            CategFiltroCbx.FormattingEnabled = true;
            CategFiltroCbx.Location = new Point(103, 10);
            CategFiltroCbx.Name = "CategFiltroCbx";
            CategFiltroCbx.Size = new Size(252, 28);
            CategFiltroCbx.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 12);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 1;
            label3.Text = "Categoria";
            // 
            // ProductFrm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1028, 716);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "ProductFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ProductFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private FontAwesome.Sharp.IconMenuItem BtAdd;
        private FontAwesome.Sharp.IconMenuItem BtUpdate;
        private FontAwesome.Sharp.IconMenuItem BtDelete;
        private Panel panel4;
        private ComboBox SuppFiltroCbx;
        private Label label2;
        private ComboBox CategFiltroCbx;
        private Label label3;
        private Button BtSearch;
    }
}