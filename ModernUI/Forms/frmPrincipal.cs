using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelCadastros.Visible = false;
            panelConsultas.Visible = false;
            panelConfiguracoes.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelCadastros.Visible == true)
            {
                panelCadastros.Visible = false;
            }

            if (panelConsultas.Visible == true)
            {
                panelConsultas.Visible = false;
            }

            if (panelConfiguracoes.Visible == true)
            {
                panelConfiguracoes.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCadastros);
        }

        #region Cadastos SubMenu

        private void btnPrimeiroSubMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Cadastros.Form1());
            //..
            // Outros códigos aqui  
            //..
            HideSubMenu();
        }

        private void btnSegundoSubMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Cadastros.Form2());
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void btnTerceiroSubMenu_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void btnQuartoSubMenu_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        #endregion

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelConsultas);
        }

        #region Consultas SubMenu

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        #endregion

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelConfiguracoes);
        }

        #region Configurações SubMenu

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }

        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            //..
            // Outros códigos aqui
            //..
            HideSubMenu();
        }
    }
}
