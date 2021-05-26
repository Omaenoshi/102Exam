using System;

namespace ConsoleApp51
{
    class Painter
    {
        public void Paint(Folder folder)
        {
            Console.Clear();
            Console.WriteLine("Файлы: ");
            foreach (var item in folder.Files)
            {
                Console.WriteLine(item.Name + "." + item.Format);
            }
            Console.WriteLine("Папки: ");
            foreach (var item in folder.Folders)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
