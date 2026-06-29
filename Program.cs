static void ShowMenu() // Выводим меню
{
    Console.WriteLine("CP 1");
    Console.WriteLine("1. Найти по айди\n2. Найти по Class\n3. Найти по Tag\n0. Выход");
    Console.WriteLine("Выбери пункт: ");
}


string html = File.ReadAllText("page.html"); // Сохраняем страницу в переменную html\

static void SearchById(string html, string id) // Ищем по ID
{
    if (html.Contains($"id=\"{id}\"")) // Ищем есть ли в html элемент с указанным ID
    {
        Console.WriteLine("ID найден");
    }
    else
    {
        Console.WriteLine("ID не найден");
    }
}


static void SearchByClass(string html, string className) // Ищем по Class
{
    if (html.Contains($"class=\"{className}\""))
    {
        Console.WriteLine("Class найден");
    }
    else
    {
        Console.WriteLine("Class не найден");
    }
}

static void SearchByTag(string html, string tag)
{
    int count = 0;

    int index = html.IndexOf($"<{tag}");
    while (index != -1)
    {
        count++;
        index = html.IndexOf($"<{tag}", index + 1);
    }
    Console.WriteLine($"Tag найден {count} раз");
}


while (true)
{
    ShowMenu();
    string choice = Console.ReadLine();


    switch (choice)
        {
            case "1":
                Console.WriteLine("Введите ID: ");
                string id = Console.ReadLine();
                SearchById(html, id); // поиск по ID
                break;


            case "2":
                Console.WriteLine("Введите Class: ");
                string className = Console.ReadLine();
                SearchByClass(html, className); // поиск по Class
                break;


            case "3":
                Console.WriteLine("Введите Tag: ");
                string tag = Console.ReadLine();
                SearchByTag(html, tag); // поиск по Tag
                break;


            case "0":
                Console.WriteLine("Выход из программы.");
                return;


            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                break;
        }
        Console.WriteLine();
}


//github