namespace ShowdoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
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
        Q1.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.Pergunta = "Quantos filhos(as) Willian Afton tinha?";
        Q2.Resposta1 = "1";
        Q2.Resposta2 = "5";
        Q2.Resposta3 = "4";
        Q2.Resposta4 = "10";
        Q2.Resposta5 = "3";
        Q2.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.Pergunta = "Qual a cor do Bonnie de FNAF 1?";
        Q3.Resposta1 = "Azul";
        Q3.Resposta2 = "Roxo";
        Q3.Resposta3 = "Amarelo";
        Q3.Resposta4 = "Marrom";
        Q3.Resposta5 = "Rosa";
        Q3.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.Pergunta = "Quandas cameras tem no Fnaf 1?";
        Q4.Resposta1 = "5";
        Q4.Resposta2 = "12";
        Q4.Resposta3 = "11";
        Q4.Resposta4 = "15";
        Q4.Resposta5 = "10";
        Q4.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.Pergunta = "Qual o nome da que o Mike usa no Fnaf 1?";
        Q5.Resposta1 = "Mike Cafida";
        Q5.Resposta2 = "Michael Jackson";
        Q5.Resposta3 = "Mike Schndit";
        Q5.Resposta4 = "Mike Schmdit";
        Q5.Resposta5 = "Mike Afton";
        Q5.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.Pergunta = "Qual a cor da roupa de William Afton";
        Q6.Resposta1 = "Rosa";
        Q6.Resposta2 = "Azul";
        Q6.Resposta3 = "Roxo";
        Q6.Resposta4 = "Vermelho";
        Q6.Resposta5 = "Spring Bonnie";
        Q6.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.Pergunta = "Qual o nome da criança dentro da Baby";
        Q7.Resposta1 = "Eleanor";
        Q7.Resposta2 = "Cassy";
        Q7.Resposta3 = "Eduardo";
        Q7.Resposta4 = "Elizabeth";
        Q7.Resposta5 = "Susie";
        Q7.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.Pergunta = "Quandos Animatrônicos tem na UCN";
        Q8.Resposta1 = "45";
        Q8.Resposta2 = "50";
        Q8.Resposta3 = "55";
        Q8.Resposta4 = "40";
        Q8.Resposta5 = "60";
        Q8.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.Pergunta = "Qual é o nome do criador da série Five Nights at Freddy's?";
        Q9.Resposta1 = "Scott Cawthon";
        Q9.Resposta2 = "Markiplier";
        Q9.Resposta3 = "Game Theory";
        Q9.Resposta4 = "Notch";
        Q9.Resposta5 = "YandereDev";
        Q9.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.Pergunta = "Qual o nome da guarda de segurança do FNAF Security Breach";
        Q10.Resposta1 = "Willian Afton";
        Q10.Resposta2 = "Mike";
        Q10.Resposta3 = "Phone Guy";
        Q10.Resposta4 = "Vanessa";
        Q10.Resposta5 = "Gregory";
        Q10.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q10);

        var Q11 = new Questao();
        Q11.Pergunta = "Pergunta Q11";
        Q11.Resposta1 = "Resposta A";
        Q11.Resposta2 = "Resposta B";
        Q11.Resposta3 = "Resposta C";
        Q11.Resposta4 = "Resposta D";
        Q11.Resposta5 = "Resposta E";
        Q11.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.Pergunta = "Pergunta Q12";
        Q12.Resposta1 = "Resposta A";
        Q12.Resposta2 = "Resposta B";
        Q12.Resposta3 = "Resposta C";
        Q12.Resposta4 = "Resposta D";
        Q12.Resposta5 = "Resposta E";
        Q12.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.Pergunta = "Pergunta Q13";
        Q13.Resposta1 = "Resposta A";
        Q13.Resposta2 = "Resposta B";
        Q13.Resposta3 = "Resposta C";
        Q13.Resposta4 = "Resposta D";
        Q13.Resposta5 = "Resposta E";
        Q13.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.Pergunta = "Pergunta Q14";
        Q14.Resposta1 = "Resposta A";
        Q14.Resposta2 = "Resposta B";
        Q14.Resposta3 = "Resposta C";
        Q14.Resposta4 = "Resposta D";
        Q14.Resposta5 = "Resposta E";
        Q14.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.Pergunta = "Pergunta Q15";
        Q15.Resposta1 = "Resposta A";
        Q15.Resposta2 = "Resposta B";
        Q15.Resposta3 = "Resposta C";
        Q15.Resposta4 = "Resposta D";
        Q15.Resposta5 = "Resposta E";
        Q15.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.Pergunta = "Pergunta Q16";
        Q16.Resposta1 = "Resposta A";
        Q16.Resposta2 = "Resposta B";
        Q16.Resposta3 = "Resposta C";
        Q16.Resposta4 = "Resposta D";
        Q16.Resposta5 = "Resposta E";
        Q16.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.Pergunta = "Pergunta Q17";
        Q17.Resposta1 = "Resposta A";
        Q17.Resposta2 = "Resposta B";
        Q17.Resposta3 = "Resposta C";
        Q17.Resposta4 = "Resposta D";
        Q17.Resposta5 = "Resposta E";
        Q17.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.Pergunta = "Pergunta Q18";
        Q18.Resposta1 = "Resposta A";
        Q18.Resposta2 = "Resposta B";
        Q18.Resposta3 = "Resposta C";
        Q18.Resposta4 = "Resposta D";
        Q18.Resposta5 = "Resposta E";
        Q18.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.Pergunta = "Pergunta Q19";
        Q19.Resposta1 = "Resposta A";
        Q19.Resposta2 = "Resposta B";
        Q19.Resposta3 = "Resposta C";
        Q19.Resposta4 = "Resposta D";
        Q19.Resposta5 = "Resposta E";
        Q19.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.Pergunta = "Pergunta Q20";
        Q20.Resposta1 = "Resposta A";
        Q20.Resposta2 = "Resposta B";
        Q20.Resposta3 = "Resposta C";
        Q20.Resposta4 = "Resposta D";
        Q20.Resposta5 = "Resposta E";
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
    }

}