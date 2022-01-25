using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciccioList
{
    internal class Program
    {
        static void Main(string[] args)
        {

           List<string> list = new List<string>();
            list.Add("Carlão");
            list.Add("Henrique");
            list.Add("Alexandre");
            list.Add("Arthur");
            list.Add("Cesar");
            list.Add("julio");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");


            //checar a quantidade na lista
            Console.WriteLine("A lista tem "+list.Count + " informações salvas");

            Console.WriteLine("--------------");

            //Encontrar o primeiro nome que comece com H
            string s1 = list.Find(x => x[0] == 'H');
            Console.WriteLine("Começa com a leta H: "+s1);

            //Encontrar a primeira palavra que começa com C
            int s3 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("Primeira posição de palavra que começa com C " + s3);

            //Encontrar a ultima posição que começa com o C
            int s2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Ultima posição que começa com C: " + s2);

            //Enocntrar apenas os nomes que posseum 5 caracteres
            List<String> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------");

            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

            //Remover apenas os nomes que possuem 5 caracteres
            list.RemoveAll(x => x.Length == 5);
            Console.WriteLine("---------------");

            foreach(String item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
