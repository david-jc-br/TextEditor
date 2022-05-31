class Program
{
    static void Main()
    {
        MenuLanguage();
    }

    static void MenuLanguage()
    {
        Console.Clear();
        Console.WriteLine(" Choose Language\n(Escolha o idioma)");
        Console.WriteLine("--------------------");
        Console.WriteLine("P - Portuguese\nE - English");
        Console.WriteLine("--------------------");

        char option = char.Parse(Console.ReadLine().ToLower());

        switch (option)
        {
            case 'p': MenuPortuguese(); break;
            case 'e': MenuEnglish(); break;
            default: MenuLanguage(); break;
        }
    }

    static void MenuPortuguese()
    {
        Console.Clear();
        Console.WriteLine("_____EDITOR DE TEXTO_____\n");
        Console.WriteLine("O que você deseja fazer?\n");
        Console.WriteLine("Opções:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1 - Abrir arquivo\n2 - Criar Arquivo\n3 - Mudar Idioma\n0 - Sair");
        ushort option = ushort.Parse(Console.ReadLine());

        switch(option)
        {
            case 0:
                Console.Clear();
                Console.WriteLine("\'Obrigado por usar o App\'");
                Environment.Exit(0);
                break;
            case 1: Open(0); break;
            case 2: Edit(0); break;
            case 3: MenuLanguage(); break;
            default: MenuPortuguese();break;
        }
    }

    static void MenuEnglish()
    {
        Console.Clear();
        Console.WriteLine("_______TEXT EDITOR_______\n");
        Console.WriteLine("What do you want to do?\n");
        Console.WriteLine("Options:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1 - Open File\n2 - Create File\n3 - Change Language\n0 - Exit");
        ushort option = ushort.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: 
                Console.Clear();
                Console.WriteLine("\'Thanks for using the App\'");
                Environment.Exit(0); 
                break;
            case 1: Open(); break;
            case 2: Edit(); break;
            case 3: MenuLanguage(); break;
            default: MenuEnglish(); break;
        }
    }

    static void Edit(int typeLanguage = (int)ELanguage.English)
    {
        Console.Clear();

        if(typeLanguage == 0)
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        else 
            Console.WriteLine("Type your text below (ESC to exit)");

        Console.WriteLine("-------------------------------------\n->");

        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        if (typeLanguage == 0)
        {
            Console.Clear();
            Console.WriteLine("Salving changes...");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Saved changes...");
            Thread.Sleep(1500);
            MenuEnglish();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Salvando alterções...");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Alterações salvas...");
            Thread.Sleep(1500);
            MenuPortuguese();
        }
    }

    static void Open(int typeLanguage = (int)ELanguage.English)
    {


    }

    enum ELanguage
    {
        Portugues = 0,
        English = 1
    }

}
