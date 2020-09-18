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
            this.cbPie = new MetroFramework.Controls.MetroComboBox();
            this.tbPeriodo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbFec = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbOpNum = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbTurno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridDefectos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceED = new System.Windows.Forms.BindingSource(this.components);
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
            // tbPeriodo
            // 
            this.tbPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.tbPeriodo.BorderColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.tbPeriodo, "tbPeriodo");
            this.tbPeriodo.Name = "tbPeriodo";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
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
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.bunifuFlatButton2, "bunifuFlatButton2");
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "-";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.quitar_Click);
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
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.bunifuFlatButton1, "bunifuFlatButton1");
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "+";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.agregar_Click);
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
            // bindingSourceED
            // 
            this.bindingSourceED.DataSource = typeof(ProyectoBase.Dominio.EspecificacionDeDefecto);
            // 
            // VistaOP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.cbPie);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.tbFec);
            this.Controls.Add(this.tbOpNum);
            this.Controls.Add(this.tbTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.bunifuFlatButton1);
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbTurno;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbPeriodo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbFec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbOpNum;
        private MetroFramework.Controls.MetroComboBox cbPie;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

