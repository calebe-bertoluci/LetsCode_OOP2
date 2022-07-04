using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace MusicStore
{
    
    internal static class Inventory
    {
        //Cria lista dos objetos à serem escritos no JSON
        private static List<Guitar> guitarInventory = new List<Guitar>();
        private static List<Piano> pianoInventory = new List<Piano>();
        private static List<Violin> violinInventory = new List<Violin>();
        
        //Caminho do JSON
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
        
        //Polimorfismo do Método Include, para N instrumentos
        internal static void Include(Guitar guitar)
        {
            guitarInventory.Add(guitar);
        }
        internal static void Include(Piano piano)
        {
            pianoInventory.Add(piano);
        }
        internal static void Include(Violin violin)
        {
            violinInventory.Add(violin);
        }
        
        //Salva e serializa o JSON com os arquivos da lista
        internal static void Save()
        {
            var content1 = JsonSerializer.Serialize(guitarInventory);
            var content2 = JsonSerializer.Serialize(pianoInventory);
            var content3 = JsonSerializer.Serialize(violinInventory);
            
            File.AppendAllText(dbPath,content1);
            File.AppendAllText(dbPath,content2);
            File.AppendAllText(dbPath, content3);
        }

        internal static void Load()
        {
            //Verifica se o JSON existe, senão cria-o, e imprime na tela.
            if (!File.Exists(dbPath))
                Save();
            var content = File.ReadAllText(dbPath);
            Console.WriteLine(content);
        }
    }
}