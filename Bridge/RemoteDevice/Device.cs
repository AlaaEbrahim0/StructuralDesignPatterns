using System.Runtime.CompilerServices;

namespace Bridge.RemoteDevice;

public abstract class Device
{
	public List<string> channelsList { get; set; } = new();
	public int Currentchannel { get; set; } = 0;
    public string Channel 
	{
		get
		{
			return channelsList[Currentchannel];
		}
	}

    public int Volume { get; set; }
	public bool IsEnabled { get; set; }
	public void Enable() => IsEnabled = true;
	public void Disable() => IsEnabled = false;

	public override string ToString()
	{
		return
			$"CURRENT CHANNEL: {this.Channel}\n" +
			$"VOLUME: {this.Volume}\n";
	}
}
