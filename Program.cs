string[] lista = {
    "Michael Jordan (Armador)",
    "LeBron James (Ala)",
    "Kareem Abdul Jabbar (Pivô)",
    "Magic Johnson (Armador)",
    "Wilt Chamberlain (Pivô)",
    "Bill Russell (Pivô)",
    "Larry Bird (Ala)",
    "Tim Duncan (Ala-pivô)",
    "Oscar Robertson (Armador)",
    "Kobe Bryant (Armador)",
    "Shaquille O’Neal (Pivô)",
    "Kevin Durant (Ala)",
    "Hakeem Olajuwon (Pivô)",
    "Julius Erving (Ala)",
    "Moses Malone (Pivô)",
    "Stephen Curry (Armador)",
    "Dirk Nowitzki (Ala-pivô)",
    "Giannis Antetokounmpo (Ala-pivô)",
    "Jerry West (Armador)",
    "Elgin Baylor (Ala)",

};

Console.Clear();
Console.Write("---Dream Team da NBA---\n");
Console.WriteLine("");

int[] jogadores = new int[5];

Console.WriteLine("Os 20 Melhores Jogadores da NBA de Todos os Tempos\n");
for (int m = 0; m < 20; m++)
{
    Console.WriteLine($"{m + 1,2} - {lista[m]}");
}

Console.WriteLine("");
Console.Write("0 jogador(es) selecionados. Adicionar o Top # ");
int quantidadeJogador = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[] time = new int[quantidadeJogador];

for (int m = 0; m < quantidadeJogador; m++)
{
    while (true)
    {
        
        Console.Write("Selecione um jogador: ");
        int jogadorselecionado = Convert.ToInt32(Console.ReadLine());
        
        if (time.ToList().Any(f => f == jogadorselecionado))
        {
            Console.WriteLine("Esse Atleta Já pertence ao seu time."); continue;
        }

        if (jogadorselecionado < 1 || jogadorselecionado > 20)
        {
            Console.WriteLine("jogador não encontrado.");
            continue;
        }        

        Console.WriteLine($"{lista[jogadorselecionado - 1]} jogador selecionado, adicionado ao Top #{quantidadeJogador} ");

        time[m] = jogadorselecionado;
              
        Console.WriteLine($"\nseu time dos sonhos é\n");

        List<int> timeList = time.ToList(); //converte a matriz em lista
        timeList.Sort(); //ordena a lista
        timeList.FindAll(t => t > 0) // Busca todos os jogadores já adicionados
                .ForEach(t => Console.WriteLine($"\t{t} - {lista[t-1]}"));    //Exibe cada (Foreach) elemento (t)

        break;
    }

}

Console.Write("\nPressione uma tecla para finalizar...");
Console.ReadKey();

Console.WriteLine();
