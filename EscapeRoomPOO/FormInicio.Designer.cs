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
            this.lblTitulo        = new System.Windows.Forms.Label();
            this.lblSub           = new System.Windows.Forms.Label();
            this.lblMejor         = new System.Windows.Forms.Label();
            this.btnJugar         = new System.Windows.Forms.Button();
            this.btnCargarPartida = new System.Windows.Forms.Button();
            this.btnHistorial     = new System.Windows.Forms.Button();
            this.lblIdioma        = new System.Windows.Forms.Label();
            this.cmbIdioma        = new System.Windows.Forms.ComboBox();
            this.lblInfo          = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize  = false;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location  = new System.Drawing.Point(0, 30);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(480, 48);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "ESCAPE ROOM";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSub
            this.lblSub.AutoSize  = false;
            this.lblSub.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblSub.Location  = new System.Drawing.Point(0, 80);
            this.lblSub.Name      = "lblSub";
            this.lblSub.Size      = new System.Drawing.Size(480, 20);
            this.lblSub.TabIndex  = 1;
            this.lblSub.Text      = "Programacion Orientada a Objetos · C# Windows Forms";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblMejor
            this.lblMejor.AutoSize  = false;
            this.lblMejor.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMejor.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblMejor.Location  = new System.Drawing.Point(0, 108);
            this.lblMejor.Name      = "lblMejor";
            this.lblMejor.Size      = new System.Drawing.Size(480, 28);
            this.lblMejor.TabIndex  = 2;
            this.lblMejor.Text      = "Mejor puntaje: 0 pts";
            this.lblMejor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnJugar
            this.btnJugar.BackColor                 = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnJugar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnJugar.ForeColor                 = System.Drawing.Color.White;
            this.btnJugar.Location                  = new System.Drawing.Point(30, 160);
            this.btnJugar.Name                      = "btnJugar";
            this.btnJugar.Size                      = new System.Drawing.Size(130, 46);
            this.btnJugar.TabIndex                  = 3;
            this.btnJugar.Text                      = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor   = false;
            this.btnJugar.Click                    += new System.EventHandler(this.btnJugar_Click);

            // btnCargarPartida
            this.btnCargarPartida.BackColor                 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCargarPartida.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPartida.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPartida.FlatAppearance.BorderSize = 0;
            this.btnCargarPartida.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCargarPartida.ForeColor                 = System.Drawing.Color.White;
            this.btnCargarPartida.Location                  = new System.Drawing.Point(175, 160);
            this.btnCargarPartida.Name                      = "btnCargarPartida";
            this.btnCargarPartida.Size                      = new System.Drawing.Size(150, 46);
            this.btnCargarPartida.TabIndex                  = 4;
            this.btnCargarPartida.Text                      = "CARGAR PARTIDA";
            this.btnCargarPartida.UseVisualStyleBackColor   = false;
            this.btnCargarPartida.Click                    += new System.EventHandler(this.btnCargarPartida_Click);

            // btnHistorial
            this.btnHistorial.BackColor                 = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnHistorial.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.ForeColor                 = System.Drawing.Color.White;
            this.btnHistorial.Location                  = new System.Drawing.Point(340, 160);
            this.btnHistorial.Name                      = "btnHistorial";
            this.btnHistorial.Size                      = new System.Drawing.Size(110, 46);
            this.btnHistorial.TabIndex                  = 5;
            this.btnHistorial.Text                      = "HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor   = false;
            this.btnHistorial.Click                    += new System.EventHandler(this.btnHistorial_Click);

            // lblIdioma
            this.lblIdioma.AutoSize  = false;
            this.lblIdioma.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdioma.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblIdioma.Location  = new System.Drawing.Point(100, 228);
            this.lblIdioma.Name      = "lblIdioma";
            this.lblIdioma.Size      = new System.Drawing.Size(60, 26);
            this.lblIdioma.TabIndex  = 6;
            this.lblIdioma.Text      = "Idioma:";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // cmbIdioma
            this.cmbIdioma.DropDownStyle         = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font                  = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIdioma.Location              = new System.Drawing.Point(168, 230);
            this.cmbIdioma.Name                  = "cmbIdioma";
            this.cmbIdioma.Size                  = new System.Drawing.Size(140, 25);
            this.cmbIdioma.TabIndex              = 7;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);

            // lblInfo
            this.lblInfo.AutoSize  = false;
            this.lblInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblInfo.Location  = new System.Drawing.Point(0, 278);
            this.lblInfo.Name      = "lblInfo";
            this.lblInfo.Size      = new System.Drawing.Size(480, 22);
            this.lblInfo.TabIndex  = 8;
            this.lblInfo.Text      = "3 acertijos por nivel  |  5 niveles  |  60 segundos por nivel";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormInicio
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(44, 62, 80);
            this.ClientSize          = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblMejor);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnCargarPartida);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.cmbIdioma);
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

        private System.Windows.Forms.Label    lblTitulo;
        private System.Windows.Forms.Label    lblSub;
        private System.Windows.Forms.Label    lblMejor;
        private System.Windows.Forms.Button   btnJugar;
        private System.Windows.Forms.Button   btnCargarPartida;
        private System.Windows.Forms.Button   btnHistorial;
        private System.Windows.Forms.Label    lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label    lblInfo;
    }
}
