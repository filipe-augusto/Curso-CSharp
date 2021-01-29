using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Arquivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CLASS FILE 1
            //string sourcePath = @"c:\temp\file1.txt";//@ serve para nao colocar o @
            //string targetePath = @"c:\temp\file2txt";

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(sourcePath);
            //    fileInfo.CopyTo(targetePath);

            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach(string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion
            #region fileStream and StreamReader
            // string path = @"c:\temp\file1.txt";
            //// FileStream fs = null;
            // StreamReader sr = null;

            // try
            // {
            //     sr = File.OpenText(path);
            //     //fs = new FileStream(path, FileMode.Open);
            //     //sr = new StreamReader(fs);

            //     while (!sr.EndOfStream)
            //     {
            //     string line = sr.ReadLine();
            //     Console.WriteLine(line);
            //     }

            // } catch(IOException e)
            // {
            //     Console.WriteLine("An error acurred");
            //     Console.WriteLine(e.Message);
            // }
            // finally
            // {
            //     if (sr != null) sr.Close();
            //     //if (fs != null) fs.Close();
            //}
            #endregion
            #region using bloco using

            //try
            //{
            //    string path = @"c:\temp\file1.txt";              
            //        using (StreamReader sr = File.OpenText(path))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }

            //    } catch (IOException e)
            //{
            //    Console.WriteLine("An error ocorred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion
            #region StreamWriter
            //string sourcePath = @"c:\temp\file1.txt";//@ serve para nao colocar o @
            //string targetePath = @"c:\temp\file2txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    using (StreamWriter sw = File.AppendText(targetePath))
            //    {
            //        foreach(string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error acurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion
            #region Directory
            //string path = @"C:/temp/myfolder";
            //try
            //{
            // var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS:");
            //    foreach(string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("Files:");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    Directory.CreateDirectory(path + "\\newFolder");


            //}
            //catch(IOException e){
            //    Console.WriteLine("An error ocorred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion
            #region Path
            string path = @"c:\temp\myfolder\file1.txt";
            Console.WriteLine("DirectorySeparatorChar" + Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetFullPath: " + Path.GetTempPath());
            #endregion

            Console.ReadKey();
        }
    }
}
