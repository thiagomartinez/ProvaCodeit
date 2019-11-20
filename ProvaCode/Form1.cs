using ProvaCode.Business;
using ProvaCode.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaCode
{
    public partial class Form1 : Form
    {
        Business.Embarque baviao = new Business.Embarque();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            LvSmart.Clear();
            LvEmbarque.Clear();
            LvAviao.Clear();
            Habilita(true);
            HabilitaBotoes(1);

            baviao.preencherEmbarque(ref LvEmbarque);
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            if (LvSmart.Items.Count == 2)
            {
                MessageBox.Show("o Smart Fortwo só leva duas pessoas por vez!");
                return;
            }
            foreach (ListViewItem item in LvEmbarque.SelectedItems)
            {
                LvEmbarque.Items.Remove(item);
                LvSmart.Items.Add(item);
            }
            if (LvSmart.Items.Count == 2)
            {
                HabilitaBotoes(2);
                if (!baviao.ValidarMotoristaSmart(LvSmart))
                    MessageBox.Show("Não há motorista autorizado a dirigir o Smart Fortwo!");
                var smart = baviao.ValidarIntegrantesSmart(LvSmart);
                if (!String.IsNullOrEmpty(smart))
                {
                    MessageBox.Show(smart);
                    Habilita(false);
                }
            }
        }

        private void BtnDel1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvSmart.SelectedItems)
            {
                LvSmart.Items.Remove(item);
                LvEmbarque.Items.Add(item);
            }
            baviao.ValidarLista(ref LvAviao);
            baviao.ValidarLista(ref LvEmbarque);
        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvSmart.SelectedItems)
            {
                LvSmart.Items.Remove(item);
                LvAviao.Items.Add(item);
            }
            if (LvEmbarque.Items.Count == 0 && LvSmart.Items.Count == 0)
            {
                MessageBox.Show("Parabéns!!!");
                Habilita(false);
            }
        }

        private void BtnDel2_Click(object sender, EventArgs e)
        {
            if (LvSmart.Items.Count == 2)
            {
                MessageBox.Show("o Smart Fortwo só leva duas pessoas por vez!");
                return;
            }
            foreach (ListViewItem item in LvAviao.SelectedItems)
            {
                LvAviao.Items.Remove(item);
                LvSmart.Items.Add(item);
            }
            if (LvSmart.Items.Count == 2 || baviao.ValidarMotoristaSmart(LvSmart))
            {
                HabilitaBotoes(1);
                if (!baviao.ValidarMotoristaSmart(LvSmart))
                    MessageBox.Show("Não há motorista autorizado a dirigir o Smart Fortwo!");
                var smart = baviao.ValidarIntegrantesSmart(LvSmart);
                if (!String.IsNullOrEmpty(smart))
                {
                    MessageBox.Show(smart);
                    Habilita(false);
                }
            }
            if (!baviao.ValidarLista(ref LvAviao))
                Habilita(false);
            if (!baviao.ValidarLista(ref LvEmbarque))
                Habilita(false);
        }

        private void Habilita(Boolean valor)
        {
            LvEmbarque.Enabled = valor;
            LvEmbarque.Enabled = valor;
            LvEmbarque.Enabled = valor;
            BtnAdd1.Enabled = valor;
            BtnAdd2.Enabled = valor;
            BtnDel1.Enabled = valor;
            BtnDel2.Enabled = valor;
        }

        private void HabilitaBotoes(int valor)
        {
            BtnAdd1.Enabled = valor == 1;
            BtnDel1.Enabled = valor == 1;
            BtnAdd2.Enabled = valor == 2;            
            BtnDel2.Enabled = valor == 2;
        }
    }
}
