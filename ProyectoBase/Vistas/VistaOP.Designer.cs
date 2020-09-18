namespace ProyectoBase
{
    partial class VistaOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaOP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbPie = new MetroFramework.Controls.MetroComboBox();
            this.tbFec = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbOpNum = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbTurno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridDefectos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceED = new System.Windows.Forms.BindingSource(this.components);
            this.btHermanado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btParPrimera = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDefectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceED)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPie
            // 
            this.cbPie.BackColor = System.Drawing.Color.White;
            this.cbPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbPie.FormattingEnabled = true;
            resources.ApplyResources(this.cbPie, "cbPie");
            this.cbPie.Name = "cbPie";
            this.cbPie.UseSelectable = true;
            // 
            // tbFec
            // 
            this.tbFec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbFec.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.tbFec, "tbFec");
            this.tbFec.Name = "tbFec";
            // 
            // tbOpNum
            // 
            this.tbOpNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbOpNum.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.tbOpNum, "tbOpNum");
            this.tbOpNum.Name = "tbOpNum";
            // 
            // tbTurno
            // 
            this.tbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbTurno.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.tbTurno, "tbTurno");
            this.tbTurno.Name = "tbTurno";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btQuitar
            // 
            this.btQuitar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btQuitar, "btQuitar");
            this.btQuitar.BorderRadius = 0;
            this.btQuitar.ButtonText = "-";
            this.btQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuitar.DisabledColor = System.Drawing.Color.Gray;
            this.btQuitar.ForeColor = System.Drawing.Color.White;
            this.btQuitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btQuitar.Iconimage = null;
            this.btQuitar.Iconimage_right = null;
            this.btQuitar.Iconimage_right_Selected = null;
            this.btQuitar.Iconimage_Selected = null;
            this.btQuitar.IconMarginLeft = 0;
            this.btQuitar.IconMarginRight = 0;
            this.btQuitar.IconRightVisible = true;
            this.btQuitar.IconRightZoom = 0D;
            this.btQuitar.IconVisible = true;
            this.btQuitar.IconZoom = 90D;
            this.btQuitar.IsTab = false;
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btQuitar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btQuitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btQuitar.selected = false;
            this.btQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btQuitar.Textcolor = System.Drawing.Color.White;
            this.btQuitar.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.btSalir, "btSalir");
            this.btSalir.BorderRadius = 0;
            this.btSalir.ButtonText = "";
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btSalir.Iconimage = global::ProyectoBase.Properties.Resources.exit_32px;
            this.btSalir.Iconimage_right = null;
            this.btSalir.Iconimage_right_Selected = null;
            this.btSalir.Iconimage_Selected = null;
            this.btSalir.IconMarginLeft = 0;
            this.btSalir.IconMarginRight = 0;
            this.btSalir.IconRightVisible = true;
            this.btSalir.IconRightZoom = 0D;
            this.btSalir.IconVisible = true;
            this.btSalir.IconZoom = 90D;
            this.btSalir.IsTab = false;
            this.btSalir.Name = "btSalir";
            this.btSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btSalir.selected = false;
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSalir.Textcolor = System.Drawing.Color.White;
            this.btSalir.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btAgregar, "btAgregar");
            this.btAgregar.BorderRadius = 0;
            this.btAgregar.ButtonText = "+";
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btAgregar.Iconimage = null;
            this.btAgregar.Iconimage_right = null;
            this.btAgregar.Iconimage_right_Selected = null;
            this.btAgregar.Iconimage_Selected = null;
            this.btAgregar.IconMarginLeft = 0;
            this.btAgregar.IconMarginRight = 0;
            this.btAgregar.IconRightVisible = true;
            this.btAgregar.IconRightZoom = 0D;
            this.btAgregar.IconVisible = true;
            this.btAgregar.IconZoom = 90D;
            this.btAgregar.IsTab = false;
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btAgregar.selected = false;
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAgregar.Textcolor = System.Drawing.Color.White;
            this.btAgregar.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // DataGridDefectos
            // 
            this.DataGridDefectos.AllowUserToAddRows = false;
            this.DataGridDefectos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDefectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridDefectos.AutoGenerateColumns = false;
            this.DataGridDefectos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridDefectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDefectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDefectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridDefectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDefectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.Contador,
            this.Id});
            this.DataGridDefectos.DataSource = this.bindingSourceED;
            this.DataGridDefectos.DoubleBuffered = true;
            this.DataGridDefectos.EnableHeadersVisualStyles = false;
            this.DataGridDefectos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.DataGridDefectos.HeaderForeColor = System.Drawing.Color.Honeydew;
            resources.ApplyResources(this.DataGridDefectos, "DataGridDefectos");
            this.DataGridDefectos.Name = "DataGridDefectos";
            this.DataGridDefectos.ReadOnly = true;
            this.DataGridDefectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridDefectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            resources.ApplyResources(this.descripcionDataGridViewTextBoxColumn, "descripcionDataGridViewTextBoxColumn");
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            resources.ApplyResources(this.tipoDataGridViewTextBoxColumn, "tipoDataGridViewTextBoxColumn");
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Contador
            // 
            resources.ApplyResources(this.Contador, "Contador");
            this.Contador.Name = "Contador";
            this.Contador.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // bindingSourceED
            // 
            this.bindingSourceED.DataSource = typeof(ProyectoBase.Dominio.EspecificacionDeDefecto);
            // 
            // btHermanado
            // 
            this.btHermanado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btHermanado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btHermanado, "btHermanado");
            this.btHermanado.BorderRadius = 0;
            this.btHermanado.ButtonText = "Realizar Hermanado";
            this.btHermanado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHermanado.DisabledColor = System.Drawing.Color.Gray;
            this.btHermanado.Iconcolor = System.Drawing.Color.Transparent;
            this.btHermanado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btHermanado.Iconimage")));
            this.btHermanado.Iconimage_right = null;
            this.btHermanado.Iconimage_right_Selected = null;
            this.btHermanado.Iconimage_Selected = null;
            this.btHermanado.IconMarginLeft = 0;
            this.btHermanado.IconMarginRight = 0;
            this.btHermanado.IconRightVisible = true;
            this.btHermanado.IconRightZoom = 0D;
            this.btHermanado.IconVisible = true;
            this.btHermanado.IconZoom = 90D;
            this.btHermanado.IsTab = false;
            this.btHermanado.Name = "btHermanado";
            this.btHermanado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btHermanado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btHermanado.OnHoverTextColor = System.Drawing.Color.White;
            this.btHermanado.selected = false;
            this.btHermanado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHermanado.Textcolor = System.Drawing.Color.White;
            this.btHermanado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btParPrimera
            // 
            this.btParPrimera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btParPrimera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btParPrimera, "btParPrimera");
            this.btParPrimera.BorderRadius = 0;
            this.btParPrimera.ButtonText = "Par a Primera";
            this.btParPrimera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParPrimera.DisabledColor = System.Drawing.Color.Gray;
            this.btParPrimera.Iconcolor = System.Drawing.Color.Transparent;
            this.btParPrimera.Iconimage = ((System.Drawing.Image)(resources.GetObject("btParPrimera.Iconimage")));
            this.btParPrimera.Iconimage_right = null;
            this.btParPrimera.Iconimage_right_Selected = null;
            this.btParPrimera.Iconimage_Selected = null;
            this.btParPrimera.IconMarginLeft = 0;
            this.btParPrimera.IconMarginRight = 0;
            this.btParPrimera.IconRightVisible = true;
            this.btParPrimera.IconRightZoom = 0D;
            this.btParPrimera.IconVisible = true;
            this.btParPrimera.IconZoom = 90D;
            this.btParPrimera.IsTab = false;
            this.btParPrimera.Name = "btParPrimera";
            this.btParPrimera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btParPrimera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btParPrimera.OnHoverTextColor = System.Drawing.Color.White;
            this.btParPrimera.selected = false;
            this.btParPrimera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btParPrimera.Textcolor = System.Drawing.Color.White;
            this.btParPrimera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // VistaOP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.btParPrimera);
            this.Controls.Add(this.btHermanado);
            this.Controls.Add(this.cbPie);
            this.Controls.Add(this.tbFec);
            this.Controls.Add(this.tbOpNum);
            this.Controls.Add(this.tbTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.DataGridDefectos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaOP";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDefectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDefectos;
        private System.Windows.Forms.BindingSource bindingSourceED;
        private Bunifu.Framework.UI.BunifuFlatButton btQuitar;
        private Bunifu.Framework.UI.BunifuFlatButton btAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btSalir;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbTurno;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbFec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbOpNum;
        private MetroFramework.Controls.MetroComboBox cbPie;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private Bunifu.Framework.UI.BunifuFlatButton btHermanado;
        private Bunifu.Framework.UI.BunifuFlatButton btParPrimera;
    }
}

