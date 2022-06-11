using System.IO.Compression;

//CONSTANTS
const string PROGRAM_NAME = "ListAndUnzip";
string[] COMMAND_LIST = { "-l", "-e", "-ed" };
string[] commandLineArgs = Environment.GetCommandLineArgs();

//Console.WriteLine(commandLineArgs[0]);

verifyArgs(commandLineArgs);


void show_usage()
{
    Console.WriteLine(
@"
Usage: {0} [options]

Options:
  --list-zips           | -l      List zip files in tree hierarchy
  --extract             | -e      Extract zip files in tree hierarchy
  --extract-and-delete  | -ed     Extract and delete zip files in tree hierarchy
", PROGRAM_NAME);
}
void verifyArgs(string[] args)
{
    if (args.Length == 1)
    {
        show_usage();
    }
    else if (args.Length == 2)
    {
        string arg = args[1];
        
        if (COMMAND_LIST.Contains(arg))
        {
            Console.WriteLine(arg);
        }
        else
        {
            show_usage();
        }
    }

}

// directory where the user initiated the program
/*var startingDirectory = Directory.GetCurrentDirectory();


var FilesInfo = new DirectoryInfo(startingDirectory).GetFiles("*.zip", SearchOption.AllDirectories);

Console.WriteLine();

foreach (var item in FilesInfo)
{
   // Console.WriteLine(item); // Mostra todos os .zips recursivamente
    //Console.WriteLine(item.GetType()); // Mostra todos os .zips recursivamente
    //Console.WriteLine(item.Directory); // Mostra todos os .zips recursivamente
    //Console.WriteLine(item.Name); // Mostra todos os .zips recursivamente
    ExtraiEExcluiZip(item);
}

void ExtraiEExcluiZip(FileInfo fileInfo)
{
    try
    {
        ZipFile.ExtractToDirectory(fileInfo.Name, fileInfo.Directory.ToString());
        Console.WriteLine("Extracted {0}...", fileInfo.Name);
        File.Delete(fileInfo.Name);
        Console.WriteLine("Deleted {0}...", fileInfo.Name);
    }
    catch (IOException e)
    {
        Console.Error.WriteLine(
            "An error occurred while trying to delete {0}: {1}",
            fileInfo.Name, e.Message);
    }
    catch (Exception e)
    {
        Console.Error.WriteLine(
            "An error occurred while trying to extract {0}: {1}",
            fileInfo.Name, e.Message);
    }
}
*/






