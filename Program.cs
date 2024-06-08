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
Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for (int m = 0; m < 5; m++)
{
    while (true)
    {
        Console.WriteLine($"{jogadores} jogador(es) selecionados. Adicionar o Top # ");
        int jogadorselecionado = Convert.ToInt32(Console.ReadLine());

        jogadorselecionado--;

        if (jogadorselecionado < 0 || jogadorselecionado >= 20)
        {
            Console.WriteLine("jogador não encontrado.");
            continue;
        }

        int[] atleta = new int[5];

        bool selecionado = false;
        for (int anterior = 0; anterior < jogadorselecionado; anterior++)
        {
            selecionado = atleta[anterior] == jogadorselecionado;

            if (selecionado) break;
        }

        if (selecionado)
        {
            Console.WriteLine("Esse Atleta Já pertence ao seu time."); continue;
        }

        atleta[m] = jogadorselecionado;
        break;

        Array.Sort(atleta);

        Console.WriteLine("/nseu time dos sonhos é/n");

    }

}