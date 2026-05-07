namespace EscapeRoomPOO
{
    partial class FormInicio
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
            this.lblTitulo    = new System.Windows.Forms.Label();
            this.lblSub       = new System.Windows.Forms.Label();
            this.lblMejor     = new System.Windows.Forms.Label();
            this.btnJugar     = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblInfo      = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize  = false;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location  = new System.Drawing.Point(0, 40);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(444, 48);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "ESCAPE ROOM";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSub
            this.lblSub.AutoSize  = false;
            this.lblSub.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblSub.Location  = new System.Drawing.Point(0, 92);
            this.lblSub.Name      = "lblSub";
            this.lblSub.Size      = new System.Drawing.Size(444, 26);
            this.lblSub.TabIndex  = 1;
            this.lblSub.Text      = "Programacion Orientada a Objetos";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblMejor
            this.lblMejor.AutoSize  = false;
            this.lblMejor.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMejor.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblMejor.Location  = new System.Drawing.Point(0, 140);
            this.lblMejor.Name      = "lblMejor";
            this.lblMejor.Size      = new System.Drawing.Size(444, 28);
            this.lblMejor.TabIndex  = 2;
            this.lblMejor.Text      = "Mejor puntaje: 0 pts";
            this.lblMejor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnJugar
            this.btnJugar.BackColor                 = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnJugar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.Font                      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnJugar.ForeColor                 = System.Drawing.Color.White;
            this.btnJugar.Location                  = new System.Drawing.Point(62, 200);
            this.btnJugar.Name                      = "btnJugar";
            this.btnJugar.Size                      = new System.Drawing.Size(140, 50);
            this.btnJugar.TabIndex                  = 3;
            this.btnJugar.Text                      = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor   = false;
            this.btnJugar.Click                    += new System.EventHandler(this.btnJugar_Click);

            // btnHistorial
            this.btnHistorial.BackColor                 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnHistorial.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.Font                      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.ForeColor                 = System.Drawing.Color.White;
            this.btnHistorial.Location                  = new System.Drawing.Point(242, 200);
            this.btnHistorial.Name                      = "btnHistorial";
            this.btnHistorial.Size                      = new System.Drawing.Size(140, 50);
            this.btnHistorial.TabIndex                  = 4;
            this.btnHistorial.Text                      = "HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor   = false;
            this.btnHistorial.Click                    += new System.EventHandler(this.btnHistorial_Click);

            // lblInfo
            this.lblInfo.AutoSize  = false;
            this.lblInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblInfo.Location  = new System.Drawing.Point(0, 282);
            this.lblInfo.Name      = "lblInfo";
            this.lblInfo.Size      = new System.Drawing.Size(444, 22);
            this.lblInfo.TabIndex  = 5;
            this.lblInfo.Text      = "3 acertijos por nivel  |  5 niveles  |  60 segundos por nivel";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormInicio
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(44, 62, 80);
            this.ClientSize          = new System.Drawing.Size(444, 330);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblMejor);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.lblInfo);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormInicio";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Escape Room POO";

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label  lblTitulo;
        private System.Windows.Forms.Label  lblSub;
        private System.Windows.Forms.Label  lblMejor;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label  lblInfo;
    }
}
