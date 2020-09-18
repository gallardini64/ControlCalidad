namespace ProyectoBase.Vistas
{
    partial class VistaSupervisorLinea
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroOP = new System.Windows.Forms.Label();
            this.btpausar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bindingSourceOP = new System.Windows.Forms.BindingSource(this.components);
            this.especificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crearOPVista1 = new ProyectoBase.Vistas.CrearOPVista();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.especificacionDataGridViewTextBoxColumn,
            this.pieDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.defectoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // numeroOP
            // 
            this.numeroOP.AutoSize = true;
            this.numeroOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOP, "Numero", true));
            this.numeroOP.Location = new System.Drawing.Point(12, 22);
            this.numeroOP.Name = "numeroOP";
            this.numeroOP.Size = new System.Drawing.Size(66, 13);
            this.numeroOP.TabIndex = 1;
            this.numeroOP.Text = "numero OP: ";
            // 
            // btpausar
            // 
            this.btpausar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btpausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btpausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btpausar.BorderRadius = 0;
            this.btpausar.ButtonText = "Pausar Op";
            this.btpausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btpausar.DisabledColor = System.Drawing.Color.Gray;
            this.btpausar.Enabled = false;
            this.btpausar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btpausar.ForeColor = System.Drawing.Color.White;
            this.btpausar.Iconcolor = System.Drawing.Color.Transparent;
            this.btpausar.Iconimage = null;
            this.btpausar.Iconimage_right = null;
            this.btpausar.Iconimage_right_Selected = null;
            this.btpausar.Iconimage_Selected = null;
            this.btpausar.IconMarginLeft = 0;
            this.btpausar.IconMarginRight = 0;
            this.btpausar.IconRightVisible = true;
            this.btpausar.IconRightZoom = 0D;
            this.btpausar.IconVisible = true;
            this.btpausar.IconZoom = 90D;
            this.btpausar.IsTab = false;
            this.btpausar.Location = new System.Drawing.Point(292, 14);
            this.btpausar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btpausar.Name = "btpausar";
            this.btpausar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btpausar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btpausar.OnHoverTextColor = System.Drawing.Color.White;
            this.btpausar.selected = false;
            this.btpausar.Size = new System.Drawing.Size(124, 32);
            this.btpausar.TabIndex = 6;
            this.btpausar.Text = "Pausar Op";
            this.btpausar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btpausar.Textcolor = System.Drawing.Color.White;
            this.btpausar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btpausar.Click += new System.EventHandler(this.btpausar_Click);
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
            this.btCrear.Location = new System.Drawing.Point(138, 14);
            this.btCrear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCrear.Name = "btCrear";
            this.btCrear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btCrear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btCrear.OnHoverTextColor = System.Drawing.Color.White;
            this.btCrear.selected = false;
            this.btCrear.Size = new System.Drawing.Size(128, 32);
            this.btCrear.TabIndex = 7;
            this.btCrear.Text = "Crear Op";
            this.btCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCrear.Textcolor = System.Drawing.Color.White;
            this.btCrear.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // bindingSourceOP
            // 
            this.bindingSourceOP.DataSource = typeof(ProyectoBase.Dominio.OrdenDeProduccion);
            // 
            // especificacionDataGridViewTextBoxColumn
            // 
            this.especificacionDataGridViewTextBoxColumn.DataPropertyName = "especificacion";
            this.especificacionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.especificacionDataGridViewTextBoxColumn.Name = "especificacionDataGridViewTextBoxColumn";
            // 
            // pieDataGridViewTextBoxColumn
            // 
            this.pieDataGridViewTextBoxColumn.DataPropertyName = "Pie";
            this.pieDataGridViewTextBoxColumn.HeaderText = "Pie";
            this.pieDataGridViewTextBoxColumn.Name = "pieDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // defectoBindingSource
            // 
            this.defectoBindingSource.DataSource = typeof(ProyectoBase.Dominio.Defecto);
            // 
            // crearOPVista1
            // 
            this.crearOPVista1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crearOPVista1.Location = new System.Drawing.Point(176, 0);
            this.crearOPVista1.Name = "crearOPVista1";
            this.crearOPVista1.Size = new System.Drawing.Size(290, 258);
            this.crearOPVista1.TabIndex = 8;
            // 
            // VistaSupervisorLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.crearOPVista1);
            this.Controls.Add(this.btpausar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.numeroOP);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaSupervisorLinea";
            this.Text = "VistaSupervisorLinea";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource defectoBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceOP;
        private System.Windows.Forms.Label numeroOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btpausar;
        private Bunifu.Framework.UI.BunifuFlatButton btCrear;
        private CrearOPVista crearOPVista1;
    }
}