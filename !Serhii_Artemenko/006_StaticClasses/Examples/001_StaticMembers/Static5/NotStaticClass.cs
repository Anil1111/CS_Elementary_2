﻿using System;

// Статический конструктор.

// Статические конструкторы обладают следующими свойствами:
// 1. Статический конструктор не имеет модификаторов доступа и не принимает параметров.
// 2. Статический конструктор вызывается автоматически для инициализации класса перед созданием первого экземпляра
//    или ссылкой на какие-либо статические члены. 
// 3. Статический конструктор нельзя вызывать напрямую.
// 4. Пользователь не управляет тем, когда статический конструктор выполняется в программе.
// 5. Типичным использованием статических конструкторов является случай, когда класс использует файл журнала и
//    конструктор применяется для добавления записей в этот файл.

namespace Static
{
    class NotStaticClass
    {
        // Статические поля readonly должны быть инициализированы в конструкторе.
        static readonly long readonlyField = 2;

        // Статическое свойство только для чтения.
        public static long ReadonlyField
        {
            get { return NotStaticClass.readonlyField; }
        }

        public NotStaticClass()
        {
            Console.WriteLine("NotStaticClass.Ctor");
        }

        // Статический конструктор.        
        static NotStaticClass()
        {
            Console.WriteLine("NotStaticClass.StaticCtor");
            readonlyField = 1;
        }
    }
}
