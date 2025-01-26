using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockService : AbstractArticleClassNotifier
    {
        public void UpdateStock (int articleId, decimal Price)
        {
            Notify(new ArticlePriceUpdated(articleId, 0, Price));
        }
    }
}
