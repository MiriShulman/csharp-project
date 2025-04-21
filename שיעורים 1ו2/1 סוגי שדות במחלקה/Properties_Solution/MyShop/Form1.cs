using System.Text;

namespace MyShop
{
    public partial class Form1 : Form
    {
        //public static Product[] Products { get; set; }
        //public static int Index = 0;
        private Product[] Products { get; set; }
        private int Index = 0;
        public Form1()
        {
            Products = new Product[100];
            InitializeComponent();
            //AddNewProductBtn.BackColor = Color.Blue;
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            //יצירת מופע ממחלקת המסך שרוצים לפתוח
            AddProductForm form = new AddProductForm("נא להכניס את פרטי המוצר");
            //רוצים לדעת על סגירת המסך
            form.FormClosed += Form_FormClosed;
            //הצגת המסך בפועל
            form.Show();
        }

        //sender - המופע שגרם להפעלת הפונקציה
        private void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Products[Index] = ((AddProductForm)sender).p;
            if (Products[Index] != null) Index++;
        }

        private void AddNewProductBtn_MouseHover(object sender, EventArgs e)
        {
            AddNewProductBtn.BackColor = Color.LightBlue;
        }

        private void AddNewProductBtn_MouseLeave(object sender, EventArgs e)
        {
            AddNewProductBtn.BackColor = Color.Purple;
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            //יצירת מופע ממחלקת המסך שרוצים לפתוח
            AddProductForm form = new AddProductForm("נא לעדכן את פרטי המוצר");
            form.p = new Product();
            //הצגת המסך בפועל
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "ncmdklsbv";
            string file = @$"c:\newFolder\""newFile.docx""{s}";
            MessageBox.Show(file);
            int x = 9;
            int y = 8;
            string str = $"{x}+{y}={x + y}";
            str = x + "+" + y + "=" + (x + y);
            str += " ";
            str = string.Format("{1}+{0}={2}", x, y, x + y);
            Console.WriteLine("{1}+{0}={2}", x, y, x + y);

            StringBuilder sb = new StringBuilder("bncjkdvb");
            sb.Append(str);
            sb.AppendLine("cgjkd");
            sb[4] = 'f';

            int[,] arr1 = new int[,] { { 1, 2, 3, 4 },
            {5,6,7,8 } };
            arr1.GetLength(0);//2
            arr1.GetLength(1);//4
            
            int[][] arr2 = new int[][] {new int[] { 1, 2, 3 },
                new int[] { 1, 2 },
                new int[] { } };

            int[] arr3 = new int[9];

            Random r = new Random();
            int n1 = r.Next();
            int n2 = r.Next(100);
            int n3 = r.Next(40,50);

            double d = n3; //המרה מרומזת


        }
    }
}