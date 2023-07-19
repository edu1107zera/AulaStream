using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula06fase2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String titulo = "Dragon Ball Z: A Batalha dos Deuses ";
            string descricao = "Depois da batalha de Majin Buu, o universo está em equilíbrio, mantido pelas ações simultâneas do Deus da Criação e do Deus da Destruição.Quando um poderoso Deus da galáxia é derrotado pelo estudante Goku, o jovem decide que seu próximo adversário deve ser o Deus da Destruição. Mas todos tem medo que o universo entre em colapso com essa batalha.";
            string caminho_imagem = "C:/Users/eduardo.lfuzato/source/repos/aula06fase2/aula06fase2/imagem/DragonFundo.jpg";
            string linkVideo = "https://www.youtube.com/embed/6nszBjDPZ7c?autoplay=true"; 
            Form2 telainfo = new Form2();
            telainfo.titulo = titulo;
            telainfo.descricao = descricao;
            telainfo.caminho_imagem = caminho_imagem;
            telainfo.linkVideo = linkVideo;
            telainfo.Show();

            
        }

        private void pbJuju_Click(object sender, EventArgs e)
        {
            String titulo = "Jujutsu Kaisen 0 ";
            string descricao = " Yuuta Okkotsu está assombrada. Desde que sua amiga de infância Rika morreu em um acidente de trânsito, seu fantasma ficou preso com ele. Mas seu espírito não aparece como a doce menina que Yuuta conheceu. Em vez disso, ela se manifesta como uma entidade monstruosa e poderosa que o protege ferozmente. Incapaz de controlar o comportamento violento de Rika, Yuuta é incapaz de impedir o derramamento de sangue que se segue à sua vingança brutal. Como resultado, quando apreendido por feiticeiros Jujutsu - os guardiões secretos do mundo, treinados para combater forças como Rika - Yuuta deseja ficar completamente isolado para que ninguém mais possa se machucar. No entanto, seu apreensor, o mestre feiticeiro Satoru Gojou, tem planos diferentes para ele: ele entrará na Escola de Ensino Médio Jujutsu e aprenderá a controlar Rika para ajudar as pessoas. Agora no primeiro ano da escola, Yuuta começa a aprender as artes do Jujutsu e a combater seres malignos. Ao lado de seus novos colegas de classe Maki Zenin, um especialista em armas de Jujutsu; Toge Inumaki, um feiticeiro que usa suas palavras como armas; e Panda, um urso panda aparentemente ambulante e falante, Yuuta começa a encontrar seu lugar no mundo e, pela primeira vez, a se sentir confortável com suas habilidades. No entanto, conforme seu treinamento progride, Yuuta aprende que os perigos do mundo do Jujutsu vão muito além dos espíritos malignos.";
            string caminho_imagem = "C:/Users/eduardo.lfuzato/source/repos/aula06fase2/aula06fase2/imagem/Jujutsu.jpg";
            string linkVideo = "https://www.youtube.com/embed/359noIH-wNo";
            Form2 telainfo = new Form2();
            telainfo.titulo = titulo;
            telainfo.descricao = descricao;
            telainfo.caminho_imagem = caminho_imagem;
            telainfo.linkVideo = linkVideo;
            telainfo.Show();

        }
    }
}
