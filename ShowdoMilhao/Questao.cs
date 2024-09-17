namespace ShowdoMilhao;

public class Questao
{
    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;
    public int nivelpergunta;
    public int RespostaCorreta;
    public int estruturadesenho;
    Label labelPergunta;
    Button buttonResposta1;
    Button buttonResposta2;
    Button buttonResposta3;
    Button buttonResposta4;
    Button buttonResposta5;

    public void Desenhar()
    {
        labelPergunta.Text = Pergunta;
        buttonResposta1.Text = Resposta1;
        buttonResposta2.Text = Resposta2;
        buttonResposta3.Text = Resposta3;
        buttonResposta4.Text = Resposta4;
        buttonResposta5.Text = Resposta5;
    }

    public bool VerificarResposta(int rr)
    {
        if (RespostaCorreta == rr)
        {
            var BTN = QualBTN(rr);
            BTN.BackgroundColor = Colors.Green;
            return true;
        }
        else
        {
            var BTNCorreto = QualBTN(RespostaCorreta);
            var BTNIncorreto = QualBTN(rr);
            BTNCorreto.BackgroundColor = Colors.Yellow;
            BTNIncorreto.BackgroundColor = Colors.Red; 
            return false;
        }
    }

    private Button QualBTN(int rr)
    {
        if (rr == 1)
            return buttonResposta1;
        else if (rr == 2)
            return buttonResposta2;
        else if (rr == 3)
            return buttonResposta3;
        else if (rr == 4)
            return buttonResposta4;
        else if (rr == 5)
            return buttonResposta5;
        else 
            return null;    
    }

    public Questao(Label pergunta, Button reposta1, Button reposta2, Button reposta3, Button reposta4, Button reposta5)
    {
        labelPergunta = pergunta;
        buttonResposta1 = reposta1;
        buttonResposta2 = reposta2;
        buttonResposta3 = reposta3;
        buttonResposta4 = reposta4;
        buttonResposta5 = reposta5; 
    }


}