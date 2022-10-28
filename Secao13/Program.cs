using System;
using System.IO;

namespace Secao13
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Felipe Santos\Documents\file.txt";
            string targetPath = @"C:\Users\Felipe Santos\Desktop\Copiafile2.txt";

            //FileStream fs = new FileStream(sourcePath, FileMode.Open);
            //StreamReader sr = new StreamReader(fs);


            //StreamReader sr = File.OpenText(sourcePath);

            try
            {
                //using (StreamReader sr = File.OpenText(sourcePath))
                //{
                //    //while (!sr.EndOfStream)
                //    //{
                //    //    string texto = sr.ReadLine();
                //    //    Console.WriteLine(texto);

                //    //}
                //    while (!sr.EndOfStream)
                //    {
                //        string texto = sr.ReadLine();
                //        Console.WriteLine(texto);

                //    }
                    string[] l = File.ReadAllLines(sourcePath);
                    StreamWriter sw = File.AppendText(targetPath);

                    foreach (string obj in l)
                    {
                        sw.WriteLine(obj.ToUpper());
                    }
                //}
                //FileInfo fi = new FileInfo(targetPath);
                //if (!(fi.Exists))
                //{
                //    //File.Copy(sourcePath, targetPath);
                //    FileInfo fi2 = new FileInfo(sourcePath);
                //    fi2.CopyTo(targetPath);
                //}
                //else
                //{
                //    string [] texto = File.ReadAllLines(targetPath);
                //    foreach (string linhas in texto)
                //    {
                //        Console.WriteLine(linhas);
                //    }
                //}             


            }
            catch (IOException e)
            {
                Console.Write("An erro occurred");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
