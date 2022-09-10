Console.Write("Digite seu nome: ");
string nomeDigitado = Console.ReadLine()!;

string nomeNinja = nomeDigitado
   .ToLower()
   .Replace("a", "KA")
   .Replace("á", "KA")
   .Replace("ã", "KA")
   .Replace("â", "KA")
   .Replace("b", "ZU")
   .Replace("c", "MI")
   .Replace("d", "TE")
   .Replace("e", "KA")
   .Replace("é", "KA")
   .Replace("ê", "KA")
   .Replace("f", "LU")
   .Replace("g", "JI")
   .Replace("h", "RI")
   .Replace("i", "KI")
   .Replace("í", "KI")
   .Replace("j", "ZUS")
   .Replace("k", "MI")
   .Replace("l", "TE")
   .Replace("m", "KA")
   .Replace("n", "ZU")
   .Replace("o", "MI")
   .Replace("õ", "MI")
   .Replace("ó", "MI")
   .Replace("ô", "MI")
   .Replace("p", "TE")
   .Replace("r", "ZU")
   .Replace("s", "MI")
   .Replace("t", "ARI")
   .Replace("u", "DO")
   .Replace("ú", "DO")
   .Replace("v", "RU")
   .Replace("w", "MEI")
   .Replace("x", "FU")
   .Replace("y", "FU")
   .Replace("z", "ZI")
   .ToLower();

string inicial = nomeNinja.Substring(0, 1).ToUpper();
string restante = nomeNinja.Substring(1);

nomeNinja = $"{inicial}{restante}";

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Seu nome ninja é {nomeNinja}.");
Console.ResetColor();


