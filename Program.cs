using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace task2912h
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            int num = 10;
            powernum(ref num);
            Console.WriteLine(num);
            //task2
            int[] arr = { 10, 20, 30, 40 };
            numarray(ref arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            //task3
            string text = " Hikmet  Abbasov ";
            ntext(ref text);
            Console.WriteLine(text);
            //task4
            int[] nums = { 1, 5, 7 };
          numarr(ref nums);
            Console.WriteLine(numarr);





        }
        static void powernum(ref int num)
        {
            //Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)
            num *= num;
        }

        
        static void numarray(ref int[] arr)
        {
            //Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            
        }
        static void ntext( ref string text)
        {
            //Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində
            //bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov "
            //deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.
           string newStr = "";
             for(int i=0;i<text.Length;i++)
             {  if (text[i]!=' ')
                {
                    newStr += text[i];

                }
            }

            text = newStr;



        }
        static int[] numarr(ref int[] array)
        {
            //Parameter olaraq integer array variable - i ve bir integer value
            //qebul eden ve hemin integer value-nu integer array-e yeni element
            //kimi elave eden metod. Misal üçün int[] nums = { 1, 5, 7 } deyə bir
            //variable - mız var.yazdığımız metodu çağırıb arqument olaraq nums və 3
            //göndərsək nums arrayının dəyəri  { 1,5,7,3} olmalıdır.
       

            int[] newArr = new int[array.Length + 1];
            newArr[array.Length] = 3;
            return newArr;

        }



    }
}

