using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Table : IEnumerable<Row>
{
    public Dictionary<string, (Type, int)> Columns = [];
    public Row[] Data;

    public Table(object[][] data, Dictionary<string, (Type, int)> columns)
    {
        Columns = columns;
        Data = new Row[data.Length];
        for (int i = 0; i < data.Length; i++)
            Data[i] = new Row(data[i], columns);
    }

    public string[] GetColNames()
    {
        string[] ret = new string[Columns.Count];
        foreach (var (name, (_, index)) in Columns)
            ret[index] = name;
        return ret;
    }

    public string GetHeaderText()
    {
        StringBuilder sb = new();
        foreach (var col in GetColNames())
        {
            sb.Append(col).Append(", ");
        }

        return sb.ToString();
    }

    public Row this[int row] => Data[row];

    public IEnumerator GetEnumerator() => Data.GetEnumerator();
    IEnumerator<Row> IEnumerable<Row>.GetEnumerator() => (IEnumerator<Row>)GetEnumerator();

    public string ToString()
    {
        StringBuilder sb = new();
        // foreach (var col in GetColNames())
        // {
        //     sb.Append(col).Append(", ");
        // }
        //
        // sb.Append("\r\n");
        // sb.Append("\n+---Querry Result---\n");
        foreach (var row in Data)
        {
            sb.Append(row.ToString()).Append('\n');
        }

        // sb.Append("+-------------------\n");

        return sb.ToString();
    }
}