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
        this.LabelPontuacao = labelPontuacao;
        this.LabelNivel = labelNivel;
        CriaPergunta(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05); 
    }
    void CriaPergunta (Label LP, Button BtResposta01, Button BtResposta02, Button BtResposta03, Button BtResposta04, Button BtResposta05)
    {
        var Q1 = new Questao();
Q1.Nivel = 1;
Q1.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q1.Pergunta = "Qual a cor do céu?";
Q1.Resposta1 = "azul"; // A
Q1.Resposta2 = "amarelo"; // B
Q1.Resposta3 = "vermelho"; // C
Q1.Resposta4 = "rosa"; // D
Q1.Resposta5 = "lilas"; // E
Q1.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q1);

var Q2 = new Questao();
Q2.Nivel = 1;
Q2.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q2.Pergunta = "Quem descobriu a América?";
Q2.Resposta1 = "Cristóvão Colombo"; // A
Q2.Resposta2 = "Vasco da Gama"; // B
Q2.Resposta3 = "Pedro Álvares Cabral"; // C
Q2.Resposta4 = "Américo Vespúcio"; // D
Q2.Resposta5 = "Bartolomeu Dias"; // E
Q2.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q2);

var Q3 = new Questao();
Q3.Nivel = 1;
Q3.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q3.Pergunta = "Qual é a capital da França?";
Q3.Resposta1 = "Berlim"; // A
Q3.Resposta2 = "Londres"; // B
Q3.Resposta3 = "Paris"; // C
Q3.Resposta4 = "Madrid"; // D
Q3.Resposta5 = "Roma"; // E
Q3.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q3);

var Q4 = new Questao();
Q4.Nivel = 1;
Q4.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q4.Pergunta = "Qual é o maior planeta do sistema solar?";
Q4.Resposta1 = "Terra"; // A
Q4.Resposta2 = "Marte"; // B
Q4.Resposta3 = "Júpiter"; // C
Q4.Resposta4 = "Saturno"; // D
Q4.Resposta5 = "Netuno"; // E
Q4.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q4);

var Q5 = new Questao();
Q5.Nivel = 1;
Q5.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q5.Pergunta = "Qual é o animal mais rápido do mundo?";
Q5.Resposta1 = "Leão"; // A
Q5.Resposta2 = "Guepardo"; // B
Q5.Resposta3 = "Cavalo"; // C
Q5.Resposta4 = "Falcão"; // D
Q5.Resposta5 = "Tigre"; // E
Q5.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q5);

var Q6 = new Questao();
Q6.Nivel = 1;
Q6.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q6.Pergunta = "Em que continente fica o Egito?";
Q6.Resposta1 = "América"; // A
Q6.Resposta2 = "Europa"; // B
Q6.Resposta3 = "Ásia"; // C
Q6.Resposta4 = "África"; // D
Q6.Resposta5 = "Oceania"; // E
Q6.RespostaCorreta = 4; // D
ListaQuestoes.Add(Q6);

var Q7 = new Questao();
Q7.Nivel = 1;
Q7.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q7.Pergunta = "Qual é a moeda do Japão?";
Q7.Resposta1 = "Dólar"; // A
Q7.Resposta2 = "Euro"; // B
Q7.Resposta3 = "Yen"; // C
Q7.Resposta4 = "Real"; // D
Q7.Resposta5 = "Peso"; // E
Q7.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q7);

var Q8 = new Questao();
Q8.Nivel = 1;
Q8.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q8.Pergunta = "O que é H2O?";
Q8.Resposta1 = "Gás"; // A
Q8.Resposta2 = "Água"; // B
Q8.Resposta3 = "Óleo"; // C
Q8.Resposta4 = "Álcool"; // D
Q8.Resposta5 = "Mercúrio"; // E
Q8.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q8);

var Q9 = new Questao();
Q9.Nivel = 1;
Q9.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q9.Pergunta = "Qual é o maior mamífero do mundo?";
Q9.Resposta1 = "Elefante"; // A
Q9.Resposta2 = "Baleia Azul"; // B
Q9.Resposta3 = "Girafa"; // C
Q9.Resposta4 = "Urso"; // D
Q9.Resposta5 = "Tigre"; // E
Q9.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q9);

var Q10 = new Questao();
Q10.Nivel = 1;
Q10.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q10.Pergunta = "Qual o idioma oficial do Brasil?";
Q10.Resposta1 = "Espanhol"; // A
Q10.Resposta2 = "Inglês"; // B
Q10.Resposta3 = "Francês"; // C
Q10.Resposta4 = "Português"; // D
Q10.Resposta5 = "Italiano"; // E
Q10.RespostaCorreta = 4; // D
ListaQuestoes.Add(Q10);

var Q11 = new Questao();
Q11.Nivel = 2;
Q11.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q11.Pergunta = "Quem escreveu 'Dom Casmurro'?";
Q11.Resposta1 = "Machado de Assis"; // A
Q11.Resposta2 = "José de Alencar"; // B
Q11.Resposta3 = "Graciliano Ramos"; // C
Q11.Resposta4 = "Clarice Lispector"; // D
Q11.Resposta5 = "Érico Veríssimo"; // E
Q11.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q11);

var Q12 = new Questao();
Q12.Nivel = 2;
Q12.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q12.Pergunta = "Qual é a fórmula química do sal?";
Q12.Resposta1 = "NaCl"; // A
Q12.Resposta2 = "KCl"; // B
Q12.Resposta3 = "CaCl2"; // C
Q12.Resposta4 = "MgCl2"; // D
Q12.Resposta5 = "FeCl3"; // E
Q12.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q12);

var Q13 = new Questao();
Q13.Nivel = 2;
Q13.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q13.Pergunta = "Em que ano foi proclamada a independência do Brasil?";
Q13.Resposta1 = "1822"; // A
Q13.Resposta2 = "1889"; // B
Q13.Resposta3 = "1500"; // C
Q13.Resposta4 = "1930"; // D
Q13.Resposta5 = "1750"; // E
Q13.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q13);

var Q14 = new Questao();
Q14.Nivel = 2;
Q14.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q14.Pergunta = "Qual é a capital da Alemanha?";
Q14.Resposta1 = "Berlim"; // A
Q14.Resposta2 = "Munique"; // B
Q14.Resposta3 = "Frankfurt"; // C
Q14.Resposta4 = "Hamburgo"; // D
Q14.Resposta5 = "Colônia"; // E
Q14.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q14);

var Q15 = new Questao();
Q15.Nivel = 2;
Q15.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q15.Pergunta = "Qual é o símbolo químico do ouro?";
Q15.Resposta1 = "Au"; // A
Q15.Resposta2 = "Ag"; // B
Q15.Resposta3 = "Fe"; // C
Q15.Resposta4 = "Pb"; // D
Q15.Resposta5 = "Cu"; // E
Q15.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q15);

var Q16 = new Questao();
Q16.Nivel = 2;
Q16.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q16.Pergunta = "Qual é a capital da Espanha?";
Q16.Resposta1 = "Barcelona"; // A
Q16.Resposta2 = "Sevilha"; // B
Q16.Resposta3 = "Madrid"; // C
Q16.Resposta4 = "Valência"; // D
Q16.Resposta5 = "Bilbao"; // E
Q16.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q16);

var Q17 = new Questao();
Q17.Nivel = 2;
Q17.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q17.Pergunta = "Qual é a montanha mais alta do mundo?";
Q17.Resposta1 = "K2"; // A
Q17.Resposta2 = "Kilimanjaro"; // B
Q17.Resposta3 = "Everest"; // C
Q17.Resposta4 = "Makalu"; // D
Q17.Resposta5 = "Aconcágua"; // E
Q17.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q17);

var Q18 = new Questao();
Q18.Nivel = 2;
Q18.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q18.Pergunta = "Qual o principal gás do efeito estufa?";
Q18.Resposta1 = "Oxigênio"; // A
Q18.Resposta2 = "Dióxido de carbono"; // B
Q18.Resposta3 = "Nitrogênio"; // C
Q18.Resposta4 = "Metano"; // D
Q18.Resposta5 = "Hélio"; // E
Q18.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q18);

var Q19 = new Questao();
Q19.Nivel = 2;
Q19.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q19.Pergunta = "Qual é o maior oceano do mundo?";
Q19.Resposta1 = "Atlântico"; // A
Q19.Resposta2 = "Índico"; // B
Q19.Resposta3 = "Pacífico"; // C
Q19.Resposta4 = "Ártico"; // D
Q19.Resposta5 = "Antártico"; // E
Q19.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q19);

var Q20 = new Questao();
Q20.Nivel = 2;
Q20.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q20.Pergunta = "Qual é o sistema de escrita dos egípcios antigos?";
Q20.Resposta1 = "Cuneiforme"; // A
Q20.Resposta2 = "Hieróglifos"; // B
Q20.Resposta3 = "Alfabeto"; // C
Q20.Resposta4 = "Silabário"; // D
Q20.Resposta5 = "Rúnico"; // E
Q20.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q20);

var Q21 = new Questao();
Q21.Nivel = 3;
Q21.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q21.Pergunta = "Qual é a capital da Itália?";
Q21.Resposta1 = "Milão"; // A
Q21.Resposta2 = "Roma"; // B
Q21.Resposta3 = "Veneza"; // C
Q21.Resposta4 = "Nápoles"; // D
Q21.Resposta5 = "Florença"; // E
Q21.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q21);

var Q22 = new Questao();
Q22.Nivel = 3;
Q22.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q22.Pergunta = "Qual é a unidade de medida da temperatura?";
Q22.Resposta1 = "Litro"; // A
Q22.Resposta2 = "Metro"; // B
Q22.Resposta3 = "Celsius"; // C
Q22.Resposta4 = "Grama"; // D
Q22.Resposta5 = "Joule"; // E
Q22.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q22);

var Q23 = new Questao();
Q23.Nivel = 3;
Q23.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q23.Pergunta = "Qual é a capital do Brasil?";
Q23.Resposta1 = "São Paulo"; // A
Q23.Resposta2 = "Rio de Janeiro"; // B
Q23.Resposta3 = "Brasília"; // C
Q23.Resposta4 = "Salvador"; // D
Q23.Resposta5 = "Belo Horizonte"; // E
Q23.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q23);

var Q24 = new Questao();
Q24.Nivel = 3;
Q24.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q24.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
Q24.Resposta1 = "George Washington"; // A
Q24.Resposta2 = "Abraham Lincoln"; // B
Q24.Resposta3 = "Thomas Jefferson"; // C
Q24.Resposta4 = "Franklin D. Roosevelt"; // D
Q24.Resposta5 = "John Adams"; // E
Q24.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q24);

var Q25 = new Questao();
Q25.Nivel = 3;
Q25.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q25.Pergunta = "Quem é o autor de 'A Divina Comédia'?";
Q25.Resposta1 = "Homero"; // A
Q25.Resposta2 = "Dante Alighieri"; // B
Q25.Resposta3 = "Virgílio"; // C
Q25.Resposta4 = "Cervantes"; // D
Q25.Resposta5 = "Tolstói"; // E
Q25.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q25);

var Q26 = new Questao();
Q26.Nivel = 3;
Q26.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q26.Pergunta = "Qual é a língua oficial do Brasil?";
Q26.Resposta1 = "Espanhol"; // A
Q26.Resposta2 = "Inglês"; // B
Q26.Resposta3 = "Francês"; // C
Q26.Resposta4 = "Português"; // D
Q26.Resposta5 = "Italiano"; // E
Q26.RespostaCorreta = 4; // D
ListaQuestoes.Add(Q26);

var Q27 = new Questao();
Q27.Nivel = 3;
Q27.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q27.Pergunta = "Qual é a maior cidade do mundo?";
Q27.Resposta1 = "Tóquio"; // A
Q27.Resposta2 = "Nova Iorque"; // B
Q27.Resposta3 = "São Paulo"; // C
Q27.Resposta4 = "Cidade do México"; // D
Q27.Resposta5 = "Pequim"; // E
Q27.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q27);

var Q28 = new Questao();
Q28.Nivel = 3;
Q28.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q28.Pergunta = "Qual é o continente onde fica o deserto do Saara?";
Q28.Resposta1 = "África"; // A
Q28.Resposta2 = "Ásia"; // B
Q28.Resposta3 = "América do Sul"; // C
Q28.Resposta4 = "América do Norte"; // D
Q28.Resposta5 = "Oceania"; // E
Q28.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q28);

var Q29 = new Questao();
Q29.Nivel = 3;
Q29.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q29.Pergunta = "Qual é o nome da obra de arte famosa que retrata a Mona Lisa?";
Q29.Resposta1 = "O Grito"; // A
Q29.Resposta2 = "A Última Ceia"; // B
Q29.Resposta3 = "A Criação de Adão"; // C
Q29.Resposta4 = "A Escola de Atenas"; // D
Q29.Resposta5 = "Mona Lisa"; // E
Q29.RespostaCorreta = 5; // E
ListaQuestoes.Add(Q29);

var Q30 = new Questao();
Q30.Nivel = 3;
Q30.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q30.Pergunta = "Qual é o país mais populoso do mundo?";
Q30.Resposta1 = "Estados Unidos"; // A
Q30.Resposta2 = "Índia"; // B
Q30.Resposta3 = "China"; // C
Q30.Resposta4 = "Indonésia"; // D
Q30.Resposta5 = "Paquistão"; // E
Q30.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q30);

var Q31 = new Questao();
Q31.Nivel = 4;
Q31.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q31.Pergunta = "Qual é a teoria que descreve a evolução das espécies?";
Q31.Resposta1 = "Evolucionismo"; // A
Q31.Resposta2 = "Criacionismo"; // B
Q31.Resposta3 = "Inteligência Artificial"; // C
Q31.Resposta4 = "Panspermia"; // D
Q31.Resposta5 = "Mutacionismo"; // E
Q31.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q31);

var Q32 = new Questao();
Q32.Nivel = 4;
Q32.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q32.Pergunta = "Qual é o elemento químico que tem como símbolo 'C'?";
Q32.Resposta1 = "Cálcio"; // A
Q32.Resposta2 = "Carbono"; // B
Q32.Resposta3 = "Cobre"; // C
Q32.Resposta4 = "Cromo"; // D
Q32.Resposta5 = "Cloro"; // E
Q32.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q32);

var Q33 = new Questao();
Q33.Nivel = 4;
Q33.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q33.Pergunta = "Qual é a capital do Japão?";
Q33.Resposta1 = "Tóquio"; // A
Q33.Resposta2 = "Pequim"; // B
Q33.Resposta3 = "Seul"; // C
Q33.Resposta4 = "Bangcoc"; // D
Q33.Resposta5 = "Hanoi"; // E
Q33.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q33);

var Q34 = new Questao();
Q34.Nivel = 4;
Q34.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q34.Pergunta = "Qual é o continente mais populoso?";
Q34.Resposta1 = "África"; // A
Q34.Resposta2 = "Ásia"; // B
Q34.Resposta3 = "Europa"; // C
Q34.Resposta4 = "América do Norte"; // D
Q34.Resposta5 = "Oceania"; // E
Q34.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q34);

var Q35 = new Questao();
Q35.Nivel = 4;
Q35.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q35.Pergunta = "Quem pintou o teto da Capela Sistina?";
Q35.Resposta1 = "Leonardo da Vinci"; // A
Q35.Resposta2 = "Michelangelo"; // B
Q35.Resposta3 = "Rafael"; // C
Q35.Resposta4 = "Botticelli"; // D
Q35.Resposta5 = "Donatello"; // E
Q35.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q35);

var Q36 = new Questao();
Q36.Nivel = 5;
Q36.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q36.Pergunta = "Qual é a moeda oficial do Japão?";
Q36.Resposta1 = "Yuan"; // A
Q36.Resposta2 = "Won"; // B
Q36.Resposta3 = "Dólar"; // C
Q36.Resposta4 = "Iene"; // D
Q36.Resposta5 = "Euro"; // E
Q36.RespostaCorreta = 4; // D
ListaQuestoes.Add(Q36);

var Q37 = new Questao();
Q37.Nivel = 5;
Q37.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q37.Pergunta = "Qual é o maior continente do mundo?";
Q37.Resposta1 = "África"; // A
Q37.Resposta2 = "América do Sul"; // B
Q37.Resposta3 = "Ásia"; // C
Q37.Resposta4 = "América do Norte"; // D
Q37.Resposta5 = "Europa"; // E
Q37.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q37);

var Q38 = new Questao();
Q38.Nivel = 5;
Q38.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q38.Pergunta = "Qual é a capital da Rússia?";
Q38.Resposta1 = "Moscovo"; // A
Q38.Resposta2 = "São Petersburgo"; // B
Q38.Resposta3 = "Kazan"; // C
Q38.Resposta4 = "Novosibirsk"; // D
Q38.Resposta5 = "Vladivostok"; // E
Q38.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q38);

var Q39 = new Questao();
Q39.Nivel = 5;
Q39.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q39.Pergunta = "Qual é o animal nacional da Austrália?";
Q39.Resposta1 = "Canguru"; // A
Q39.Resposta2 = "Emu"; // B
Q39.Resposta3 = "Koala"; // C
Q39.Resposta4 = "Dingo"; // D
Q39.Resposta5 = "Crocodilo"; // E
Q39.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q39);

var Q40 = new Questao();
Q40.Nivel = 5;
Q40.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q40.Pergunta = "Qual é a maior floresta do mundo?";
Q40.Resposta1 = "Floresta Amazônica"; // A
Q40.Resposta2 = "Floresta de Taiga"; // B
Q40.Resposta3 = "Floresta Tropical"; // C
Q40.Resposta4 = "Floresta Boreal"; // D
Q40.Resposta5 = "Floresta de Redwood"; // E
Q40.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q40);
var Q41 = new Questao();
Q41.Nivel = 6;
Q41.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q41.Pergunta = "Qual é o nome do autor de 'Dom Quixote'?";
Q41.Resposta1 = "Miguel de Cervantes"; // A
Q41.Resposta2 = "Gabriel García Márquez"; // B
Q41.Resposta3 = "Jorge Luis Borges"; // C
Q41.Resposta4 = "Fernando Pessoa"; // D
Q41.Resposta5 = "Machado de Assis"; // E
Q41.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q41);

var Q42 = new Questao();
Q42.Nivel = 6;
Q42.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q42.Pergunta = "Qual é o país conhecido como a Terra dos Sorrisos?";
Q42.Resposta1 = "Tailândia"; // A
Q42.Resposta2 = "Índia"; // B
Q42.Resposta3 = "Japão"; // C
Q42.Resposta4 = "Filipinas"; // D
Q42.Resposta5 = "Malásia"; // E
Q42.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q42);

var Q43 = new Questao();
Q43.Nivel = 6;
Q43.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q43.Pergunta = "Qual é a fórmula química da água?";
Q43.Resposta1 = "CO2"; // A
Q43.Resposta2 = "H2O"; // B
Q43.Resposta3 = "O2"; // C
Q43.Resposta4 = "H2SO4"; // D
Q43.Resposta5 = "CH4"; // E
Q43.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q43);

var Q44 = new Questao();
Q44.Nivel = 6;
Q44.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q44.Pergunta = "Qual é o maior oceano do mundo?";
Q44.Resposta1 = "Atlântico"; // A
Q44.Resposta2 = "Índico"; // B
Q44.Resposta3 = "Pacífico"; // C
Q44.Resposta4 = "Ártico"; // D
Q44.Resposta5 = "Antártico"; // E
Q44.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q44);

var Q45 = new Questao();
Q45.Nivel = 6;
Q45.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q45.Pergunta = "Qual é a primeira letra do alfabeto grego?";
Q45.Resposta1 = "Alpha"; // A
Q45.Resposta2 = "Beta"; // B
Q45.Resposta3 = "Gamma"; // C
Q45.Resposta4 = "Delta"; // D
Q45.Resposta5 = "Épsilon"; // E
Q45.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q45);

var Q46 = new Questao();
Q46.Nivel = 7;
Q46.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q46.Pergunta = "Qual é a capital da Itália?";
Q46.Resposta1 = "Roma"; // A
Q46.Resposta2 = "Milão"; // B
Q46.Resposta3 = "Veneza"; // C
Q46.Resposta4 = "Florença"; // D
Q46.Resposta5 = "Nápoles"; // E
Q46.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q46);

var Q47 = new Questao();
Q47.Nivel = 7;
Q47.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q47.Pergunta = "Qual é a principal língua falada no Brasil?";
Q47.Resposta1 = "Espanhol"; // A
Q47.Resposta2 = "Inglês"; // B
Q47.Resposta3 = "Francês"; // C
Q47.Resposta4 = "Português"; // D
Q47.Resposta5 = "Italiano"; // E
Q47.RespostaCorreta = 4; // D
ListaQuestoes.Add(Q47);

var Q48 = new Questao();
Q48.Nivel = 7;
Q48.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q48.Pergunta = "Qual é o nome do famoso físico que desenvolveu a teoria da relatividade?";
Q48.Resposta1 = "Isaac Newton"; // A
Q48.Resposta2 = "Albert Einstein"; // B
Q48.Resposta3 = "Galileu Galilei"; // C
Q48.Resposta4 = "Stephen Hawking"; // D
Q48.Resposta5 = "Niels Bohr"; // E
Q48.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q48);

var Q49 = new Questao();
Q49.Nivel = 7;
Q49.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q49.Pergunta = "Qual é a capital da França?";
Q49.Resposta1 = "Berlim"; // A
Q49.Resposta2 = "Madri"; // B
Q49.Resposta3 = "Paris"; // C
Q49.Resposta4 = "Lisboa"; // D
Q49.Resposta5 = "Roma"; // E
Q49.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q49);

var Q50 = new Questao();
Q50.Nivel = 7;
Q50.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q50.Pergunta = "Qual é a capital da Austrália?";
Q50.Resposta1 = "Sydney"; // A
Q50.Resposta2 = "Canberra"; // B
Q50.Resposta3 = "Melbourne"; // C
Q50.Resposta4 = "Brisbane"; // D
Q50.Resposta5 = "Perth"; // E
Q50.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q50);

var Q51 = new Questao();
Q51.Nivel = 8;
Q51.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q51.Pergunta = "Qual é o nome do continente que tem mais países?";
Q51.Resposta1 = "África"; // A
Q51.Resposta2 = "América do Sul"; // B
Q51.Resposta3 = "Ásia"; // C
Q51.Resposta4 = "Europa"; // D
Q51.Resposta5 = "Oceania"; // E
Q51.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q51);

var Q52 = new Questao();
Q52.Nivel = 8;
Q52.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q52.Pergunta = "Quem escreveu 'A Divina Comédia'?";
Q52.Resposta1 = "Virgílio"; // A
Q52.Resposta2 = "Dante Alighieri"; // B
Q52.Resposta3 = "Homero"; // C
Q52.Resposta4 = "Shakespeare"; // D
Q52.Resposta5 = "Goethe"; // E
Q52.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q52);

var Q53 = new Questao();
Q53.Nivel = 8;
Q53.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q53.Pergunta = "Qual é a principal fonte de energia utilizada no mundo?";
Q53.Resposta1 = "Energia solar"; // A
Q53.Resposta2 = "Carvão"; // B
Q53.Resposta3 = "Petróleo"; // C
Q53.Resposta4 = "Gás natural"; // D
Q53.Resposta5 = "Energia hidrelétrica"; // E
Q53.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q53);

var Q54 = new Questao();
Q54.Nivel = 8;
Q54.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q54.Pergunta = "Qual é a capital da Espanha?";
Q54.Resposta1 = "Barcelona"; // A
Q54.Resposta2 = "Valência"; // B
Q54.Resposta3 = "Sevilha"; // C
Q54.Resposta4 = "Madri"; // D
Q54.Resposta5 = "Bilbao"; // E
Q54.RespostaCorreta = 4; // D
ListaQuestoes.Add(Q54);

var Q55 = new Questao();
Q55.Nivel = 8;
Q55.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q55.Pergunta = "Qual é o planeta mais próximo do Sol?";
Q55.Resposta1 = "Terra"; // A
Q55.Resposta2 = "Marte"; // B
Q55.Resposta3 = "Mercúrio"; // C
Q55.Resposta4 = "Vênus"; // D
Q55.Resposta5 = "Saturno"; // E
Q55.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q55);

var Q56 = new Questao();
Q56.Nivel = 9;
Q56.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q56.Pergunta = "Quem foi o primeiro homem a viajar ao espaço?";
Q56.Resposta1 = "Yuri Gagarin"; // A
Q56.Resposta2 = "Neil Armstrong"; // B
Q56.Resposta3 = "Buzz Aldrin"; // C
Q56.Resposta4 = "John Glenn"; // D
Q56.Resposta5 = "Valentina Tereshkova"; // E
Q56.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q56);

var Q57 = new Questao();
Q57.Nivel = 9;
Q57.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q57.Pergunta = "Qual é a capital da Grécia?";
Q57.Resposta1 = "Atenas"; // A
Q57.Resposta2 = "Tessalônica"; // B
Q57.Resposta3 = "Patras"; // C
Q57.Resposta4 = "Heraclion"; // D
Q57.Resposta5 = "Corinto"; // E
Q57.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q57);

var Q58 = new Questao();
Q58.Nivel = 9;
Q58.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q58.Pergunta = "Qual é a maior montanha do mundo?";
Q58.Resposta1 = "K2"; // A
Q58.Resposta2 = "Kangchenjunga"; // B
Q58.Resposta3 = "Everest"; // C
Q58.Resposta4 = "Lhotse"; // D
Q58.Resposta5 = "Makalu"; // E
Q58.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q58);

var Q59 = new Questao();
Q59.Nivel = 9;
Q59.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q59.Pergunta = "Qual é o nome da maior cadeia de montanhas do mundo?";
Q59.Resposta1 = "Andes"; // A
Q59.Resposta2 = "Himalaia"; // B
Q59.Resposta3 = "Alpes"; // C
Q59.Resposta4 = "Rocosos"; // D
Q59.Resposta5 = "Apalaches"; // E
Q59.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q59);

var Q60 = new Questao();
Q60.Nivel = 9;
Q60.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q60.Pergunta = "Qual é a cidade mais populosa do mundo?";
Q60.Resposta1 = "Nova York"; // A
Q60.Resposta2 = "Tóquio"; // B
Q60.Resposta3 = "Pequim"; // C
Q60.Resposta4 = "Mumbai"; // D
Q60.Resposta5 = "Seul"; // E
Q60.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q60);

var Q61 = new Questao();
Q61.Nivel = 10;
Q61.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q61.Pergunta = "Qual é a velocidade da luz?";
Q61.Resposta1 = "300.000 km/s"; // A
Q61.Resposta2 = "150.000 km/s"; // B
Q61.Resposta3 = "600.000 km/s"; // C
Q61.Resposta4 = "1.000.000 km/s"; // D
Q61.Resposta5 = "75.000 km/s"; // E
Q61.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q61);

var Q62 = new Questao();
Q62.Nivel = 10;
Q62.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q62.Pergunta = "Qual é o nome do maior animal do planeta?";
Q62.Resposta1 = "Elefante"; // A
Q62.Resposta2 = "Baleia Azul"; // B
Q62.Resposta3 = "Tubarão Branco"; // C
Q62.Resposta4 = "Girafa"; // D
Q62.Resposta5 = "Orca"; // E
Q62.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q62);

var Q63 = new Questao();
Q63.Nivel = 10;
Q63.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q63.Pergunta = "Qual é a teoria que explica a origem do universo?";
Q63.Resposta1 = "Teoria da Evolução"; // A
Q63.Resposta2 = "Teoria do Big Bang"; // B
Q63.Resposta3 = "Teoria da Relatividade"; // C
Q63.Resposta4 = "Teoria da Criação"; // D
Q63.Resposta5 = "Teoria da Gravidade"; // E
Q63.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q63);

var Q64 = new Questao();
Q64.Nivel = 10;
Q64.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q64.Pergunta = "Qual é o continente onde fica o deserto do Saara?";
Q64.Resposta1 = "África"; // A
Q64.Resposta2 = "Ásia"; // B
Q64.Resposta3 = "América do Sul"; // C
Q64.Resposta4 = "Oceania"; // D
Q64.Resposta5 = "Antártida"; // E
Q64.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q64);

var Q65 = new Questao();
Q65.Nivel = 10;
Q65.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q65.Pergunta = "Qual é o nome da camada mais externa da Terra?";
Q65.Resposta1 = "Núcleo"; // A
Q65.Resposta2 = "Manto"; // B
Q65.Resposta3 = "Crosta"; // C
Q65.Resposta4 = "Atmósfera"; // D
Q65.Resposta5 = "Hidrosfera"; // E
Q65.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q65);
var Q66 = new Questao();
Q66.Nivel = 10;
Q66.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q66.Pergunta = "Qual é o órgão responsável pela circulação do sangue?";
Q66.Resposta1 = "Coração"; // A
Q66.Resposta2 = "Pulmões"; // B
Q66.Resposta3 = "Fígado"; // C
Q66.Resposta4 = "Rins"; // D
Q66.Resposta5 = "Estômago"; // E
Q66.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q66);

var Q67 = new Questao();
Q67.Nivel = 10;
Q67.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q67.Pergunta = "Qual é a capital da China?";
Q67.Resposta1 = "Pequim"; // A
Q67.Resposta2 = "Xangai"; // B
Q67.Resposta3 = "Cantão"; // C
Q67.Resposta4 = "Hong Kong"; // D
Q67.Resposta5 = "Macao"; // E
Q67.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q67);

var Q68 = new Questao();
Q68.Nivel = 10;
Q68.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q68.Pergunta = "Qual é o nome do famoso satélite natural da Terra?";
Q68.Resposta1 = "Marte"; // A
Q68.Resposta2 = "Lua"; // B
Q68.Resposta3 = "Vênus"; // C
Q68.Resposta4 = "Júpiter"; // D
Q68.Resposta5 = "Saturno"; // E
Q68.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q68);

var Q69 = new Questao();
Q69.Nivel = 10;
Q69.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q69.Pergunta = "Qual é o nome do famoso quadro de Leonardo da Vinci?";
Q69.Resposta1 = "A Última Ceia"; // A
Q69.Resposta2 = "Mona Lisa"; // B
Q69.Resposta3 = "O Nascimento de Vênus"; // C
Q69.Resposta4 = "A Criação de Adão"; // D
Q69.Resposta5 = "O Grito"; // E
Q69.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q69);

var Q70 = new Questao();
Q70.Nivel = 10;
Q70.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q70.Pergunta = "Qual é a capital da Alemanha?";
Q70.Resposta1 = "Berlim"; // A
Q70.Resposta2 = "Munique"; // B
Q70.Resposta3 = "Hamburgo"; // C
Q70.Resposta4 = "Frankfurt"; // D
Q70.Resposta5 = "Colônia"; // E
Q70.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q70);

var Q71 = new Questao();
Q71.Nivel = 10;
Q71.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q71.Pergunta = "Qual é o nome do rio mais longo do mundo?";
Q71.Resposta1 = "Amazonas"; // A
Q71.Resposta2 = "Nilo"; // B
Q71.Resposta3 = "Yangtze"; // C
Q71.Resposta4 = "Mississippi"; // D
Q71.Resposta5 = "Danúbio"; // E
Q71.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q71);

var Q72 = new Questao();
Q72.Nivel = 10;
Q72.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q72.Pergunta = "Qual é a fórmula química da água?";
Q72.Resposta1 = "H2O"; // A
Q72.Resposta2 = "CO2"; // B
Q72.Resposta3 = "O2"; // C
Q72.Resposta4 = "H2O2"; // D
Q72.Resposta5 = "NaCl"; // E
Q72.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q72);

var Q73 = new Questao();
Q73.Nivel = 10;
Q73.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q73.Pergunta = "Qual é o elemento químico com símbolo 'Fe'?";
Q73.Resposta1 = "Ferro"; // A
Q73.Resposta2 = "Flúor"; // B
Q73.Resposta3 = "Fósforo"; // C
Q73.Resposta4 = "Mercúrio"; // D
Q73.Resposta5 = "Cobre"; // E
Q73.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q73);

var Q74 = new Questao();
Q74.Nivel = 10;
Q74.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q74.Pergunta = "Qual é a moeda oficial do Japão?";
Q74.Resposta1 = "Yen"; // A
Q74.Resposta2 = "Won"; // B
Q74.Resposta3 = "Dólar"; // C
Q74.Resposta4 = "Euro"; // D
Q74.Resposta5 = "Rupia"; // E
Q74.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q74);

var Q75 = new Questao();
Q75.Nivel = 10;
Q75.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q75.Pergunta = "Qual é o nome do fundador da Microsoft?";
Q75.Resposta1 = "Steve Jobs"; // A
Q75.Resposta2 = "Bill Gates"; // B
Q75.Resposta3 = "Mark Zuckerberg"; // C
Q75.Resposta4 = "Larry Page"; // D
Q75.Resposta5 = "Elon Musk"; // E
Q75.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q75);

var Q76 = new Questao();
Q76.Nivel = 10;
Q76.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q76.Pergunta = "Qual é a cor da caixa preta de um avião?";
Q76.Resposta1 = "Preta"; // A
Q76.Resposta2 = "Laranja"; // B
Q76.Resposta3 = "Amarela"; // C
Q76.Resposta4 = "Verde"; // D
Q76.Resposta5 = "Branca"; // E
Q76.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q76);

var Q77 = new Questao();
Q77.Nivel = 10;
Q77.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q77.Pergunta = "Quem pintou a Capela Sistina?";
Q77.Resposta1 = "Michelangelo"; // A
Q77.Resposta2 = "Da Vinci"; // B
Q77.Resposta3 = "Raphael"; // C
Q77.Resposta4 = "Botticelli"; // D
Q77.Resposta5 = "Caravaggio"; // E
Q77.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q77);

var Q78 = new Questao();
Q78.Nivel = 10;
Q78.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q78.Pergunta = "Qual é o oceano mais profundo do mundo?";
Q78.Resposta1 = "Atlântico"; // A
Q78.Resposta2 = "Índico"; // B
Q78.Resposta3 = "Pacífico"; // C
Q78.Resposta4 = "Ártico"; // D
Q78.Resposta5 = "Antártico"; // E
Q78.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q78);

var Q79 = new Questao();
Q79.Nivel = 10;
Q79.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q79.Pergunta = "Qual é a principal fonte de proteína na dieta humana?";
Q79.Resposta1 = "Carne"; // A
Q79.Resposta2 = "Ovos"; // B
Q79.Resposta3 = "Peixe"; // C
Q79.Resposta4 = "Leite"; // D
Q79.Resposta5 = "Leguminosas"; // E
Q79.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q79);

// Nível 6
var Q81 = new Questao();
Q81.Nivel = 6;
Q81.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q81.Pergunta = "Qual é o continente mais populoso?";
Q81.Resposta1 = "África"; // A
Q81.Resposta2 = "Ásia"; // B
Q81.Resposta3 = "América do Sul"; // C
Q81.Resposta4 = "Europa"; // D
Q81.Resposta5 = "Oceania"; // E
Q81.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q81);

// Nível 7
var Q82 = new Questao();
Q82.Nivel = 7;
Q82.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q82.Pergunta = "Qual é o maior país do mundo em área?";
Q82.Resposta1 = "Canadá"; // A
Q82.Resposta2 = "Rússia"; // B
Q82.Resposta3 = "China"; // C
Q82.Resposta4 = "Estados Unidos"; // D
Q82.Resposta5 = "Brasil"; // E
Q82.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q82);

// Nível 8
var Q83 = new Questao();
Q83.Nivel = 8;
Q83.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q83.Pergunta = "Quem foi o primeiro presidente do Brasil?";
Q83.Resposta1 = "Getúlio Vargas"; // A
Q83.Resposta2 = "Deodoro da Fonseca"; // B
Q83.Resposta3 = "Juscelino Kubitschek"; // C
Q83.Resposta4 = "Fernando Henrique Cardoso"; // D
Q83.Resposta5 = "Luiz Inácio Lula da Silva"; // E
Q83.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q83);

// Nível 9
var Q84 = new Questao();
Q84.Nivel = 9;
Q84.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q84.Pergunta = "Qual é a capital do Egito?";
Q84.Resposta1 = "Cairo"; // A
Q84.Resposta2 = "Alexandria"; // B
Q84.Resposta3 = "Lúxor"; // C
Q84.Resposta4 = "Giza"; // D
Q84.Resposta5 = "Aswan"; // E
Q84.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q84);

// Nível 10
var Q85 = new Questao();
Q85.Nivel = 10;
Q85.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q85.Pergunta = "Qual é o gás que compõe a maior parte da atmosfera terrestre?";
Q85.Resposta1 = "Oxigênio"; // A
Q85.Resposta2 = "Nitrogênio"; // B
Q85.Resposta3 = "Dióxido de carbono"; // C
Q85.Resposta4 = "Hélio"; // D
Q85.Resposta5 = "Argônio"; // E
Q85.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q85);

// Nível 6
var Q86 = new Questao();
Q86.Nivel = 6;
Q86.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q86.Pergunta = "Qual é a capital da Austrália?";
Q86.Resposta1 = "Sydney"; // A
Q86.Resposta2 = "Canberra"; // B
Q86.Resposta3 = "Melbourne"; // C
Q86.Resposta4 = "Brisbane"; // D
Q86.Resposta5 = "Perth"; // E
Q86.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q86);

// Nível 7
var Q87 = new Questao();
Q87.Nivel = 7;
Q87.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q87.Pergunta = "Qual é o maior deserto do mundo?";
Q87.Resposta1 = "Deserto do Saara"; // A
Q87.Resposta2 = "Deserto da Antártida"; // B
Q87.Resposta3 = "Deserto de Gobi"; // C
Q87.Resposta4 = "Deserto de Kalahari"; // D
Q87.Resposta5 = "Deserto de Atacama"; // E
Q87.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q87);

// Nível 8
var Q88 = new Questao();
Q88.Nivel = 8;
Q88.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q88.Pergunta = "Qual é o nome do primeiro satélite artificial lançado ao espaço?";
Q88.Resposta1 = "Vostok 1"; // A
Q88.Resposta2 = "Apollo 11"; // B
Q88.Resposta3 = "Sputnik 1"; // C
Q88.Resposta4 = "Explorer 1"; // D
Q88.Resposta5 = "Hubble"; // E
Q88.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q88);

// Nível 9
var Q89 = new Questao();
Q89.Nivel = 9;
Q89.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q89.Pergunta = "Qual é o nome da teoria que explica a evolução das espécies?";
Q89.Resposta1 = "Teoria da Relatividade"; // A
Q89.Resposta2 = "Teoria do Big Bang"; // B
Q89.Resposta3 = "Teoria da Evolução"; // C
Q89.Resposta4 = "Teoria da Gravidade"; // D
Q89.Resposta5 = "Teoria da Geração Espontânea"; // E
Q89.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q89);

// Nível 10
var Q90 = new Questao();
Q90.Nivel = 10;
Q90.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q90.Pergunta = "Qual é a moeda oficial da União Europeia?";
Q90.Resposta1 = "Euro"; // A
Q90.Resposta2 = "Franco"; // B
Q90.Resposta3 = "Libra"; // C
Q90.Resposta4 = "Dólar"; // D
Q90.Resposta5 = "Yen"; // E
Q90.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q90);

// Nível 8
var Q91 = new Questao();
Q91.Nivel = 8;
Q91.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q91.Pergunta = "Qual foi o primeiro país a conceder o direito de voto às mulheres?";
Q91.Resposta1 = "Nova Zelândia"; // A
Q91.Resposta2 = "Austrália"; // B
Q91.Resposta3 = "Suécia"; // C
Q91.Resposta4 = "Finlândia"; // D
Q91.Resposta5 = "Reino Unido"; // E
Q91.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q91);

// Nível 7
var Q92 = new Questao();
Q92.Nivel = 7;
Q92.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q92.Pergunta = "Qual é o maior mamífero terrestre?";
Q92.Resposta1 = "Elefante"; // A
Q92.Resposta2 = "Hipopótamo"; // B
Q92.Resposta3 = "Girafa"; // C
Q92.Resposta4 = "Rinoceronte"; // D
Q92.Resposta5 = "Baleia Azul"; // E
Q92.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q92);

// Nível 6
var Q93 = new Questao();
Q93.Nivel = 6;
Q93.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q93.Pergunta = "Qual é a principal língua falada no Brasil?";
Q93.Resposta1 = "Espanhol"; // A
Q93.Resposta2 = "Inglês"; // B
Q93.Resposta3 = "Português"; // C
Q93.Resposta4 = "Francês"; // D
Q93.Resposta5 = "Italiano"; // E
Q93.RespostaCorreta = 3; // C
ListaQuestoes.Add(Q93);

// Nível 5
var Q94 = new Questao();
Q94.Nivel = 5;
Q94.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q94.Pergunta = "Qual é o elemento químico com símbolo 'O'?";
Q94.Resposta1 = "Oxigênio"; // A
Q94.Resposta2 = "Ouro"; // B
Q94.Resposta3 = "Argônio"; // C
Q94.Resposta4 = "Carbono"; // D
Q94.Resposta5 = "Nitrogênio"; // E
Q94.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q94);

// Nível 4
var Q95 = new Questao();
Q95.Nivel = 4;
Q95.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q95.Pergunta = "Qual é a capital da França?";
Q95.Resposta1 = "Paris"; // A
Q95.Resposta2 = "Londres"; // B
Q95.Resposta3 = "Berlim"; // C
Q95.Resposta4 = "Madrid"; // D
Q95.Resposta5 = "Roma"; // E
Q95.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q95);

// Nível 3
var Q96 = new Questao();
Q96.Nivel = 3;
Q96.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q96.Pergunta = "Qual é a capital do Brasil?";
Q96.Resposta1 = "São Paulo"; // A
Q96.Resposta2 = "Brasília"; // B
Q96.Resposta3 = "Rio de Janeiro"; // C
Q96.Resposta4 = "Salvador"; // D
Q96.Resposta5 = "Fortaleza"; // E
Q96.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q96);

// Nível 2
var Q97 = new Questao();
Q97.Nivel = 2;
Q97.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q97.Pergunta = "Quantos dias há em um ano normal?";
Q97.Resposta1 = "365"; // A
Q97.Resposta2 = "366"; // B
Q97.Resposta3 = "364"; // C
Q97.Resposta4 = "365,25"; // D
Q97.Resposta5 = "360"; // E
Q97.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q97);

// Nível 1
var Q98 = new Questao();
Q98.Nivel = 1;
Q98.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q98.Pergunta = "Qual é a cor do céu em um dia claro?";
Q98.Resposta1 = "Azul"; // A
Q98.Resposta2 = "Verde"; // B
Q98.Resposta3 = "Amarelo"; // C
Q98.Resposta4 = "Vermelho"; // D
Q98.Resposta5 = "Preto"; // E
Q98.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q98);

// Nível 2
var Q99 = new Questao();
Q99.Nivel = 2;
Q99.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q99.Pergunta = "Quantas patas tem uma aranha?";
Q99.Resposta1 = "6"; // A
Q99.Resposta2 = "8"; // B
Q99.Resposta3 = "10"; // C
Q99.Resposta4 = "12"; // D
Q99.Resposta5 = "4"; // E
Q99.RespostaCorreta = 2; // B
ListaQuestoes.Add(Q99);

// Nível 3
var Q100 = new Questao();
Q100.Nivel = 3;
Q100.ConfigurarDesenho(LP, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
Q100.Pergunta = "Qual é a capital da Itália?";
Q100.Resposta1 = "Roma"; // A
Q100.Resposta2 = "Milão"; // B
Q100.Resposta3 = "Florença"; // C
Q100.Resposta4 = "Nápoles"; // D
Q100.Resposta5 = "Turim"; // E
Q100.RespostaCorreta = 1; // A
ListaQuestoes.Add(Q100);

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