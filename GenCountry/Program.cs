using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ImageMagick;

namespace GenCountry
{
    class Program
    {
        static public int STATES_COUNT = 806;
        static public string OUT_PATH = @"C:\Users\maksim\Desktop\test\";
        static void Main(string[] args)
        {
            List<Country> countrys = new List<Country>();
            string[] lines = File.ReadAllLines(".\\countrys.csv", new UTF8Encoding(false));
            Random random = new Random();
            foreach (string line in lines)
            {
                Country country = new Country();
                country.StateID = random.Next(1, 806);
                string[] cols = line.Split(';');
                country.Tag = cols[0];
                country.NameEng = cols[1];
                country.NameRus = cols[2];
                country.ColorR = (byte)random.Next(0, 255);
                country.ColorG = (byte)random.Next(0, 255);
                country.ColorB = (byte)random.Next(0, 255);
                countrys.Add(country);
            }
            /*for(int index = 1; index <= STATES_COUNT; index++)
            {
                Country country = new Country();
                country.StateID = index;
                country.Tag = GetTag(index);
                byte[] tc = BitConverter.GetBytes(index * 20815);
                if (!BitConverter.IsLittleEndian) Array.Reverse(tc);
                country.ColorB = tc[0];
                country.ColorG = tc[1];
                country.ColorR = tc[2];
                countrys.Add(country);
            }*/
            GenCountryTagsFile(countrys);
            GenCountryFiles(countrys);
            GenCountryClorsFile(countrys);
            GenHistoryFiles(countrys);
            GenFlags(countrys);
            //UpdateStateFiles(countrys);
            GenLocFile(countrys);
             return;
        }
        static string GetTag(int StateID)
        {
            string tag = StateID.ToString("000");
            if(tag[0] == '0')
            {
                return "A" + tag.Substring(1);
            }
            else if(tag[0] == '1')
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
        static void GenCountryTagsFile(List<Country> countrys)
        {
            Directory.CreateDirectory(OUT_PATH + "common\\country_tags");
            using (StreamWriter fs = new StreamWriter(OUT_PATH + "common\\country_tags\\00_countries.txt", false, new UTF8Encoding(false)))
            {
                foreach(Country c in countrys)
                {
                    fs.WriteLine($"{c.Tag} = \"countries/{c.NameEng}.txt\"");
                }
                fs.Close();
            }
        }
        static void GenCountryFiles(List<Country> countrys)
        {
            Directory.CreateDirectory(OUT_PATH + "common\\countries");
            foreach (Country c in countrys)
            {
                using (StreamWriter fs = new StreamWriter(OUT_PATH + "common\\countries\\" + c.NameEng + ".txt", false, new UTF8Encoding(false)))
                {
                    fs.WriteLine("graphical_culture = western_european_gfx");
                    fs.WriteLine("graphical_culture_2d = western_european_2d");
                    fs.WriteLine($"color = {{{c.ColorR}  {c.ColorG}  {c.ColorB}}}");
                    fs.Close();
                }
            }
        }
        static void GenCountryClorsFile(List<Country> countrys)
        {
            Directory.CreateDirectory(OUT_PATH + "common\\countries");
            using (StreamWriter fs = new StreamWriter(OUT_PATH + "common\\countries\\colors.txt", false, new UTF8Encoding(false)))
            {
                foreach (Country c in countrys)
                {
                    fs.WriteLine($"{c.Tag} = {{");
                    fs.WriteLine($"color = rgb {{ {c.ColorR}  {c.ColorG}  {c.ColorB} }}");
                    fs.WriteLine($"color_ui = rgb {{ {c.ColorR}  {c.ColorG}  {c.ColorB} }}");
                    fs.WriteLine("}");
                }
                fs.Close();
            }
        }
        static void GenHistoryFiles(List<Country> countrys)
        {
            Directory.CreateDirectory(OUT_PATH + "history\\countries");
            foreach (Country c in countrys)
            {
                using (StreamWriter fs = new StreamWriter(OUT_PATH + "history\\countries\\" + c.Tag + " - " + c.NameEng + ".txt", false, new UTF8Encoding(false)))
                {
                    fs.WriteLine($"capital = {c.StateID}");
                    fs.WriteLine("set_technology = {");
                    fs.WriteLine("	infantry_weapons = 1");
                    fs.WriteLine("}");
                    fs.WriteLine("set_convoys = 150");
                    fs.WriteLine("add_political_power = 150");
                    fs.WriteLine("set_research_slots = 4");
                    fs.WriteLine("set_stability = 0.6");
                    fs.WriteLine("set_war_support = 0.5");
                    fs.WriteLine("set_oob = \"ZZZ_1936\"");
                    fs.WriteLine("set_politics = {");
                    fs.WriteLine("	ruling_party = neutrality");
                    fs.WriteLine("	last_election = \"1936.1.1\"");
                    fs.WriteLine("	election_frequency = 48");
                    fs.WriteLine("	elections_allowed = yes");
                    fs.WriteLine("}");
                    fs.WriteLine("set_popularities = {");
                    fs.WriteLine("	fascism = 25");
                    fs.WriteLine("	communism = 25");
                    fs.WriteLine("	democratic = 25");
                    fs.WriteLine("	neutrality = 25");
                    fs.WriteLine("}");
                    fs.Close();
                }
            }
        }
        static void GenFlags(List<Country> countrys)
        {
            MagickImage communism = new MagickImage("communism.png");
            MagickImage democratic = new MagickImage("democratic.png");
            MagickImage fascism = new MagickImage("fascism.png");
            MagickImage neutrality = new MagickImage("neutrality.png");
            string gfx_path = OUT_PATH + "gfx\\";
            Directory.CreateDirectory(gfx_path + "flags\\medium");
            Directory.CreateDirectory(gfx_path + "flags\\small");
            var m_size = new MagickGeometry(41, 26);
            m_size.IgnoreAspectRatio = true;
            var s_size = new MagickGeometry(10, 7);
            s_size.IgnoreAspectRatio = true;
            foreach (Country c in countrys)
            {
                ColorRGB fon_color = new ColorRGB(c.ColorR, c.ColorG, c.ColorB);
                MagickImage fon = new MagickImage(fon_color.ToMagickColor(), 82, 52);
                using (var flag_communism = new MagickImageCollection())
                {
                    // Add the first image

                    flag_communism.Add(fon.Clone());

                    // Add the second image

                    flag_communism.Add(communism.Clone());


                    using (var result = flag_communism.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        //result.Flip();
                        // Save the result
                        result.Write(gfx_path + "flags\\" + c.Tag + "_communism.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + c.Tag + "_communism.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + c.Tag + "_communism.tga");
                    }

                }
                using (var flag_democratic = new MagickImageCollection())
                {
                    // Add the first image

                    flag_democratic.Add(fon.Clone());

                    // Add the second image

                    flag_democratic.Add(democratic.Clone());


                    using (var result = flag_democratic.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        // Save the result
                        result.Write(gfx_path + "flags\\" + c.Tag + "_democratic.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + c.Tag + "_democratic.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + c.Tag + "_democratic.tga");
                    }

                }
                using (var flag_fascism = new MagickImageCollection())
                {

                    // Add the first image

                    flag_fascism.Add(fon.Clone());

                    // Add the second image

                    flag_fascism.Add(fascism.Clone());


                    using (var result = flag_fascism.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        // Save the result
                        result.Write(gfx_path + "flags\\" + c.Tag + "_fascism.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + c.Tag + "_fascism.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + c.Tag + "_fascism.tga");
                    }

                }
                using (var flag_neutrality = new MagickImageCollection())
                {
                    // Add the first image

                    flag_neutrality.Add(fon.Clone());

                    // Add the second image

                    flag_neutrality.Add(neutrality.Clone());


                    using (var result = flag_neutrality.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        // Save the result
                        result.Write(gfx_path + "flags\\" + c.Tag + "_neutrality.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + c.Tag + "_neutrality.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + c.Tag + "_neutrality.tga");
                    }

                }
                Console.WriteLine(c.Tag + "...OK");
            }
        }
        static void UpdateStateFiles(List<Country> countrys)
        {
            string[] files = Directory.GetFiles(OUT_PATH + "history\\states", "*.txt");
            foreach(Country c in countrys)
            {
                string file = GetStateFile(files, c.StateID);
                if(file != null)
                {
                    string[] lines = File.ReadAllLines(file, new UTF8Encoding(false));
                    for(int index = 0; index < lines.Length; index++)
                    {
                        if(lines[index].IndexOf("owner = ") >= 0)
                        {
                            lines[index] = "owner = " + c.Tag;
                        }
                        if (lines[index].IndexOf("add_core_of = ") >= 0)
                        {
                            lines[index] = "add_core_of = " + c.Tag;
                        }
                    }
                    File.WriteAllLines(file, lines, new UTF8Encoding(false));
                }
                else
                {
                    Console.WriteLine($"Не найден фаил региона - {c.StateID}");
                }
            }
        }
        static string GetStateFile(string[] StateFiles, int StateID)
        {
            foreach(string s in StateFiles)
            {
                int index = s.IndexOf(OUT_PATH + "history\\states" + "\\" + StateID.ToString() + "-");
                if(index == 0)
                {
                    return s;
                }
            }
            return null;
        }
        static void GenLocFile(List<Country> countrys)
        {
            Directory.CreateDirectory(OUT_PATH + "localisation");
            using (StreamWriter fs = new StreamWriter(OUT_PATH + "localisation\\countries_l_russian.yml", false, Encoding.UTF8))
            {
                fs.WriteLine("l_russian:");
                foreach (Country c in countrys)
                {
                    fs.WriteLine($"{c.Tag}:0 \"{c.NameRus}\"");
                    fs.WriteLine($"{c.Tag}_DEF:0 \"{c.NameRus}\"");
                    fs.WriteLine($"{c.Tag}_ADJ:0 \"{c.NameRus}\"");
                    /*fs.WriteLine($"{c.Tag}_fascism:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_fascism_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_fascism_ADJ:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_communism:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_communism_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_communism_ADJ:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_democratic:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_democratic_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_democratic_ADJ:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_neutrality:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_neutrality_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_neutrality_ADJ:0 \"[{c.StateID}.GetName]\"");*/
                }
                fs.Close();
            }
            using (StreamWriter fs = new StreamWriter(OUT_PATH + "localisation\\countries_l_english.yml", false, Encoding.UTF8))
            {
                fs.WriteLine("l_english::");
                foreach (Country c in countrys)
                {
                    fs.WriteLine($"{c.Tag}:0 \"{c.NameEng}\"");
                    fs.WriteLine($"{c.Tag}_DEF:0 \"{c.NameEng}\"");
                    fs.WriteLine($"{c.Tag}_ADJ:0 \"{c.NameEng}\"");
                    /*fs.WriteLine($"{c.Tag}_fascism:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_fascism_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_fascism_ADJ:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_communism:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_communism_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_communism_ADJ:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_democratic:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_democratic_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_democratic_ADJ:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_neutrality:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_neutrality_DEF:0 \"[{c.StateID}.GetName]\"");
                    fs.WriteLine($"{c.Tag}_neutrality_ADJ:0 \"[{c.StateID}.GetName]\"");*/
                }
                fs.Close();
            }
        }
    }
    class Country
    {
        public int StateID = 0;
        public string Tag = null;
        public string NameEng = null;
        public string NameRus = null;
        public byte ColorR = 0;
        public byte ColorG = 0;
        public byte ColorB = 0;
    }
}
