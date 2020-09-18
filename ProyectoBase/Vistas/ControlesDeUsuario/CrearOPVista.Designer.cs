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
            this.lbLinea = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbModelo = new MetroFramework.Controls.MetroComboBox();
            this.cbColor = new MetroFramework.Controls.MetroComboBox();
            this.btCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btConfirmar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbLinea = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(105, 39);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(137, 27);
            this.tbNumero.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 42);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Nro OP";
            // 
            // lbLinea
            // 
            this.lbLinea.AutoSize = true;
            this.lbLinea.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbLinea.ForeColor = System.Drawing.Color.White;
            this.lbLinea.Location = new System.Drawing.Point(320, 42);
            this.lbLinea.Name = "lbLinea";
            this.lbLinea.Size = new System.Drawing.Size(51, 21);
            this.lbLinea.TabIndex = 2;
            this.lbLinea.Text = "Linea";
            // 
            // dpFecha
            // 
            this.dpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFecha.FormatCustom = "dd/MM/yyyy";
            this.dpFecha.Location = new System.Drawing.Point(313, 231);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(184, 31);
            this.dpFecha.TabIndex = 3;
            this.dpFecha.Value = new System.DateTime(2020, 9, 17, 19, 35, 28, 789);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(48, 167);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 21);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Color";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(30, 99);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 21);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Modelo";
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.ItemHeight = 23;
            this.cbModelo.Location = new System.Drawing.Point(105, 95);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(392, 29);
            this.cbModelo.TabIndex = 25;
            this.cbModelo.UseSelectable = true;
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.ItemHeight = 23;
            this.cbColor.Location = new System.Drawing.Point(105, 163);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(392, 29);
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
            this.btCancelar.Location = new System.Drawing.Point(351, 271);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btCancelar.selected = false;
            this.btCancelar.Size = new System.Drawing.Size(146, 55);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancelar.Textcolor = System.Drawing.Color.White;
            this.btCancelar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfirmar.BorderRadius = 0;
            this.btConfirmar.ButtonText = "Confirmar";
            this.btConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirmar.DisabledColor = System.Drawing.Color.Gray;
            this.btConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btConfirmar.ForeColor = System.Drawing.Color.White;
            this.btConfirmar.Iconcolor = System.Drawing.Color.Transparent;
            this.btConfirmar.Iconimage = null;
            this.btConfirmar.Iconimage_right = null;
            this.btConfirmar.Iconimage_right_Selected = null;
            this.btConfirmar.Iconimage_Selected = null;
            this.btConfirmar.IconMarginLeft = 0;
            this.btConfirmar.IconMarginRight = 0;
            this.btConfirmar.IconRightVisible = true;
            this.btConfirmar.IconRightZoom = 0D;
            this.btConfirmar.IconVisible = true;
            this.btConfirmar.IconZoom = 90D;
            this.btConfirmar.IsTab = false;
            this.btConfirmar.Location = new System.Drawing.Point(27, 271);
            this.btConfirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btConfirmar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btConfirmar.OnHoverTextColor = System.Drawing.Color.White;
            this.btConfirmar.selected = false;
            this.btConfirmar.Size = new System.Drawing.Size(146, 55);
            this.btConfirmar.TabIndex = 28;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btConfirmar.Textcolor = System.Drawing.Color.White;
            this.btConfirmar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(248, 236);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 21);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "Fecha";
            // 
            // cbLinea
            // 
            this.cbLinea.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbLinea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbLinea.FormattingEnabled = true;
            this.cbLinea.ItemHeight = 23;
            this.cbLinea.Location = new System.Drawing.Point(377, 38);
            this.cbLinea.Name = "cbLinea";
            this.cbLinea.Size = new System.Drawing.Size(120, 29);
            this.cbLinea.TabIndex = 25;
            this.cbLinea.UseSelectable = true;
            // 
            // CrearOPVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbLinea);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.lbLinea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbNumero);
            this.Name = "CrearOPVista";
            this.Size = new System.Drawing.Size(540, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbNumero;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbLinea;
        private Bunifu.Framework.UI.BunifuDatepicker dpFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private MetroFramework.Controls.MetroComboBox cbModelo;
        private MetroFramework.Controls.MetroComboBox cbColor;
        private Bunifu.Framework.UI.BunifuFlatButton btCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btConfirmar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private MetroFramework.Controls.MetroComboBox cbLinea;
    }
}
