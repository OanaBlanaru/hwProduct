using System;

namespace hwOOP3
{
    class Product : IProductSpecifications
    {
        private string productName;

        public string ProductName
        { get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        private float weight;

        public float ProductWeight
        { get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        private string producer;

        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }

        private DateTime productionDate;

        public DateTime ProductionDate
        {
            get
            {
                return productionDate;
            }

            set
            {
                productionDate = value;
            }
        }

        enum ProductType { Fruit, Beverage, Dairy, Bread }

        private string productType;

        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Please choose product category: Fruit, Beverage, Dairy, Bread ");
            string productType = Console.ReadLine();

            if (productType == ProductType.Fruit.ToString())
            {
                productType = ProductType.Fruit.ToString();
            }
            else if (productType == ProductType.Beverage.ToString())
            {
                productType = ProductType.Beverage.ToString();
            }
            else if (productType == ProductType.Dairy.ToString())
            {
                productType = ProductType.Dairy.ToString();
            }
            else if (productType == ProductType.Bread.ToString())
            {
                productType = ProductType.Bread.ToString();
            }
            else
            {
                Console.WriteLine("Please enter a valid product type");
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please insert product name:");
            product.ProductName = System.Console.ReadLine();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please enter producer name:");
            product.Producer = Console.ReadLine();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please enter product weight:");
            product.ProductWeight = float.Parse(Console.ReadLine());

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please enter production date (mm/dd/yyyy):");
            product.ProductionDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Product {product.productName} is a {productType} type produced by {product.Producer}");
            Console.WriteLine($"We received {product.ProductWeight} kilos. It was produced on {product.ProductionDate}");
            product.ExpirationDate(productType);
        }

        public void ExpirationDate(string productType)
        {
            DateTime ? expirationDate = null;

            if (productType == ProductType.Fruit.ToString())
            {
                expirationDate = productionDate.AddDays(2);
            }
            else if (productType == ProductType.Beverage.ToString())
            {
                expirationDate = productionDate.AddYears(3);               
            }
            else if (productType == ProductType.Dairy.ToString())
            {
                expirationDate = productionDate.AddDays(7);
            }
            else if (productType == ProductType.Bread.ToString())
            {
                expirationDate = productionDate.AddDays(4);
            }

            Console.WriteLine("The product expires on:" + expirationDate);

        }
    }
}
