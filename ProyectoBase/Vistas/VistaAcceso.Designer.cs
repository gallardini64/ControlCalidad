namespace ProyectoBase.Vistas
{
    partial class VistaAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAcceso));
            this.tbPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPass.ForeColor = System.Drawing.Color.Olive;
            this.tbPass.HintForeColor = System.Drawing.Color.Green;
            this.tbPass.HintText = "";
            this.tbPass.isPassword = false;
            this.tbPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tbPass.LineIdleColor = System.Drawing.Color.LightGray;
            this.tbPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tbPass.LineThickness = 2;
            this.tbPass.Location = new System.Drawing.Point(145, 123);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(171, 33);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Iniciar Sesión";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(106, 189);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbUsuario);
            this.panel2.Controls.Add(this.tbPass);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 256);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUsuario.ForeColor = System.Drawing.Color.Olive;
            this.tbUsuario.HintForeColor = System.Drawing.Color.Green;
            this.tbUsuario.HintText = "";
            this.tbUsuario.isPassword = false;
            this.tbUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tbUsuario.LineIdleColor = System.Drawing.Color.LightGray;
            this.tbUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tbUsuario.LineThickness = 2;
            this.tbUsuario.Location = new System.Drawing.Point(145, 61);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(171, 33);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(353, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(20, 20);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(138)))));
            this.header.Controls.Add(this.cerrar);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(384, 24);
            this.header.TabIndex = 6;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // VistaAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAcceso";
            this.Text = "VistaAcceso";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPass;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsuario;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Panel header;
    }
}