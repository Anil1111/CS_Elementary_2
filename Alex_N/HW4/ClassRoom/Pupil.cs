using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class Pupil
    {
        private string name;
        private int savvy; //смекалка 
        private int cheerfulnes; //бодрость
        private int mentalCondition;//Эмоциональное состояние
        private int physicalCondition;//физическое состояние 
        private int selfEsteem;//самооценка

        public string Name { get { return name; } }
        public int Savvy { get { return savvy; } }
        public int Cheerfulnes { get { return cheerfulnes; } }
        public int MentalCondition { get { return mentalCondition; } }
        public int PhysicalCondition { get { return physicalCondition; } }
        public int SelfEsteem { get { return selfEsteem; } }

        public Pupil() { }//по умолчанию
        public Pupil(string name, int savvy, int mentalCondition, int cheerfulnes, int physicalCondition, int selfEsteem)
        {
            this.name = name;
            this.savvy = savvy;
            this.mentalCondition = mentalCondition;
            this.cheerfulnes = cheerfulnes;
            this.physicalCondition = physicalCondition;
            this.selfEsteem = selfEsteem;
        }

        private double Analisation()
        {
            double result = 0;

            result = (savvy + cheerfulnes + mentalCondition + physicalCondition + selfEsteem) / 100;//среднее

            return result;
        }

        public double coef { get { return Analisation(); } }

        public string Info { get { return $"Имечко: {name}\nСмекалка: {savvy}\nБодрость: {cheerfulnes}\nЭмоциональное состояние: {mentalCondition}\nФизическое состояние: {physicalCondition}\nСамооценка: {selfEsteem}"; } }

        public virtual string Description()
        {
            return "Это базовый ученик со сбалансированными идеально параметрами";
        }



    }
}
