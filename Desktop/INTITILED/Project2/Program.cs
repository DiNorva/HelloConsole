/*class Program
{
    static void Main(string[] args)
    {
        // тип [] название массива
        // int [] numbers = new int[4] {1,1,23,4};

        // int[] nums1 = new int[] {1,23,4,5};
        // int[] nims2 = new[] {1,23,4,5};
        int[] nums3 = {1,2,3,45,43,2,234,1,412,4,21,214,12,4,214,12,34};
        for(int i = 1; i < nums3.Length; i++)
        {
            nums3[i] = 0;
            Console.WriteLine(nums3[i]);
        }
    }        
}
*/

class Hero
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
    Dictionary<string,int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}


class Program
{
    static void SelectRase(Hero myHero)
    {
        string[] namesRase = {"Люди","Эльфы","Гномы","Орки","Гоблины"};
        Console.WriteLine("Выбери свою расу");
        Select(namesRase);
        string RaseHero = namesRase[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали Расу " + RaseHero);
        myHero.Rase = RaseHero;
    }   
    static void SelectSex(Hero myHero)
    {
        string[] namesSex = {"Женский","Мужской"};
        Console.WriteLine("Выбери свой пол");
        Select(namesSex);
        string SexHero = namesSex[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали пол " + SexHero);
        myHero.Sex = SexHero;
    }
    static void SelectClass(Hero myHero)
    {
        string[] namesClass = {"Воин","Разбойник","Маг","Вор"};
        Console.WriteLine("Выбери свой класс");
        Select(namesClass);
        string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        myHero.Class = ClassHero;
    }
    static void Select(string[] words)
    {
        for(int i = 0; i < words.Length-1; i++)
        {
            Console.Write(i+1 + " - " + words[i] + " ");
        }
        Console.Write(words.Length + " - " + words[words.Length - 1] + ".");
        Console.WriteLine("");
    }     

    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("Как вас зовут?");
        myHero.Name = Console.ReadLine();
        SelectRase(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Все наши хар-ки");
        Console.WriteLine("Ваше имя " + myHero.Name);
        Console.WriteLine("Ваше пол " + myHero.Sex);
        Console.WriteLine("Ваше раса " + myHero.Rase);
        Console.WriteLine("Ваше класс " + myHero.Class);
    }
}