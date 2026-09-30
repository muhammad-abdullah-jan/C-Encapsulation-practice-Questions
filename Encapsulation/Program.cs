using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    //Question01
    //public class Product
    //{
    //    private decimal productPrice;
    //    public void setPrice(decimal price)
    //    {
    //        if (price < 0)
    //            Console.WriteLine("Price cannot be negative");
    //        else
    //            productPrice = price;
    //    }

    //    public decimal getPrice()
    //    {
    //        return productPrice;
    //    }
    //}
    //public class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Product product = new Product();
    //        product.setPrice(100);
    //        decimal price = product.getPrice();
    //        Console.WriteLine("Product Price: " + price);
    //        product.setPrice(-50); // This will display an error message
    //    }
    //}


    //Question02
    //public class Product
    //{
    //    private int stockQuantity;
    //    public void setStockQuantity(int quantity)
    //    {
    //        if (quantity < 0)
    //            Console.WriteLine("Stock Quantity cannot be negative");
    //        else
    //            stockQuantity = quantity;
    //    }

    //    public int getStockQuantity()
    //    {
    //        return stockQuantity;
    //    }
    //}

    //public class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Product product = new Product();
    //        product.setStockQuantity(50);
    //        product.setStockQuantity(-10); // This will display an error message
    //        product.getStockQuantity();
    //        int quantity = product.getStockQuantity();
    //        Console.WriteLine("Stock Quantity:" + quantity);
    //    }
    //}

    //Question03
    //public class Product
    //{
    //    private decimal productPrice;
    //    public void setPrice(decimal price)
    //    {
    //        if (price < 0)
    //            Console.WriteLine("Price cannot be negative");
    //        else if(price ==0)
    //            Console.WriteLine("Price cannot be zero");
    //        else
    //            productPrice = price;
    //    }

    //    public decimal getPrice()
    //    {
    //        return productPrice;
    //    }
    //}

    //public class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Product product = new Product();
    //        product.setPrice(150);
            

    //        decimal price = product.getPrice();
    //        Console.WriteLine("Product Price:" + price);
    //        product.setPrice(0);
    //        product.setPrice(-20);
    //        price = product.getPrice();
    //        Console.WriteLine("Product Price2:" + price);
    //    }
    //}

    //Question04
    //public class Product
    //{
    //    private int productId;
    //    private string productName;
    //    private decimal productPrice;
    //    private int stock;
    //    private bool isActive;
    //    public void setProduct(int id, string name, decimal price, int stockQuantity, bool active)
    //    {
    //        if (id <= 0)
    //            Console.WriteLine("Id cannot be zero or negative");
    //        else
    //            productId = id;
    //        productName = name;
    //        if(price <=0)
    //            Console.WriteLine("Price cannot be zero or negative");
    //        else
    //            productPrice = price;
    //        if (stockQuantity < 0)
    //            Console.WriteLine("Stock cannot be negative");
    //        else
    //            stock = stockQuantity;
    //        isActive = active;

    //    }

    //    public void updatePrice(decimal price)
    //    {
    //        if (price <= 0)
    //            Console.WriteLine("Price cannot be negative or zero");
    //        else
    //            productPrice = price;
    //    }

    //    public void updateStock(int stockQuantity)
    //    {
    //        if (stockQuantity < 0)
    //            Console.WriteLine("Stock cannot be negative");
    //        else
    //            stock = stockQuantity;
    //    }

    //    public void deactivateProduct(bool deactivate)
    //    {
    //        isActive = deactivate;
    //    }

    //    public void activateProduct(bool activate)
    //    {
    //        isActive = activate;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine("Product Id: " + productId);
    //        Console.WriteLine("Product Name: " + productName);
    //        Console.WriteLine("Product Price: " + productPrice);
    //        Console.WriteLine("Stock Quantity: " + stock);
    //        Console.WriteLine("Is Active: " + isActive);
    //    }
    //}

    //public class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Product product = new Product();
    //        product.setProduct(1, "Laptop", 1500, 10, true);
    //        Console.WriteLine("initial product details:");
    //        product.display();
    //        Console.WriteLine("Updated price details:");
    //        product.updatePrice(2000);
    //        product.display();
    //        Console.WriteLine("Updated stock details:");
    //        product.updateStock(5);
    //        product.display();
    //        Console.WriteLine("Updated activation status:");
    //        product.deactivateProduct(false);
    //        product.display();
    //        Console.WriteLine("Activation status changed back to active:");
    //        product.activateProduct(true);
    //        product.display();
    //        product.setProduct(2, "Laptop", -1500, 10, true);
    //        product.display();
    //        product.setProduct(3, "Laptop", 1500, -10, true);
    //        product.display();
    //    }
    //}


    //Question05
    //public class Product
    //{
    //    private int stockQuantity;
    //    public void addInventory(int quantity)
    //    {
    //        if (quantity < 0)
    //            Console.WriteLine("Quantity cannot be negative");
    //        else
    //        {
    //            stockQuantity += quantity;
    //            Console.WriteLine("Stock Quantity after adding inventory: " + stockQuantity);
    //        }
    //    }

    //    public void removeInventory(int quantity)
    //    {
    //        if (quantity < 0)
    //            Console.WriteLine("Quantity cannot be negative or zero");
    //        else if (quantity > stockQuantity)
    //            Console.WriteLine("Quantity cannot be greater than stock");
    //        else
    //        {
    //            stockQuantity -= quantity;
    //            Console.WriteLine("Stock Quantity after successful removal: " + stockQuantity);
    //        }
    //    }

       
    //}

    //public class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Product product = new Product();
    //        product.addInventory(50);
    //        product.removeInventory(20);
    //        product.addInventory(20);
           
    //    }
    //}


    //Question06
    //public class Discount
    //{
    //    private decimal discountPercentage;
    //    public void calculateDiscount(decimal price, decimal discount)
    //    {
    //        if ((discount < 0 || discount > 100) )
    //            Console.WriteLine("Invalid discount percentage");
    //        else
    //        {
    //            if(price<0)
    //                Console.WriteLine("Price cannot be negative");
    //            else
    //                discountPercentage = discount;
    //            decimal discountAmount = price * discountPercentage / 100;
    //            decimal finalPrice = price - discountAmount;
    //            Console.WriteLine("Final Price after discount: " + finalPrice);
    //        }
    //    }
    //}

    //public class Mainclass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Discount discount = new Discount();
    //        discount.calculateDiscount(1000, 10);
    //        discount.calculateDiscount(1000, -5); // Invalid discount percentage
    //    }
    //}


    //Question07
    //public class User
    //{
    //    public int userId;
    //    public string userName;
    //    private string userPassword;
    //    public string userRole;
    //    public bool status;
    //    public void setPassword(string password)
    //    {
    //        if (password.Length < 6)
    //            Console.WriteLine("Password must be at least 6 characters long");
    //        else
    //            userPassword = password;
    //    }

    //    public void changePassword(string newPassword)
    //    {
    //        if (newPassword.Length < 6)
    //            Console.WriteLine("New password must be at least 6 characters long");
    //        else
    //        {
    //            userPassword = newPassword;
    //            Console.WriteLine("Password changed successfully");
    //        }
    //        }

    //    public void displayUserDetails()
    //    {
    //        Console.WriteLine("User Id: " + userId);
    //        Console.WriteLine("User Password: " + userPassword);
    //        Console.WriteLine("User Role: " + userRole);
    //        Console.WriteLine("Status: " + status);
    //    }
    //}

    //public class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        User user = new User();
    //        user.userId = 1;
    //        user.userName = "John Doe";
    //        user.setPassword("pass123");

    //        user.userRole = "Admin";
    //        user.status = true;
    //        user.displayUserDetails();
    //        Console.WriteLine("After password update");
    //        user.changePassword("234567");
    //        user.displayUserDetails();

    //        Console.WriteLine("After password update2");
    //        user.changePassword("2");
    //        user.displayUserDetails();
    //    }
    //}



    //Question08
    //public class Sale
    //{
    //    private string product;
    //    private int quantity;

    //    public Sale(string product)
    //    {
    //        this.product = product;
            
    //    }
    //    public void setQuantity(int quantity)
    //    {
    //        if (quantity < 0)
    //        {
    //            Console.WriteLine("Quantity cannot be changed");
    //        }
    //        else
    //            this.quantity = quantity;
    //    }

    //    public void updateQuantity(int quantity)
    //    {
    //        if (quantity < 0)
    //        {
    //            Console.WriteLine("Quantity cannot be changed");
    //        }
    //        else
    //        {
    //            this.quantity = quantity;
    //            Console.WriteLine("Quantity updated successfully");
    //        }
    //    }
    //}

    //public class MainClass {         public static void Main(string[] args)
    //    {
    //        Sale sale = new Sale("Eggs");
    //        sale.setQuantity(10);
            
    //        sale.updateQuantity(-3); // This will display an error message
    //        sale.updateQuantity(5);


    //    }
    //}

    //Question09
    //public class Product
    //{
    //    private int stock;
    //    public void setStock(int stock)
    //    {
    //        if (stock < 0)
    //            Console.WriteLine("Stock cannot be negative");
    //        else
    //            this.stock = stock;
    //    }

    //    public int getStock()
    //    {
    //        return this.stock;
    //    }
    //}
    //public class Sale 
    //{
    //    private int quantity;
    //    public void setQuantity(int quantity)
    //    {
    //        if (quantity < 0)
    //            Console.WriteLine("Quantity cannot be negative");
    //        else
    //            this.quantity = quantity;
    //    }

    //    public void sale(int stock)
    //    {
    //        if (stock < quantity)
    //        {
    //            Console.WriteLine("Insufficient stock");
    //        }
    //        else
    //        {
    //            int remainingStock;
    //            remainingStock = stock - quantity;
    //            Console.WriteLine("Product Stock: " + stock);
    //            Console.WriteLine("Quantity Sold: " + quantity);
    //            Console.WriteLine("Remaining Stock: " + remainingStock);
    //        }
    //    }
    //}

    //public class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Product product = new Product();
    //        product.setStock(20);
    //        int stock = product.getStock();

    //        Sale sale = new Sale();
    //        sale.setQuantity(3);
    //        sale.sale(stock);

    //    }
    //}

    //Question10
    public class Product
    {
        private int id;
        private string name;
        private int stock;
        private decimal price;
        public void setDetails(int id, string name, int stock, decimal price)
        {
            this.id = id;
            this.name = name;
            this.stock = stock;
            this.price = price;
        }

        public void addStock(int stock)
        {
            this.stock += stock;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getStock()
        {
            return stock;
        }

        public decimal getPrice()
        {
            return price;
        }

        public void stockUpdate(int remainingStock)
        {
            Console.WriteLine("Stock remaining" + remainingStock);
        }
    }

    public class Sale
    {
        private int quantity;
        private decimal discount;
        public void setDetails(int quantity, int discount)
        {
            this.quantity = quantity;
            this.discount = discount;
        }

        public int getStock(int stock)
        {
            return stock - quantity;
        }

        public int CalculateBill(int stock, decimal price, string name, decimal amountPaid)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             Raja Garments");
            Console.WriteLine("==============================================");
            decimal change;
            if (stock < quantity)
            {
                Console.WriteLine("Insufficient stock");
                return stock - quantity;
            }
            else
            {
                Console.WriteLine("Product: " + name);
                decimal subTotal = quantity * price;

                if (discount < 0 || discount > 100)
                {

                    Console.WriteLine("Final Bill: " + subTotal);
                    if (amountPaid > subTotal)
                    {
                        Console.WriteLine("Amount Paid: " + amountPaid);
                        change = amountPaid - subTotal;
                        Console.WriteLine("Change: " + change);
                    }
                    else
                        Console.WriteLine("Amount Paid: " + amountPaid);



                }
                else
                {
                    Console.WriteLine("Subtotal: " + subTotal);
                    decimal discountAmount = price * discount / 100;
                    Console.WriteLine("Discount Amount: " + discountAmount);
                    decimal finalBill = subTotal - discountAmount;
                    Console.WriteLine("Final Bill after discount of " + discountAmount + ": " + finalBill);
                    if (amountPaid > subTotal)
                    {
                        Console.WriteLine("Amount Paid: " + amountPaid);
                        change = amountPaid - finalBill;
                        Console.WriteLine("Change: " + change);
                    }
                    else
                        Console.WriteLine("Amount Paid: " + amountPaid);
                    
                }

                return stock - quantity;

            }
        }
    }

    public class MainClass 
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.setDetails(1, "T shirts", 10, 550);
            product.addStock(120);
            int id = product.getId();
            string name = product.getName();
            int stock = product.getStock();
            decimal price = product.getPrice();
            
            Sale sale = new Sale();
            sale.setDetails(5, 10);
            int stockSold = sale.CalculateBill(stock, price, name, 6000);
            int remainingStock = sale.getStock(stock);
            product.stockUpdate(remainingStock);
            

        }
    
    }
}
