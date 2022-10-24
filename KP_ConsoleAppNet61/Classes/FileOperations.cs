using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KP_ConsoleAppNet61.Classes;

public class FileOperations
{
    private const string OriginalFileName = "TextFile1.txt";

    public static void Read()
    {
        StringBuilder builder = new StringBuilder();
        List<string> list = new List<string>();

        var lines = File.ReadAllLines(OriginalFileName)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToArray();

        foreach (var line in lines)
        {
            var data = line.Split('|');
            foreach (var item in data)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    list.Add(item);
                }

            }
        }

        list.OrderBy(x => x);

        File.WriteAllLines("000.txt", list.ToArray());

        foreach (var item in list)
        {
            builder.Append($"{item}|");
        }

        File.WriteAllText("111.txt", builder.ToString());

    }
}