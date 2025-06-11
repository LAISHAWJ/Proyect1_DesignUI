namespace Wever_s_miniMarket
{
    partial class CategoryFrm
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
            CategoryDGV = new DataGridView();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            BtAdd = new FontAwesome.Sharp.IconMenuItem();
            BtUpdate = new FontAwesome.Sharp.IconMenuItem();
            BtDelete = new FontAwesome.Sharp.IconMenuItem();
            BtClose = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 72);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(744, 7);
            label1.Name = "label1";
            label1.Size = new Size(263, 58);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIA";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(CategoryDGV);
            panel2.Location = new Point(0, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 533);
            panel2.TabIndex = 3;
            // 
            // CategoryDGV
            // 
            CategoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDGV.Dock = DockStyle.Fill;
            CategoryDGV.Location = new Point(0, 0);
            CategoryDGV.Name = "CategoryDGV";
            CategoryDGV.RowHeadersWidth = 51;
            CategoryDGV.Size = new Size(1013, 533);
            CategoryDGV.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuStrip1);
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 46);
            panel3.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtAdd, BtUpdate, BtDelete, BtClose });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1013, 35);
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
            // CategoryFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1012, 661);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CategoryFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CategoryFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).EndInit();
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
        private DataGridView CategoryDGV;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem BtAdd;
        private FontAwesome.Sharp.IconMenuItem BtUpdate;
        private FontAwesome.Sharp.IconMenuItem BtDelete;
        private FontAwesome.Sharp.IconMenuItem BtClose;
    }
}