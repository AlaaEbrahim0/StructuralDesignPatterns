using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.FileDataSource;
public interface IDataSource
{
    void WriteData(byte[] data);
    byte[] ReadData();
}
