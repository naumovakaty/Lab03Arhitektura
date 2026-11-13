using System.Text;

int number = 65536
;
Console.WriteLine($"Число: {number}"); 
Console.WriteLine($"B hex: 0x{number:X8}");
Console.WriteLine($"Little-endian: {BitConverter.IsLittleEndian}");
byte[] numberBytes = BitConverter.GetBytes(number);
Console.WriteLine("Байты числа:");
Console.WriteLine(BitConverter.ToString(numberBytes));
string text = "Hello";
Console.WriteLine();
Console.WriteLine($"Текст: {text}");
byte[] textBytes = Encoding.UTF8.GetBytes(text);
Console.WriteLine("Байты текста UTF-8:");
Console.WriteLine(BitConverter.ToString(textBytes));

string text2 = "Привет";
byte[] textBytes2 = Encoding.UTF8.GetBytes(text2);
Console.WriteLine();
Console.WriteLine($"Текст: {text2}");
Console.WriteLine($"Количество символов: {text2.Length}");
Console.WriteLine($"Количество байтов UTF-8: {textBytes2.Length}");
Console.WriteLine($"Байты: {BitConverter.ToString(textBytes2)}");




