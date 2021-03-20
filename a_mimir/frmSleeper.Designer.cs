namespace a_mimir
{
    partial class frmSleeper
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSleeper));
            this.pnlPai = new Bunifu.Framework.UI.BunifuCards();
            this.btnNightMode = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblSegundos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMinutos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHoras = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSegundos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMinutos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHoras = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioHibernar = new XanderUI.XUIRadio();
            this.btnParar = new XanderUI.XUIButton();
            this.btnIniciar = new XanderUI.XUIButton();
            this.lblTimer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlLinhaTempo = new System.Windows.Forms.Panel();
            this.lblTempo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlLinhaDefinirTempo = new System.Windows.Forms.Panel();
            this.pnlDivisorTempo = new System.Windows.Forms.Panel();
            this.lblTemporizador = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlLinhaAcao = new System.Windows.Forms.Panel();
            this.radioBloquear = new XanderUI.XUIRadio();
            this.radioReiniciar = new XanderUI.XUIRadio();
            this.radioDesligar = new XanderUI.XUIRadio();
            this.lblAcao = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.elipseErmSleeper = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNomePrograma = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.controlHead = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tmrAcao = new System.Windows.Forms.Timer(this.components);
            this.pnlPai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNightMode)).BeginInit();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPai
            // 
            this.pnlPai.BackColor = System.Drawing.Color.White;
            this.pnlPai.BorderRadius = 5;
            this.pnlPai.BottomSahddow = true;
            this.pnlPai.color = System.Drawing.Color.DodgerBlue;
            this.pnlPai.Controls.Add(this.btnNightMode);
            this.pnlPai.Controls.Add(this.lblSegundos);
            this.pnlPai.Controls.Add(this.lblMinutos);
            this.pnlPai.Controls.Add(this.lblHoras);
            this.pnlPai.Controls.Add(this.txtSegundos);
            this.pnlPai.Controls.Add(this.txtMinutos);
            this.pnlPai.Controls.Add(this.txtHoras);
            this.pnlPai.Controls.Add(this.radioHibernar);
            this.pnlPai.Controls.Add(this.btnParar);
            this.pnlPai.Controls.Add(this.btnIniciar);
            this.pnlPai.Controls.Add(this.lblTimer);
            this.pnlPai.Controls.Add(this.pnlLinhaTempo);
            this.pnlPai.Controls.Add(this.lblTempo);
            this.pnlPai.Controls.Add(this.pnlLinhaDefinirTempo);
            this.pnlPai.Controls.Add(this.pnlDivisorTempo);
            this.pnlPai.Controls.Add(this.lblTemporizador);
            this.pnlPai.Controls.Add(this.pnlLinhaAcao);
            this.pnlPai.Controls.Add(this.radioBloquear);
            this.pnlPai.Controls.Add(this.radioReiniciar);
            this.pnlPai.Controls.Add(this.radioDesligar);
            this.pnlPai.Controls.Add(this.lblAcao);
            this.pnlPai.Controls.Add(this.pnlDivisor);
            this.pnlPai.LeftSahddow = false;
            this.pnlPai.Location = new System.Drawing.Point(-2, 21);
            this.pnlPai.Name = "pnlPai";
            this.pnlPai.RightSahddow = true;
            this.pnlPai.ShadowDepth = 20;
            this.pnlPai.Size = new System.Drawing.Size(482, 252);
            this.pnlPai.TabIndex = 0;
            // 
            // btnNightMode
            // 
            this.btnNightMode.BackColor = System.Drawing.Color.Transparent;
            this.btnNightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNightMode.Image = global::a_mimir.Properties.Resources.night;
            this.btnNightMode.ImageActive = null;
            this.btnNightMode.Location = new System.Drawing.Point(435, 203);
            this.btnNightMode.Name = "btnNightMode";
            this.btnNightMode.Size = new System.Drawing.Size(32, 32);
            this.btnNightMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNightMode.TabIndex = 23;
            this.btnNightMode.TabStop = false;
            this.btnNightMode.Zoom = 10;
            this.btnNightMode.Click += new System.EventHandler(this.btnNightMode_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(118, 183);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(54, 13);
            this.lblSegundos.TabIndex = 22;
            this.lblSegundos.Text = "Segundos";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(118, 127);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(47, 13);
            this.lblMinutos.TabIndex = 21;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(118, 75);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(36, 13);
            this.lblHoras.TabIndex = 20;
            this.lblHoras.Text = "Horas";
            // 
            // txtSegundos
            // 
            this.txtSegundos.Depth = 0;
            this.txtSegundos.Hint = "";
            this.txtSegundos.Location = new System.Drawing.Point(121, 203);
            this.txtSegundos.MaxLength = 6;
            this.txtSegundos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.PasswordChar = '\0';
            this.txtSegundos.SelectedText = "";
            this.txtSegundos.SelectionLength = 0;
            this.txtSegundos.SelectionStart = 0;
            this.txtSegundos.Size = new System.Drawing.Size(147, 23);
            this.txtSegundos.TabIndex = 19;
            this.txtSegundos.TabStop = false;
            this.txtSegundos.UseSystemPasswordChar = false;
            this.txtSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundos_KeyPress_1);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Depth = 0;
            this.txtMinutos.Hint = "";
            this.txtMinutos.Location = new System.Drawing.Point(121, 149);
            this.txtMinutos.MaxLength = 4;
            this.txtMinutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.PasswordChar = '\0';
            this.txtMinutos.SelectedText = "";
            this.txtMinutos.SelectionLength = 0;
            this.txtMinutos.SelectionStart = 0;
            this.txtMinutos.Size = new System.Drawing.Size(147, 23);
            this.txtMinutos.TabIndex = 18;
            this.txtMinutos.TabStop = false;
            this.txtMinutos.UseSystemPasswordChar = false;
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutos_KeyPress);
            // 
            // txtHoras
            // 
            this.txtHoras.Depth = 0;
            this.txtHoras.Hint = "";
            this.txtHoras.Location = new System.Drawing.Point(121, 95);
            this.txtHoras.MaxLength = 2;
            this.txtHoras.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.PasswordChar = '\0';
            this.txtHoras.SelectedText = "";
            this.txtHoras.SelectionLength = 0;
            this.txtHoras.SelectionStart = 0;
            this.txtHoras.Size = new System.Drawing.Size(147, 23);
            this.txtHoras.TabIndex = 17;
            this.txtHoras.TabStop = false;
            this.txtHoras.UseSystemPasswordChar = false;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            // 
            // radioHibernar
            // 
            this.radioHibernar.Checked = false;
            this.radioHibernar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioHibernar.Location = new System.Drawing.Point(12, 171);
            this.radioHibernar.Name = "radioHibernar";
            this.radioHibernar.RadioColor = System.Drawing.Color.CornflowerBlue;
            this.radioHibernar.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.radioHibernar.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.radioHibernar.Size = new System.Drawing.Size(72, 15);
            this.radioHibernar.TabIndex = 3;
            this.radioHibernar.Text = "Hibernar";
            // 
            // btnParar
            // 
            this.btnParar.BackgroundColor = System.Drawing.Color.Brown;
            this.btnParar.ButtonImage = null;
            this.btnParar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnParar.ButtonText = "Parar";
            this.btnParar.ClickBackColor = System.Drawing.Color.Maroon;
            this.btnParar.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnParar.CornerRadius = 5;
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnParar.HoverBackgroundColor = System.Drawing.Color.Maroon;
            this.btnParar.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnParar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnParar.Location = new System.Drawing.Point(396, 153);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(71, 33);
            this.btnParar.TabIndex = 8;
            this.btnParar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnParar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnIniciar.ButtonImage = null;
            this.btnIniciar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnIniciar.ButtonText = "Iniciar";
            this.btnIniciar.ClickBackColor = System.Drawing.Color.RoyalBlue;
            this.btnIniciar.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.CornerRadius = 5;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnIniciar.HoverBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnIniciar.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnIniciar.Location = new System.Drawing.Point(313, 153);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(71, 33);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Yu Gothic UI", 18.25F);
            this.lblTimer.Location = new System.Drawing.Point(336, 93);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(103, 35);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "00:00:00";
            // 
            // pnlLinhaTempo
            // 
            this.pnlLinhaTempo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLinhaTempo.Location = new System.Drawing.Point(292, 44);
            this.pnlLinhaTempo.Name = "pnlLinhaTempo";
            this.pnlLinhaTempo.Size = new System.Drawing.Size(189, 2);
            this.pnlLinhaTempo.TabIndex = 14;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(368, 23);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(39, 13);
            this.lblTempo.TabIndex = 13;
            this.lblTempo.Text = "Tempo";
            // 
            // pnlLinhaDefinirTempo
            // 
            this.pnlLinhaDefinirTempo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLinhaDefinirTempo.Location = new System.Drawing.Point(100, 44);
            this.pnlLinhaDefinirTempo.Name = "pnlLinhaDefinirTempo";
            this.pnlLinhaDefinirTempo.Size = new System.Drawing.Size(190, 2);
            this.pnlLinhaDefinirTempo.TabIndex = 12;
            // 
            // pnlDivisorTempo
            // 
            this.pnlDivisorTempo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDivisorTempo.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlDivisorTempo.Location = new System.Drawing.Point(290, 4);
            this.pnlDivisorTempo.Name = "pnlDivisorTempo";
            this.pnlDivisorTempo.Size = new System.Drawing.Size(2, 250);
            this.pnlDivisorTempo.TabIndex = 8;
            // 
            // lblTemporizador
            // 
            this.lblTemporizador.AutoSize = true;
            this.lblTemporizador.Location = new System.Drawing.Point(152, 23);
            this.lblTemporizador.Name = "lblTemporizador";
            this.lblTemporizador.Size = new System.Drawing.Size(85, 13);
            this.lblTemporizador.TabIndex = 7;
            this.lblTemporizador.Text = "Definir o Tempo";
            // 
            // pnlLinhaAcao
            // 
            this.pnlLinhaAcao.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLinhaAcao.Location = new System.Drawing.Point(-1, 44);
            this.pnlLinhaAcao.Name = "pnlLinhaAcao";
            this.pnlLinhaAcao.Size = new System.Drawing.Size(99, 2);
            this.pnlLinhaAcao.TabIndex = 6;
            // 
            // radioBloquear
            // 
            this.radioBloquear.Checked = false;
            this.radioBloquear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioBloquear.Location = new System.Drawing.Point(12, 145);
            this.radioBloquear.Name = "radioBloquear";
            this.radioBloquear.RadioColor = System.Drawing.Color.CornflowerBlue;
            this.radioBloquear.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.radioBloquear.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.radioBloquear.Size = new System.Drawing.Size(72, 15);
            this.radioBloquear.TabIndex = 2;
            this.radioBloquear.Text = "Logoff";
            // 
            // radioReiniciar
            // 
            this.radioReiniciar.Checked = false;
            this.radioReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioReiniciar.Location = new System.Drawing.Point(12, 119);
            this.radioReiniciar.Name = "radioReiniciar";
            this.radioReiniciar.RadioColor = System.Drawing.Color.CornflowerBlue;
            this.radioReiniciar.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.radioReiniciar.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.radioReiniciar.Size = new System.Drawing.Size(72, 15);
            this.radioReiniciar.TabIndex = 1;
            this.radioReiniciar.Text = "Reiniciar";
            // 
            // radioDesligar
            // 
            this.radioDesligar.Checked = false;
            this.radioDesligar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioDesligar.Location = new System.Drawing.Point(13, 93);
            this.radioDesligar.Name = "radioDesligar";
            this.radioDesligar.RadioColor = System.Drawing.Color.CornflowerBlue;
            this.radioDesligar.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.radioDesligar.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.radioDesligar.Size = new System.Drawing.Size(72, 15);
            this.radioDesligar.TabIndex = 0;
            this.radioDesligar.Text = "Desligar";
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Location = new System.Drawing.Point(32, 23);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(34, 13);
            this.lblAcao.TabIndex = 2;
            this.lblAcao.Text = "Ação ";
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDivisor.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlDivisor.Location = new System.Drawing.Point(98, 5);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(2, 250);
            this.pnlDivisor.TabIndex = 1;
            // 
            // elipseErmSleeper
            // 
            this.elipseErmSleeper.ElipseRadius = 5;
            this.elipseErmSleeper.TargetControl = this;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlHead.Controls.Add(this.btnMinimizar);
            this.pnlHead.Controls.Add(this.btnFechar);
            this.pnlHead.Controls.Add(this.lblNomePrograma);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(478, 21);
            this.pnlHead.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(436, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(13, 13);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageActive = null;
            this.btnFechar.Location = new System.Drawing.Point(458, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(13, 13);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 19;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 10;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblNomePrograma
            // 
            this.lblNomePrograma.AutoSize = true;
            this.lblNomePrograma.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.lblNomePrograma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomePrograma.Location = new System.Drawing.Point(3, 4);
            this.lblNomePrograma.Name = "lblNomePrograma";
            this.lblNomePrograma.Size = new System.Drawing.Size(47, 13);
            this.lblNomePrograma.TabIndex = 8;
            this.lblNomePrograma.Text = "A mimir";
            // 
            // controlHead
            // 
            this.controlHead.Fixed = true;
            this.controlHead.Horizontal = true;
            this.controlHead.TargetControl = this.pnlHead;
            this.controlHead.Vertical = true;
            // 
            // tmrAcao
            // 
            this.tmrAcao.Interval = 1000;
            this.tmrAcao.Tick += new System.EventHandler(this.tmrAcao_Tick);
            // 
            // frmSleeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 272);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlPai);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSleeper";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A mimir zZzZ";
            this.Load += new System.EventHandler(this.frmSleeper_Load);
            this.pnlPai.ResumeLayout(false);
            this.pnlPai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNightMode)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards pnlPai;
        private Bunifu.Framework.UI.BunifuElipse elipseErmSleeper;
        private System.Windows.Forms.Panel pnlDivisor;
        private XanderUI.XUIRadio radioDesligar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAcao;
        private XanderUI.XUIRadio radioBloquear;
        private XanderUI.XUIRadio radioReiniciar;
        private System.Windows.Forms.Panel pnlLinhaAcao;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTemporizador;
        private System.Windows.Forms.Panel pnlDivisorTempo;
        private System.Windows.Forms.Panel pnlLinhaDefinirTempo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTempo;
        private System.Windows.Forms.Panel pnlLinhaTempo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimer;
        private XanderUI.XUIButton btnIniciar;
        private XanderUI.XUIButton btnParar;
        private XanderUI.XUIRadio radioHibernar;
        private System.Windows.Forms.Panel pnlHead;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNomePrograma;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuDragControl controlHead;
        private System.Windows.Forms.Timer tmrAcao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHoras;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSegundos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMinutos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHoras;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSegundos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMinutos;
        private Bunifu.Framework.UI.BunifuImageButton btnNightMode;
    }
}

