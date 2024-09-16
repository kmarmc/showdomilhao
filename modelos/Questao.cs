namespace Questao
{
    public class Questao
    {
    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;
    public int RespostaCorreta;
    public int Nivel;
    private Label labelPergunta;
    private Button BtResposta01;
    private Button BtResposta02;
    private Button BtResposta03;
    private Button BtResposta04;
    private Button BtResposta05;
    public Questao ()
    {

    } 
    public void Desenhar ()
    {
        labelPergunta.Text=Pergunta;
    }
    public Questao( Label LP, Button Botao01, Button Botao02, Button Botao03, Button Botao04, Button Botao05 )
    {
    labelPergunta=LP;
    BtResposta01=Botao01;
    BtResposta02=Botao02;
    BtResposta03=Botao03;
    BtResposta04=Botao04;
    BtResposta05=Botao05;        
    }
    }
}