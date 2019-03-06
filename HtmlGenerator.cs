using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HtmlGenerator
    {
        int columns=0;
        List<List<string>> data;
        public HtmlGenerator(int columns, List<List<string>> input)
        {
            this.columns = columns;
            this.data = input;
        }
 
        public HtmlGenerator(int columns)
        {
            data = new List<List<string>>();
            this.columns = columns;
        }
        public void addRow() //<tr>
        {
            data.Add(new List<string>{"r"});
        }

        public void Print()//prints everything
        {
            string open="", close="";
            Console.WriteLine("<table>");
            foreach(var x in data)
            {
                switch (x[0])
                {
                    case "r":
                        open = "<tr>";
                        close = "</tr>";
                        break;
                    case "f":
                        open = "<tfoot>";
                        close = "</tfoot>";
                        break;
                    case "h":
                        open = "<thead>";
                        close = "</thead>";
                        break;
                    default:
                        Console.WriteLine("Error rfh");
                        break;
                }
                Console.WriteLine(open);
                for(int i=1;i<=columns;++i)
                {   if (String.Compare(open, "<thead>") == 0)
                        Console.Write("<th>");
                    else
                        Console.Write("<td>");
                    Console.Write(x[i]);
                    if (String.Compare(open, "<thead>") == 0)
                        Console.WriteLine("</th>");
                    else
                        Console.WriteLine("</td>");
                }
            }
            Console.WriteLine(close);
            Console.WriteLine("</table>");
        }

        public string generateString()
        {
            StringBuilder tmp = new StringBuilder(); 
            string open = "", close = "";
            tmp.AppendLine("<!DOCTYPE html>");
            tmp.AppendLine("<html>");
            tmp.AppendLine("<body>");
            tmp.AppendLine("<table>");
            foreach (var x in data)
            {
                switch (x[0])
                {
                    case "r":
                        open = "<tr>";
                        close = "</tr>";
                        break;
                    case "f":
                        open = "<tfoot>";
                        close = "</tfoot>";
                        break;
                    case "h":
                        open = "<thead>";
                        close = "</thead>";
                        break;
                    default:
                        //Console.WriteLine("Error rfh");
                        break;
                }
                tmp.AppendLine(open);
                for (int i = 1; i <= columns; ++i)
                {
                    if (String.Compare(open, "<thead>") == 0)
                        tmp.Append("<th>");
                    else
                        tmp.Append("<td>");
                    tmp.Append(x[i]);
                    if (String.Compare(open, "<thead>") == 0)
                        tmp.AppendLine("</th>");
                    else
                        tmp.AppendLine("</td>");
                }
            }
            tmp.AppendLine(close);
            tmp.AppendLine("</table>");
            tmp.AppendLine("</body>");
            tmp.AppendLine("</html>");

            return tmp.ToString();
        }

        public void addFooter()
        {
            data.Add(new List<string> { "f" });
        }

        public void addHeader()
        {
            data.Add(new List<string> { "h" });
        }

        public void addData(string td)
        {
            data[data.Count - 1].Add(td);
        }


    }
}
