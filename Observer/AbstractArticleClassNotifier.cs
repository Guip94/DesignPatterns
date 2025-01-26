using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class AbstractArticleClassNotifier
    {
        public event EventHandler<ArticlePriceUpdated>? ArticlePriceUpdated;   // = méthode spécifique c#
     //   private List<IArticlePriceObserver> _observers = [];    == approche OO

        //public void AddObserver(IArticlePriceObserver observer) 
        //{
        //    _observers.Add(observer);
        //}
        //public void RemoveObserver(IArticlePriceObserver observer) 
        //{
        //    _observers.Remove(observer); 
        //}

        public void Notify(ArticlePriceUpdated info)
        {
            //foreach (IArticlePriceObserver observer in _observers) { observer.ReceivePriceChanged(info); }

            ArticlePriceUpdated?.Invoke(this, info);
        }
    }
}
