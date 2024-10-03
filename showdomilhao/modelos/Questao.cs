using System.Diagnostics;

namespace showdomilhao;

public class Questao : IEquatable<Questao>
{
public Questao()
{
  
}
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
  
    public bool Equals ( Questao q )
    {
      return this.Nivel == q.Nivel &&
        this.Pergunta == q.Pergunta;
    }

    public void Desenhar()
    {
      labelPergunta.Text = Pergunta;
      BtResposta01.Text = Resposta1;
      BtResposta02.Text = Resposta2;
      BtResposta03.Text = Resposta3;
      BtResposta04.Text = Resposta4;
      BtResposta05.Text = Resposta5;

      BtResposta01.BackgroundColor = Colors.White;
      BtResposta01.TextColor = Colors.Black;
      BtResposta02.BackgroundColor = Colors.White;
      BtResposta02.TextColor = Colors.Black;
      BtResposta03.BackgroundColor = Colors.White;
      BtResposta03.TextColor = Colors.Black;
      BtResposta04.BackgroundColor = Colors.White;
      BtResposta04.TextColor = Colors.Black;
      BtResposta05.BackgroundColor = Colors.White;
      BtResposta05.TextColor = Colors.Black;
      
      BtResposta01.IsVisible = true;
      BtResposta02.IsVisible = true;
      BtResposta03.IsVisible = true;
      BtResposta04.IsVisible = true;
      BtResposta05.IsVisible = true;

    }

    public Questao(Label LP, Button Botao01, Button Botao02, Button Botao03, Button Botao04, Button Botao05)
    {
      labelPergunta = LP;
      BtResposta01 = Botao01;
      BtResposta02 = Botao02;
      BtResposta03 = Botao03;
      BtResposta04 = Botao04;
      BtResposta05 = Botao05;
    }
    public void ConfigurarDesenho(Label LP, Button Botao01, Button Botao02, Button Botao03, Button Botao04, Button Botao05)
    {
      labelPergunta = LP;
      BtResposta01 = Botao01;
      BtResposta02 = Botao02;
      BtResposta03 = Botao03;
      BtResposta04 = Botao04;
      BtResposta05 = Botao05;
    }
    public bool VerificarResposta(int RespostaResolvida)
    {
      if (RespostaResolvida == RespostaCorreta)
      {
        var Botao = QualBotao(RespostaResolvida);
        Botao.BackgroundColor = Colors.Green;
        return true;
      }
      else
      {
        var Botao = QualBotao(RespostaResolvida);
        Botao.BackgroundColor = Colors.Red;

        return false;
      }
    }
    private Button QualBotao(int RespostaResolvida)
    {
      if (RespostaResolvida == 1)
        return BtResposta01;
      else if (RespostaResolvida == 2)
        return BtResposta02;
      else if (RespostaResolvida == 3)
        return BtResposta03;
      else if (RespostaResolvida == 4)
        return BtResposta04;
      else if (RespostaResolvida == 5)
        return BtResposta05;
      else
        return null;
    }
  }

