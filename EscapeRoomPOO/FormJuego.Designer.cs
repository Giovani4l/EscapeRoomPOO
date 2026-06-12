namespace EscapeRoomPOO
{
    partial class FormJuego
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
            this.components          = new System.ComponentModel.Container();
            this.timerJuego          = new System.Windows.Forms.Timer(this.components);
            this.panelTop            = new System.Windows.Forms.Panel();
            this.lblNivel            = new System.Windows.Forms.Label();
            this.lblTipo             = new System.Windows.Forms.Label();
            this.lblPuntaje          = new System.Windows.Forms.Label();
            this.lblMejorPuntaje     = new System.Windows.Forms.Label();
            this.lblTimer            = new System.Windows.Forms.Label();
            this.progressBarTimer    = new System.Windows.Forms.ProgressBar();
            this.lblProgreso         = new System.Windows.Forms.Label();
            this.progressBarAcertijo = new System.Windows.Forms.ProgressBar();
            this.panelPregunta       = new System.Windows.Forms.Panel();
            this.lblPregunta         = new System.Windows.Forms.Label();
            this.txtRespuesta        = new System.Windows.Forms.TextBox();
            this.btnValidar          = new System.Windows.Forms.Button();
            this.lblFeedback         = new System.Windows.Forms.Label();
            this.lblIntentos         = new System.Windows.Forms.Label();
            this.lblPista            = new System.Windows.Forms.Label();
            this.panelBottom         = new System.Windows.Forms.Panel();
            this.btnPista            = new System.Windows.Forms.Button();
            this.btnGuardar          = new System.Windows.Forms.Button();
            this.btnRendirse         = new System.Windows.Forms.Button();
            this.lblInstruccion      = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelPregunta.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // timerJuego
            this.timerJuego.Interval = 1000;
            this.timerJuego.Tick    += new System.EventHandler(this.timerJuego_Tick);

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelTop.Controls.Add(this.lblTimer);
            this.panelTop.Controls.Add(this.lblMejorPuntaje);
            this.panelTop.Controls.Add(this.lblPuntaje);
            this.panelTop.Controls.Add(this.lblTipo);
            this.panelTop.Controls.Add(this.lblNivel);
            this.panelTop.Controls.Add(this.progressBarTimer);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name     = "panelTop";
            this.panelTop.Size     = new System.Drawing.Size(616, 90);
            this.panelTop.TabIndex = 0;

            // lblNivel
            this.lblNivel.AutoSize  = false;
            this.lblNivel.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location  = new System.Drawing.Point(12, 8);
            this.lblNivel.Name      = "lblNivel";
            this.lblNivel.Size      = new System.Drawing.Size(220, 28);
            this.lblNivel.TabIndex  = 0;
            this.lblNivel.Text      = "NIVEL 1 / 5";

            // lblTipo
            this.lblTipo.AutoSize  = false;
            this.lblTipo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(180, 190, 200);
            this.lblTipo.Location  = new System.Drawing.Point(12, 38);
            this.lblTipo.Name      = "lblTipo";
            this.lblTipo.Size      = new System.Drawing.Size(220, 20);
            this.lblTipo.TabIndex  = 1;
            this.lblTipo.Text      = "[Tipo]";

            // lblPuntaje
            this.lblPuntaje.AutoSize  = false;
            this.lblPuntaje.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuntaje.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblPuntaje.Location  = new System.Drawing.Point(336, 8);
            this.lblPuntaje.Name      = "lblPuntaje";
            this.lblPuntaje.Size      = new System.Drawing.Size(148, 28);
            this.lblPuntaje.TabIndex  = 2;
            this.lblPuntaje.Text      = "Puntaje: 0";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblMejorPuntaje
            this.lblMejorPuntaje.AutoSize  = false;
            this.lblMejorPuntaje.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMejorPuntaje.ForeColor = System.Drawing.Color.FromArgb(180, 190, 200);
            this.lblMejorPuntaje.Location  = new System.Drawing.Point(336, 38);
            this.lblMejorPuntaje.Name      = "lblMejorPuntaje";
            this.lblMejorPuntaje.Size      = new System.Drawing.Size(148, 20);
            this.lblMejorPuntaje.TabIndex  = 3;
            this.lblMejorPuntaje.Text      = "Mejor: 0 pts";
            this.lblMejorPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblTimer
            this.lblTimer.AutoSize  = false;
            this.lblTimer.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblTimer.Location  = new System.Drawing.Point(492, 8);
            this.lblTimer.Name      = "lblTimer";
            this.lblTimer.Size      = new System.Drawing.Size(110, 52);
            this.lblTimer.TabIndex  = 4;
            this.lblTimer.Text      = "60s";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // progressBarTimer
            this.progressBarTimer.Location = new System.Drawing.Point(12, 70);
            this.progressBarTimer.Maximum  = 100;
            this.progressBarTimer.Name     = "progressBarTimer";
            this.progressBarTimer.Size     = new System.Drawing.Size(592, 8);
            this.progressBarTimer.Style    = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTimer.TabIndex = 5;
            this.progressBarTimer.Value    = 100;

            // lblProgreso
            this.lblProgreso.AutoSize  = false;
            this.lblProgreso.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProgreso.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProgreso.Location  = new System.Drawing.Point(12, 100);
            this.lblProgreso.Name      = "lblProgreso";
            this.lblProgreso.Size      = new System.Drawing.Size(200, 20);
            this.lblProgreso.TabIndex  = 1;
            this.lblProgreso.Text      = "Acertijo 1 de 3";

            // progressBarAcertijo
            this.progressBarAcertijo.Location = new System.Drawing.Point(12, 122);
            this.progressBarAcertijo.Maximum  = 100;
            this.progressBarAcertijo.Name     = "progressBarAcertijo";
            this.progressBarAcertijo.Size     = new System.Drawing.Size(592, 7);
            this.progressBarAcertijo.Style    = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarAcertijo.TabIndex = 2;

            // panelPregunta
            this.panelPregunta.BackColor   = System.Drawing.SystemColors.ControlLight;
            this.panelPregunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPregunta.Controls.Add(this.lblPregunta);
            this.panelPregunta.Location    = new System.Drawing.Point(12, 136);
            this.panelPregunta.Name        = "panelPregunta";
            this.panelPregunta.Size        = new System.Drawing.Size(592, 130);
            this.panelPregunta.TabIndex    = 3;

            // lblPregunta
            this.lblPregunta.AutoSize  = false;
            this.lblPregunta.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblPregunta.Font      = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPregunta.Location  = new System.Drawing.Point(0, 0);
            this.lblPregunta.Name      = "lblPregunta";
            this.lblPregunta.Padding   = new System.Windows.Forms.Padding(10);
            this.lblPregunta.Size      = new System.Drawing.Size(590, 128);
            this.lblPregunta.TabIndex  = 0;
            this.lblPregunta.Text      = "Aqui aparecera la pregunta...";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtRespuesta
            this.txtRespuesta.Font            = new System.Drawing.Font("Segoe UI", 13F);
            this.txtRespuesta.Location        = new System.Drawing.Point(12, 278);
            this.txtRespuesta.Name            = "txtRespuesta";
            this.txtRespuesta.PlaceholderText = "Escribe tu respuesta...";
            this.txtRespuesta.Size            = new System.Drawing.Size(472, 34);
            this.txtRespuesta.TabIndex        = 4;
            this.txtRespuesta.KeyDown        += new System.Windows.Forms.KeyEventHandler(this.txtRespuesta_KeyDown);

            // btnValidar
            this.btnValidar.BackColor                 = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btnValidar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnValidar.ForeColor                 = System.Drawing.Color.White;
            this.btnValidar.Location                  = new System.Drawing.Point(492, 278);
            this.btnValidar.Name                      = "btnValidar";
            this.btnValidar.Size                      = new System.Drawing.Size(112, 34);
            this.btnValidar.TabIndex                  = 5;
            this.btnValidar.Text                      = "Validar";
            this.btnValidar.UseVisualStyleBackColor   = false;
            this.btnValidar.Click                    += new System.EventHandler(this.btnValidar_Click);

            // lblFeedback
            this.lblFeedback.AutoSize  = false;
            this.lblFeedback.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFeedback.Location  = new System.Drawing.Point(12, 322);
            this.lblFeedback.Name      = "lblFeedback";
            this.lblFeedback.Size      = new System.Drawing.Size(592, 28);
            this.lblFeedback.TabIndex  = 6;
            this.lblFeedback.Text      = "";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblIntentos
            this.lblIntentos.AutoSize  = false;
            this.lblIntentos.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntentos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIntentos.Location  = new System.Drawing.Point(12, 358);
            this.lblIntentos.Name      = "lblIntentos";
            this.lblIntentos.Size      = new System.Drawing.Size(200, 22);
            this.lblIntentos.TabIndex  = 7;
            this.lblIntentos.Text      = "Intentos: 3";

            // lblPista
            this.lblPista.AutoSize  = false;
            this.lblPista.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
            this.lblPista.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblPista.ForeColor = System.Drawing.Color.FromArgb(100, 60, 0);
            this.lblPista.Location  = new System.Drawing.Point(12, 386);
            this.lblPista.Name      = "lblPista";
            this.lblPista.Padding   = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblPista.Size      = new System.Drawing.Size(592, 36);
            this.lblPista.TabIndex  = 8;
            this.lblPista.Text      = "";
            this.lblPista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPista.Visible   = false;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBottom.Controls.Add(this.btnPista);
            this.panelBottom.Controls.Add(this.btnGuardar);
            this.panelBottom.Controls.Add(this.btnRendirse);
            this.panelBottom.Controls.Add(this.lblInstruccion);
            this.panelBottom.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 436);
            this.panelBottom.Name     = "panelBottom";
            this.panelBottom.Size     = new System.Drawing.Size(616, 120);
            this.panelBottom.TabIndex = 9;

            // btnPista
            this.btnPista.BackColor                 = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnPista.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnPista.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnPista.FlatAppearance.BorderSize = 0;
            this.btnPista.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPista.ForeColor                 = System.Drawing.Color.FromArgb(60, 40, 0);
            this.btnPista.Location                  = new System.Drawing.Point(12, 28);
            this.btnPista.Name                      = "btnPista";
            this.btnPista.Size                      = new System.Drawing.Size(130, 40);
            this.btnPista.TabIndex                  = 0;
            this.btnPista.Text                      = "Pedir pista";
            this.btnPista.UseVisualStyleBackColor   = false;
            this.btnPista.Click                    += new System.EventHandler(this.btnPista_Click);

            // btnGuardar
            this.btnGuardar.BackColor                 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGuardar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor                 = System.Drawing.Color.White;
            this.btnGuardar.Location                  = new System.Drawing.Point(158, 28);
            this.btnGuardar.Name                      = "btnGuardar";
            this.btnGuardar.Size                      = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex                  = 1;
            this.btnGuardar.Text                      = "Guardar partida";
            this.btnGuardar.UseVisualStyleBackColor   = false;
            this.btnGuardar.Click                    += new System.EventHandler(this.btnGuardar_Click);

            // btnRendirse
            this.btnRendirse.BackColor                 = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnRendirse.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnRendirse.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnRendirse.FlatAppearance.BorderSize = 0;
            this.btnRendirse.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRendirse.ForeColor                 = System.Drawing.Color.White;
            this.btnRendirse.Location                  = new System.Drawing.Point(462, 28);
            this.btnRendirse.Name                      = "btnRendirse";
            this.btnRendirse.Size                      = new System.Drawing.Size(142, 40);
            this.btnRendirse.TabIndex                  = 2;
            this.btnRendirse.Text                      = "Abandonar y Guardar";
            this.btnRendirse.UseVisualStyleBackColor   = false;
            this.btnRendirse.Click                    += new System.EventHandler(this.btnRendirse_Click);

            // lblInstruccion
            this.lblInstruccion.AutoSize  = false;
            this.lblInstruccion.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.lblInstruccion.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInstruccion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblInstruccion.Location  = new System.Drawing.Point(0, 94);
            this.lblInstruccion.Name      = "lblInstruccion";
            this.lblInstruccion.Size      = new System.Drawing.Size(616, 26);
            this.lblInstruccion.TabIndex  = 3;
            this.lblInstruccion.Text      = "Presiona Enter o Validar para responder";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormJuego
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(616, 556);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.progressBarAcertijo);
            this.Controls.Add(this.panelPregunta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.lblPista);
            this.Controls.Add(this.panelBottom);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormJuego";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Escape Room - POO";

            this.panelTop.ResumeLayout(false);
            this.panelPregunta.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer       timerJuego;
        private System.Windows.Forms.Panel       panelTop;
        private System.Windows.Forms.Panel       panelPregunta;
        private System.Windows.Forms.Panel       panelBottom;
        private System.Windows.Forms.Label       lblNivel;
        private System.Windows.Forms.Label       lblTipo;
        private System.Windows.Forms.Label       lblPuntaje;
        private System.Windows.Forms.Label       lblMejorPuntaje;
        private System.Windows.Forms.Label       lblTimer;
        private System.Windows.Forms.Label       lblProgreso;
        private System.Windows.Forms.Label       lblPregunta;
        private System.Windows.Forms.Label       lblFeedback;
        private System.Windows.Forms.Label       lblIntentos;
        private System.Windows.Forms.Label       lblPista;
        private System.Windows.Forms.Label       lblInstruccion;
        private System.Windows.Forms.TextBox     txtRespuesta;
        private System.Windows.Forms.Button      btnValidar;
        private System.Windows.Forms.Button      btnPista;
        private System.Windows.Forms.Button      btnGuardar;
        private System.Windows.Forms.Button      btnRendirse;
        private System.Windows.Forms.ProgressBar progressBarTimer;
        private System.Windows.Forms.ProgressBar progressBarAcertijo;
    }
}
