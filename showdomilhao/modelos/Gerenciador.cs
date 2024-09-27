namespace showdomilhao;
public class Gerenciador 
{
    public int Pontuacao { get; private set; }
    int NivelAtual = 1;
    List <Questao> ListaQuestoes = new List <Questao> ();
    List<int> ListaQuestoesResolvidas = new List <int> ();
    Questao QuestaoCorrente;
    Label LabelPontuacao;
    Label LabelNivel;

    public Gerenciador (Label LP, Button BtResposta01, Button BtResposta02, Button BtResposta03, Button BtResposta04, Button BtResposta05, Label LabelPontuacao, Label labelNivel)
    {
        
        CriaPergunta(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05); 
    }
    void CriaPergunta (Label LP, Button BtResposta01, Button BtResposta02, Button BtResposta03, Button BtResposta04, Button BtResposta05)
    {
        var Q1 = new Questao ();
        Q1.Nivel=1;
        Q1.ConfigurarDesenho (LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
        Q1.Pergunta = "Qual a cor do céu?";
        Q1.Resposta1 = "azul";
        Q1.Resposta2 = "amarelo";
        Q1.Resposta3 = "vermelho";
        Q1.Resposta4 = "Rosa";
        Q1.Resposta5 = "Lilas";
        Q1.RespostaCorreta = 1;
        ListaQuestoes.Add(Q1);
        
        var Q2 = new Questao ();
        Q2.Nivel=1;
        Q2.ConfigurarDesenho (LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
        Q2.Pergunta = "Quem descobriu a América?";
        Q2.Resposta1 = "Vasco da Gama";
        Q2.Resposta2 = "Pedro Álvarez Cabral";
        Q2.Resposta3 = "Pedro Bortequilha";
        Q2.Resposta4 = "Cristovão Colombo";
        Q2.Resposta5 = "Américo Vespúcio";
        Q2.RespostaCorreta = 4;
        ListaQuestoes.Add(Q2);

        ProximaQuestao();
    }
    public async void VerificaResposta(int RespostaResolvida)
    {
        if (QuestaoCorrente.VerificarResposta(RespostaResolvida))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await Task.Delay(1000);

            await App.Current.MainPage.DisplayAlert("Acabou", "Resposta Incorreta", "Certa Resposta");
            Inicializar();
        }
        LabelPontuacao.Text="Pontuação:R$"+Pontuacao.ToString();
        LabelNivel.Text="Nível:"+NivelAtual.ToString();
    }
    void ProximaQuestao()
    {

        var numAleat=Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesResolvidas.Contains(numAleat))
            numAleat=Random.Shared.Next(0, ListaQuestoes.Count);

        ListaQuestoesResolvidas.Add(numAleat);
        QuestaoCorrente=ListaQuestoes[numAleat];
        QuestaoCorrente.Desenhar();
    }
    void Inicializar()
    {
        Pontuacao=0;
        NivelAtual=1;
        ProximaQuestao();
    }
    void AdicionaPontuacao(int n)
    {
        if(n==1)
            Pontuacao=1000;
        else if(n==2)
            Pontuacao=2000;
        else if(n==3)
            Pontuacao=5000;
        else if(n==4)
            Pontuacao=10000;
        else if(n==5)
            Pontuacao=20000;
        else if(n==6)
            Pontuacao=50000;
        else if(n==7)
            Pontuacao=100000;
        else if(n==8)
            Pontuacao=200000;
        else if(n==9)
            Pontuacao=500000;
        else 
            Pontuacao=1000000;
        
    }


    } 