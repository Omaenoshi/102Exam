namespace ConsoleApp51
{
    class File
    {
        public string Name { get; private set; }

        public string Format { get; private set; }

        public Folder ParentFolder { get; private set; }

        public File(string name, string format, Folder parentFolder)
        {
            ParentFolder = parentFolder;
            Name = name;
            Format = format;
        }
    }
}
