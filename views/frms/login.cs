using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto2023;
using projeto2023.models;
using projeto2023.controllers;

namespace projeto2023.views.frms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Colaboradores usuario = new Colaboradores(txb_user.Text, Security.Hash_login(txb_pass.Text));
                AddBanco loginDAO = new AddBanco();
                AddBanco loginDAO2 = new AddBanco();
                AddBanco loginDAO3 = new AddBanco();

                if (loginDAO.validarloginAtendente(usuario))
                {
                    this.Visible = false;
                    menu Menu = new menu();
                    Menu.ShowDialog();
                    this.Visible = true;
                    btn_limparcampos_Click(null, null);

                }

                else if (loginDAO2.validarloginSupervisor(usuario))
                {
                    this.Visible = false;
                    menu Menu = new menu();
                    Menu.ShowDialog();
                    this.Visible = true;
                    btn_limparcampos_Click(null, null);
                }

                else if (loginDAO3.validarloginOperador(usuario))
                {
                    this.Visible = false;
                    menu Menu = new menu();
                    Menu.ShowDialog();
                    this.Visible = true;
                    btn_limparcampos_Click(null, null);
                }

                else
                {
                    MessageBox.Show("NOME DE USUARIO ou SENHA invalidos", "ATENCAO!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_limparcampos_Click(null, null);
           
        }



        private void btn_limparcampos_Click(object sender, EventArgs e)
        {
            txb_user.Clear();
            txb_pass.Clear();
            txb_user.Focus();
        }
    }
}

