class FileOperations
{
    string filename;
    string rootFolder = @"E:\C# projects\BroadwayInfosys\dotnet-training\dotnet-training-santosh\TextFiles";

    //@ is a verbatim character
    public void LearnFileOperations()
    {
        //Create text file containing text "Hello World"
        string filePath = $"{rootFolder}\\test.txt";
        File.WriteAllText(filePath, "Hello World");
        Console.WriteLine("File Successfully Created");
        string newDirPath = @$"{rootFolder}\testFolder";
        Directory.CreateDirectory(newDirPath);

        //Create a folder with nam "A" somewhere and creata a text file a.file inside A
        string newDirName = @$"{rootFolder}\A";
        CheckIfDirExists(newDirName);
        string newFilePath = @$"{newDirName}\a.file";
        File.WriteAllText(newFilePath, "Contents inside a.file");

        //Create 10 folders with names Folder 1,Folder 2, Folder 3,...10
        for (int i = 1; i <= 10; i++)
        {
            CheckIfDirExists(@$"{rootFolder}\\Folder {i}");
        }
    }

    public void CheckIfDirExists(string dirName)
    {
        //Create a new directory if the directory does not exists
        if (Directory.Exists(dirName) == false)
        {
            Directory.CreateDirectory(dirName);
        }
    }

}