using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenLoc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(".\\states.yml", Encoding.UTF8);
            List<string> out_lines = new List<string>();
            foreach(string line in lines)
            {
                //string str = line.Replace(" ", String.Empty);
                string[] arr = line.Split(':');
                string out_str = String.Format($" {GetTag(int.Parse(arr[0].Replace(" ", String.Empty)))}:{arr[1]}");
                out_lines.Add(out_str);
                out_str = String.Format($" {GetTag(int.Parse(arr[0]))}_DEF:{arr[1]}");
                out_lines.Add(out_str);
                out_str = String.Format($" {GetTag(int.Parse(arr[0]))}_ADJ:{arr[1]}");
                out_lines.Add(out_str);
            }
            File.WriteAllLines(".\\states_out.yml", out_lines, Encoding.UTF8);
        }
        static string GetTag(int StateID)
        {
            string tag = StateID.ToString("000");
            if (tag[0] == '0')
            {
                return "A" + tag.Substring(1);
            }
            else if (tag[0] == '1')
            {
                return "B" + tag.Substring(1);
            }
            else if (tag[0] == '2')
            {
                return "C" + tag.Substring(1);
            }
            else if (tag[0] == '3')
            {
                return "D" + tag.Substring(1);
            }
            else if (tag[0] == '4')
            {
                return "E" + tag.Substring(1);
            }
            else if (tag[0] == '5')
            {
                return "F" + tag.Substring(1);
            }
            else if (tag[0] == '6')
            {
                return "G" + tag.Substring(1);
            }
            else if (tag[0] == '7')
            {
                return "H" + tag.Substring(1);
            }
            else if (tag[0] == '8')
            {
                return "I" + tag.Substring(1);
            }
            else
            {
                return "J" + tag.Substring(1);
            }
        }
    }
}
