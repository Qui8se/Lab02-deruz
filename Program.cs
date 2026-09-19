// Console.WriteLine("Границы целочисленных типов");
// Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// Console.WriteLine();
// Console.WriteLine("Границы дробных типов данных");
// Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// Console.WriteLine($"Double: {double.MinValue} .. {double.MaxValue}");
// Console.WriteLine($"Decimal: {decimal.MinValue} .. {decimal.MaxValue}");



Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overFlowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overFlowed}");