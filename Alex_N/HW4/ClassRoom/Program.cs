using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoomOne = new ClassRoom();
            Start();

            void Start()
            {
                Console.Clear();
                Console.WriteLine("Опции: \n1. Добавить зрачок.\n2. Инфа по зрачкам");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddPupil();
                        break;
                    case "2":
                        ShowInfo();
                        break;
                    default:
                        break;
                }
            }

            void ShowInfo()
            {

                classRoomOne.ClassRoomInfo();
                Console.ReadLine();
                Start();

            }

            void AddPupil()
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите Имя и пять параметров(Смекалка, Бодрость, Эмоциональное состояние, Физическое состояние, Самооценка) пожалуйста:");
                    classRoomOne.addPupil((new Pupil(Console.ReadLine(), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()))));
                    classRoomOne.Identify();

                    Console.WriteLine("Еще?\n 1: ДА\n 2: НЕ...");
                }
                while (Console.ReadKey().Key != ConsoleKey.D2);

                Start();

            }


            Console.ReadLine();

        }
    }
}
