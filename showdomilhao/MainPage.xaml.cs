using Microsoft.Maui.Animations;

namespace showdomilhao;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador =new Gerenciador(Perguntas, BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05, LabelPontuacao, LabelNivel);
	}
	void ClicarResposta01(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(1);
	}

	void ClicarResposta02(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(2);
	}

	void ClicarResposta03(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(3);
	}

	void ClicarResposta04(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(4);
	}

	void ClicarResposta05(object sender, EventArgs args)
	{
		gerenciador.VerificaResposta(5);
	}

  void AjudaRetirar (object s, EventArgs e)
  {
	var ajuda = new RetirarErrada();
	ajuda.ConfigurarDesenho(BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
	ajuda.RealizarAjuda(gerenciador.GetQuestaoCorrente());
	(s as Button).IsVisible = false;
  }
  int pular =0;
	void AjudaPular(object S, EventArgs e)
	{
			
			if (pular == 2)
			{
			gerenciador.ProximaQuestao();
			(S as Button).IsVisible=false;
			}

			else
			{
				gerenciador.ProximaQuestao();
			}

			if (pular == 0)
			{ 
				Ajuda02.Text = "+ 2 pulos";
			}
			if (pular == 1)
			{ 
				Ajuda02.Text = " + 1 Pulo";
			}
			pular++;

	} 

 void AjudaUniversitarios (object s, EventArgs e)
  {
	var ajuda = new Universitario();
	ajuda.ConfigurarDesenho(BtResposta01, BtResposta02, BtResposta03, BtResposta04, BtResposta05);
	ajuda.RealizarAjuda(gerenciador.GetQuestaoCorrente());
	(s as Button).IsVisible = false;
  }



}
