namespace ShowdoMilhao;

public class Universitarios:IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i++)
        {
            int NumRandomico = 0;
            if(porcentagem > 0)
            {
                NumRandomico = Random.Shared.Next(0, porcentagem);
                porcentagem -= NumRandomico;
            }
            switch (i)
            {
                case 0:
                buttonResposta1.Text += "-" + NumRandomico.ToString() + "%";
                break;

                case 1:
                buttonResposta2.Text += "-" + NumRandomico.ToString() + "%";
                break;

                case 2:
                buttonResposta3.Text += "-" + NumRandomico.ToString() + "%";
                break;

                case 3:
                buttonResposta4.Text += "-" + NumRandomico.ToString() + "%";
                break;

                case 4:
                buttonResposta5.Text += "-" + NumRandomico.ToString() + "%";
                break;

            }
        }
    }
}