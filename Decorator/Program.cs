using System.Text;
using Decorator.Components;
using Decorator.Decorators;

public class Program
{
	public static void Main(string[] args)
	{
		var path = @"C:\Users\DELL\OneDrive\Desktop\DecoratorTextFile.txt";
		var file = new FileDataSource(path);

		var content = "Text To Be Written";
		var contentAsBytes = Encoding.UTF8.GetBytes(content);


		// Writing data to the specified file 
		file.WriteData(contentAsBytes);

		// Decorating The File With an encryptor
		var encryptionDecorator = new EncryptionDecorator(file);
		// Encrypt Fist => Write 
		encryptionDecorator.WriteData(contentAsBytes);

		// Read Data => Decrypt
		var decryptedData = encryptionDecorator.ReadData();
		var decryptedDataAsString = Encoding.UTF8.GetString(decryptedData);

        Console.WriteLine("\n" + decryptedDataAsString);

		// Decorating The Encryptor with a Compressor
		var compressionDecorator = new CompressionDecorator(encryptionDecorator);

		var compressedData = compressionDecorator.ReadData();
		var compressedDataAsString = Encoding.UTF8.GetString(compressedData);

		Console.WriteLine("\n" + compressedDataAsString);




    }
}

