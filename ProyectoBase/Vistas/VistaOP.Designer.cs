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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridDefectos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceED = new System.Windows.Forms.BindingSource(this.components);
            this.cbPie = new MetroFramework.Controls.MetroComboBox();
            this.btSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDefectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceED)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbPeriodo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbPeriodo.Location = new System.Drawing.Point(360, 313);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(100, 27);
            this.tbPeriodo.TabIndex = 22;
            // 
            // tbFec
            // 
            this.tbFec.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbFec.Enabled = false;
            this.tbFec.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbFec.Location = new System.Drawing.Point(370, 29);
            this.tbFec.Name = "tbFec";
            this.tbFec.Size = new System.Drawing.Size(84, 27);
            this.tbFec.TabIndex = 22;
            // 
            // tbOpNum
            // 
            this.tbOpNum.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbOpNum.Enabled = false;
            this.tbOpNum.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbOpNum.Location = new System.Drawing.Point(135, 29);
            this.tbOpNum.Name = "tbOpNum";
            this.tbOpNum.Size = new System.Drawing.Size(84, 27);
            this.tbOpNum.TabIndex = 22;
            // 
            // tbTurno
            // 
            this.tbTurno.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbTurno.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbTurno.Location = new System.Drawing.Point(115, 313);
            this.tbTurno.Name = "tbTurno";
            this.tbTurno.Size = new System.Drawing.Size(100, 27);
            this.tbTurno.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "PERIODO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Defectos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "OP ACTUAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "TURNO:";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "-";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Century Gothic", 12F);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(570, 134);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(57, 53);
            this.bunifuFlatButton2.TabIndex = 18;
            this.bunifuFlatButton2.Text = "-";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.quitar_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "+";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 12F);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(493, 134);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(57, 53);
            this.bunifuFlatButton1.TabIndex = 19;
            this.bunifuFlatButton1.Text = "+";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
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
            this.DataGridDefectos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.DataGridDefectos.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.DataGridDefectos.Location = new System.Drawing.Point(34, 97);
            this.DataGridDefectos.Name = "DataGridDefectos";
            this.DataGridDefectos.ReadOnly = true;
            this.DataGridDefectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridDefectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridDefectos.Size = new System.Drawing.Size(420, 196);
            this.DataGridDefectos.TabIndex = 17;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Contador
            // 
            this.Contador.HeaderText = "Contador";
            this.Contador.Name = "Contador";
            this.Contador.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // bindingSourceED
            // 
            this.bindingSourceED.DataSource = typeof(ProyectoBase.Dominio.EspecificacionDeDefecto);
            // 
            // cbPie
            // 
            this.cbPie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.cbPie.FormattingEnabled = true;
            this.cbPie.ItemHeight = 23;
            this.cbPie.Location = new System.Drawing.Point(493, 97);
            this.cbPie.Name = "cbPie";
            this.cbPie.Size = new System.Drawing.Size(134, 29);
            this.cbPie.TabIndex = 24;
            this.cbPie.UseSelectable = true;
            // 
            // btSalir
            // 
            this.btSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalir.BorderRadius = 0;
            this.btSalir.ButtonText = "";
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
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
            this.btSalir.Location = new System.Drawing.Point(580, 294);
            this.btSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btSalir.Name = "btSalir";
            this.btSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.btSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.btSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btSalir.selected = false;
            this.btSalir.Size = new System.Drawing.Size(47, 53);
            this.btSalir.TabIndex = 19;
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSalir.Textcolor = System.Drawing.Color.White;
            this.btSalir.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.btSalir.Click += new System.EventHandler(this.agregar_Click);
            // 
            // VistaOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(655, 366);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaOP";
            this.Text = "VistaOP";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
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
    }
}

