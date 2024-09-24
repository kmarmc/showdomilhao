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

}
