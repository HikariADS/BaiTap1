﻿using System;
using System.Collections.Generic;
using System.Linq;
using BaiTap1.Models;
using BaiTap1.Utils;

namespace BaiTap1
{
    class Program
    {
        static void Main()
        {
            // 🔸 Tạo logger để ghi log ra file
            ILogger logger = new Logger();

            // 🔸 Danh sách sinh viên
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Khôi", Age = 21, Major = "BCSE", GPA = 3.8 },
                new Student { Name = "Quang", Age = 22, Major = "BCSE", GPA = 3.2 },
                new Student { Name = "Tùng", Age = 21, Major = "BCSE", GPA = 3.9 },
                new Student { Name = "Hải Anh", Age = 23, Major = "Struc", GPA = 3.5 }
            };

            try
            {
                // 🔹 LINQ: lọc sinh viên giỏi (GPA >= 3.5)
                var excellent = students.Where(s => s.GPA >= 3.5).Select(s => s.Name);

                Console.WriteLine(" Sinh viên giỏi:");
                foreach (var name in excellent)
                    Console.WriteLine($"- {name}");

                // 🔹 LINQ: nhóm theo ngành
                var groups = students.GroupBy(s => s.Major);

                Console.WriteLine("\n Nhóm sinh viên theo ngành:");
                foreach (var group in groups)
                {
                    Console.WriteLine($"Ngành {group.Key}:");
                    foreach (var s in group)
                        Console.WriteLine($"   - {s.Name} ({s.GPA})");
                }

                // 🔹 Tính GPA trung bình bằng LINQ
                double avgGPA = students.Average(s => s.GPA);
                Console.WriteLine($"\n GPA trung bình: {avgGPA:F2}");

                // 🔹 Ghi log
                logger.Log("Chạy chương trình thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Lỗi: {ex.Message}");
                logger.Log("Lỗi: " + ex.Message);
                throw; // 🔹 throw new Exception để ném lỗi tiếp
            }
        }
    }
}
