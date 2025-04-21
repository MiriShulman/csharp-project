using System;
using static BO.Tools;

internal class ImplementationOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    void SearchSaleForProduct(BO.ProductInOrder product, bool IsPreferredCustomer)
    {
        try
        {
            if (IsPreferredCustomer)
            {
                product.SalesInProducts = (from sale in _dal.sale.ReadAll()
                                         where sale.code == product.ProductId &&
                                         sale.beginSale > DateTime.Now && sale.endSale < DateTime.Now
                                         && product.ProductAmount >= sale.minimumAmount
                                         orderby sale.minimumAmount / sale.sum
                                         select CastSaleToSaleInProduct(sale)).ToList();
            }
            else
            {
                product.SalesInProducts = (from sale in _dal.sale.ReadAll()
                                         where sale.id == product.ProductId &&
                                         sale.beginSale > DateTime.Now && sale.endSale < DateTime.Now
                                         && product.ProductAmount >= sale.minimumAmount
                                         && sale.isNeedClub == false
                                         orderby sale.minimumAmount / sale.sum
                                         select CastSaleToSaleInProduct(sale)).ToList();
            }
        }
        catch (Exception ex) { throw ex; }

    }
    //calc the total price of this product
    void CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        try
        {
            double? sum = 0;
            int? count = product.ProductAmount;
            foreach (BO.SaleInProduct sale in product.SalesInProducts)
            {
                if (count == 0)
                    break;
                while (count >= sale.Amount)
                {
                    sum += sale.Price;
                    count -= sale.Amount;
                }

            }
            sum += count * product.ProductBasePrice;
            product.TotalSum = sum;
        }
        catch (Exception e) { throw e; }
    }

    //calc the total sum of this order
    void CalcTotalPrice(BO.Order order)
    {
        try
        {
            double? total = 0;
            foreach (BO.ProductInOrder product in order.ProductsInOrder)
            {
                CalcTotalPriceForProduct(product);
                if (total != null)
                    total += product.ProductBasePrice;
            }
            order.Price = total;
        }
        catch (Exception e) { throw e; }
    }
    //return list of sales that add in this product's add
    List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int ProductId, int amount)
    {
        try
        {
            DO.Product product = _dal.product.Read(ProductId);
            BO.ProductInOrder p = order.any(p => p.Identity == productId);
            if (p != null)
            {
                if (p.ProductAmount + amount <= product.amount)
                {
                    p.ProductAmount += amount;
                }
                else
                    throw new Exception("e");
            }
            else
            {
                if (amount <= product.amount)
                {
                    order.ProductsInOrder.Add(CastProductToProductInOrder(product));
                }
                else
                {
                    throw new Exception();
                }
            }
            SearchSaleForProduct(p, order.PreferredCustomer);
            CalcTotalPriceForProduct(p);
            CalcTotalPrice(order);
            return;

        }
        catch (Exception e)
        {
            throw e;
        }
    }
    void DoOrder(BO.Order order)
    {
        try
        {
            order.ProductsInOrder = (p =>
            {
                var product = _dal.product.read(p.ProductId); // קריאה למוצר
                if (product != null) // בדיקה שהמוצר לא null
                {
                    product.amount -= p.ProductAmount; // הפחתת כמות
                    _dal.product.update(product); // עדכון המוצר במסד הנתונים
                }
            });
        }
        catch (Exception e) { throw e; }

    }

}

