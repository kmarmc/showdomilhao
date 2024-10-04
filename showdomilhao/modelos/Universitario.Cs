namespace showdomilhao;

public class Universitario : Ajuda
{
    public override void RealizarAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i++)


        {
            int numRand = 0;
            if porcentagem(numRand > 0)
    }
        {
            numRand = Random.Shared.Next(0, porcentagem);
            porcentagem -= numRand;
        }
        switch (i)
        {
            case 0:
                BtResposta01.Text += "=" + numRand.ToString() + "%";
                break;
            case 1:
                BtResposta02.Text += "=" + numRand.ToString() + "%";
                break;
            case 2:
                BtResposta03.Text += "=" + numRand.ToString() + "%";
                break;
            case 3:
                BtResposta04.Text += "=" + numRand.ToString() + "%";
                break;
            case 4:
                BtResposta05.Text += "=" + numRand.ToString() + "%";
                break;
        }
    }
}

