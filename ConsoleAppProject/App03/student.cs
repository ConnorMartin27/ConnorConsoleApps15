namespace ConsoleAppProject.App03
{
    public class Student
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public int Mark { get; set; }
            
        public Student(int id, string name = "UNNAMED", int mark = 0)
        {
            Name = name;
            Id = id;
            Mark = mark;
        }


            
    }
}