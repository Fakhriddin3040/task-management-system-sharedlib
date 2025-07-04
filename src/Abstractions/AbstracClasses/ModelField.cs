using System.Collections.Generic;
using System.Linq;


namespace TaskManagementSystem.SharedLib.Abstractions;


public interface IModelField
{
    string Value { get;  }
}


public abstract record ModelField<T>(string Value) : IModelField
    where T : ModelField<T>
{
    public override string ToString() => Value;

    private static readonly List<T> All = typeof(T)
        .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
        .Where(f => f.FieldType == typeof(T))
        .Select(f => (T)f.GetValue(null)!)
        .ToList();

    public static IEnumerable<T> GetAll() => All;

    public static T? GetFieldByName(string name) =>
        All.FirstOrDefault(f => f.Value == name);

    public static bool ContainsField(string name) =>
        All.Any(f => f.Value == name);

    public static bool ContainsField(T field) =>
        All.Contains(field);
}
