using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPuppetLider
{
    internal class Program
    {
        static Queue<string> portraits_queue = null;
        static void Main(string[] args)
        {
            string[] tags = File.ReadAllLines(".\\tags.csv", Encoding.UTF8);
            GenerateFile("ACW", tags, ".\\acw_portraits.txt");
            GenerateFile("HEN", tags, ".\\hen_portraits.txt");
            GenerateFile("MAH", tags, ".\\mah_portraits.txt");
            GenerateFile("MEH", tags, ".\\meh_portraits.txt");
            GenerateFile("MMS", tags, ".\\mms_portraits.txt");
            GenerateFile("TRP", tags, ".\\trp_portraits.txt");
        }
        static string GetPortrait()
        {
            string p = portraits_queue.Dequeue();
            portraits_queue.Enqueue(p);
            return p;
        }
        static void GenerateFile(string TagMaster, string[] Tags, string PortraitsFile)
        {
            string[] portraits = File.ReadAllLines(PortraitsFile, Encoding.UTF8);
            portraits_queue = new Queue<string>(portraits);
            using (StreamWriter fs = new StreamWriter(TagMaster + "_puppet_leaders.txt", false, new UTF8Encoding(false)))
            {
                fs.WriteLine("characters = {");
                foreach (string tag in Tags)
                {
                    fs.WriteLine($"\t{TagMaster}_{tag}_puppet_leader_neutrality = {{");
                    fs.WriteLine("\t\tname = generic_political_advisor");
                    fs.WriteLine($"\t\tportraits = {{ civilian = {{ large = \"{GetPortrait()}\" }} }}");
                    fs.WriteLine("\t\tcountry_leader = { ideology = despotism traits = { wfc_anime_tyan } expire = \"1953.3.1.1\" id = -1 }");
                    fs.WriteLine("\t}");

                    fs.WriteLine($"\t{TagMaster}_{tag}_puppet_leader_democratic = {{");
                    fs.WriteLine("\t\tname = generic_political_advisor");
                    fs.WriteLine($"\t\tportraits = {{ civilian = {{ large = \"{GetPortrait()}\" }} }}");
                    fs.WriteLine("\t\tcountry_leader = { ideology = liberalism traits = { wfc_anime_tyan } expire = \"1953.3.1.1\" id = -1 }");
                    fs.WriteLine("\t}");

                    fs.WriteLine($"\t{TagMaster}_{tag}_puppet_leader_communism = {{");
                    fs.WriteLine("\t\tname = generic_political_advisor");
                    fs.WriteLine($"\t\tportraits = {{ civilian = {{ large = \"{GetPortrait()}\" }} }}");
                    fs.WriteLine("\t\tcountry_leader = { ideology = stalinism traits = { wfc_anime_tyan } expire = \"1953.3.1.1\" id = -1 }");
                    fs.WriteLine("\t}");

                    fs.WriteLine($"\t{TagMaster}_{tag}_puppet_leader_fascism = {{");
                    fs.WriteLine("\t\tname = generic_political_advisor");
                    fs.WriteLine($"\t\tportraits = {{ civilian = {{ large = \"{GetPortrait()}\" }} }}");
                    fs.WriteLine("\t\tcountry_leader = { ideology = fascism_ideology traits = { wfc_anime_tyan } expire = \"1953.3.1.1\" id = -1 }");
                    fs.WriteLine("\t}");
                }
                fs.WriteLine("}");
                fs.Close();
            }
            using (StreamWriter fs = new StreamWriter(TagMaster + "_change_country_leader.txt", false, new UTF8Encoding(false)))
            {
                fs.WriteLine($"{TagMaster}_change_country_leader = {{");
                for (int i = 0; i < Tags.Length; i++)
                {
                    if (i == 0)
                    {
                        fs.WriteLine("\tif = {");
                        fs.WriteLine($"\t\tlimit = {{ original_tag = {Tags[i]} }}");
                        fs.WriteLine("\t\tif = {");
                        fs.WriteLine("\t\t\tlimit = { has_government = communism }");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_communism");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t\telse_if = {");
                        fs.WriteLine("\t\t\tlimit = { has_government = fascism }");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_fascism");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t\telse_if = {");
                        fs.WriteLine("\t\t\tlimit = { has_government = democratic }");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_democratic");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t\telse = {");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_neutrality");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t}");
                    }
                    else
                    {
                        fs.WriteLine("\telse_if = {");
                        fs.WriteLine($"\t\tlimit = {{ original_tag = {Tags[i]} }}");
                        fs.WriteLine("\t\tif = {");
                        fs.WriteLine("\t\t\tlimit = { has_government = communism }");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_communism");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t\telse_if = {");
                        fs.WriteLine("\t\t\tlimit = { has_government = fascism }");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_fascism");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t\telse_if = {");
                        fs.WriteLine("\t\t\tlimit = { has_government = democratic }");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_democratic");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t\telse = {");
                        fs.WriteLine($"\t\t\trecruit_character = {TagMaster}_{Tags[i]}_puppet_leader_neutrality");
                        fs.WriteLine("\t\t}");
                        fs.WriteLine("\t}");
                    }
                }
                fs.WriteLine("}");
                fs.Close();
            }

        }
    }
}
