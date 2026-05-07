namespace EscapeRoomPOO
{
    partial class FormFinal
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
            this.lblResultado  = new System.Windows.Forms.Label();
            this.lblPuntaje    = new System.Windows.Forms.Label();
            this.lblNivelInfo  = new System.Windows.Forms.Label();
            this.lblRecord     = new System.Windows.Forms.Label();
            this.btnReiniciar  = new System.Windows.Forms.Button();
            this.btnSalir      = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblResultado
            this.lblResultado.AutoSize  = false;
            this.lblResultado.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location  = new System.Drawing.Point(0, 30);
            this.lblResultado.Name      = "lblResultado";
            this.lblResultado.Size      = new System.Drawing.Size(394, 40);
            this.lblResultado.TabIndex  = 0;
            this.lblResultado.Text      = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblPuntaje
            this.lblPuntaje.AutoSize  = false;
            this.lblPuntaje.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPuntaje.ForeColor = System.Drawing.Color.White;
            this.lblPuntaje.Location  = new System.Drawing.Point(0, 88);
            this.lblPuntaje.Name      = "lblPuntaje";
            this.lblPuntaje.Size      = new System.Drawing.Size(394, 32);
            this.lblPuntaje.TabIndex  = 1;
            this.lblPuntaje.Text      = "Puntaje: 0 pts";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNivelInfo
            this.lblNivelInfo.AutoSize  = false;
            this.lblNivelInfo.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNivelInfo.ForeColor = System.Drawing.Color.White;
            this.lblNivelInfo.Location  = new System.Drawing.Point(0, 126);
            this.lblNivelInfo.Name      = "lblNivelInfo";
            this.lblNivelInfo.Size      = new System.Drawing.Size(394, 26);
            this.lblNivelInfo.TabIndex  = 2;
            this.lblNivelInfo.Text      = "Nivel alcanzado: 1 / 5";
            this.lblNivelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblRecord
            this.lblRecord.AutoSize  = false;
            this.lblRecord.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location  = new System.Drawing.Point(0, 158);
            this.lblRecord.Name      = "lblRecord";
            this.lblRecord.Size      = new System.Drawing.Size(394, 26);
            this.lblRecord.TabIndex  = 3;
            this.lblRecord.Text      = "Mejor puntaje: 0 pts";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnReiniciar
            this.btnReiniciar.BackColor                 = System.Drawing.Color.White;
            this.btnReiniciar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.ForeColor                 = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnReiniciar.Location                  = new System.Drawing.Point(30, 218);
            this.btnReiniciar.Name                      = "btnReiniciar";
            this.btnReiniciar.Size                      = new System.Drawing.Size(150, 46);
            this.btnReiniciar.TabIndex                  = 4;
            this.btnReiniciar.Text                      = "Jugar de nuevo";
            this.btnReiniciar.UseVisualStyleBackColor   = false;
            this.btnReiniciar.Click                    += new System.EventHandler(this.btnReiniciar_Click);

            // btnSalir
            this.btnSalir.BackColor                 = System.Drawing.Color.FromArgb(80, 0, 0, 0);
            this.btnSalir.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 1;
            this.btnSalir.FlatAppearance.BorderColor= System.Drawing.Color.White;
            this.btnSalir.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor                 = System.Drawing.Color.White;
            this.btnSalir.Location                  = new System.Drawing.Point(214, 218);
            this.btnSalir.Name                      = "btnSalir";
            this.btnSalir.Size                      = new System.Drawing.Size(150, 46);
            this.btnSalir.TabIndex                  = 5;
            this.btnSalir.Text                      = "Salir";
            this.btnSalir.UseVisualStyleBackColor   = false;
            this.btnSalir.Click                    += new System.EventHandler(this.btnSalir_Click);

            // FormFinal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(394, 300);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblNivelInfo);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSalir);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.Name            = "FormFinal";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Resultado";

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label  lblResultado;
        private System.Windows.Forms.Label  lblPuntaje;
        private System.Windows.Forms.Label  lblNivelInfo;
        private System.Windows.Forms.Label  lblRecord;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSalir;
    }
}
