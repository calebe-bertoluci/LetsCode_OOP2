using System;
using System.Collections.Generic;

namespace MusicStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando Objetos
            var guitar = new Guitar()
            {
                Maker = "Fender",
                NumFret = 24,
                NumStrings = 6,
                Price = 400
            };
            var piano = new Piano()
            {
                Maker = "Fritz Dobbert",
                NumKeys = 88,
                NumPedals = 3,
                NumStrings = 230,
                Price = 9500
            };
            var violin = new Violin()
            {
                Maker = "Stradivarius",
                NumStrings = 5,
                BowSize = 15,
                Price = 900
            };
                
            //Incluindo Objetos no JSON
            Inventory.Include(piano);
            Inventory.Include(guitar);
            Inventory.Include(violin);
            
            //Salvando
            Inventory.Save();
            
            //Mostrando Arquivo
            Inventory.Load();
            
        }
    }
}