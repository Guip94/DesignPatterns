using Observer;

var StockService = new StockService();

Magasin1Observer magasin1 = new Magasin1Observer();
Magasin2Observer magasin2 = new Magasin2Observer();


StockService.ArticlePriceUpdated += magasin1.ReceivePriceChanged;
StockService.ArticlePriceUpdated += magasin2.ReceivePriceChanged;
//StockService.AddObserver(magasin1);
//StockService.AddObserver(magasin2);

StockService.UpdateStock(1, 100m);

StockService.ArticlePriceUpdated -=  magasin1.ReceivePriceChanged;
//StockService.RemoveObserver(magasin1);
StockService.UpdateStock(2, 20m);