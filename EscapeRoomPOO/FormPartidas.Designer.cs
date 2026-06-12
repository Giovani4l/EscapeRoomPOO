namespace EscapeRoomPOO
{
    partial class FormPartidas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo   = new System.Windows.Forms.Label();
            this.lblRanuras  = new System.Windows.Forms.Label();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.btnCargar   = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize  = false;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location  = new System.Drawing.Point(0, 20);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(474, 30);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "Partidas guardadas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblRanuras
            this.lblRanuras.AutoSize  = false;
            this.lblRanuras.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRanuras.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblRanuras.Location  = new System.Drawing.Point(0, 54);
            this.lblRanuras.Name      = "lblRanuras";
            this.lblRanuras.Size      = new System.Drawing.Size(474, 20);
            this.lblRanuras.TabIndex  = 1;
            this.lblRanuras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lstPartidas
            this.lstPartidas.BackColor              = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lstPartidas.BorderStyle            = System.Windows.Forms.BorderStyle.None;
            this.lstPartidas.Font                   = new System.Drawing.Font("Segoe UI", 10F);
            this.lstPartidas.ForeColor              = System.Drawing.Color.White;
            this.lstPartidas.Location               = new System.Drawing.Point(20, 84);
            this.lstPartidas.Name                   = "lstPartidas";
            this.lstPartidas.Size                   = new System.Drawing.Size(434, 200);
            this.lstPartidas.TabIndex               = 2;
            this.lstPartidas.SelectedIndexChanged  += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            this.lstPartidas.DoubleClick           += new System.EventHandler(this.lstPartidas_DoubleClick);

            // btnCargar
            this.btnCargar.BackColor                 = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCargar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Enabled                   = false;
            this.btnCargar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor                 = System.Drawing.Color.White;
            this.btnCargar.Location                  = new System.Drawing.Point(20, 304);
            this.btnCargar.Name                      = "btnCargar";
            this.btnCargar.Size                      = new System.Drawing.Size(160, 42);
            this.btnCargar.TabIndex                  = 3;
            this.btnCargar.Text                      = "Cargar";
            this.btnCargar.UseVisualStyleBackColor   = false;
            this.btnCargar.Click                    += new System.EventHandler(this.btnCargar_Click);

            // btnEliminar
            this.btnEliminar.BackColor                 = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnEliminar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled                   = false;
            this.btnEliminar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor                 = System.Drawing.Color.White;
            this.btnEliminar.Location                  = new System.Drawing.Point(196, 304);
            this.btnEliminar.Name                      = "btnEliminar";
            this.btnEliminar.Size                      = new System.Drawing.Size(120, 42);
            this.btnEliminar.TabIndex                  = 4;
            this.btnEliminar.Text                      = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor   = false;
            this.btnEliminar.Click                    += new System.EventHandler(this.btnEliminar_Click);

            // btnCancelar
            this.btnCancelar.BackColor                 = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnCancelar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font                      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor                 = System.Drawing.Color.White;
            this.btnCancelar.Location                  = new System.Drawing.Point(334, 304);
            this.btnCancelar.Name                      = "btnCancelar";
            this.btnCancelar.Size                      = new System.Drawing.Size(120, 42);
            this.btnCancelar.TabIndex                  = 5;
            this.btnCancelar.Text                      = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor   = false;
            this.btnCancelar.Click                    += new System.EventHandler(this.btnCancelar_Click);

            // FormPartidas
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(44, 62, 80);
            this.ClientSize          = new System.Drawing.Size(474, 370);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRanuras);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.Name            = "FormPartidas";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Partidas guardadas";

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label   lblTitulo;
        private System.Windows.Forms.Label   lblRanuras;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Button  btnCargar;
        private System.Windows.Forms.Button  btnEliminar;
        private System.Windows.Forms.Button  btnCancelar;
    }
}
