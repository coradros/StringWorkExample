using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringWorkLibrary
{
    public static class StringWorker
    {
        /// <summary>
        /// Увеличивает каждое число в строке на инкремент
        /// </summary>
        /// <param name="inputText">Исходная строка</param>
        /// <param name="increment">Значение инкремента</param>
        /// <param name="isIncSymbol">Требуется увеличить символ, предшествующий числу?</param>
        /// <returns></returns>
        public static string StringIncrementor(string inputText, int increment, bool isIncSymbol = false )
        {
            StringBuilder sb = new StringBuilder(inputText);

            //Получаем числа в строке
            MatchCollection matches = new Regex(@"\d+").Matches(inputText);

            //Если чисел нет, вернем ту же строку
            if (matches.Count == 0)
                return inputText;

            foreach (Match item in matches)
            {
                //Получаем строковое представление увеличенного числа
                string incrementedValueString = (Convert.ToInt32(item.Value) + increment).ToString();

                //Если новый разряд не появился...
                if (incrementedValueString.Length == item.Length)
                {
                    //...изменяем значения в StringBuilder
                    for (int i = 0; i < item.Length; i++)
                        sb[item.Index + i] = incrementedValueString[i];
                }
                else
                {
                    //...иначе отбрасываем разряд...
                    int startIndex = incrementedValueString.Length - item.Length;

                    //...и изменяем значение
                    for (int i = 0; i <= item.Length - 1; i++)
                        sb[item.Index + i] = incrementedValueString[startIndex + i];

                    //Если передан параметр для увеличения символа, предшествующего числу...
                    if(isIncSymbol)
                    {
                        //...проверяем, есть ли символ
                        if (item.Index > 0)
                        {
                            //получаем индекс символа
                            int symbolIncrementor = Convert.ToInt32(incrementedValueString.Substring(0, incrementedValueString.Length - item.Length));

                            //записваем символ, увеличенный на отоброшенный разряд
                            sb[item.Index - 1] = (char)(sb[item.Index - 1] + symbolIncrementor);

                            //P.S. не стал усложнять с проверкой на ограничения алфавита и выход за границы алфавита.
                        }
                    }
                }
            }

            return sb.ToString();

            throw new Exception();
        }
    }
}
