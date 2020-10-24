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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSourceED = new System.Windows.Forms.BindingSource(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pObservado = new System.Windows.Forms.Panel();
            this.defectoAgregarObs = new ProyectoBase.Vistas.ControlesDeUsuario.DefectoAgregar();
            this.lbObservado = new System.Windows.Forms.Label();
            this.pReprocesado = new System.Windows.Forms.Panel();
            this.defectoAgregarRep = new ProyectoBase.Vistas.ControlesDeUsuario.DefectoAgregar();
            this.lbReprocesado = new System.Windows.Forms.Label();
            this.btAgregarParPrimera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbPie = new MetroFramework.Controls.MetroComboBox();
            this.tbFec = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbOpNum = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbTurno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridDefectos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btHermanado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btQuitarParPrimera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hermanadoVista1 = new ProyectoBase.Vistas.ControlesDeUsuario.HermanadoVista();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.pObservado.SuspendLayout();
            this.pReprocesado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDefectos)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceED
            // 
            this.bindingSourceED.DataSource = typeof(ProyectoBase.Dominio.EspecificacionDeDefecto);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 8;
            this.trackBar1.Name = "trackBar1";
            // 
            // pObservado
            // 
            resources.ApplyResources(this.pObservado, "pObservado");
            this.pObservado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.pObservado.Controls.Add(this.defectoAgregarObs);
            this.pObservado.Controls.Add(this.label7);
            this.pObservado.Controls.Add(this.label6);
            this.pObservado.Controls.Add(this.lbObservado);
            this.pObservado.Name = "pObservado";
            // 
            // defectoAgregarObs
            // 
            this.defectoAgregarObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.defectoAgregarObs, "defectoAgregarObs");
            this.defectoAgregarObs.Name = "defectoAgregarObs";
            // 
            // lbObservado
            // 
            resources.ApplyResources(this.lbObservado, "lbObservado");
            this.lbObservado.ForeColor = System.Drawing.Color.White;
            this.lbObservado.Name = "lbObservado";
            // 
            // pReprocesado
            // 
            resources.ApplyResources(this.pReprocesado, "pReprocesado");
            this.pReprocesado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.pReprocesado.Controls.Add(this.defectoAgregarRep);
            this.pReprocesado.Controls.Add(this.label9);
            this.pReprocesado.Controls.Add(this.lbReprocesado);
            this.pReprocesado.Controls.Add(this.label8);
            this.pReprocesado.Name = "pReprocesado";
            // 
            // defectoAgregarRep
            // 
            this.defectoAgregarRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.defectoAgregarRep, "defectoAgregarRep");
            this.defectoAgregarRep.Name = "defectoAgregarRep";
            // 
            // lbReprocesado
            // 
            resources.ApplyResources(this.lbReprocesado, "lbReprocesado");
            this.lbReprocesado.ForeColor = System.Drawing.Color.White;
            this.lbReprocesado.Name = "lbReprocesado";
            // 
            // btAgregarParPrimera
            // 
            this.btAgregarParPrimera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btAgregarParPrimera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btAgregarParPrimera, "btAgregarParPrimera");
            this.btAgregarParPrimera.BorderRadius = 5;
            this.btAgregarParPrimera.ButtonText = "Agregar Par Primera";
            this.btAgregarParPrimera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregarParPrimera.DisabledColor = System.Drawing.Color.Gray;
            this.btAgregarParPrimera.Iconcolor = System.Drawing.Color.Transparent;
            this.btAgregarParPrimera.Iconimage = global::ProyectoBase.Properties.Resources.plus_math_24px;
            this.btAgregarParPrimera.Iconimage_right = null;
            this.btAgregarParPrimera.Iconimage_right_Selected = null;
            this.btAgregarParPrimera.Iconimage_Selected = null;
            this.btAgregarParPrimera.IconMarginLeft = 0;
            this.btAgregarParPrimera.IconMarginRight = 0;
            this.btAgregarParPrimera.IconRightVisible = true;
            this.btAgregarParPrimera.IconRightZoom = 0D;
            this.btAgregarParPrimera.IconVisible = true;
            this.btAgregarParPrimera.IconZoom = 50D;
            this.btAgregarParPrimera.IsTab = false;
            this.btAgregarParPrimera.Name = "btAgregarParPrimera";
            this.btAgregarParPrimera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btAgregarParPrimera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btAgregarParPrimera.OnHoverTextColor = System.Drawing.Color.White;
            this.btAgregarParPrimera.selected = false;
            this.btAgregarParPrimera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregarParPrimera.Textcolor = System.Drawing.Color.White;
            this.btAgregarParPrimera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarParPrimera.Click += new System.EventHandler(this.btParPrimera_Click);
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
            this.tbFec.ForeColor = System.Drawing.Color.White;
            this.tbFec.Name = "tbFec";
            // 
            // tbOpNum
            // 
            this.tbOpNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbOpNum.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.tbOpNum, "tbOpNum");
            this.tbOpNum.ForeColor = System.Drawing.Color.White;
            this.tbOpNum.Name = "tbOpNum";
            // 
            // tbTurno
            // 
            this.tbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbTurno.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.tbTurno, "tbTurno");
            this.tbTurno.ForeColor = System.Drawing.Color.White;
            this.tbTurno.Name = "tbTurno";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
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
            // DataGridDefectos
            // 
            this.DataGridDefectos.AllowUserToAddRows = false;
            this.DataGridDefectos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDefectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDefectos.AutoGenerateColumns = false;
            this.DataGridDefectos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridDefectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridDefectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDefectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridDefectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDefectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.Id,
            this.Contador});
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Contador
            // 
            resources.ApplyResources(this.Contador, "Contador");
            this.Contador.Name = "Contador";
            this.Contador.ReadOnly = true;
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
            this.btSalir.Iconimage = global::ProyectoBase.Properties.Resources.exit_32px1;
            this.btSalir.Iconimage_right = null;
            this.btSalir.Iconimage_right_Selected = null;
            this.btSalir.Iconimage_Selected = null;
            this.btSalir.IconMarginLeft = 0;
            this.btSalir.IconMarginRight = 0;
            this.btSalir.IconRightVisible = true;
            this.btSalir.IconRightZoom = 0D;
            this.btSalir.IconVisible = true;
            this.btSalir.IconZoom = 70D;
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
            // btHermanado
            // 
            this.btHermanado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btHermanado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btHermanado, "btHermanado");
            this.btHermanado.BorderRadius = 5;
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
            this.btHermanado.Click += new System.EventHandler(this.btHermanado_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // btQuitarParPrimera
            // 
            this.btQuitarParPrimera.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btQuitarParPrimera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.btQuitarParPrimera, "btQuitarParPrimera");
            this.btQuitarParPrimera.BorderRadius = 5;
            this.btQuitarParPrimera.ButtonText = "Quitar Par Primera";
            this.btQuitarParPrimera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuitarParPrimera.DisabledColor = System.Drawing.Color.Gray;
            this.btQuitarParPrimera.Iconcolor = System.Drawing.Color.Transparent;
            this.btQuitarParPrimera.Iconimage = global::ProyectoBase.Properties.Resources.minus_24px;
            this.btQuitarParPrimera.Iconimage_right = null;
            this.btQuitarParPrimera.Iconimage_right_Selected = null;
            this.btQuitarParPrimera.Iconimage_Selected = null;
            this.btQuitarParPrimera.IconMarginLeft = 0;
            this.btQuitarParPrimera.IconMarginRight = 0;
            this.btQuitarParPrimera.IconRightVisible = true;
            this.btQuitarParPrimera.IconRightZoom = 0D;
            this.btQuitarParPrimera.IconVisible = true;
            this.btQuitarParPrimera.IconZoom = 50D;
            this.btQuitarParPrimera.IsTab = false;
            this.btQuitarParPrimera.Name = "btQuitarParPrimera";
            this.btQuitarParPrimera.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btQuitarParPrimera.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btQuitarParPrimera.OnHoverTextColor = System.Drawing.Color.White;
            this.btQuitarParPrimera.selected = false;
            this.btQuitarParPrimera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuitarParPrimera.Textcolor = System.Drawing.Color.White;
            this.btQuitarParPrimera.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitarParPrimera.Click += new System.EventHandler(this.btParPrimera_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // hermanadoVista1
            // 
            this.hermanadoVista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.hermanadoVista1, "hermanadoVista1");
            this.hermanadoVista1.Name = "hermanadoVista1";
            // 
            // VistaOP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.hermanadoVista1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pObservado);
            this.Controls.Add(this.pReprocesado);
            this.Controls.Add(this.btQuitarParPrimera);
            this.Controls.Add(this.btAgregarParPrimera);
            this.Controls.Add(this.btHermanado);
            this.Controls.Add(this.cbPie);
            this.Controls.Add(this.tbFec);
            this.Controls.Add(this.tbOpNum);
            this.Controls.Add(this.tbTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.DataGridDefectos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaOP";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VistaOP_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.pObservado.ResumeLayout(false);
            this.pObservado.PerformLayout();
            this.pReprocesado.ResumeLayout(false);
            this.pReprocesado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDefectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridDefectos;
        private System.Windows.Forms.BindingSource bindingSourceED;
        private Bunifu.Framework.UI.BunifuFlatButton btSalir;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbTurno;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbFec;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbOpNum;
        private MetroFramework.Controls.MetroComboBox cbPie;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private Bunifu.Framework.UI.BunifuFlatButton btHermanado;
        private Bunifu.Framework.UI.BunifuFlatButton btAgregarParPrimera;
        private System.Windows.Forms.TrackBar trackBar1;
        private Vistas.ControlesDeUsuario.DefectoAgregar defectoAgregarRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbReprocesado;
        private System.Windows.Forms.Panel pReprocesado;
        private System.Windows.Forms.Panel pObservado;
        private Vistas.ControlesDeUsuario.DefectoAgregar defectoAgregarObs;
        private System.Windows.Forms.Label lbObservado;
        private Bunifu.Framework.UI.BunifuFlatButton btQuitarParPrimera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Vistas.ControlesDeUsuario.HermanadoVista hermanadoVista1;
    }
}

