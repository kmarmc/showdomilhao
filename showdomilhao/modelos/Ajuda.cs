using System.Runtime.CompilerServices;

namespace showdomilhao;
public abstract class Ajuda
{
    protected Button BtResposta01;
    protected Button BtResposta02;
    protected Button BtResposta03;
    protected Button BtResposta04;
    protected Button BtResposta05;
    protected Frame FrameAjuda;
    
    public void ConfigurarDesenho(Button BtResposta01, Button BtResposta02, Button BtResposta03, Button BtResposta04, Button BtResposta05)
    {
    this.BtResposta01 = BtResposta01;
    this.BtResposta02 = BtResposta02;
    this.BtResposta03 = BtResposta03;
    this.BtResposta04 = BtResposta04;
    this.BtResposta05 = BtResposta05;
    }
    public void ConfigurarDesenho(Frame FrameAjuda)
    {
        this.FrameAjuda = FrameAjuda;
    }
    public abstract void RealizarAjuda (Questao questao);
}