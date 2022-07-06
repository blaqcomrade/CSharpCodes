 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
//IDictionary<int, string> object> data = new Dictionary<string , object>()

Dictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "Eating");
numberNames.Add(2, "video games");
numberNames.Add(3, "Basketball");

for (int i = 1; i <= numberNames.Count; i++)
{
    Console.WriteLine(numberNames[i]);
}

