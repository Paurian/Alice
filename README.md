# Alice
Playing around with Factory-esque models that instantiates objects based on classes registered in App.config. Also tests efficiency of different string search algorithms.
 
TODO:
1. Add parallel messages to send real-time results to the interface.
2. Add option (?) to pull all classes that implement IBookReader.

For #2, look into using the following (as shown at http://stackoverflow.com/questions/9854900/instantiate-a-class-from-its-textual-name):

```
private static IEnumerable<Type> GetDerivedTypesFor(Type baseType)
{
    var assembly = Assembly.GetExecutingAssembly();

    return assembly.GetTypes()
        .Where(baseType.IsAssignableFrom)
        .Where(t => baseType != t);
}
```
