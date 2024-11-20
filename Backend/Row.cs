using System;
using System.Collections.Generic;

namespace Backend;

public class Row
{
    private Dictionary<string, (Type, int)> Columns;
    public readonly object[] Data;
    private Row thisRow;

    public Indexer<int> Int;
    public Indexer<string> Str;

    public Row(object[] objects, Dictionary<string, (Type, int)> columns)
    {
        Data = objects;
        Columns = columns;
        Int = new Indexer<int>(this);
        Str = new Indexer<string>(this);
    }

    public T GetItem<T>(string col)
    {
        if (!Columns.ContainsKey(col)) throw new ArgumentException("Cannot find the specified column");
        (Type type, int i) = Columns[col];
        if (!type.IsAssignableTo(typeof(T))) throw new ArgumentException("Column is wrong type");
        return (T)Data[i];
    }

    public class Indexer<T>(Row parent)
    {
        public T this[string col] => parent.GetItem<T>(col);
    }
    

    public object this[string col] => GetItem<object>(col);
    
    public int GetInt(string col) => GetItem<int>(col);
    public string GetString(string col) => GetItem<string>(col);
}