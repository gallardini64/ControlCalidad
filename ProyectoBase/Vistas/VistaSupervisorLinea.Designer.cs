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
            this.bindingSourceOP = new System.Windows.Forms.BindingSource(this.components);
            this.defectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroOP = new System.Windows.Forms.Label();
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
            this.pieDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.especificacionDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.defectoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSourceOP
            // 
            this.bindingSourceOP.DataSource = typeof(ProyectoBase.Dominio.OrdenDeProduccion);
            // 
            // defectoBindingSource
            // 
            this.defectoBindingSource.DataSource = typeof(ProyectoBase.Dominio.Defecto);
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
            // especificacionDataGridViewTextBoxColumn
            // 
            this.especificacionDataGridViewTextBoxColumn.DataPropertyName = "especificacion";
            this.especificacionDataGridViewTextBoxColumn.HeaderText = "especificacion";
            this.especificacionDataGridViewTextBoxColumn.Name = "especificacionDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // VistaSupervisorLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 270);
            this.Controls.Add(this.numeroOP);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource defectoBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceOP;
        private System.Windows.Forms.Label numeroOP;
    }
}