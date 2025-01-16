namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _Products=new();

        private static readonly List<Category> _Categories=new();

        static Repository(){

        }

        public static List<Product> Products{
            get{
                return _Products;
            }
        }

        public static List<Category> Categories{
            get{
                return _Categories;
            }
        }
    }
}