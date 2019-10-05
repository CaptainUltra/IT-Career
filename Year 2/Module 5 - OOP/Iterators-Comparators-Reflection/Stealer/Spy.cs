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
.000000000.0
            for (int i = 0; i < inputFields.Length; i++)
            {
                var currentField = type.GetField(inputFields[i], BindingFlags.Public |
                 BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
                var value = currentField.GetValue()
            }

        }
    }
}