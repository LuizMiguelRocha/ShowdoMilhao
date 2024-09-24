namespace ShowdoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;

    public int Pontuação { get; private set; }
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
        Q1.nivelpergunta = 1;
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
        Q2.nivelpergunta = 1;
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
        Q3.nivelpergunta = 1;
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
        Q4.nivelpergunta = 1;
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
        Q5.nivelpergunta = 1;
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
        Q6.nivelpergunta = 1;
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
        Q7.nivelpergunta = 1;
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
        Q8.nivelpergunta = 1;
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
        Q9.nivelpergunta = 1;
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
        Q10.nivelpergunta = 1;
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
        Q11.nivelpergunta = 2;
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
        Q12.nivelpergunta = 2;
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
        Q13.nivelpergunta = 2;
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
        Q14.nivelpergunta = 2;
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
        Q15.nivelpergunta = 2;
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
        Q16.nivelpergunta = 2;
        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.Pergunta = "Qual o historia a Eleanor aparece ?";
        Q17.Resposta1 = "The Real Jake";
        Q17.Resposta2 = "Loneley Freddy";
        Q17.Resposta3 = "To Be Beautiful";
        Q17.Resposta4 = "Bunny Call";
        Q17.Resposta5 = "Blackbird";
        Q17.RespostaCorreta = 3;
        Q17.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q17.nivelpergunta = 2;
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
        Q18.nivelpergunta = 2;
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
        Q19.nivelpergunta = 2;
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
        Q20.nivelpergunta = 2;
        ListaQuestoes.Add(Q20);

        var Q21 = new Questao();
        Q21.Pergunta = "Qual o animatronic não aparece em nenhuma camera?";
        Q21.Resposta1 = "Freddy";
        Q21.Resposta2 = "Golden Freddy";
        Q21.Resposta3 = "Puppet";
        Q21.Resposta4 = "Ballon Boy";
        Q21.Resposta5 = "Todas as opções";
        Q21.RespostaCorreta = 2;
        Q21.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q21.nivelpergunta = 3;
        ListaQuestoes.Add(Q21);

        var Q22 = new Questao();
        Q22.Pergunta = "Qual o nome do animatronic mata e se difarça de Sarah";
        Q22.Resposta1 = "Baby";
        Q22.Resposta2 = "Fetch";
        Q22.Resposta3 = "Mimic";
        Q22.Resposta4 = "Eleanor";
        Q22.Resposta5 = "The Stitchwraith";
        Q22.RespostaCorreta = 4;
        Q22.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q22.nivelpergunta = 3;
        ListaQuestoes.Add(Q22);

        var Q23 = new Questao();
        Q23.Pergunta = "Qual o maior animatronic de Fnaf?";
        Q23.Resposta1 = "Blob";
        Q23.Resposta2 = "Mimic";
        Q23.Resposta3 = "Jg music man";
        Q23.Resposta4 = "Ballon Boy";
        Q23.Resposta5 = "Bombom";
        Q23.RespostaCorreta = 1;
        Q23.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q23.nivelpergunta = 3;
        ListaQuestoes.Add(Q23);

        var Q24 = new Questao();
        Q24.Pergunta = "Qual o valor do pagamendo nosso de Fnaf 1";
        Q24.Resposta1 = "US$ 100,00";
        Q24.Resposta2 = "US$ 200,00";
        Q24.Resposta3 = "US$ 2000,00";
        Q24.Resposta4 = "US$ 120,00";
        Q24.Resposta5 = "US$ 220,00";
        Q24.RespostaCorreta = 4;
        Q24.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q24.nivelpergunta = 3;
        ListaQuestoes.Add(Q24);

        var Q25 = new Questao();
        Q25.Pergunta = "Qual nome do animatronic que parece um coelho assasino que todo mundo zoa ele?";
        Q25.Resposta1 = "SpringTrap";
        Q25.Resposta2 = "Toy Bonnie";
        Q25.Resposta3 = "Bonnie";
        Q25.Resposta4 = "Bombom";
        Q25.Resposta5 = "RockStar Bonnie";
        Q25.RespostaCorreta = 2;
        Q25.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q25.nivelpergunta = 3;
        ListaQuestoes.Add(Q25);

        var Q26 = new Questao();
        Q26.Pergunta = "Qual o nightmare que se esconte dentro do quarta roupa";
        Q26.Resposta1 = "Nightmare Freddy";
        Q26.Resposta2 = "Nightmare Chica";
        Q26.Resposta3 = "Nightmare Bonnie";
        Q26.Resposta4 = "Nightmare Foxy";
        Q26.Resposta5 = "Nightmare FreddyBear";
        Q26.RespostaCorreta = 4;
        Q26.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q26.nivelpergunta = 3;
        ListaQuestoes.Add(Q26);

        var Q27 = new Questao();
        Q27.Pergunta = "Como era o relacionamento de Willian Afton com sues filhos?";
        Q27.Resposta1 = "Boa";
        Q27.Resposta2 = "Ruim";
        Q27.Resposta3 = "Aceitavel";
        Q27.Resposta4 = "Muito Boa";
        Q27.Resposta5 = "Saudavel";
        Q27.RespostaCorreta = 2;
        Q27.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q27.nivelpergunta = 3;
        ListaQuestoes.Add(Q27);

        var Q28 = new Questao();
        Q28.Pergunta = "Qual o animatronic que se nega a fazer parte do Ennard?";
        Q28.Resposta1 = "Baby";
        Q28.Resposta2 = "Ballora";
        Q28.Resposta3 = "Funtame Freddy";
        Q28.Resposta4 = "Funtame Foxy";
        Q28.Resposta5 = "Funtame Chica";
        Q28.RespostaCorreta = 2;
        Q28.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q28.nivelpergunta = 2;
        ListaQuestoes.Add(Q28);

        var Q29 = new Questao();
        Q29.Pergunta = "Qual a fala mais famosa de Fnaf?";
        Q29.Resposta1 = "I Always Come Back";
        Q29.Resposta2 = "Ad Astra Abysosque";
        Q29.Resposta3 = "Hello? Hello?";
        Q29.Resposta4 = "Exotic Butters";
        Q29.Resposta5 = "Hello";
        Q29.RespostaCorreta = 1;
        Q29.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q29.nivelpergunta = 3;
        ListaQuestoes.Add(Q29);

        var Q30 = new Questao();
        Q30.Pergunta = "Qual o Withered não tem cara?";
        Q30.Resposta1 = "Withered Freddy";
        Q30.Resposta2 = "Withered Bonnie";
        Q30.Resposta3 = "Withered Foxy";
        Q30.Resposta4 = "Withered Chica";
        Q30.Resposta5 = "Withered Golden Freddy";
        Q30.RespostaCorreta = 2;
        Q30.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q30.nivelpergunta = 3;
        ListaQuestoes.Add(Q30);

        var Q31 = new Questao();
        Q31.Pergunta = "Qual animatronic se esconte dentro do banheiro feminino no Fnaf 1?";
        Q31.Resposta1 = "Freddy";
        Q31.Resposta2 = "Bonnie";
        Q31.Resposta3 = "Chica";
        Q31.Resposta4 = "Foxy";
        Q31.Resposta5 = "Puppet";
        Q31.RespostaCorreta = 1; 
        Q31.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q31.nivelpergunta = 4;
        ListaQuestoes.Add(Q31);

        var Q32 = new Questao();
        Q32.Pergunta = "De qual animatronic nos usa a mascara no fnaf 2?";
        Q32.Resposta1 = "Chica";
        Q32.Resposta2 = "Bonnie";
        Q32.Resposta3 = "Foxy";
        Q32.Resposta4 = "Freddy";
        Q32.Resposta5 = "Puppet";
        Q32.RespostaCorreta = 4; 
        Q32.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q32.nivelpergunta = 4;
        ListaQuestoes.Add(Q32);

        var Q33 = new Questao();
        Q33.Pergunta = "Qual animatronic não aparece na UCN";
        Q33.Resposta1 = "Phanton Freddy";
        Q33.Resposta2 = "Toy Chica";
        Q33.Resposta3 = "Funtame Chica";
        Q33.Resposta4 = "Nightmare Foxy";
        Q33.Resposta5 = "Phone Guy";
        Q33.RespostaCorreta = 4; 
        Q33.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q33.nivelpergunta = 4;
        ListaQuestoes.Add(Q33);

        


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
            AdicionarPontuação(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }

        else
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Você Errou", "Ok");
            Inicializar();
        }
    }

    void AdicionarPontuação(int n)
    {

    }
}