using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Komunikator
{
    class Cenzor
    {
        List<string> wulgaryzmy = new List<string>();
        public StreamReader file;
        public string SprawdzTekst(string tekst)
        {
            int ile_wulgaryzmow = 0;
            foreach(string wulgaryzm in wulgaryzmy)
            {
                int index = tekst.IndexOf(wulgaryzm); //wyszukujemy wulgaryzm
                if(index != -1) //jezeli wykryto przeklenstwo
                {
                    string cenzura = new string('*', wulgaryzm.Length);  //tyle gwiazdek jak dlugie jest slowo
                    tekst = tekst.Remove(index, wulgaryzm.Length).Insert(index,cenzura); //zastepujemy wulgaryzm gwiazdkami
                    Console.WriteLine("Ocenzurowano: "+tekst);
                }
            }
            return tekst;
        }
        public Cenzor()
        {
           
            try //wczytujemy słownik
            {
                file = new StreamReader("slownik.txt");
                string line;
                int licznik = 0;
                while ((line = file.ReadLine()) != null)
                {
                    wulgaryzmy.Add(line);
                    Console.WriteLine(line);
                    licznik++;
                }
                Console.WriteLine("Dodano slow do slownika: " + licznik.ToString());
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Blad odczytu slownika");
            }
            
            }
    }
}
