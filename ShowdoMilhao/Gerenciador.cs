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
        Q1.Resposta1 = "";
        Q1.Resposta2 = "";
        Q1.Resposta3 = "";
        Q1.Resposta4 = "1987";
        Q1.Resposta5 = "";
        Q1.Desenhar(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
        ListaQuestoes.Add(Q1);
    }

    public void ProximaQuestao()
    {
        var NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count);
        While(ListaQuestoesRespondidas.Contains(NumRandomico));
        NumRandomico = Ramdom.Shared.Next(0, ListaQuestoes.Count);
        ListaQuestoesRespondidas.Add(NumRandomico);
        QuestaoCorrente = ListaQuestoes[NumRandomico];
        QuestaoCorrente.Desenhar();
    }

    public async void 
}