using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public record class ArticlePriceUpdated(int ArticleId, decimal OldPrice, decimal NewPrice);


    
}
