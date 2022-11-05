Menu();

//Console.WriteLine(nameof(RetornaValorDigitado).ToLower());

static string RetornaValorDigitado(short telaRetorno = 7)
{
    //Ler do console
    var valorDigitado = Console.ReadLine() ?? string.Empty;

    // if(valorDigitado.ToUpper() == "MENU")
    //     Menu();

    // if(valorDigitado.ToLower() == "menu")
    //     Menu();

    if(valorDigitado.ToUpper() == nameof(Menu).ToUpper())
        Menu();

    if(valorDigitado.ToUpper() == nameof(Soma).ToUpper())
        Soma();    
    
    if(valorDigitado.ToUpper() == nameof(Divisao).ToUpper())
        Divisao();

    if(valorDigitado.ToUpper() == nameof(Multiplicacao).ToUpper())
        Multiplicacao();
    
     if(valorDigitado.ToUpper() == nameof(Subtracao).ToUpper())
        Subtracao();
    
    //Verificar valor
    // if(string.IsNullOrEmpty(valorDigitado) || valorDigitado.Length != 1 || !Char.IsNumber(char.Parse(valorDigitado))){
    //   ExibirMensagem("Valor digitado incorreto.");
    // } 

    // if(!char.TryParse(valorDigitado, out var valorDigitadoChar) || !Char.IsNumber(valorDigitadoChar)){
    //   ExibirMensagem("Valor digitado incorreto.");
    // } 

    if(!float.TryParse(valorDigitado, out var x)){
      ExibirMensagem("Valor digitado incorreto.",telaRetorno);
    } 

    //retornar o valor
    return valorDigitado;


}

static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Divisao");
    Console.WriteLine("4 - Multiplicacao");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("---------------------");
    Console.WriteLine("Selecione uma opção:");

    var valorDigitado = RetornaValorDigitado();
    short res = short.Parse(valorDigitado);

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("-------SOMAR-------\n");

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(RetornaValorDigitado(1));
    
    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(RetornaValorDigitado(1));

    Console.WriteLine("");

    Loading("Calculando",30);

    Console.WriteLine("");

    float resultado = v1 + v2;
    Console.WriteLine("Resultado da  Soma: " + resultado);
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

     Console.WriteLine("-------SUBTRAIR-------\n");

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(RetornaValorDigitado(2));

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(RetornaValorDigitado(2));

    Console.WriteLine("");

    Loading("Calculando",30);

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine("Resultado da subtracao: " + resultado);
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("-------DIVIDIR-------\n");
    
    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(RetornaValorDigitado(3));

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(RetornaValorDigitado(3));

    Console.WriteLine("");

    Loading("Calculando",30);

    Console.WriteLine("");

    float resultado = v1 / v2;
    Console.WriteLine("Resultado da subtracao: " + resultado);
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("-------MULTIPLICAR-------\n");

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(RetornaValorDigitado(4));

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(RetornaValorDigitado(4));

    Console.WriteLine("");

    Loading("Calculando",30);
    
    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine("Resultado da subtracao: " + resultado);
    Console.ReadKey();
    Menu();
}

static void ExibirMensagem(string mensagem, short telaRetorno = 7)
{
    Console.Clear();
    Console.WriteLine("#####################ATENÇÃO######################");
    Console.WriteLine();
    Console.WriteLine(mensagem);
    Console.WriteLine();
    Console.WriteLine("##################################################");

    Loading();

    switch (telaRetorno)    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Loading(string mensagem = "Voltando", int tempo = 50)
{
    Console.WriteLine();
    Console.WriteLine(mensagem);
    var controle = 0;
    while (controle < tempo)
    {
        Console.Write(".");
        Thread.Sleep(100);
        controle++;
    }
}

