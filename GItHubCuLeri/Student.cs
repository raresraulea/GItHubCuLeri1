namespace GItHubCuLeri
{
    internal class Student
    {
        private int age;
        public Student()
        {
            this.age = -1;
        }
        public Student(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}