namespace ShowdoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    Label labelPontuacao;
    Label labelNivel;

    public int Pontuação { get; private set; }
    int NivelAtual = 0;

    public Questao GetQuestaoCorrente()
    {
        return GetQuestaoCorrente;
    }

    void Inicializar()
    {
        Pontuação = 0;
        NivelAtual = 0;
        ProximaQuestao();
        labelPontuacao.Text = "Pontuação: R$" + Pontuação.ToString();
        labelNivel.Text = "Nivel:" + NivelAtual.ToString();
        ListaQuestoesRespondidas.Clear();
    }

    public Gerenciador(Label labelPergunta, Label labelNivel, Label labelPont, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        CriarQuestoes(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        labelPontuacao = labelPont;
        this.labelNivel = labelNivel;

    }

    void AdicionaPontuacao(int michelly)
    {
        if (michelly == 1)
            Pontuação = 1000;
        else if (michelly == 2)
            Pontuação = 2000;
        else if (michelly == 3)
            Pontuação = 5000;
        else if (michelly == 4)
            Pontuação = 10000;
        else if (michelly == 5)
            Pontuação = 20000;
        else if (michelly == 6)
            Pontuação = 50000;
        else if (michelly == 7)
            Pontuação = 100000;
        else if (michelly == 8)
            Pontuação = 200000;
        else if (michelly == 9)
            Pontuação = 500000;
        else
            Pontuação = 1000000;
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
        Q20.RespostaCorreta = 3;
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
        Q24.Pergunta = "Qual o valor do pagamento nosso de Fnaf 1";
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
        Q25.Pergunta = "Qual nome do animatronic que parece um coelho assassino que todo mundo zoa ele?";
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
        Q26.Pergunta = "Qual o nightmare que se esconde dentro do guarda-roupa?";
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
        Q27.Pergunta = "Como era o relacionamento de Willian Afton com seus filhos?";
        Q27.Resposta1 = "Boa";
        Q27.Resposta2 = "Ruim";
        Q27.Resposta3 = "Aceitável";
        Q27.Resposta4 = "Muito Boa";
        Q27.Resposta5 = "Saudável";
        Q27.RespostaCorreta = 2;
        Q27.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q27.nivelpergunta = 3;
         ListaQuestoes.Add(Q27);

        var Q28 = new Questao();
        Q28.Pergunta = "Qual o animatronic que se nega a fazer parte do Ennard?";
        Q28.Resposta1 = "Baby";
        Q28.Resposta2 = "Ballora";
        Q28.Resposta3 = "Funtime Freddy";
        Q28.Resposta4 = "Funtime Foxy";
        Q28.Resposta5 = "Funtime Chica";
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
        Q31.Pergunta = "Qual animatronic se esconde dentro do banheiro feminino no Fnaf 1?";
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
        Q32.Pergunta = "De qual animatronic nos usamos a máscara no Fnaf 2?";
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
        Q33.Pergunta = "Qual animatronic não aparece na UCN?";
        Q33.Resposta1 = "Phantom Freddy";
        Q33.Resposta2 = "Toy Chica";
        Q33.Resposta3 = "Funtime Chica";
        Q33.Resposta4 = "Nightmare Foxy";
        Q33.Resposta5 = "Phone Guy";
        Q33.RespostaCorreta = 4;
        Q33.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q33.nivelpergunta = 4;
         ListaQuestoes.Add(Q33);

        var Q34 = new Questao();
        Q34.Pergunta = "Quantos dentes tem o Nightmare Nightmare?";
        Q34.Resposta1 = "100";
        Q34.Resposta2 = "94";
        Q34.Resposta3 = "96";
        Q34.Resposta4 = "120";
        Q34.Resposta5 = "62";
        Q34.RespostaCorreta = 3;
        Q34.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q34.nivelpergunta = 4;
         ListaQuestoes.Add(Q34);

        var Q35 = new Questao();
        Q35.Pergunta = "Em que noite o Nightmare aparece?";
        Q35.Resposta1 = "20/0/0/0";
        Q35.Resposta2 = "0/20/0/0";
        Q35.Resposta3 = "0/0/20/0";
        Q35.Resposta4 = "0/0/0/20";
        Q35.Resposta5 = "20/20/20/20";
        Q35.RespostaCorreta = 5;
        Q35.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q35.nivelpergunta = 4;
         ListaQuestoes.Add(Q35);

        var Q36 = new Questao();
        Q36.Pergunta = "Qual o nome da filha do Henry Emily?";
        Q36.Resposta1 = "Elizabeth";
        Q36.Resposta2 = "Gabriel";
        Q36.Resposta3 = "Charlie";
        Q36.Resposta4 = "Susie";
        Q36.Resposta5 = "Cassie";
        Q36.RespostaCorreta = 3;
        Q36.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q36.nivelpergunta = 4;
         ListaQuestoes.Add(Q36);

        var Q37 = new Questao();
        Q37.Pergunta = "Por que o Withered Foxy te mata mesmo estando com a máscara?";
        Q37.Resposta1 = "Porque sim";
        Q37.Resposta2 = "Porque ele é inteligente";
        Q37.Resposta3 = "Porque ele não gosta do Freddy";
        Q37.Resposta4 = "Porque você é o guarda";
        Q37.Resposta5 = "Porque é a mecânica do jogo";
        Q37.RespostaCorreta = 5;
        Q37.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q37.nivelpergunta = 4;
         ListaQuestoes.Add(Q37);

        var Q38 = new Questao();
        Q38.Pergunta = "Que horas o jogo acaba?";
        Q38.Resposta1 = "1 hora da manhã";
        Q38.Resposta2 = "3 horas da manhã";
        Q38.Resposta3 = "Meia-noite";
        Q38.Resposta4 = "6 horas da manhã";
        Q38.Resposta5 = "Nunca acaba";
        Q38.RespostaCorreta = 4;
        Q38.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q38.nivelpergunta = 4;
         ListaQuestoes.Add(Q38);

        var Q39 = new Questao();
        Q39.Pergunta = "De onde veio o jumpscare de Fnaf?";
        Q39.Resposta1 = "De outro jogo";
        Q39.Resposta2 = "De uma série";
        Q39.Resposta3 = "De um filme";
        Q39.Resposta4 = "De um anime";
        Q39.Resposta5 = "Por crianças";
        Q39.RespostaCorreta = 3;
        Q39.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q39.nivelpergunta = 4;
         ListaQuestoes.Add(Q39);

        var Q40 = new Questao();
        Q40.Pergunta = "Quantas portas tem o quarto da criança chorona?";
        Q40.Resposta1 = "1";
        Q40.Resposta2 = "2";
        Q40.Resposta3 = "3";
        Q40.Resposta4 = "4";
        Q40.Resposta5 = "5";
        Q40.RespostaCorreta = 1;
        Q40.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q40.nivelpergunta = 4;
         ListaQuestoes.Add(Q40);


        var Q41 = new Questao();
        Q41.Pergunta = "Qual o nome do recordista mundial de Fnaf 1 até o dia 25/09/2024?";
        Q41.Resposta1 = "arcaneryan";
        Q41.Resposta2 = "D4rkGhostBr";
        Q41.Resposta3 = "felpfelp";
        Q41.Resposta4 = "Core";
        Q41.Resposta5 = "Rouzones";
        Q41.RespostaCorreta = 3;
        Q41.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q41.nivelpergunta = 5;
         ListaQuestoes.Add(Q41);

        var Q42 = new Questao();
        Q42.Pergunta = "Qual o nome do assassino de Fnaf?";
        Q42.Resposta1 = "William Cafita";
        Q42.Resposta2 = "Wiliiam Pai de Família";
        Q42.Resposta3 = "William Arnaldo";
        Q42.Resposta4 = "William Frids";
        Q42.Resposta5 = "William Afton";
        Q42.RespostaCorreta = 5;
        Q42.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q42.nivelpergunta = 5;
         ListaQuestoes.Add(Q42);

        var Q43 = new Questao();
        Q43.Pergunta = "Qual o nome da ferramenta usada para criar Fnaf 1?";
        Q43.Resposta1 = "GameMaker";
        Q43.Resposta2 = "Visual Studio";
        Q43.Resposta3 = "Clickteam Fusion 2.5";
        Q43.Resposta4 = "Clickteam Fusion 2.0";
        Q43.Resposta5 = "Clickteam Fusion 3.0";
        Q43.RespostaCorreta = 3;
        Q43.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q43.nivelpergunta = 5;
         ListaQuestoes.Add(Q43);

        var Q44 = new Questao();
        Q44.Pergunta = "Qual frase o Golden Freddy sempre diz?";
        Q44.Resposta1 = "It´s you";
        Q44.Resposta2 = "It´s me mario";
        Q44.Resposta3 = "It´s me Golden Freddy";
        Q44.Resposta4 = "It´s me Warrio";
        Q44.Resposta5 = "It´s me";
        Q44.RespostaCorreta = 5;
        Q44.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q44.nivelpergunta = 5;
         ListaQuestoes.Add(Q44);

        var Q45 = new Questao();
        Q45.Pergunta = "Quem é que fala 'I always come back'?";
        Q45.Resposta1 = "William Afton";
        Q45.Resposta2 = "Spring Bonnie";
        Q45.Resposta3 = "SpringTrap";
        Q45.Resposta4 = "Golden Freddy";
        Q45.Resposta5 = "Mike Afton";
        Q45.RespostaCorreta = 3;
        Q45.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q45.nivelpergunta = 5;
         ListaQuestoes.Add(Q45);

        var Q46 = new Questao();
        Q46.Pergunta = "Qual animatronic é o rosto da Fazbear?";
        Q46.Resposta1 = "Freddy";
        Q46.Resposta2 = "Help";
        Q46.Resposta3 = "Bonnie";
        Q46.Resposta4 = "Um urso aleatório";
        Q46.Resposta5 = "William Afton";
        Q46.RespostaCorreta = 2;
        Q46.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q46.nivelpergunta = 5;
         ListaQuestoes.Add(Q46);

        var Q47 = new Questao();
        Q47.Pergunta = "Qual o nome do primeiro Youtuber brasileiro a passar o 50/20 da UCN?";
        Q47.Resposta1 = "Core";
        Q47.Resposta2 = "MrGuinas";
        Q47.Resposta3 = "HUEstation";
        Q47.Resposta4 = "EnderBuilder";
        Q47.Resposta5 = "Pirate Cove";
        Q47.RespostaCorreta = 2;
        Q47.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q47.nivelpergunta = 5;
         ListaQuestoes.Add(Q47);

        var Q48 = new Questao();
        Q48.Pergunta = "Qual o nome da fangame de Fnaf em que o animatronic principal é um gato?";
        Q48.Resposta1 = "JR’s";
        Q48.Resposta2 = "Tyke and Sons Lumber Co.";
        Q48.Resposta3 = "The Glitched Attraction";
        Q48.Resposta4 = "The Joy of Creation";
        Q48.Resposta5 = "Five Nights at Candy's";
        Q48.RespostaCorreta = 5;
        Q48.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q48.nivelpergunta = 5;
         ListaQuestoes.Add(Q48);

        var Q49 = new Questao();
        Q49.Pergunta = "Qual a fangame de Fnaf em que nós controlamos o Scott Cawthon?";
        Q49.Resposta1 = "JR’s";
        Q49.Resposta2 = "Tyke and Sons Lumber Co.";
        Q49.Resposta3 = "The Glitched Attraction";
        Q49.Resposta4 = "The Joy of Creation";
        Q49.Resposta5 = "Five Nights at Candy's";
        Q49.RespostaCorreta = 4;
        Q49.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q49.nivelpergunta = 5;
         ListaQuestoes.Add(Q49);

        var Q50 = new Questao();
        Q50.Pergunta = "Qual a fangame em que o vilão é um ovo?";
        Q50.Resposta1 = "Five Nights at Candy's";
        Q50.Resposta2 = "One Night at Flumpty's";
        Q50.Resposta3 = "Super FNaF";
        Q50.Resposta4 = "Wonderland";
        Q50.Resposta5 = "POPGOES Evergreen";
        Q50.RespostaCorreta = 2;
        Q50.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q50.nivelpergunta = 5;
         ListaQuestoes.Add(Q50);


        var Q51 = new Questao();
        Q51.Pergunta = "Qual a fangame que recebeu um processo de uma empresa de verdade";
        Q51.Resposta1 = "POPGOES Evergreen";
        Q51.Resposta2 = "Five Nights at Candy's";
        Q51.Resposta3 = "Wonderland";
        Q51.Resposta4 = "JOLLY ";
        Q51.Resposta5 = "Golden Memory";
        Q51.RespostaCorreta = 4;
        Q51.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q51.nivelpergunta = 6;
         ListaQuestoes.Add(Q51);

        var Q52 = new Questao();
        Q52.Pergunta = "Em qual Five Nights at Candy's o personagen Rat aparece";
        Q52.Resposta1 = "Five Nights at Candy's 1";
        Q52.Resposta2 = "Five Nights at Candy's 2";
        Q52.Resposta3 = "Five Nights at Candy's 3";
        Q52.Resposta4 = "Five Nights at Candy's 4";
        Q52.Resposta5 = "Five Nights at Candy's Remaster";
        Q52.RespostaCorreta = 3;
        Q52.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q52.nivelpergunta = 6;
        ListaQuestoes.Add(Q52);

        var Q53 = new Questao();
        Q53.Pergunta = "Qual o nome do personagen de Five Nights at Candy's que se parece a puppet";
        Q53.Resposta1 = "Blank";
        Q53.Resposta2 = "Monster Rat";
        Q53.Resposta3 = "Old Candy";
        Q53.Resposta4 = "Mary Schmidt";
        Q53.Resposta5 = "Vinnie";
        Q53.RespostaCorreta = 5;
        Q53.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q53.nivelpergunta = 6;
        ListaQuestoes.Add(Q53);

        var Q54 = new Questao();
        Q54.Pergunta = "Qual a primeira forma de blob?";
        Q54.Resposta1 = "Ennard";
        Q54.Resposta2 = "Molte Freddy";
        Q54.Resposta3 = "O endo esqueleto de funtame Freddy";
        Q54.Resposta4 = "William Afton";
        Q54.Resposta5 = "Nunca teve forma primortial";
        Q54.RespostaCorreta = 1;
        Q54.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q54.nivelpergunta = 6;
        ListaQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.Pergunta = " Na ultimate custom night qual é o animatronico que entala na ventilação ";
        Q55.Resposta1 = "SpringTrap";
        Q55.Resposta2 = "Molden Freddy";
        Q55.Resposta3 = "Ennard";
        Q55.Resposta4 = "Mangle";
        Q55.Resposta5 = "Wintered Chica";
        Q55.RespostaCorreta = 5;
        Q55.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q55.nivelpergunta = 6;
        ListaQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.Pergunta = "Quais dos animatronics foram queimados em fnaf 6?";
        Q56.Resposta1 = "Molten Freddy, Scrap Baby, Afton e Left";
        Q56.Resposta2 = "Molten Freddy, Scrap Baby, Afton, Left e Mike Afton";
        Q56.Resposta3 = "Molten Freddy, Scrap Baby e Afton";
        Q56.Resposta4 = "Molten Freddy e Left";
        Q56.Resposta5 = "Scrap Baby e Afton";
        Q56.RespostaCorreta = 1;
        Q56.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q56.nivelpergunta = 6;
        ListaQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.Pergunta = " Quantos shadows existem? ";
        Q57.Resposta1 = "1";
        Q57.Resposta2 = "2";
        Q57.Resposta3 = "3";
        Q57.Resposta4 = "4";
        Q57.Resposta5 = "5";
        Q57.RespostaCorreta = 2;
        Q57.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q57.nivelpergunta = 6;
        ListaQuestoes.Add(Q57);

        var Q58 = new Questao();
        Q58.Pergunta = "Qual destes animatronics cantam ao te matar na ultimate custom night? ";
        Q58.Resposta1 = "El Chip";
        Q58.Resposta2 = "Rockstar Foxy";
        Q58.Resposta3 = "Rockstar Freddy";
        Q58.Resposta4 = "Rockstar Bonnie";
        Q58.Resposta5 = "Rockstar Chica";
        Q58.RespostaCorreta = 4;
        Q58.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q58.nivelpergunta = 6;
        ListaQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.Pergunta = " Qual é o jumpscare mais longo?ALERTA!este jumpscare tem uns 4 minutos você não vai querer morrer para esse animatronic. ";
        Q59.Resposta1 = "NightMarione";
        Q59.Resposta2 = "Fredbear";
        Q59.Resposta3 = "Baby";
        Q59.Resposta4 = "Puppet";
        Q59.Resposta5 = "Mr.Hippo";
        Q59.RespostaCorreta = 5;
        Q59.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q59.nivelpergunta = 6;
        ListaQuestoes.Add(Q59);

        var Q60 = new Questao();
        Q60.Pergunta = "Quais destes personagens não estão em fnaf ";
        Q60.Resposta1 = "Glamrock Mr.Hippo";
        Q60.Resposta2 = "Candy";
        Q60.Resposta3 = "Music Man";
        Q60.Resposta4 = "Plush Trap";
        Q60.Resposta5 = "Glamrock Bonnie";
        Q60.RespostaCorreta = 2;
        Q60.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q60.nivelpergunta = 6;
        ListaQuestoes.Add(Q60);

        // Perguntas 61 a 70 - Nível 7
        var Q61 = new Questao();
        Q61.Pergunta = "Qual é o nome verdadeiro de Springtrap?";
        Q61.Resposta1 = "Michael Afton";
        Q61.Resposta2 = "William Afton";
        Q61.Resposta3 = "Henry Emily";
        Q61.Resposta4 = "Jeremy Fitzgerald";
        Q61.Resposta5 = "Phone Guy";
        Q61.RespostaCorreta = 2;
        Q61.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q61.nivelpergunta = 7;
        ListaQuestoes.Add(Q61);

        var Q62 = new Questao();
        Q62.Pergunta = "Qual é o restaurante original em FNAF?";
        Q62.Resposta1 = "Fredbear's Family Diner";
        Q62.Resposta2 = "Fazbear's Fright";
        Q62.Resposta3 = "Circus Baby's Pizza World";
        Q62.Resposta4 = "Freddy Fazbear's Pizza";
        Q62.Resposta5 = "Fazbear Entertainment";
        Q62.RespostaCorreta = 1;
        Q62.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q62.nivelpergunta = 7;
        ListaQuestoes.Add(Q62);

        var Q63 = new Questao();
        Q63.Pergunta = "Qual destes personagens é controlado por Elizabeth Afton?";
        Q63.Resposta1 = "Ballora";
        Q63.Resposta2 = "Circus Baby";
        Q63.Resposta3 = "Funtime Foxy";
        Q63.Resposta4 = "Bonnet";
        Q63.Resposta5 = "Funtime Freddy";
        Q63.RespostaCorreta = 2;
        Q63.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q63.nivelpergunta = 7;
        ListaQuestoes.Add(Q63);

        var Q64 = new Questao();
        Q64.Pergunta = "Quem é o personagem antagonista de FNAF 4?";
        Q64.Resposta1 = "Nightmare Fredbear";
        Q64.Resposta2 = "Springtrap";
        Q64.Resposta3 = "Funtime Freddy";
        Q64.Resposta4 = "Toy Chica";
        Q64.Resposta5 = "Puppet";
        Q64.RespostaCorreta = 1;
        Q64.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q64.nivelpergunta = 7;
        ListaQuestoes.Add(Q64);

        var Q65 = new Questao();
        Q65.Pergunta = "Qual destes animatrônicos é conhecido por sua música?";
        Q65.Resposta1 = "Ballora";
        Q65.Resposta2 = "Funtime Freddy";
        Q65.Resposta3 = "Circus Baby";
        Q65.Resposta4 = "Music Man";
        Q65.Resposta5 = "Chica";
        Q65.RespostaCorreta = 4;
        Q65.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q65.nivelpergunta = 7;
        ListaQuestoes.Add(Q65);

        var Q66 = new Questao();
        Q66.Pergunta = "Quem é o assassino responsável pelos desaparecimentos no universo FNAF?";
        Q66.Resposta1 = "Mike Schmidt";
        Q66.Resposta2 = "Henry Emily";
        Q66.Resposta3 = "William Afton";
        Q66.Resposta4 = "Jeremy Fitzgerald";
        Q66.Resposta5 = "Phone Guy";
        Q66.RespostaCorreta = 3;
        Q66.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q66.nivelpergunta = 7;
        ListaQuestoes.Add(Q66);

        var Q67 = new Questao();
        Q67.Pergunta = "Qual destes personagens não aparece no jogo FNAF Help Wanted?";
        Q67.Resposta1 = "Dreadbear";
        Q67.Resposta2 = "Grim Foxy";
        Q67.Resposta3 = "Glitchtrap";
        Q67.Resposta4 = "Ballora";
        Q67.Resposta5 = "Nightmare Freddy";
        Q67.RespostaCorreta = 4;
        Q67.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q67.nivelpergunta = 7;
        ListaQuestoes.Add(Q67);

        var Q68 = new Questao();
        Q68.Pergunta = "Qual destes personagens tem múltiplas formas em diferentes jogos?";
        Q68.Resposta1 = "Freddy Fazbear";
        Q68.Resposta2 = "Chica";
        Q68.Resposta3 = "Foxy";
        Q68.Resposta4 = "Bonnie";
        Q68.Resposta5 = "Golden Freddy";
        Q68.RespostaCorreta = 1;
        Q68.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q68.nivelpergunta = 7;
        ListaQuestoes.Add(Q68);

        var Q69 = new Questao();
        Q69.Pergunta = "Qual é o nome do local do jogo FNAF Sister Location?";
        Q69.Resposta1 = "Fazbear's Fright";
        Q69.Resposta2 = "Circus Baby's Entertainment and Rental";
        Q69.Resposta3 = "Fredbear's Family Diner";
        Q69.Resposta4 = "Freddy Fazbear's Pizza";
        Q69.Resposta5 = "Fazbear Entertainment";
        Q69.RespostaCorreta = 2;
        Q69.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q69.nivelpergunta = 7;
        ListaQuestoes.Add(Q69);

        var Q70 = new Questao();
        Q70.Pergunta = "Quem é o personagem principal em FNAF 3?";
        Q70.Resposta1 = "Freddy Fazbear";
        Q70.Resposta2 = "Foxy";
        Q70.Resposta3 = "Springtrap";
        Q70.Resposta4 = "Chica";
        Q70.Resposta5 = "Bonnie";
        Q70.RespostaCorreta = 3;
        Q70.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q70.nivelpergunta = 7;
        ListaQuestoes.Add(Q70);

        // Perguntas 71 a 80 - Nível 8
        var Q71 = new Questao();
        Q71.Pergunta = "Quem é o protagonista em FNAF 2?";
        Q71.Resposta1 = "Jeremy Fitzgerald";
        Q71.Resposta2 = "Mike Schmidt";
        Q71.Resposta3 = "William Afton";
        Q71.Resposta4 = "Fritz Smith";
        Q71.Resposta5 = "Phone Guy";
        Q71.RespostaCorreta = 1;
        Q71.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q71.nivelpergunta = 8;
        ListaQuestoes.Add(Q71);

        var Q72 = new Questao();
        Q72.Pergunta = "Qual destes animatrônicos tem uma máscara de Freddy?";
        Q72.Resposta1 = "Funtime Freddy";
        Q72.Resposta2 = "Golden Freddy";
        Q72.Resposta3 = "Toy Freddy";
        Q72.Resposta4 = "Withered Freddy";
        Q72.Resposta5 = "Phantom Freddy";
        Q72.RespostaCorreta = 2;
        Q72.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q72.nivelpergunta = 8;
        ListaQuestoes.Add(Q72);

        var Q73 = new Questao();
        Q73.Pergunta = "Em que noite ocorre o minigame 'Give Gifts, Give Life' em FNAF 2?";
        Q73.Resposta1 = "Noite 1";
        Q73.Resposta2 = "Noite 3";
        Q73.Resposta3 = "Noite 5";
        Q73.Resposta4 = "Noite 6";
        Q73.Resposta5 = "Custom Night";
        Q73.RespostaCorreta = 3;
        Q73.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q73.nivelpergunta = 8;
        ListaQuestoes.Add(Q73);

        var Q74 = new Questao();
        Q74.Pergunta = "Quem está por trás da criação dos animatrônicos?";
        Q74.Resposta1 = "Michael Afton";
        Q74.Resposta2 = "William Afton";
        Q74.Resposta3 = "Henry Emily";
        Q74.Resposta4 = "Phone Guy";
        Q74.Resposta5 = "Jeremy Fitzgerald";
        Q74.RespostaCorreta = 3;
        Q74.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q74.nivelpergunta = 8;
        ListaQuestoes.Add(Q74);

        var Q75 = new Questao();
        Q75.Pergunta = "Qual é a principal função de Funtime Foxy?";
        Q75.Resposta1 = "Entretenimento";
        Q75.Resposta2 = "Guarda de segurança";
        Q75.Resposta3 = "Chef de cozinha";
        Q75.Resposta4 = "Dançarina";
        Q75.Resposta5 = "Palhaço";
        Q75.RespostaCorreta = 1;
        Q75.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q75.nivelpergunta = 8;
        ListaQuestoes.Add(Q75);

        var Q76 = new Questao();
        Q76.Pergunta = "Quem é o principal antagonista em FNAF Sister Location?";
        Q76.Resposta1 = "Circus Baby";
        Q76.Resposta2 = "Funtime Freddy";
        Q76.Resposta3 = "Ballora";
        Q76.Resposta4 = "Ennard";
        Q76.Resposta5 = "Funtime Foxy";
        Q76.RespostaCorreta = 4;
        Q76.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q76.nivelpergunta = 8;
        ListaQuestoes.Add(Q76);

        var Q77 = new Questao();
        Q77.Pergunta = "Qual personagem tem a habilidade de rastejar pelos dutos de ventilação?";
        Q77.Resposta1 = "Funtime Freddy";
        Q77.Resposta2 = "Ballora";
        Q77.Resposta3 = "Circus Baby";
        Q77.Resposta4 = "Funtime Foxy";
        Q77.Resposta5 = "Ennard";
        Q77.RespostaCorreta = 5;
        Q77.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q77.nivelpergunta = 8;
        ListaQuestoes.Add(Q77);

        var Q78 = new Questao();
        Q78.Pergunta = "Qual destes animatrônicos está em Security Breach?";
        Q78.Resposta1 = "Glamrock Chica";
        Q78.Resposta2 = "Nightmare Foxy";
        Q78.Resposta3 = "Withered Freddy";
        Q78.Resposta4 = "Golden Freddy";
        Q78.Resposta5 = "Toy Bonnie";
        Q78.RespostaCorreta = 1;
        Q78.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q78.nivelpergunta = 8;
        ListaQuestoes.Add(Q78);

        var Q79 = new Questao();
        Q79.Pergunta = "Qual destes personagens pode ser considerado um dos primeiros antagonistas?";
        Q79.Resposta1 = "Golden Freddy";
        Q79.Resposta2 = "Phone Guy";
        Q79.Resposta3 = "Springtrap";
        Q79.Resposta4 = "Freddy Fazbear";
        Q79.Resposta5 = "Chica";
        Q79.RespostaCorreta = 1;
        Q79.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q79.nivelpergunta = 8;
        ListaQuestoes.Add(Q79);

        var Q80 = new Questao();
        Q80.Pergunta = "Qual destes jogos tem o tema 'Pizzaplex'?";
        Q80.Resposta1 = "FNAF 1";
        Q80.Resposta2 = "FNAF 2";
        Q80.Resposta3 = "FNAF 3";
        Q80.Resposta4 = "FNAF: Security Breach";
        Q80.Resposta5 = "FNAF 4";
        Q80.RespostaCorreta = 4;
        Q80.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q80.nivelpergunta = 8;
        ListaQuestoes.Add(Q80);

        // Perguntas 81 a 90 - Nível 9
        var Q81 = new Questao();
        Q81.Pergunta = "Qual é o nome do jogador em FNAF 4?";
        Q81.Resposta1 = "Michael Afton";
        Q81.Resposta2 = "William Afton";
        Q81.Resposta3 = "Henry Emily";
        Q81.Resposta4 = "Crying Child";
        Q81.Resposta5 = "Phone Guy";
        Q81.RespostaCorreta = 4;
        Q81.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q81.nivelpergunta = 9;
        ListaQuestoes.Add(Q81);

        var Q82 = new Questao();
        Q82.Pergunta = "Qual animatrônico não aparece em FNAF 4?";
        Q82.Resposta1 = "Nightmare";
        Q82.Resposta2 = "Nightmare Fredbear";
        Q82.Resposta3 = "Nightmare Foxy";
        Q82.Resposta4 = "Nightmare Chica";
        Q82.Resposta5 = "Nightmare Springtrap";
        Q82.RespostaCorreta = 5;
        Q82.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q82.nivelpergunta = 9;
        ListaQuestoes.Add(Q82);

        // Perguntas 83 a 90 - Nível 9
        var Q83 = new Questao();
        Q83.Pergunta = "Qual destes animatrônicos possui o nome de 'Nightmare' no jogo FNAF 4?";
        Q83.Resposta1 = "Nightmare Freddy";
        Q83.Resposta2 = "Nightmare Foxy";
        Q83.Resposta3 = "Nightmare Chica";
        Q83.Resposta4 = "Nightmare";
        Q83.Resposta5 = "Nightmare Fredbear";
        Q83.RespostaCorreta = 4;
        Q83.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q83.nivelpergunta = 9;
        ListaQuestoes.Add(Q83);

        var Q84 = new Questao();
        Q84.Pergunta = "Qual Phanton vaz a ventilação parar de funcionar em FNAF 3?";
        Q84.Resposta1 = "Freddy Fazbear";
        Q84.Resposta2 = "Foxy";
        Q84.Resposta3 = "Chica";
        Q84.Resposta4 = "Bonnie";
        Q84.Resposta5 = "Mangle";
        Q84.RespostaCorreta = 5;
        Q84.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q84.nivelpergunta = 9;
        ListaQuestoes.Add(Q84);

        var Q85 = new Questao();
        Q85.Pergunta = "Quem é o personagem que aparece no final de FNAF 3 como 'Springtrap'?";
        Q85.Resposta1 = "William Afton";
        Q85.Resposta2 = "Michael Afton";
        Q85.Resposta3 = "Henry Emily";
        Q85.Resposta4 = "Phone Guy";
        Q85.Resposta5 = "Freddy Fazbear";
        Q85.RespostaCorreta = 1;
        Q85.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q85.nivelpergunta = 9;
        ListaQuestoes.Add(Q85);

        var Q86 = new Questao();
        Q86.Pergunta = "Em FNAF Sister Location, qual personagem tenta enganar o jogador para desativar todos os outros?";
        Q86.Resposta1 = "Circus Baby";
        Q86.Resposta2 = "Funtime Freddy";
        Q86.Resposta3 = "Ballora";
        Q86.Resposta4 = "Ennard";
        Q86.Resposta5 = "Funtime Foxy";
        Q86.RespostaCorreta = 4;
        Q86.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q86.nivelpergunta = 9;
        ListaQuestoes.Add(Q86);

        var Q87 = new Questao();
        Q87.Pergunta = "Qual é o nome do animatrônico que substitui Bonnie em FNAF Security Breach?";
        Q87.Resposta1 = "Glamrock Freddy";
        Q87.Resposta2 = "Montgomery Gator";
        Q87.Resposta3 = "Roxanne Wolf";
        Q87.Resposta4 = "Chica";
        Q87.Resposta5 = "Funtime Freddy";
        Q87.RespostaCorreta = 2;
        Q87.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q87.nivelpergunta = 9;
        ListaQuestoes.Add(Q87);

        var Q88 = new Questao();
        Q88.Pergunta = "Em que jogo de FNAF foi introduzido o personagem 'Glitchtrap'?";
        Q88.Resposta1 = "FNAF 1";
        Q88.Resposta2 = "FNAF 2";
        Q88.Resposta3 = "FNAF Help Wanted";
        Q88.Resposta4 = "FNAF 3";
        Q88.Resposta5 = "FNAF 4";
        Q88.RespostaCorreta = 3;
        Q88.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q88.nivelpergunta = 9;
        ListaQuestoes.Add(Q88);

        var Q89 = new Questao();
        Q89.Pergunta = "Qual destes personagens não está no jogo FNAF Ultimate Custom Night?";
        Q89.Resposta1 = "Molten Freddy";
        Q89.Resposta2 = "Scraptrap";
        Q89.Resposta3 = "Phanton Foxy";
        Q89.Resposta4 = "Nightmare Fredbear";
        Q89.Resposta5 = "Phantom Freddy";
        Q89.RespostaCorreta = 3;
        Q89.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q89.nivelpergunta = 9;
        ListaQuestoes.Add(Q89);

        var Q90 = new Questao();
        Q90.Pergunta = "Quem é o último animatrônico a ser revelado em FNAF 6?";
        Q90.Resposta1 = "Scrap Baby";
        Q90.Resposta2 = "Molten Freddy";
        Q90.Resposta3 = "Lefty";
        Q90.Resposta4 = "Scraptrap";
        Q90.Resposta5 = "Funtime Freddy";
        Q90.RespostaCorreta = 3;
        Q90.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q90.nivelpergunta = 9;
        ListaQuestoes.Add(Q90);

        // Perguntas 91 a 100 - Nível 10
        var Q91 = new Questao();
        Q91.Pergunta = "Quem é o dono da Fazbear Entertainment em FNAF?";
        Q91.Resposta1 = "Michael Afton";
        Q91.Resposta2 = "William Afton";
        Q91.Resposta3 = "Henry Emily";
        Q91.Resposta4 = "Phone Guy";
        Q91.Resposta5 = "Jeremy Fitzgerald";
        Q91.RespostaCorreta = 3;
        Q91.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q91.nivelpergunta = 10;
        ListaQuestoes.Add(Q91);

        var Q92 = new Questao();
        Q92.Pergunta = "Qual animatrônico faz parte da banda no Pizzaplex de FNAF Security Breach?";
        Q92.Resposta1 = "Glamrock Freddy";
        Q92.Resposta2 = "Montgomery Gator";
        Q92.Resposta3 = "Roxanne Wolf";
        Q92.Resposta4 = "Glamrock Chica";
        Q92.Resposta5 = "Todos os anteriores";
        Q92.RespostaCorreta = 5;
        Q92.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q92.nivelpergunta = 10;
        ListaQuestoes.Add(Q92);

        var Q93 = new Questao();
        Q93.Pergunta = "Quem controla Lefty em FNAF 6?";
        Q93.Resposta1 = "Michael Afton";
        Q93.Resposta2 = "William Afton";
        Q93.Resposta3 = "Puppet";
        Q93.Resposta4 = "Crying Child";
        Q93.Resposta5 = "Elizabeth Afton";
        Q93.RespostaCorreta = 3;
        Q93.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q93.nivelpergunta = 10;
        ListaQuestoes.Add(Q93);

        var Q94 = new Questao();
        Q94.Pergunta = "Qual animatrônico tem uma versão 'Rockstar' em FNAF 6?";
        Q94.Resposta1 = "Freddy Fazbear";
        Q94.Resposta2 = "Bonnie";
        Q94.Resposta3 = "Chica";
        Q94.Resposta4 = "Foxy";
        Q94.Resposta5 = "Todos os anteriores";
        Q94.RespostaCorreta = 5;
        Q94.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q94.nivelpergunta = 10;
        ListaQuestoes.Add(Q94);

        var Q95 = new Questao();
        Q95.Pergunta = "Quem é o protagonista em FNAF 6?";
        Q95.Resposta1 = "William Afton";
        Q95.Resposta2 = "Michael Afton";
        Q95.Resposta3 = "Henry Emily";
        Q95.Resposta4 = "Phone Guy";
        Q95.Resposta5 = "Jeremy Fitzgerald";
        Q95.RespostaCorreta = 2;
        Q95.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q95.nivelpergunta = 10;
        ListaQuestoes.Add(Q95);

        var Q96 = new Questao();
        Q96.Pergunta = "Em FNAF Ultimate Custom Night, quantos animatrônicos são jogáveis?";
        Q96.Resposta1 = "40";
        Q96.Resposta2 = "50";
        Q96.Resposta3 = "60";
        Q96.Resposta4 = "70";
        Q96.Resposta5 = "80";
        Q96.RespostaCorreta = 2;
        Q96.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q96.nivelpergunta = 10;
        ListaQuestoes.Add(Q96);

        var Q97 = new Questao();
        Q97.Pergunta = "Em FNAF Help Wanted, qual mini-jogo coloca o jogador dentro de um ventilador?";
        Q97.Resposta1 = "Vent Repair";
        Q97.Resposta2 = "Parts and Service";
        Q97.Resposta3 = "Night Terrors";
        Q97.Resposta4 = "Danger Keep Out";
        Q97.Resposta5 = "Pizza Party";
        Q97.RespostaCorreta = 1;
        Q97.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q97.nivelpergunta = 10;
        ListaQuestoes.Add(Q97);

        var Q98 = new Questao();
        Q98.Pergunta = "Quem é o personagem jogável em FNAF Security Breach?";
        Q98.Resposta1 = "Gregory";
        Q98.Resposta2 = "Vanessa";
        Q98.Resposta3 = "Freddy Fazbear";
        Q98.Resposta4 = "Glamrock Chica";
        Q98.Resposta5 = "Roxanne Wolf";
        Q98.RespostaCorreta = 1;
        Q98.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q98.nivelpergunta = 10;
        ListaQuestoes.Add(Q98);

        var Q99 = new Questao();
        Q99.Pergunta = "Quem é o antagonista secreto em FNAF 6?";
        Q99.Resposta1 = "Lefty";
        Q99.Resposta2 = "Molten Freddy";
        Q99.Resposta3 = "Scrap Baby";
        Q99.Resposta4 = "Afton";
        Q99.Resposta5 = "Circus Baby";
        Q99.RespostaCorreta = 4;
        Q99.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q99.nivelpergunta = 10;
        ListaQuestoes.Add(Q99);

        var Q100 = new Questao();
        Q100.Pergunta = "Qual personagem aparece na cena final de FNAF 6?";
        Q100.Resposta1 = "Molten Freddy";
        Q100.Resposta2 = "Scrap Baby";
        Q100.Resposta3 = "Lefty";
        Q100.Resposta4 = "Afton";
        Q100.Resposta5 = "Henry Emily";
        Q100.RespostaCorreta = 4;
        Q100.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q100.nivelpergunta = 10;
        ListaQuestoes.Add(Q100);



    }

    public void ProximaQuestao()
    {
        var NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        while(ListaQuestoesRespondidas.Contains(NumRandomico))
        NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
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