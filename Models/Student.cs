using System;
using BaiTap1.Utils;

namespace BaiTap1.Models
{
    public class Student : Person 
    {
        public string Major { get; set; } = string.Empty;
        public double GPA { get; set; }

        private string _id = Guid.NewGuid().ToString();
        public string ID
        {
            get { return _id; }

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}, Major: {Major}, GPA: {GPA}");
        }
    }
}