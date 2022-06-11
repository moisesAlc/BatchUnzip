using System.IO.Compression;

static void Main(string[] args)
{
    var diretorioInicial = Directory.GetCurrentDirectory();
    var diretorios = Directory.EnumerateDirectories(diretorioInicial);

    foreach (var item in diretorios)
    {
        Console.WriteLine(item);
    }
}

//List<string> retornaSubdiretorios(string

void ExtraiEExcluiZip(string nomeArquivo)
{
    try
    {
        ZipFile.ExtractToDirectory(nomeArquivo, Directory.GetCurrentDirectory());
        Console.WriteLine("Extracted {0}...", nomeArquivo);
        File.Delete(nomeArquivo);
        Console.WriteLine("Deleted {0}...", nomeArquivo);
    }
    catch (IOException e)
    {
        Console.Error.WriteLine(
            "An error occurred while trying to delete {0}: {1}",
            nomeArquivo, e.Message);
    }
    catch (Exception e)
    {
        Console.Error.WriteLine(
            "An error occurred while trying to extract {0}: {1}",
            nomeArquivo, e.Message);
    }
}







