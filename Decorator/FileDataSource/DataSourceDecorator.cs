using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.FileDataSource.Components;

namespace Decorator.FileDataSource.Decorators;
public class DataSourceDecorator : IDataSource
{
    protected IDataSource _dataSource;

    public DataSourceDecorator(IDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public virtual byte[] ReadData()
    {
        return _dataSource.ReadData();
    }

    public virtual void WriteData(byte[] data)
    {
        _dataSource.WriteData(data);
    }
}
