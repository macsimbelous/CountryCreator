using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using System.IO;

namespace FlagGen
{
    class Program
    {
        static void Main(string[] args)
        {
            MagickImage communism = new MagickImage("communism.png");
            MagickImage democratic = new MagickImage("democratic.png");
            MagickImage fascism = new MagickImage("fascism.png");
            MagickImage neutrality = new MagickImage("neutrality.png");
            Random rnd = new Random();
            string[] tags = File.ReadAllLines("tags.txt");
            //string gfx_path = @"C:\Users\maksim\Documents\Paradox Interactive\Hearts of Iron IV\mod\anime_world\gfx\";
            string gfx_path = @".\";
            Directory.CreateDirectory(gfx_path + "flags\\medium");
            Directory.CreateDirectory(gfx_path + "flags\\small");
            var m_size = new MagickGeometry(41, 26);
            m_size.IgnoreAspectRatio = true;
            var s_size = new MagickGeometry(10, 7);
            s_size.IgnoreAspectRatio = true;
            foreach (string tag in tags)
            {
                ColorRGB fon_color = new ColorRGB((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255));
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
                        result.Write(gfx_path + "flags\\" + tag + "_communism.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + tag + "_communism.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + tag + "_communism.tga");
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
                        result.Write(gfx_path + "flags\\" + tag + "_democratic.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + tag + "_democratic.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + tag + "_democratic.tga");
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
                        result.Write(gfx_path + "flags\\" + tag + "_fascism.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + tag + "_fascism.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + tag + "_fascism.tga");
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
                        result.Write(gfx_path + "flags\\" + tag + "_neutrality.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\medium\\" + tag + "_neutrality.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "flags\\small\\" + tag + "_neutrality.tga");
                    }

                }
                Console.WriteLine(tag + "...OK");
            }

        }
    }
}
