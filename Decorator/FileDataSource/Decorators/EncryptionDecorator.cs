namespace Decorator.FileDataSource.Decorators;

public class EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
    {
    }
    public override void WriteData(byte[] data)
    {
        EncryptData(data);
        base.WriteData(data);
    }

    public override byte[] ReadData()
    {
        var data = base.ReadData();
        DecryptData(data);
        return data;
    }

    private void EncryptData(byte[] data)
    {
        // Simulating Encryption 
        for (var i = 0; i < data.Length; i++)
        {
            if (data[i] < 255)
                data[i] += 1;
        }
        Console.WriteLine($"Encrypting Data...");
    }
    private void DecryptData(byte[] data)
    {
        // Simulating Decryption 
        for (var i = 0; i < data.Length; i++)
        {
            if (data[i] < 255 && data[i] >= 0)
                data[i] -= 1;
        }
        Console.WriteLine($"Decrypting Data...");
    }

}
