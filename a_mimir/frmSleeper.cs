using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace a_mimir
{
    public partial class frmSleeper : Form
    {
        TimeSpan tempoRestante;
        int horas, minutos, segundos;
        List<XanderUI.XUIRadio> lstRadio = new List<XanderUI.XUIRadio>();

        public frmSleeper()
        {
            InitializeComponent();

            tema_claro();

            lstRadio.Add(rbDesligar);
            lstRadio.Add(rbReiniciar);
            lstRadio.Add(rbLogoff);
            lstRadio.Add(rbHinernar);
        }

        public void alterar_tema()
        {
            if (lblNomePrograma.Text == "A mimir")
            {
                tema_escuro();

                btnAlteraTema.Image = Properties.Resources.sun_60px;
                lblNomePrograma.Text = "A mimir | zZzZzZz";
                icoNotificacao.Text = lblNomePrograma.Text;
            }
            else
            {
                tema_claro();

                btnAlteraTema.Image = Properties.Resources.night;
                lblNomePrograma.Text = "A mimir";
                icoNotificacao.Text = lblNomePrograma.Text;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void checagem()
        {
            _ = txtHoras.Text.Count() == 0 ? txtHoras.Text = "0" : "";
            _ = txtMinutos.Text.Count() == 0 ? txtMinutos.Text = "0" : "";
            _ = txtSegundos.Text.Count() == 0 ? txtSegundos.Text = "0" : "";

            horas = Convert.ToInt32(txtHoras.Text);
            minutos = Convert.ToInt32(txtMinutos.Text);
            segundos = Convert.ToInt32(txtSegundos.Text);

            _ = horas > 23 ? txtHoras.Text = "23" : "0";
            _ = minutos > 59 ? txtMinutos.Text = "59" : "0";
            _ = segundos > 59 ? txtSegundos.Text = "59" : "0";

        }



        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            foreach (XanderUI.XUIRadio rb in lstRadio)
            {
                if (rb.Checked)
                {
                    checagem();

                    tempoRestante = new TimeSpan(Convert.ToInt32(txtHoras.Text), Convert.ToInt32(txtMinutos.Text), Convert.ToInt32(txtSegundos.Text));
                    tmrAcao.Start();
                    lblTimer.Text = tempoRestante.ToString(@"hh\:mm\:ss");
                }
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            tmrAcao.Stop();
            lblTimer.Text = "00:00:00";
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 08;
            _ = txtHoras.Text == "Horas" ? txtHoras.Text = "" : "";
        }

        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 08;
            _ = txtMinutos.Text == "Minutos" ? txtMinutos.Text = "" : "";
        }

        private void txtSegundos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 08;
            _ = txtSegundos.Text == "Segundos" ? txtSegundos.Text = "" : "";
        }

        private void tmrAcao_Tick(object sender, EventArgs e)
        {
            tempoRestante = tempoRestante.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Text = tempoRestante.ToString(@"hh\:mm\:ss");

            if (tempoRestante.TotalSeconds <= 0)
            {
                tmrAcao.Stop();
                executar_acao();
            }
        }

        private void executar_acao()
        {
            if (rbDesligar.Checked == true)
                Process.Start("CMD.exe", @"/C " + "shutdown -t 0 -s");
            if (rbReiniciar.Checked == true)
                Process.Start("CMD.exe", @"/C" + "shutdown -t 0 -r");
            if (rbLogoff.Checked == true)
                Process.Start("shutdown", "/l");
            if (rbHinernar.Checked == true)
                Process.Start("shutdown", "/h");
        }

        private void btnNightMode_Click(object sender, EventArgs e)
        {
            alterar_tema();
        }

        private void cmFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmCanceleAcao_Click(object sender, EventArgs e)
        {
            tmrAcao.Stop();
            lblTimer.Text = "00:00:00";
        }

        private void cmExecutaAcao_Click(object sender, EventArgs e)
        {
            tmrAcao.Stop();
            lblTimer.Text = "00:00:00";
            executar_acao();
        }

        private void frmSleeper_Move(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                icoNotificacao.Visible = true;
                icoNotificacao.ShowBalloonTip(1000, "Note:", "O programa foi minimizado e está sendo executado em segundo plano", ToolTipIcon.Info);
            }
            else
            {
                icoNotificacao.Visible = false;
            }

            if (tempoRestante.Minutes == 5)
                icoNotificacao.ShowBalloonTip(100, "Aviso!", "Em 5 minutos a ação selecionada será executada!", ToolTipIcon.Warning);
        }

        private void icoNotificacao_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        public void tema_escuro()
        {
            MaterialSkinManager MSM = MaterialSkinManager.Instance;
            MSM.Theme = MaterialSkinManager.Themes.DARK;
            MSM.ColorScheme = new ColorScheme
            (
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            pnlPai.BackColor = Color.FromArgb(255, 20, 29, 38);
            pnlPai.color = Color.FromArgb(36, 52, 71);
            pnlLinhaAcao.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlLinhaDefinirTempo.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlLinhaTempo.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlDivisor.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlDivisorTempo.BackColor = Color.FromArgb(36, 85, 109, 143);
            btnIniciar.BackgroundColor = Color.FromArgb(255, 33, 49, 79);
            btnParar.BackgroundColor = Color.FromArgb(255, 110, 28, 28);

            lblAcao.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblTempo.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblTemporizador.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblHoras.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblMinutos.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblSegundos.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblTimer.ForeColor = Color.FromArgb(255, 245, 245, 245);
            lblNomePrograma.ForeColor = Color.FromArgb(255, 245, 245, 245);
            rbDesligar.ForeColor = Color.FromArgb(255, 245, 245, 245);
            rbReiniciar.ForeColor = Color.FromArgb(255, 245, 245, 245);
            rbLogoff.ForeColor = Color.FromArgb(255, 245, 245, 245);
            rbHinernar.ForeColor = Color.FromArgb(255, 245, 245, 245);

        }

        public void tema_claro()
        {
            MaterialSkinManager MSM = MaterialSkinManager.Instance;
            MSM.Theme = MaterialSkinManager.Themes.LIGHT;
            MSM.ColorScheme = new ColorScheme
            (
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            pnlPai.BackColor = Color.FromArgb(255, 255, 255, 255);
            pnlPai.color = Color.DodgerBlue;
            pnlLinhaAcao.BackColor = Color.FromArgb(255, 240, 240, 240);
            pnlLinhaDefinirTempo.BackColor = Color.FromArgb(255, 240, 240, 240);
            pnlLinhaTempo.BackColor = Color.FromArgb(255, 240, 240, 240);
            pnlDivisor.BackColor = Color.FromArgb(255, 240, 240, 240);
            pnlDivisorTempo.BackColor = Color.FromArgb(255, 240, 240, 240);
            btnIniciar.BackgroundColor = Color.CornflowerBlue;
            btnParar.BackgroundColor = Color.Brown;

            lblAcao.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblTempo.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblTemporizador.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblHoras.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblMinutos.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblSegundos.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblTimer.ForeColor = Color.FromArgb(255, 32, 32, 32);
            lblNomePrograma.ForeColor = Color.WhiteSmoke;
            rbDesligar.ForeColor = Color.FromArgb(255, 32, 32, 32);
            rbReiniciar.ForeColor = Color.FromArgb(255, 32, 32, 32);
            rbLogoff.ForeColor = Color.FromArgb(255, 32, 32, 32);
            rbHinernar.ForeColor = Color.FromArgb(255, 32, 32, 32);
        }
    }
}