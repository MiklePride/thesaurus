class program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> thesaurus = new Dictionary<string, string>();
        thesaurus.Add("Стул", "Необходимая часть интерьера. Обычно их два на выбор...");
        thesaurus.Add("Алкаш", "Мистическое животное, как правило сосед.");
        thesaurus.Add("Чиновник", "Существо, имитирующее человека, оперирует мутными фразами, честность до сих пор не обнаружена.");
        thesaurus.Add("Экстримист", "Человек, выражающий своё недовольство по отношению к чиновникам и действующей власти.");

        SearchMeaningOfWorld(thesaurus);
    }

    static void SearchMeaningOfWorld(Dictionary<string, string> dictionary)
    {
        bool isOpenSearch = true;

        while (isOpenSearch)
        {
            Console.WriteLine("Введите слово, чтобы найти значение:");
            string userInput = Console.ReadLine();

            if (dictionary.ContainsKey(userInput))
            {
                Console.WriteLine($"{userInput} - {dictionary[userInput]}");
                isOpenSearch = false;
            }
            else
            {
                Console.WriteLine("В словаре такого слова нет!");
            }
        }
    }
}