namespace HW4Task2
{
    public abstract class Pupil
    {
        string firstName;
        string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
        public abstract void print();

    }
}
