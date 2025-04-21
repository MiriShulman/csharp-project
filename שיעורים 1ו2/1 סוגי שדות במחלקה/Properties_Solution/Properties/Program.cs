namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product.IndexUp(50);
            Product product = new Product() { Name = "Milk", ExpDate = new DateTime(2025, 2, 5) , ByWeight=false};
            product.Name = "Milk";
            product.ExpDate = new DateTime(2025, 2, 5);
            //product.ByWeight = false; שגיאה! שדה init ניתן לאתחול עד האתחול המהיר
            product.Price = 6.2;
            //product.Code = 99; שגיאה! אין אפשרות לשנות ערך לשדה לקריאה בלבד
            Console.WriteLine(product.Name);
            //גישה לשדות סטטיים וקבועים דרך שם המחלקה
            int x = Product.MAX_LENGTH;
            int y = Product.Index;

            Product[] p = new Product[4];
            p[0] = new Product(); //Code=151
            p[1] = new Product(); //Code=152
            p[2] = new Product(); //Code=153
            p[3] = new Product(); //Code=154

            for (int i = 0; i < 4; i++)
            {
                p[i].PrintIndex();
            }

        }
    }
}