
// // // Дан текст. В тексте нужно все пробелы заменить черточками, 
// // // маленькие буквы “к” заменить большими “К”,
// // // a большие “С” заменить маленькими “с”.
// // // Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
           + "ежели бы вас послали вместо нашего милого Винценгероде,"
          + "вы бы взяли приступом согласие прусского короля. "
           + "Вы так красноречивы. Вы дадите мне чаю?";

string Method(string text, char oldVar, char newVar)
    {
        string result = string.Empty;
        int length = text.Length;
        for (int i = 0; i < length; i++)
            {
                if(text[i] == oldVar) result = result + $"{newVar}";
                else result = result + $"{text[i]}";
            }

        return result;
    }
string sum1 = Method(text, ' ', '+');
string sum2 = Method(sum1, 'к', 'К');
string sum = Method(sum2, 'С', 'с');
Console.WriteLine(sum);