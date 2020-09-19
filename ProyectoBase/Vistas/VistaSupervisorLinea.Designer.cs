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
            this.especificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroOP = new System.Windows.Forms.Label();
            this.bindingSourceOP = new System.Windows.Forms.BindingSource(this.components);
            this.btpausar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btFinalizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btReanudar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.crearOPVista1 = new ProyectoBase.Vistas.CrearOPVista();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOP)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 251);
            this.dataGridView1.TabIndex = 0;
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
            // numeroOP
            // 
            this.numeroOP.AutoSize = true;
            this.numeroOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOP, "Numero", true));
            this.numeroOP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroOP.ForeColor = System.Drawing.Color.White;
            this.numeroOP.Location = new System.Drawing.Point(30, 20);
            this.numeroOP.Name = "numeroOP";
            this.numeroOP.Size = new System.Drawing.Size(72, 21);
            this.numeroOP.TabIndex = 1;
            this.numeroOP.Text = "Nro OP: ";
            // 
            // bindingSourceOP
            // 
            this.bindingSourceOP.DataSource = typeof(ProyectoBase.Dominio.OrdenDeProduccion);
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
            this.btpausar.Location = new System.Drawing.Point(269, 303);
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
            this.btCrear.Location = new System.Drawing.Point(131, 303);
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
            // btFinalizar
            // 
            this.btFinalizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFinalizar.BorderRadius = 0;
            this.btFinalizar.ButtonText = "Finalizar Op";
            this.btFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinalizar.DisabledColor = System.Drawing.Color.Gray;
            this.btFinalizar.Enabled = false;
            this.btFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btFinalizar.ForeColor = System.Drawing.Color.White;
            this.btFinalizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btFinalizar.Iconimage = null;
            this.btFinalizar.Iconimage_right = null;
            this.btFinalizar.Iconimage_right_Selected = null;
            this.btFinalizar.Iconimage_Selected = null;
            this.btFinalizar.IconMarginLeft = 0;
            this.btFinalizar.IconMarginRight = 0;
            this.btFinalizar.IconRightVisible = true;
            this.btFinalizar.IconRightZoom = 0D;
            this.btFinalizar.IconVisible = true;
            this.btFinalizar.IconZoom = 90D;
            this.btFinalizar.IsTab = false;
            this.btFinalizar.Location = new System.Drawing.Point(403, 303);
            this.btFinalizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btFinalizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btFinalizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btFinalizar.selected = false;
            this.btFinalizar.Size = new System.Drawing.Size(124, 32);
            this.btFinalizar.TabIndex = 9;
            this.btFinalizar.Text = "Finalizar Op";
            this.btFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btFinalizar.Textcolor = System.Drawing.Color.White;
            this.btFinalizar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btReanudar
            // 
            this.btReanudar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btReanudar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btReanudar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReanudar.BorderRadius = 0;
            this.btReanudar.ButtonText = "Reanudar Op";
            this.btReanudar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReanudar.DisabledColor = System.Drawing.Color.Gray;
            this.btReanudar.Enabled = false;
            this.btReanudar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btReanudar.ForeColor = System.Drawing.Color.White;
            this.btReanudar.Iconcolor = System.Drawing.Color.Transparent;
            this.btReanudar.Iconimage = null;
            this.btReanudar.Iconimage_right = null;
            this.btReanudar.Iconimage_right_Selected = null;
            this.btReanudar.Iconimage_Selected = null;
            this.btReanudar.IconMarginLeft = 0;
            this.btReanudar.IconMarginRight = 0;
            this.btReanudar.IconRightVisible = true;
            this.btReanudar.IconRightZoom = 0D;
            this.btReanudar.IconVisible = true;
            this.btReanudar.IconZoom = 90D;
            this.btReanudar.IsTab = false;
            this.btReanudar.Location = new System.Drawing.Point(269, 303);
            this.btReanudar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btReanudar.Name = "btReanudar";
            this.btReanudar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btReanudar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btReanudar.OnHoverTextColor = System.Drawing.Color.White;
            this.btReanudar.selected = false;
            this.btReanudar.Size = new System.Drawing.Size(124, 32);
            this.btReanudar.TabIndex = 6;
            this.btReanudar.Text = "Reanudar Op";
            this.btReanudar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btReanudar.Textcolor = System.Drawing.Color.White;
            this.btReanudar.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btReanudar.Visible = false;
            this.btReanudar.Click += new System.EventHandler(this.btReanudar_Click);
            // 
            // crearOPVista1
            // 
            this.crearOPVista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.crearOPVista1.Location = new System.Drawing.Point(-1, 0);
            this.crearOPVista1.Name = "crearOPVista1";
            this.crearOPVista1.Size = new System.Drawing.Size(581, 360);
            this.crearOPVista1.TabIndex = 10;
            // 
            // VistaSupervisorLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(578, 360);
            this.Controls.Add(this.crearOPVista1);
            this.Controls.Add(this.btReanudar);
            this.Controls.Add(this.btpausar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.numeroOP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaSupervisorLinea";
            this.Text = "VistaSupervisorLinea";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaSupervisorLinea_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VistaSupervisorLinea_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VistaSupervisorLinea_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOP)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btFinalizar;
        private CrearOPVista crearOPVista1;
        private Bunifu.Framework.UI.BunifuFlatButton btReanudar;
    }
}