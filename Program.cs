Console.WriteLine("Введите перечень элементов массива");
string text = Console.ReadLine();

string[] separators = {" ", ",", ".", ";"};
int i = 0;
char s = ' ';

string[] Words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
string[] tempWords = new string[Words.Length];
string texta = tempWords[0];
string[] TempArray(string[] inArray)
{
    for (i = 0; i < inArray.Length; i++)
    {
        inArray[i] = inArray[i] + s;
        if (((inArray[i].LastIndexOf(s) - 1) <= 2))
            tempWords[i] = inArray[i];
    }
    return (tempWords);
}
String Texta(string[] inArray)
{
    for (i = 0; i < inArray.Length; i++)
        texta = texta + inArray[i];
    return (texta);
}
