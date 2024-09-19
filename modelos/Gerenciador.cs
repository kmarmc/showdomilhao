namespace showdomilhao
public class Gerenciador 
{
    List <Questao> ListaQuestoes = new List <Questao> ();
    List<int> ListaQuestoesResolvidas = new List <int> ();
    Questao QuestaoCorrente;
    public Gerenciador (Label LP, Button BtResposta01, Button BtResposta02, Button BtResposta03, Button BtResposta04, Button BtResposta05 )
    {
        CriaPergunta(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05); 
    }
    void CriaPergunta (Label LP, Button BtResposta01, Button BtResposta02, Button BtResposta03, Button BtResposta04, Button BtResposta05)
    {
        var Q1 = new Questao ();
        Q1 ConfigurarDesenho (LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
        Q1.Pergunta = "Qual a cor do céu?";
        Q1.Resposta1 = "";
    } 
}