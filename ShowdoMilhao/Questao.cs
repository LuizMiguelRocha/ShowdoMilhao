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
    public int Pontuação;
    Label labelPergunta;
    Button buttonResposta1;
    Button buttonResposta2;
    Button buttonResposta3;
    Button buttonResposta4;
    Button buttonResposta5;

    public void ConfiguraDesenho(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        this.labelPergunta=labelPergunta;
        this.buttonResposta1 = buttonResposta1;
        this.buttonResposta2=buttonResposta2;
        this.buttonResposta3=buttonResposta3;
        this.buttonResposta4=buttonResposta4;
        this.buttonResposta5=buttonResposta5;
    }
  
    public void Desenhar()
    {
        labelPergunta.Text = Pergunta;
        buttonResposta1.Text = Resposta1;
        buttonResposta2.Text = Resposta2;
        buttonResposta3.Text = Resposta3;
        buttonResposta4.Text = Resposta4;
        buttonResposta5.Text = Resposta5;

        this.buttonResposta1!.BackgroundColor = Colors.Brown;
        this.buttonResposta2!.BackgroundColor = Colors.Brown;
        this.buttonResposta3!.BackgroundColor = Colors.Brown;
        this.buttonResposta4.BackgroundColor = Colors.Brown;
        this.buttonResposta5!.BackgroundColor = Colors.Brown;
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

   


}