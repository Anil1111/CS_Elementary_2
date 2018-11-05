using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

namespace Task2
{
    [System.Serializable]
    public class ThisException : Exception
    {
        public ThisException()
        {

        }
        
        //класс должен определять конструктор, который устанавливает значение унаследованного
        public ThisException(string thisMessage) : base(thisMessage) { }

        //конструктор для обработки внутренних иссключений
        public ThisException(string thisMessage, Exception inner)
        {
                
        }
        //конструктор для поддержки сериализации типа
        public ThisException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

}
