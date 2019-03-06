using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static public void test1()
        {
            Console.WriteLine("TEST 1");
            var input = new List<List<string>>
            {
                new List<string> { "r", "1", "2222" },
                new List<string> { "r", "12", "34" }
            };
            /*input[3].Add("lOL");
            Console.WriteLine("input length: "+ input.Count);
            input[3][0] = "ser";
            foreach(var i in input)
                foreach (var x in i)
                    Console.WriteLine(x);

            Console.WriteLine("input0");
            foreach (var x in input[0])
                Console.WriteLine(x);*/
            HtmlGenerator test1 = new HtmlGenerator(2, input);
            test1.Print();
        }

        static public void test1b()
        {
            Console.WriteLine("TEST 1B");
            HtmlGenerator test1b = new HtmlGenerator(2);
            test1b.addRow();
            test1b.addData("h1");
            test1b.addData("h2");
            test1b.addRow();
            test1b.addData(":)");
            test1b.addData(":(");
            test1b.Print();
        }

        static public void test2()
        {
            Console.WriteLine("TEST 2");
            var input = new List<List<string>>
            {
                new List<string> { "r", "What is Lorem Ipsum?", "Why do we use it?" },
                new List<string> { "r",
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's " +
                    "standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining "

                    , "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. " +
                    "The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, " +
                    "content here', making it look like readable English." },
                new List<string> { "f",
                    "essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",

                    "Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for " +
                    "'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, " +
                    "sometimes by accident, sometimes on purpose " }
            };
            HtmlGenerator test2 = new HtmlGenerator(2, input);
            test2.Print();
        }

        static public void test3()
        {
            int row = -1;
            var input = new List<List<string>>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Miki\Desktop\SEM6\csharp\Lab1\Lab1\input_file.txt");
            foreach (var line in lines)
            {
                string[] tmp = line.Split(' ');
                input.Add(new List<string>());
                row++;
                for (int i = 0; i < tmp.Length; ++i)
                    input[row].Add(tmp[i]);
            }
            int columns = input[0].Count - 1;
            HtmlGenerator test3 = new HtmlGenerator(columns, input);
            string text = test3.generateString();
            System.IO.File.WriteAllText(@"C:\Users\Miki\Desktop\SEM6\csharp\Lab1\Lab1\output_file.html", text);
        }

        static public void test4()
        {
            Console.WriteLine("TEST 4");
            var input = new List<List<string>>
            {
                new List<string> { "h", "a", "b", "c", "d", "e"},
                new List<string> { "r", "f", "g", "h", "i", "j"}
            };

            HtmlGenerator test4 = new HtmlGenerator(5, input);
            test4.Print();
        }

        static void Main(string[] args)
        {
            //test1();
            test1b();
            //test2();
            //test3();
            //test4();
            Console.ReadKey();
        }
    }
}
