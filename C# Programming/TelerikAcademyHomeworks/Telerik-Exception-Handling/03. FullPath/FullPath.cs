
namespace _03.FullPath
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Security;

    class FullPath
    {
        static void Main()
        {
            Console.Write("Enter the full path of the file you want to read: ");
            string filePath = Console.ReadLine();
            ReadFile(filePath);
        }

        static void ReadFile(string filePath)
        {
            try
            {
                filePath = File.ReadAllText(filePath);
                Console.WriteLine(filePath);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (PathTooLongException ptl)
            {
                Console.WriteLine(ptl.Message);
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
