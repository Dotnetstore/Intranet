namespace Utilities.Attributes;

public class EfCoreValueConverterAttribute(Type valueConverter) : Attribute
{
    public Type ValueConverter { get; } = valueConverter;
}