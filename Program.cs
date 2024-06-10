using Searchy;

static List<T> SuperCoolSearch<T>(List<T> objectList, string search)
{
    string searchLowerCase = search.ToLower();
    const int notFound = -1;
    List<T> filteredObjectList = new();
    foreach (var @object in objectList)
    {
        if (@object is not null)
        {
            foreach (var property in @object.GetType().GetProperties())
            {
                object? propertyValue = property.GetValue(@object);
                if (propertyValue is not null)
                {
                    string? propertyValueString = propertyValue.ToString();
                    if (propertyValueString is not null && propertyValueString.ToLower().IndexOf(searchLowerCase) is not notFound)
                    {
                        filteredObjectList.Add(@object);                       
                    }
                }
            }
        }
    }
    return filteredObjectList;
}

List<Apple> apples = new List<Apple>() { new("Pink lady","The best"),new("Green apple","mid"), new("Normal apple","It is quite yummy"), new("Pineapple", "Incredibly yummy") };

List<Apple> yummyApples = SuperCoolSearch(apples,"yummy");
Console.WriteLine(string.Join(",",yummyApples.Select(yummyApple => yummyApple.Name).ToArray()));