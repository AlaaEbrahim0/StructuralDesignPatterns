namespace Decorator.Components;

public class FileDataSource : IDataSource
{
	private string filePath;

	public FileDataSource(string filePath)
	{
		this.filePath = filePath;
	}

	public byte[] ReadData()
	{
        Console.WriteLine("Reading Data...");
		return File.ReadAllBytes(filePath);
    }

	public void WriteData(byte[] data)
	{
		File.WriteAllBytes(filePath, data);	
        Console.WriteLine("Writing Data...");
    }
}
