namespace Bridge.RemoteDevice;
public class Remote
{
	private Device device;

	public Remote(Device device)
	{
		this.device = device;
	}

	public void TogglePower()
	{
		if (device.IsEnabled)
		{
			device.Disable();
		}
		else
		{
			device.Enable();
		}
	}
	public void VolumeDown(int value = 1)
	{
		if (device.Volume >= value)
			device.Volume -= value;
	}
	public void VolumeUp(int value = 1)
	{
		if (device.Volume <= value)
			device.Volume += value;
	}

	public void ChannelUp()
	{
		var currentChannel = device.Currentchannel;
		if (currentChannel == device.channelsList.Count - 1)
		{
			device.Currentchannel = 0;
		}
		else
		{
			device.Currentchannel++;
		}
	}
	public void ChannelDown()
	{
		var currentChannel = device.Currentchannel;
		if (currentChannel == 0)
		{
			device.Currentchannel = device.channelsList.Count - 1;
		}
		else
		{
			device.Currentchannel--;
		}
	}

}
