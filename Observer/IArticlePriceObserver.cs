using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IArticlePriceObserver
    {

        //void ReceivePriceChanged(ArticlePriceUpdated info);
        void ReceivePriceChanged(object sender, ArticlePriceUpdated info);

    }
}
