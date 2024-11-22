using System;
using System.Collections.Generic;
using System.Text;

namespace Backend;

public class Row
{
    private Dictionary<string, (Type, int)> Columns;
    public readonly object[] Data;
    private Row thisRow;

    public Indexer<int> Int;
    public Indexer<string> Str;
    public Indexer<DateTimeOffset> Date;

    public Row(object[] objects, Dictionary<string, (Type, int)> columns)
    {
        Data = objects;
        Columns = columns;
        Int = new Indexer<int>(this);
        Str = new Indexer<string>(this);
        Date = new Indexer<DateTimeOffset>(this);
    }

    public T GetItem<T>(string col)
    {
        if (!Columns.ContainsKey(col)) throw new ArgumentException("Cannot find the specified column");
        (Type type, int i) = Columns[col];
        if (!type.IsAssignableTo(typeof(T))) throw new ArgumentException("Column is wrong type");
        try
        {
            return (T)Data[i];
        }
        catch (Exception _)
        {
            return default;
        }
    }

    public class Indexer<T>(Row parent)
    {
        public T this[string col] => parent.GetItem<T>(col);
    }
    

    public object this[string col] => GetItem<object>(col);
    
    public int GetInt(string col) => GetItem<int>(col);
    public DateTimeOffset GetDate(string col) => GetItem<DateTimeOffset>(col);
    public string GetString(string col) => GetItem<string>(col);

    public string ToString()
    {
        StringBuilder sb = new();
        foreach (object data in Data)
            if (data.GetType().IsAssignableTo(typeof(DateTimeOffset)))
                sb.Append(((DateTimeOffset)data).Date.ToShortDateString()+", ");
            else
                sb.Append(data + ", ");
        return sb.ToString();
    }
}