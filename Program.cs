using cs_lab2;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("выбери задание для выполнения:");
            Console.WriteLine("1. имена");
            Console.WriteLine("2. человек с именем");
            Console.WriteLine("3. города");
            Console.WriteLine("4. создаем имена");
            Console.WriteLine("5. кот мяукает");
            Console.WriteLine("0. выход");

            Console.Write(">> ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Name cleopatra0 = new Name("", "Клеопатра", "");
                    Name pushkin0 = new Name("Пушкин", "Александр", "Сергеевич");
                    Name mayakovsky0 = new Name("Маяковский", "Владимир", "");
                    Console.WriteLine(cleopatra0.ToString());
                    Console.WriteLine(pushkin0.ToString());
                    Console.WriteLine(mayakovsky0.ToString());
                    break;
                case 2:
                    PersonWithName cleopatra1 = new PersonWithName(new Name("", "Клеопатра", ""), 152);
                    PersonWithName pushkin1 = new PersonWithName(new Name("Пушкин", "Александр", "Сергеевич"), 167);
                    PersonWithName mayakovsky1 = new PersonWithName(new Name("Маяковский", "Владимир", ""), 189);
                    Console.WriteLine(cleopatra1.ToString());
                    Console.WriteLine(pushkin1.ToString());
                    Console.WriteLine(mayakovsky1.ToString());
                    break;
                case 3:
                    City A = new City("A");
                    City B = new City("B");
                    City C = new City("C");
                    City D = new City("D");
                    City E = new City("E");
                    City F = new City("F");

                    A.add(D, 6);
                    A.add(F, 1);
                    A.add(B, 5);

                    B.add(A, 5);
                    B.add(C, 3);

                    C.add(B, 3);
                    C.add(D, 4);

                    D.add(A, 6);
                    D.add(E, 2);
                    D.add(C, 4);

                    E.add(F, 2);

                    F.add(B, 1);
                    F.add(E, 2);

                    Console.WriteLine(A.ToString());
                    Console.WriteLine(B.ToString());
                    Console.WriteLine(C.ToString());
                    Console.WriteLine(D.ToString());
                    Console.WriteLine(E.ToString());
                    Console.WriteLine(F.ToString());
                    break;

                case 4:
                    CreatingNames cleopatra2 = new CreatingNames("Клеопатра");
                    CreatingNames pushkin2 = new CreatingNames("Александр", "Пушкин", "Сергеевич");
                    CreatingNames mayakovsky2 = new CreatingNames("Владимир", "Маяковский");
                    CreatingNames christopher = new CreatingNames("Христофор", "Бонифатьевич");
                    Console.WriteLine(cleopatra2.ToString());
                    Console.WriteLine(pushkin2.ToString());
                    Console.WriteLine(mayakovsky2.ToString());
                    Console.WriteLine(christopher.ToString());
                    break;

                case 5:
                    Cat barsik = new Cat("Барсик");
                    Console.WriteLine(barsik.ToString());
                    barsik.Meow();
                    barsik.Meow(3);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("неверный выбор");
                    break;
            }
            Console.WriteLine("\nнажми любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }
    }
}