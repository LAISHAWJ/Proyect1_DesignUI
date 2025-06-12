namespace Wever_s_miniMarket
{
    partial class CategoryCrear
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
            Nametxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Descriptxt = new TextBox();
            label4 = new Label();
            dateTimeCrear = new DateTimePicker();
            dateTimeUpdate = new DateTimePicker();
            label5 = new Label();
            BtSubirPic = new Button();
            CategoryPic = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            StatuscCmbx = new ComboBox();
            BtSave = new Button();
            BtCancel = new Button();
            openFileDialog = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryPic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(264, 63);
            label1.TabIndex = 0;
            label1.Text = "CATEGORY";
            // 
            // Nametxt
            // 
            Nametxt.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nametxt.Location = new Point(120, 118);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(464, 34);
            Nametxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 122);
            label2.Name = "label2";
            label2.Size = new Size(91, 27);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 194);
            label3.Name = "label3";
            label3.Size = new Size(125, 27);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            // 
            // Descriptxt
            // 
            Descriptxt.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descriptxt.Location = new Point(151, 194);
            Descriptxt.Name = "Descriptxt";
            Descriptxt.Size = new Size(433, 34);
            Descriptxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 269);
            label4.Name = "label4";
            label4.Size = new Size(157, 27);
            label4.TabIndex = 5;
            label4.Text = "Fecha Creación";
            // 
            // dateTimeCrear
            // 
            dateTimeCrear.CalendarFont = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeCrear.Location = new Point(183, 270);
            dateTimeCrear.Name = "dateTimeCrear";
            dateTimeCrear.Size = new Size(401, 27);
            dateTimeCrear.TabIndex = 6;
            // 
            // dateTimeUpdate
            // 
            dateTimeUpdate.CalendarFont = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeUpdate.Location = new Point(222, 335);
            dateTimeUpdate.Name = "dateTimeUpdate";
            dateTimeUpdate.Size = new Size(362, 27);
            dateTimeUpdate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 334);
            label5.Name = "label5";
            label5.Size = new Size(199, 27);
            label5.TabIndex = 7;
            label5.Text = "Fecha Modificación";
            // 
            // BtSubirPic
            // 
            BtSubirPic.Location = new Point(137, 594);
            BtSubirPic.Name = "BtSubirPic";
            BtSubirPic.Size = new Size(94, 29);
            BtSubirPic.TabIndex = 9;
            BtSubirPic.Text = "Subir";
            BtSubirPic.UseVisualStyleBackColor = true;
            BtSubirPic.Click += BtSubirPic_Click;
            // 
            // CategoryPic
            // 
            CategoryPic.BackColor = Color.SeaGreen;
            CategoryPic.Location = new Point(237, 389);
            CategoryPic.Name = "CategoryPic";
            CategoryPic.Size = new Size(347, 234);
            CategoryPic.TabIndex = 10;
            CategoryPic.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 387);
            label6.Name = "label6";
            label6.Size = new Size(219, 27);
            label6.TabIndex = 11;
            label6.Text = "Seleccionar imágenes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 665);
            label7.Name = "label7";
            label7.Size = new Size(82, 27);
            label7.TabIndex = 12;
            label7.Text = "Estado:";
            // 
            // StatuscCmbx
            // 
            StatuscCmbx.FormattingEnabled = true;
            StatuscCmbx.Items.AddRange(new object[] { "Activo", "Eliminado" });
            StatuscCmbx.Location = new Point(103, 664);
            StatuscCmbx.Name = "StatuscCmbx";
            StatuscCmbx.Size = new Size(339, 28);
            StatuscCmbx.TabIndex = 13;
            // 
            // BtSave
            // 
            BtSave.Location = new Point(506, 729);
            BtSave.Name = "BtSave";
            BtSave.Size = new Size(94, 29);
            BtSave.TabIndex = 14;
            BtSave.Text = "Guardar";
            BtSave.UseVisualStyleBackColor = true;
            BtSave.Click += BtSave_Click;
            // 
            // BtCancel
            // 
            BtCancel.Location = new Point(406, 729);
            BtCancel.Name = "BtCancel";
            BtCancel.Size = new Size(94, 29);
            BtCancel.TabIndex = 15;
            BtCancel.Text = "Cancelar";
            BtCancel.UseVisualStyleBackColor = true;
            BtCancel.Click += BtCancel_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // CategoryCrear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(619, 784);
            Controls.Add(BtCancel);
            Controls.Add(BtSave);
            Controls.Add(StatuscCmbx);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(CategoryPic);
            Controls.Add(BtSubirPic);
            Controls.Add(dateTimeUpdate);
            Controls.Add(label5);
            Controls.Add(dateTimeCrear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Descriptxt);
            Controls.Add(label2);
            Controls.Add(Nametxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CategoryCrear";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox Nametxt;
        private Label label2;
        private Label label3;
        private TextBox Descriptxt;
        private Label label4;
        private DateTimePicker dateTimeCrear;
        private DateTimePicker dateTimeUpdate;
        private Label label5;
        private Button BtSubirPic;
        private PictureBox CategoryPic;
        private Label label6;
        private Label label7;
        private ComboBox StatuscCmbx;
        private Button BtSave;
        private Button BtCancel;
        private OpenFileDialog openFileDialog;
    }
}