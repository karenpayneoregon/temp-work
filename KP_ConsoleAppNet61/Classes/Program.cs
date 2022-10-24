using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace KP_ConsoleAppNet61
{
    internal partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            AnsiConsole.MarkupLine("");
            Console.Title = "Work...";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }
    }
}
