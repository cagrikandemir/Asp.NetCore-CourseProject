namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _Products=new();

        private static readonly List<Category> _Categories=new();

        static Repository(){
            _Categories.Add(new Category{CategoryId=1,Name="Telefon"});
            _Categories.Add(new Category{CategoryId=2,Name="Bilgisayar"});


            _Products.Add(new Product{ProductId=1,Name="Iphone 13",Price=34999,IsActive=true,Image="1.jpg",Despcription="Super Retina XDR display",CategoryId=1});
            _Products.Add(new Product{ProductId=2,Name="Iphone 14",Price=43000,IsActive=true,Despcription="Super Retina XDR display",Image="2.jpg",CategoryId=1});
            _Products.Add(new Product{ProductId=3,Name="Iphone 15 Pro",Price=87000,IsActive=true,Despcription="Super Retina XDR display",Image="3.jpg",CategoryId=1});
            _Products.Add(new Product{ProductId=4,Name="Iphone 16",Price=59000,IsActive=true,Despcription="Super Retina XDR display",Image="4.jpg",CategoryId=1});

            _Products.Add(new Product{ProductId=5,Name="Macbook Air M3",Price=48800,IsActive=true,Despcription="Super Retina XDR display",Image="5.jpg",CategoryId=2});
            _Products.Add(new Product{ProductId=6,Name="Acer Aspire 7",Price=26000,IsActive=true,Despcription="Super Retina XDR display",Image="6.jpg",CategoryId=2});

        }

        public static List<Product> Products{
            get{
                return _Products;
            }
        }
        public static void CreateProduct(Product entity){
            _Products.Add(entity);
        }
        public static List<Category> Categories{
            get{
                return _Categories;
            }
        }
    }
}