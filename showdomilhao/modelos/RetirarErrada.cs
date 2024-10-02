namespace showdomilhao;

public class RetirarErrada : Ajuda
{
    public override void RealizarAjuda (Questao questao)
    {
        switch (questao.RespostaCorreta)
        {
            case 1:
            BtResposta02.IsVisible = false;
            BtResposta03.IsVisible = false;
            BtResposta04.IsVisible = false;
            break;
            case 2:
            BtResposta03.IsVisible = false;
            BtResposta04.IsVisible=false;
            BtResposta05.IsVisible = false;
            break ;
            case 3:
            BtResposta04.IsVisible = false;
            BtResposta05.IsVisible=false;
            BtResposta01.IsVisible = false;
            break;
            case 4:
            BtResposta05.IsVisible = false;
            BtResposta01.IsVisible=false;
            BtResposta02.IsVisible=false;
            break ; 
            case 5 :
            BtResposta01.IsVisible = false;
            BtResposta02.IsVisible = false;
            BtResposta03.IsVisible=false;
            break;

        }
    }
}