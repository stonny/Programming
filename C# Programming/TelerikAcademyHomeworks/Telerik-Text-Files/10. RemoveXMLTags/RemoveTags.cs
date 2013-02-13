// Write a program that extracts from given XML file all the text without the tags. 
namespace _10.RemoveXMLTags
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Xml;
    using System.Text;

    class RemoveTags
    {
        static void Main(string[] args)
        {

            using (XmlReader xmlr = XmlReader.Create(new StreamReader("../../input.xml")))
            {
                while (!xmlr.EOF)
                {
                    using (StreamWriter sw = new StreamWriter("../../output.txt"))
                    {
                        while (!xmlr.EOF)
                        {
                            xmlr.Read();
                            if (xmlr.NodeType == XmlNodeType.Text)
                            {
                                sw.WriteLine(xmlr.Value);
                            }
                        }
                    }
                }

            }
        }
    }
}