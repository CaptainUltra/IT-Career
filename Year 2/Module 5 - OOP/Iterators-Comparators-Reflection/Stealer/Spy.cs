using System;
using System.Text;
using System.Reflection;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] inputFields)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {className}");

            var type = typeof(Hacker);
            var hackerInstance = Activator.CreateInstance(type);
<<<<<<< HEAD
=======
.000000000.0
>>>>>>> 66c5fe4852bf453936367f34110c7fd785447eac
            for (int i = 0; i < inputFields.Length; i++)
            {
                var currentField = type.GetField(inputFields[i], BindingFlags.Public |
                 BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
<<<<<<< HEAD
                var value = currentField.GetValue();
=======
                var value = currentField.GetValue()
>>>>>>> 66c5fe4852bf453936367f34110c7fd785447eac
            }

        }
    }
}