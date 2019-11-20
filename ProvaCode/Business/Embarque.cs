using ProvaCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProvaCode.Business
{
    public class Embarque
    {
        public void preencherEmbarque(ref ListView lv)
        {
            lv.Items.Add(String.Concat("João", " - ", TipoPessoa.Piloto));
            lv.Items.Add(String.Concat("Cleiton", " - ", TipoPessoa.Oficial));
            lv.Items.Add(String.Concat("Carlos", " - ", TipoPessoa.Oficial));
            lv.Items.Add(String.Concat("José", " - ", TipoPessoa.ChefeServico));
            lv.Items.Add(String.Concat("Aline", " - ", TipoPessoa.Comissaria));
            lv.Items.Add(String.Concat("Clarice", " - ", TipoPessoa.Comissaria));
            lv.Items.Add(String.Concat("Martins", " - ", TipoPessoa.Policial));
            lv.Items.Add(String.Concat("Miguel", " - ", TipoPessoa.Presidiario));
        }

        public Boolean ValidarLista(ref ListView ListaAviao)
        {
            var ChefeServico = ListaAviao.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("ChefeServico")).Count() > 0;
            var Comissaria = ListaAviao.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Comissaria")).Count() > 0;
            var Piloto = ListaAviao.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Piloto")).Count() > 0;
            var Oficial = ListaAviao.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Oficial")).Count() > 0;
            var Policial = ListaAviao.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Policial")).Count() > 0;
            var Presidiario = ListaAviao.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Presidiario")).Count() > 0;

            if (Piloto && Comissaria && (!ChefeServico && !Oficial && !Policial && !Presidiario))
            {
                MessageBox.Show("O Piloto não pode ficar sozinho com as comissárias!");
                return false;
            }
            if (ChefeServico && Oficial && (!Piloto && !Comissaria && !Policial && !Presidiario))
            {
                MessageBox.Show("O Chefe de serviços não pode ficar sozinho com os oficiais!");
                return false;
            }
            if (Presidiario && !Policial)
            {
                MessageBox.Show("O Presidiário não pode ficar sem o policial no avião!");
                return false;
            }

            return true;
        }

        public Boolean ValidarMotoristaSmart(ListView lv)
        {
            var ChefeServico = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("ChefeServico")).Count() > 0;
            var Piloto = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Piloto")).Count() > 0;
            var Policial = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Policial")).Count() > 0;
            Boolean retorno = false;

            if (ChefeServico || Piloto || Policial)
            {
                retorno = true;
            }

            return retorno;
        }

        public String ValidarIntegrantesSmart(ListView lv)
        {
            var ChefeServico = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("ChefeServico")).Count() > 0;
            var Comissaria = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Comissaria")).Count() > 0;
            var Piloto = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Piloto")).Count() > 0;
            var Oficial = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Oficial")).Count() > 0;
            var Policial = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Policial")).Count() > 0;
            var Presidiario = lv.Items.OfType<ListViewItem>().Where(x => x.Text.Contains("Presidiario")).Count() > 0;

            // Valida Presidiario
            if ((Presidiario && !Policial) || (!Presidiario && Policial))
            {
                return "O Presidiário não pode ficar sem o policial";
            }

            // Valida Chefe de serviço
            if (ChefeServico && Oficial)
            {
                return "O Chefe de serviço de voo não pode ficar sozinho com nenhum oficial";
            }

            // Valida Chefe de serviço
            if (Piloto && Comissaria)
            {
                return "O Piloto de voo não pode ficar sozinho com nenhuma comissária";
            }

            return String.Empty;
        }
    }
}
