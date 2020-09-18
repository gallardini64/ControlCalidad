namespace ProyectoBase.Vistas
{
    partial class CrearOPVista
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNumero = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbModelo = new MetroFramework.Controls.MetroComboBox();
            this.cbColor = new MetroFramework.Controls.MetroComboBox();
            this.btCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbNumero.Location = new System.Drawing.Point(71, 25);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(135, 20);
            this.tbNumero.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Nro OP";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 61);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Fecha";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = "dd/MM/yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(71, 61);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(184, 36);
            this.bunifuDatepicker1.TabIndex = 3;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 9, 17, 19, 35, 28, 789);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 152);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Color";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(23, 117);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Modelo";
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.ItemHeight = 23;
            this.cbModelo.Location = new System.Drawing.Point(72, 114);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(134, 29);
            this.cbModelo.TabIndex = 25;
            this.cbModelo.UseSelectable = true;
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.ItemHeight = 23;
            this.cbColor.Location = new System.Drawing.Point(72, 149);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(134, 29);
            this.cbColor.TabIndex = 26;
            this.cbColor.UseSelectable = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.BorderRadius = 0;
            this.btCancelar.ButtonText = "Cancelar";
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btCancelar.Iconimage = null;
            this.btCancelar.Iconimage_right = null;
            this.btCancelar.Iconimage_right_Selected = null;
            this.btCancelar.Iconimage_Selected = null;
            this.btCancelar.IconMarginLeft = 0;
            this.btCancelar.IconMarginRight = 0;
            this.btCancelar.IconRightVisible = true;
            this.btCancelar.IconRightZoom = 0D;
            this.btCancelar.IconVisible = true;
            this.btCancelar.IconZoom = 90D;
            this.btCancelar.IsTab = false;
            this.btCancelar.Location = new System.Drawing.Point(159, 207);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btCancelar.selected = false;
            this.btCancelar.Size = new System.Drawing.Size(124, 32);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancelar.Textcolor = System.Drawing.Color.White;
            this.btCancelar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCrear
            // 
            this.btCrear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCrear.BorderRadius = 0;
            this.btCrear.ButtonText = "Crear Op";
            this.btCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCrear.DisabledColor = System.Drawing.Color.Gray;
            this.btCrear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btCrear.ForeColor = System.Drawing.Color.White;
            this.btCrear.Iconcolor = System.Drawing.Color.Transparent;
            this.btCrear.Iconimage = null;
            this.btCrear.Iconimage_right = null;
            this.btCrear.Iconimage_right_Selected = null;
            this.btCrear.Iconimage_Selected = null;
            this.btCrear.IconMarginLeft = 0;
            this.btCrear.IconMarginRight = 0;
            this.btCrear.IconRightVisible = true;
            this.btCrear.IconRightZoom = 0D;
            this.btCrear.IconVisible = true;
            this.btCrear.IconZoom = 90D;
            this.btCrear.IsTab = false;
            this.btCrear.Location = new System.Drawing.Point(5, 207);
            this.btCrear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCrear.Name = "btCrear";
            this.btCrear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btCrear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btCrear.OnHoverTextColor = System.Drawing.Color.White;
            this.btCrear.selected = false;
            this.btCrear.Size = new System.Drawing.Size(128, 32);
            this.btCrear.TabIndex = 28;
            this.btCrear.Text = "Crear Op";
            this.btCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCrear.Textcolor = System.Drawing.Color.White;
            this.btCrear.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // CrearOPVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbNumero);
            this.Name = "CrearOPVista";
            this.Size = new System.Drawing.Size(290, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbNumero;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private MetroFramework.Controls.MetroComboBox cbModelo;
        private MetroFramework.Controls.MetroComboBox cbColor;
        private Bunifu.Framework.UI.BunifuFlatButton btCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btCrear;
    }
}
