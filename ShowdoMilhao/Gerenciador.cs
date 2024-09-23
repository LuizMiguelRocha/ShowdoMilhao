namespace ShowdoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;

    public int Pontuação{ get; private set; }
    int NivelAtual = 0;

    void Inicializar()
    {
        Pontuação = 0;
        NivelAtual = 0;
        ProximaQuestao();
    }

    public Gerenciador(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        var Q1 = new Questao();
        Q1.Pergunta = "Em que anos se passa FNAF 2 ?";
        Q1.Resposta1 = "1986";
        Q1.Resposta2 = "1988";
        Q1.Resposta3 = "2000";
        Q1.Resposta4 = "1987";
        Q1.Resposta5 = "1989";
        Q1.RespostaCorreta = 4;
        Q1.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.Pergunta = "Quantos filhos(as) Willian Afton tinha?";
        Q2.Resposta1 = "1";
        Q2.Resposta2 = "5";
        Q2.Resposta3 = "4";
        Q2.Resposta4 = "10";
        Q2.Resposta5 = "3";
        Q2.RespostaCorreta = 5;
        Q2.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.Pergunta = "Qual a cor do Bonnie de FNAF 1?";
        Q3.Resposta1 = "Azul";
        Q3.Resposta2 = "Roxo";
        Q3.Resposta3 = "Amarelo";
        Q3.Resposta4 = "Marrom";
        Q3.Resposta5 = "Rosa";
        Q3.RespostaCorreta = 2;
        Q3.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.Pergunta = "Quandas cameras tem no Fnaf 1?";
        Q4.Resposta1 = "5";
        Q4.Resposta2 = "12";
        Q4.Resposta3 = "11";
        Q4.Resposta4 = "15";
        Q4.Resposta5 = "10";
        Q4.RespostaCorreta = 3;
        Q4.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.Pergunta = "Qual o nome da que o Mike usa no Fnaf 1?";
        Q5.Resposta1 = "Mike Cafida";
        Q5.Resposta2 = "Michael Jackson";
        Q5.Resposta3 = "Mike Schndit";
        Q5.Resposta4 = "Mike Schmdit";
        Q5.Resposta5 = "Mike Afton";
        Q5.RespostaCorreta = 4;
        Q5.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.Pergunta = "Qual a cor da roupa de William Afton";
        Q6.Resposta1 = "Rosa";
        Q6.Resposta2 = "Azul";
        Q6.Resposta3 = "Roxo";
        Q6.Resposta4 = "Vermelho";
        Q6.Resposta5 = "Spring Bonnie";
        Q6.RespostaCorreta = 3;
        Q6.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.Pergunta = "Qual o nome da criança dentro da Baby";
        Q7.Resposta1 = "Eleanor";
        Q7.Resposta2 = "Cassy";
        Q7.Resposta3 = "Eduardo";
        Q7.Resposta4 = "Elizabeth";
        Q7.Resposta5 = "Susie";
        Q7.RespostaCorreta = 4;
        Q7.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.Pergunta = "Quandos Animatrônicos tem na UCN";
        Q8.Resposta1 = "45";
        Q8.Resposta2 = "50";
        Q8.Resposta3 = "55";
        Q8.Resposta4 = "40";
        Q8.Resposta5 = "60";
        Q8.RespostaCorreta = 2;
        Q8.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.Pergunta = "Qual é o nome do criador da série Five Nights at Freddy's?";
        Q9.Resposta1 = "Scott Cawthon";
        Q9.Resposta2 = "Markiplier";
        Q9.Resposta3 = "Game Theory";
        Q9.Resposta4 = "Notch";
        Q9.Resposta5 = "YandereDev";
        Q9.RespostaCorreta = 1;
        Q9.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.Pergunta = "Qual o nome da guarda de segurança do FNAF Security Breach";
        Q10.Resposta1 = "Willian Afton";
        Q10.Resposta2 = "Mike";
        Q10.Resposta3 = "Phone Guy";
        Q10.Resposta4 = "Vanessa";
        Q10.Resposta5 = "Gregory";
        Q10.RespostaCorreta = 4;
        Q10.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q10);

        var Q11 = new Questao();
        Q11.Pergunta = "Qual Animatrônico não tem uma versão phanton?";
        Q11.Resposta1 = "Chica";
        Q11.Resposta2 = "Ballon Boy";
        Q11.Resposta3 = "Bonnie";
        Q11.Resposta4 = "Foxy";
        Q11.Resposta5 = "Freddy";
        Q11.RespostaCorreta = 3;
        Q11.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.Pergunta = "Qual o Animatrônic de Fnaf 2 que quando de mata fecha o jogo?";
        Q12.Resposta1 = "Golden Freddy";
        Q12.Resposta2 = "Shadow Freddy";
        Q12.Resposta3 = "RWQFSFASXC";
        Q12.Resposta4 = "Puppet";
        Q12.Resposta5 = "Ballon Boy";
        Q12.RespostaCorreta = 3;
        Q12.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.Pergunta = "Qual o nome do pesonagem que rouba as suas pilhas ?";
        Q13.Resposta1 = "JJ";
        Q13.Resposta2 = "Ballon Boy";
        Q13.Resposta3 = "Toy Bonnie";
        Q13.Resposta4 = "Toy Chica";
        Q13.Resposta5 = "Mangle";
        Q13.RespostaCorreta = 2;
        Q13.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.Pergunta = "O que a Mangle é?";
        Q14.Resposta1 = "Um Robô";
        Q14.Resposta2 = "Um animatrônic";
        Q14.Resposta3 = "Um cachorro";
        Q14.Resposta4 = "Um ninguem";
        Q14.Resposta5 = "Um sim";
        Q14.RespostaCorreta = 5;
        Q14.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.Pergunta = "Qual a noite de Fnaf 1 tam a maior chance de apareçer o Golgen Freddy?";
        Q15.Resposta1 = "Apartir da Noite 4";
        Q15.Resposta2 = "Apartir da Noite 2";
        Q15.Resposta3 = "Apartir da Noite 3";
        Q15.Resposta4 = "Apartir da Noite 5";
        Q15.Resposta5 = "Apartir da Noite 1";
        Q15.RespostaCorreta = 1;
        Q15.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.Pergunta = "Qual animatronic deu a mordida de 83 ?";
        Q16.Resposta1 = "Mangle";
        Q16.Resposta2 = "FreddyBear";
        Q16.Resposta3 = "Spring Bonnie";
        Q16.Resposta4 = "Toy Bonnie";
        Q16.Resposta5 = "Foxy";
        Q16.RespostaCorreta = 2;
        Q16.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.Pergunta = "Qual o historia a Eleanor aparece ?";
        Q17.Resposta1 = "The Real Jake";
        Q17.Resposta2 = "Loneley Freddy";
        Q17.Resposta3 = "To Be Beautiful";
        Q17.Resposta4 = "Bunny Call";
        Q17.Resposta5 = "Blackbird";
        Q17.RespostaCorreta = 2;
        Q17.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.Pergunta = "Quantas historia tem o  Five Nights at Freddy's: Fazbear Frights?";
        Q18.Resposta1 = "40";
        Q18.Resposta2 = "60";
        Q18.Resposta3 = "68";
        Q18.Resposta4 = "48";
        Q18.Resposta5 = "12";
        Q18.RespostaCorreta = 4;
        Q18.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.Pergunta = "Qual o nome do Fnaf que parece um RPG";
        Q19.Resposta1 = "Fnaf Ar";
        Q19.Resposta2 = "Fnaf Help Wanted";
        Q19.Resposta3 = "Fnaf Word";
        Q19.Resposta4 = "Five Laps at Freddy";
        Q19.Resposta5 = "Fnaf RPG";
        Q19.RespostaCorreta = 3;
        Q19.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.Pergunta = "Qual o animatonic que de mata quando a music acaba?";
        Q20.Resposta1 = "MusicMan";
        Q20.Resposta2 = "Freddy";
        Q20.Resposta3 = "Puppet";
        Q20.Resposta4 = "Bonnie";
        Q20.Resposta5 = "Foxy";
        Q20.RespostaCorreta = 1;
        Q20.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q20);


    }

    public void ProximaQuestao()
    {
        var NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(NumRandomico)) ;
        NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count);
        ListaQuestoesRespondidas.Add(NumRandomico);
        QuestaoCorrente = ListaQuestoes[NumRandomico];
        QuestaoCorrente.Desenhar();
    }

    public async void VerificarCorreto(int rr)
    {
        if (QuestaoCorrente.VerificarResposta(rr))
        {
            await Task.Delay(1000); //1seg
            ProximaQuestao();
        }

        else
        {
            await App.Current.MainPage.DisplayAlert("Fim","Você Errou","Ok");
            Inicializar();
        }
    }

    void AdicionarPontuação(int n)
    {

    }
}