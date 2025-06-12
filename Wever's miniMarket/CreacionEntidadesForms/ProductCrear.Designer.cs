namespace Wever_s_miniMarket.CreacionEntidadesForms
{
    partial class ProductCrear
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
            label2 = new Label();
            Nametxt = new TextBox();
            label3 = new Label();
            PrecioxUnitxt = new TextBox();
            label4 = new Label();
            CategCmbx = new ComboBox();
            SuppCmbx = new ComboBox();
            label5 = new Label();
            dateTimeUpdate = new DateTimePicker();
            label7 = new Label();
            dateTimeCrear = new DateTimePicker();
            label8 = new Label();
            StatuscCmbx = new ComboBox();
            label9 = new Label();
            BtCancel = new Button();
            BtSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(304, 63);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 113);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // Nametxt
            // 
            Nametxt.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nametxt.Location = new Point(117, 109);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(319, 34);
            Nametxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 177);
            label3.Name = "label3";
            label3.Size = new Size(185, 27);
            label3.TabIndex = 8;
            label3.Text = "Precio por unidad";
            // 
            // PrecioxUnitxt
            // 
            PrecioxUnitxt.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioxUnitxt.Location = new Point(211, 173);
            PrecioxUnitxt.Name = "PrecioxUnitxt";
            PrecioxUnitxt.Size = new Size(225, 34);
            PrecioxUnitxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 237);
            label4.Name = "label4";
            label4.Size = new Size(106, 27);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            // 
            // CategCmbx
            // 
            CategCmbx.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategCmbx.FormattingEnabled = true;
            CategCmbx.Items.AddRange(new object[] { "Activo", "Eliminado" });
            CategCmbx.Location = new Point(133, 233);
            CategCmbx.Name = "CategCmbx";
            CategCmbx.Size = new Size(303, 35);
            CategCmbx.TabIndex = 14;
            // 
            // SuppCmbx
            // 
            SuppCmbx.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SuppCmbx.FormattingEnabled = true;
            SuppCmbx.Items.AddRange(new object[] { "Activo", "Eliminado" });
            SuppCmbx.Location = new Point(133, 293);
            SuppCmbx.Name = "SuppCmbx";
            SuppCmbx.Size = new Size(303, 35);
            SuppCmbx.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 297);
            label5.Name = "label5";
            label5.Size = new Size(95, 27);
            label5.TabIndex = 15;
            label5.Text = "Suplidor";
            // 
            // dateTimeUpdate
            // 
            dateTimeUpdate.CalendarFont = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeUpdate.Location = new Point(228, 418);
            dateTimeUpdate.Name = "dateTimeUpdate";
            dateTimeUpdate.Size = new Size(208, 27);
            dateTimeUpdate.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 417);
            label7.Name = "label7";
            label7.Size = new Size(199, 27);
            label7.TabIndex = 19;
            label7.Text = "Fecha Modificación";
            // 
            // dateTimeCrear
            // 
            dateTimeCrear.CalendarFont = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeCrear.Location = new Point(189, 358);
            dateTimeCrear.Name = "dateTimeCrear";
            dateTimeCrear.Size = new Size(247, 27);
            dateTimeCrear.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 357);
            label8.Name = "label8";
            label8.Size = new Size(157, 27);
            label8.TabIndex = 17;
            label8.Text = "Fecha Creación";
            // 
            // StatuscCmbx
            // 
            StatuscCmbx.FormattingEnabled = true;
            StatuscCmbx.Items.AddRange(new object[] { "Activo", "Eliminado" });
            StatuscCmbx.Location = new Point(108, 469);
            StatuscCmbx.Name = "StatuscCmbx";
            StatuscCmbx.Size = new Size(328, 28);
            StatuscCmbx.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 470);
            label9.Name = "label9";
            label9.Size = new Size(82, 27);
            label9.TabIndex = 21;
            label9.Text = "Estado:";
            // 
            // BtCancel
            // 
            BtCancel.Location = new Point(415, 560);
            BtCancel.Name = "BtCancel";
            BtCancel.Size = new Size(94, 29);
            BtCancel.TabIndex = 24;
            BtCancel.Text = "Cancelar";
            BtCancel.UseVisualStyleBackColor = true;
            BtCancel.Click += BtCancel_Click;
            // 
            // BtSave
            // 
            BtSave.Location = new Point(515, 560);
            BtSave.Name = "BtSave";
            BtSave.Size = new Size(94, 29);
            BtSave.TabIndex = 23;
            BtSave.Text = "Guardar";
            BtSave.UseVisualStyleBackColor = true;
            BtSave.Click += BtSave_Click;
            // 
            // ProductCrear
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(635, 613);
            Controls.Add(BtCancel);
            Controls.Add(BtSave);
            Controls.Add(StatuscCmbx);
            Controls.Add(label9);
            Controls.Add(dateTimeUpdate);
            Controls.Add(label7);
            Controls.Add(dateTimeCrear);
            Controls.Add(label8);
            Controls.Add(SuppCmbx);
            Controls.Add(label5);
            Controls.Add(CategCmbx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PrecioxUnitxt);
            Controls.Add(label2);
            Controls.Add(Nametxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProductCrear";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox Nametxt;
        private Label label3;
        private TextBox PrecioxUnitxt;
        private Label label4;
        private ComboBox CategCmbx;
        private ComboBox SuppCmbx;
        private Label label5;
        private DateTimePicker dateTimeUpdate;
        private Label label7;
        private DateTimePicker dateTimeCrear;
        private Label label8;
        private ComboBox StatuscCmbx;
        private Label label9;
        private Button BtCancel;
        private Button BtSave;
    }
}