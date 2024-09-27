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

        var Q34 = new Questao();
        Q34.Pergunta = "Quandos dentes tem o nightmare Nightmare?";
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
        Q36.Pergunta = "Qual o nome da filha do Henry Emily";
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
        Q37.Pergunta = "Por que o withered foxy de mata mesmo estande mascara?";
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
        Q38.Pergunta = "Que horas o jogo acaba";
        Q38.Resposta1 = "1 hora da manhã";
        Q38.Resposta2 = "3 horas da manhã";
        Q38.Resposta3 = "meia noite";
        Q38.Resposta4 = "6 horas da manhã";
        Q38.Resposta5 = "Nunca acaba";
        Q38.RespostaCorreta = 4;
        Q38.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q38.nivelpergunta = 4;
        ListaQuestoes.Add(Q38);

        var Q39 = new Questao();
        Q39.Pergunta = "De onde veio o jumpscare de fnaf";
        Q39.Resposta1 = "De outro jogo";
        Q39.Resposta2 = "De uma serie";
        Q39.Resposta3 = "De um filme";
        Q39.Resposta4 = "De um anime";
        Q39.Resposta5 = "Por crianças";
        Q39.RespostaCorreta = 3;
        Q39.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q39.nivelpergunta = 4;
        ListaQuestoes.Add(Q39);

        var Q40 = new Questao();
        Q40.Pergunta = "Quandas portas de o quarta da criança chorona";
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
        Q41.Pergunta = "Qual o nome do recordisda mundial de Fnaf 1 até o dia 25/09/2024";
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
        Q42.Pergunta = "Qual o nome do assacino de fnaf";
        Q42.Resposta1 = "William Cafita";
        Q42.Resposta2 = "Wiliiam Pai de Familha";
        Q42.Resposta3 = "William Arnaldo";
        Q42.Resposta4 = "William Frids";
        Q42.Resposta5 = "William Afton";
        Q42.RespostaCorreta = 5;
        Q42.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q42.nivelpergunta = 5;
        ListaQuestoes.Add(Q42);

        var Q43 = new Questao();
        Q43.Pergunta = "Qual o nome da ferramenta usada para criar fnaf 1";
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
        Q44.Pergunta = "Qual fala que o Golden Freddy sempre diz?";
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
        Q45.Pergunta = "Quem é que fala 'I always come back'";
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
        Q46.Pergunta = "O do animatronic que é o rosdo da Fazbear";
        Q46.Resposta1 = "Freddy";
        Q46.Resposta2 = "Help";
        Q46.Resposta3 = "Bonnie";
        Q46.Resposta4 = "Um urso aleatorio";
        Q46.Resposta5 = "Wiilam Afton";
        Q46.RespostaCorreta = 2;
        Q46.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q46.nivelpergunta = 5;
        ListaQuestoes.Add(Q46);

        var Q47 = new Questao();
        Q47.Pergunta = "Qual o nome do primeiro Youtuber br a passar o 50/20 da UCN";
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
        Q48.Pergunta = "Qual o nome da fangame de fnaf em que o animatronic principal é um gato";
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
        Q49.Pergunta = "Qual a fangame de fnaf em que nôs controla o scott cawthon";
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
        Q50.Pergunta = "Qual a fangame em que o vilão é um ovo";
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
        Q54.Pergunta = "";
        Q54.Resposta1 = "";
        Q54.Resposta2 = "";
        Q54.Resposta3 = "";
        Q54.Resposta4 = "";
        Q54.Resposta5 = "";
        Q54.RespostaCorreta = 4;
        Q54.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q54.nivelpergunta = 6;
        ListaQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.Pergunta = "";
        Q55.Resposta1 = "";
        Q55.Resposta2 = "";
        Q55.Resposta3 = "";
        Q55.Resposta4 = "";
        Q55.Resposta5 = "";
        Q55.RespostaCorreta = 4;
        Q55.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q55.nivelpergunta = 6;
        ListaQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.Pergunta = "";
        Q56.Resposta1 = "";
        Q56.Resposta2 = "";
        Q56.Resposta3 = "";
        Q56.Resposta4 = "";
        Q56.Resposta5 = "";
        Q56.RespostaCorreta = 4;
        Q56.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q56.nivelpergunta = 6;
        ListaQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.Pergunta = "";
        Q57.Resposta1 = "";
        Q57.Resposta2 = "";
        Q57.Resposta3 = "";
        Q57.Resposta4 = "";
        Q57.Resposta5 = "";
        Q57.RespostaCorreta = 4;
        Q57.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q57.nivelpergunta = 6;
        ListaQuestoes.Add(Q57);

        var Q58 = new Questao();
        Q58.Pergunta = "";
        Q58.Resposta1 = "";
        Q58.Resposta2 = "";
        Q58.Resposta3 = "";
        Q58.Resposta4 = "";
        Q58.Resposta5 = "";
        Q58.RespostaCorreta = 4;
        Q58.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q58.nivelpergunta = 6;
        ListaQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.Pergunta = "";
        Q59.Resposta1 = "";
        Q59.Resposta2 = "";
        Q59.Resposta3 = "";
        Q59.Resposta4 = "";
        Q59.Resposta5 = "";
        Q59.RespostaCorreta = 4;
        Q59.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q59.nivelpergunta = 6;
        ListaQuestoes.Add(Q59);

        var Q60 = new Questao();
        Q60.Pergunta = "";
        Q60.Resposta1 = "";
        Q60.Resposta2 = "";
        Q60.Resposta3 = "";
        Q60.Resposta4 = "";
        Q60.Resposta5 = "";
        Q60.RespostaCorreta = 4;
        Q60.ConfiguraDesenho(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        Q60.nivelpergunta = 6;
        ListaQuestoes.Add(Q60);



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