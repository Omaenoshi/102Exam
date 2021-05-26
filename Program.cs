using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFolder = new Folder("Первая", null);
            var secondFolder = new Folder("Вторая", firstFolder);
            firstFolder.AddFolder(secondFolder);
            var currentFolder = firstFolder;
            var painter = new Painter();
            painter.Paint(currentFolder);
            Console.WriteLine("Нажмите кнопку для продолжения (выход -  Esc)");
            while(ConsoleKey.Escape.ToString()!=Console.ReadKey().ToString())
            {
                Console.WriteLine("Введите комманду!");
                var command = Console.ReadLine();
                switch(command)
                {
                    case "cd.":
                        if(currentFolder.ParentFolder==null)
                            throw new Exception("Нет такой папки!");
                        currentFolder = currentFolder.ParentFolder;
                        painter.Paint(currentFolder);
                        break;
                    case "cd":
                        var folder = Console.ReadLine();
                        if (!currentFolder.NamesFolders.Contains(folder))
                            throw new Exception("Нет такой папки!"); ;
                        currentFolder = currentFolder.GoDown(new Folder("sdas", currentFolder));
                        painter.Paint(currentFolder);
                        break;
                    case "add file":
                        Console.WriteLine("Введите файл: ");
                        var fileA = Console.ReadLine();
                        Console.WriteLine("Введите формат: ");
                        var formatA = Console.ReadLine();
                        currentFolder.AddFile(new File(fileA, formatA, currentFolder));
                        painter.Paint(currentFolder);
                        break;
                    case "delete file":
                        Console.WriteLine("Введите файл: ");
                        var fileD = Console.ReadLine();
                        Console.WriteLine("Введите формат: ");
                        var formatD = Console.ReadLine();
                        currentFolder.RemoveFile(new File(fileD, formatD, currentFolder));
                        painter.Paint(currentFolder);
                        break;
                }
            }
        }
    }
}
