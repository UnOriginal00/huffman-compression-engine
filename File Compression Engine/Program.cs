using System.Globalization;

string filePath = @"C:\Users\pfumi\Downloads\protect type beat - keepit.mp3";
byte[] data = File.ReadAllBytes(filePath);

Dictionary<byte, int> CalculateFrequencies(byte[] data)
{
    Dictionary<byte, int> frequencies = new Dictionary<byte, int>();

    foreach(byte b in data)
    {
        frequencies.TryGetValue(b, out int count);
        frequencies[b] = count + 1;
    }

    var sorted = frequencies.OrderByDescending(pair => pair.Value);
    return frequencies;

}

CalculateFrequencies(data);
foreach (var pair in CalculateFrequencies(data))
{
    Console.WriteLine($"Byte {pair.Key}: {pair.Value} times");
}

