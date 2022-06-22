//Задание 7
//Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
//должно быть заменено на набор символов *. По итогам работы приложения необходимо показать статистику
//действий.

//Например, если и у нас есть такой текст:
//To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer
//The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles,
//And by opposing end them? To die: to sleep;
//No more; and by a sleep to say we end The heart-ache and the thousand natural shocks
//That flesh is heir to, 'tis a consummation Devoutly to be wish'd. To die, to sleep.
//Недопустимое слово: die.

//Результат работы:
//To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer
//The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles,
//And by opposing end them? To ***: to sleep;
//No more; and by a sleep to say we end The heart-ache and the thousand natural shocks
//That flesh is heir to, 'tis a consummation Devoutly to be wish'd. To ***, to sleep.

//Статистика: 2 замены слова die.

using System;

namespace HW_2_C_Sharp_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text, wich you want to check");
            string text = Console.ReadLine();
            Console.WriteLine("Input a word that you want to change into \"*\" in the text");
            string word = Console.ReadLine();
            string newText;
            int count = 0;
            foreach (var item in text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (item == word)
                count++;
            }
            if (count != 0)
            {
                string pattern = new string('*', word.Length);
                newText = text.Replace(word, pattern);
                Console.WriteLine($"New text without word - {word} below:\n");
                Console.WriteLine(newText);
                Console.WriteLine($"Statistics: {count} word substitutions {word}");
            }
            else
                Console.WriteLine($"Inputed text don`t include any word - \"{word}\"");
        }
    }
}
