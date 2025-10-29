namespace BaiTap1.Models
{
    public abstract class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public virtual void ShowInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}