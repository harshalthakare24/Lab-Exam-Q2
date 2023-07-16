namespace LabExam.Models
{
    
        public class product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }

        internal static void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        internal static List<product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        internal static product GetSingleProduct(int value)
        {
            throw new NotImplementedException();
        }

        internal static void InsertProduct(product obj)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateProduct(product obj)
        {
            throw new NotImplementedException();
        }
    }
    
}
