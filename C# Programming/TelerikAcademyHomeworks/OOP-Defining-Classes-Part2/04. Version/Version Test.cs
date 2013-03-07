using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class VersionTest
{
    [Version("12.6", "New features")]
    private static void ProjectButter()
    {

    }

    [Version("6.67", "The entry point.")]
    static void Main()
    {
        Type type = typeof(VersionTest);

        object[] customAttributes = type.GetCustomAttributes(false);

        if (customAttributes.Length > 0)
        {
            Console.WriteLine("This class has v.{0} / \"{1}\"",
                (customAttributes[0] as VersionAttribute).Version,
                (customAttributes[0] as VersionAttribute).Comment);
        }

        MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

        foreach (MethodInfo method in methods)
        {
            object[] methodAttributes = method.GetCustomAttributes(false);

            if (methodAttributes.Length > 0 && methodAttributes[0] is VersionAttribute)
            {
                Console.WriteLine("Method  \"{0}\" v.{1} / \"{2}\"",
                    method.Name,
                    (methodAttributes[0] as VersionAttribute).Version,
                    (methodAttributes[0] as VersionAttribute).Comment);
            }
        }
    }
}