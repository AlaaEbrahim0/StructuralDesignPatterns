using Decorator.Components;

namespace Decorator.Decorators;

public class CompressionDecorator : DataSourceDecorator
{
	public CompressionDecorator(IDataSource dataSource) : base(dataSource)
	{
	}

	public override void WriteData(byte[] data)
	{
		CompressData(data);
		base.WriteData(data);
	}

	public override byte[] ReadData()
	{
		var data =  base.ReadData();
		DecompressData(data);
		return data;
	}

	private void CompressData(byte[] data)
	{
        Console.WriteLine("Compressing Data...");
    }
	private void DecompressData(byte[] data)
	{
		Console.WriteLine("Decompressing Data...");
	}
}
