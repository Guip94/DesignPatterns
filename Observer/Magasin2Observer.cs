using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Magasin2Observer : IArticlePriceObserver
    {
        public void ReceivePriceChanged(object sender, ArticlePriceUpdated info)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nouveau prix pour {info.ArticleId} : {info.NewPrice} (Ancien prix : {info.OldPrice})");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
