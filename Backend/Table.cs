using System;
using System.Collections;
using System.Collections.Generic;

namespace Backend;

public class Table : IEnumerable<Row>
{
    public Dictionary<string, (Type, int)> Columns = [];
    public Row[] Data;

    public Table(object[][] data, Dictionary<string, (Type, int)> columns)
    {
        Columns = columns;
        Data = new Row[data.Length];
        for (int i = 0; i<data.Length;i++)
            Data[i] = new Row(data[i],columns);
    }
    
    public Row this[int row] => Data[row];

    public IEnumerator GetEnumerator() => Data.GetEnumerator();
    IEnumerator<Row> IEnumerable<Row>.GetEnumerator() => (IEnumerator<Row>)GetEnumerator();
}