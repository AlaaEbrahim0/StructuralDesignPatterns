using System.Runtime.InteropServices;

namespace Bridge.RemoteDevice;

public class TV : Device
{
    public TV()
    {
		channelsList.AddRange(new List<string>
		{
			"TV Channel - 01",
			"TV Channel - 02",
			"TV Channel - 03",
			"TV Channel - 04",
			"TV Channel - 05",
			"TV Channel - 06",
			"TV Channel - 07",
			"TV Channel - 08",
			"TV Channel - 09",
		});
	}



}
