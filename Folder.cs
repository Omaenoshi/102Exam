using System.Collections.Generic;

namespace ConsoleApp51
{
    class Folder
    {
        public List<File> Files { get; private set; }

        public List<Folder> Folders { get; private set; }

        public List<string> NamesFolders { get; private set; }

        public Folder ParentFolder { get; private set; }

        public string Name { get; private set; }

        public Folder(string name, Folder parentFolder)
        {
            Name = name;
            ParentFolder = parentFolder;
            Files = new List<File>();
            Folders = new List<Folder>();
            NamesFolders = new List<string>();
        }

        public void AddFile(File file)
        {
            Files.Add(file);
        }

        public void AddFolder(Folder folder)
        {
            Folders.Add(folder);
            NamesFolders.Add(folder.Name);
        }

        public bool RemoveFile(File file)
        {
            var flag = false;
            for (int i = 0; i < Files.Count; i++)
            {
                if (Files[i].Name == file.Name)
                {
                    Files.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public bool RemoveFolder(Folder folder)
        {
            var flag = false;
            for (int i = 0; i < Folders.Count; i++)
            {
                if (Folders[i].Name == folder.Name)
                {
                    Folders.RemoveAt(i);
                    NamesFolders.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public Folder GoDown(Folder folder)
        {
            return folder;
        }

        public string GoDownFile(File file)
        {
            return file.Name + file.Format;
        }
    }
}
