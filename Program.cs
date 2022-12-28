Console.WriteLine("Введите перечень элементов массива");
string text = Console.ReadLine();

string[] separators = {" ", ",", ".", ";"};
int i = 0;
char s = ' ';

string[] Words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
string[] tempWords = new string[Words.Length];
string texta = tempWords[0];
