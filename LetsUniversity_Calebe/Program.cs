using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace LetsUniversity_Calebe
{
    class Program 
    {

        public static void DisplayPublicProperties(object student)
        {
            PropertyInfo[] propertyInfos = student.GetType().GetProperties();
            foreach(var propertyInfo in propertyInfos)
            {
                Console.WriteLine($"Atributo: {propertyInfo.Name}, do tipo: {propertyInfo.PropertyType.Name}");
            }
        }
        
        
        public static object CreateInstance()
        {
            var student = Activator.CreateInstance<Student>();

            PropertyInfo[] propertyInfos = student.GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (propertyInfo.Name == "Name")
                {
                    propertyInfo.SetValue(student, "João Alfredo");
                }

                if (propertyInfo.Name == "University")
                {
                    propertyInfo.SetValue(student, "Harvard");
                }

                if (propertyInfo.Name == "RollNumber")
                {
                    propertyInfo.SetValue(student, 1243253);
                }
            }

            return student;
        }

        public static void DisplayInfo(object student)
        {
            PropertyInfo[] propertyInfos = student.GetType().GetProperties();

            foreach(var propertyInfo in propertyInfos)
            {
                Console.WriteLine($"{propertyInfo.Name} = '{propertyInfo.GetValue(student)}'.");
            }
        }
        
        public static void Main(string[] args)
        {
            DisplayPublicProperties(CreateInstance());
            
            DisplayInfo(CreateInstance());
        }
    }
}