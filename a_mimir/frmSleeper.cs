using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace a_mimir
{
    public partial class frmSleeper : Form
    {
        TimeSpan tempoRestante;
        bool iniciaTimer = true;
        int horas, minutos, segundos;
        public frmSleeper()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void frmSleeper_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void checagem()
        {
            //---------------------------------------------------------------------

            _ = txtHoras.Text.Count() == 0 ? txtHoras.Text = "0" : "";
            _ = txtMinutos.Text.Count() == 0 ? txtMinutos.Text = "0" : "";
            _ = txtSegundos.Text.Count() == 0 ? txtSegundos.Text = "0" : "";

            //---------------------------------------------------------------------
        }
        void incremento()
        {
            //---------------------------------------------------------------------

            horas = Convert.ToInt32(txtHoras.Text);
            minutos = Convert.ToInt32(txtMinutos.Text);
            segundos = Convert.ToInt32(txtSegundos.Text);

            if (horas != 0)
            {
                horas += horas;
                txtHoras.Text = horas.ToString();

                if (horas >= 24)
                    horas -= 1;
                txtHoras.Text = 23.ToString();

            }

            if (minutos != 0)
            {
                minutos += minutos;
                txtMinutos.Text = minutos.ToString();

                if (minutos >= 59)
                    txtMinutos.Text = 59.ToString();
            }

            if (segundos != 0)
            {
                segundos += segundos;
                txtSegundos.Text = segundos.ToString();

                if (segundos >= 59)
                    txtSegundos.Text = 59.ToString();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            checagem();
            incremento();

            if (rbDesligar.Checked == false && rbReiniciar.Checked == false && rbLogoff.Checked == false && rbHinernar.Checked == false)
            {
                MessageBox.Show("Selecione uma ação para exercer!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                tempoRestante = new TimeSpan(Convert.ToInt32(txtHoras.Text), Convert.ToInt32(txtMinutos.Text), Convert.ToInt32(txtSegundos.Text));

                if (iniciaTimer == true)
                {
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
                Process.Start("CMD.exe", "/C" + "shutdown -t 0 -l");
            if (rbHinernar.Checked == true)
                Process.Start("CMD.exe", "/C" + "shutdown -t 0 -h");
        }

        private void btnNightMode_Click(object sender, EventArgs e)
        {

            if (lblNomePrograma.Text == "A mimir")
            {
                dark_theme();

                btnAlteraTema.Image = Properties.Resources.sun_60px;
                lblNomePrograma.Text = "A mimir | zZzZzZz";
            }


            else if (lblNomePrograma.Text == "A mimir | zZzZzZz")
            {
                light_theme();
                btnAlteraTema.Image = Properties.Resources.night;
                lblNomePrograma.Text = "A mimir";
            }
        }

        private void dark_theme()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            //--------------------------------------------------------------------------

            pnlPai.BackColor = Color.FromArgb(255, 20, 29, 38);
            pnlPai.color = Color.FromArgb(36, 52, 71);
            pnlLinhaAcao.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlLinhaDefinirTempo.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlLinhaTempo.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlDivisor.BackColor = Color.FromArgb(36, 85, 109, 143);
            pnlDivisorTempo.BackColor = Color.FromArgb(36, 85, 109, 143);

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

            btnIniciar.BackgroundColor = Color.FromArgb(255, 33, 49, 79);
            btnParar.BackgroundColor = Color.FromArgb(255, 110, 28, 28);
        }

        void light_theme()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
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

            btnIniciar.BackgroundColor = Color.CornflowerBlue;

            btnParar.BackgroundColor = Color.Brown;
        }
    }
}