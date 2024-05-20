using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ComputerCenter.Forms.Utils.DataBase;
using static ComputerCenter.Forms.Utils.UtilMaster;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ComputerCenter.Forms.Utils
{
    internal class DataBase
    {
        private static string BD_CONNECTION_STRING = "Host=localhost;Username=postgres;Password=admin;Database=ComputerCenter";

        public static List<User> GetAllUsers()
        {
            var users = new List<User>();
            var customerIds = new List<Guid>();
            var employeeIds = new List<Guid>();

            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "SELECT \"UserUUID\", login, password, type FROM public.users;";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var userUUID = reader.GetGuid(0);
                            var userType = reader.GetString(3);

                            User user = userType switch
                            {
                                "customer" => new Customer { UserUUID = userUUID },
                                "employee" => new Employee { UserUUID = userUUID },
                                _ => new User { UserUUID = userUUID },
                            };

                            user.Login = reader.GetString(1);
                            user.Password = reader.GetString(2);
                            user.Type = userType;

                            users.Add(user);

                            if (userType == "customer") customerIds.Add(userUUID);
                            else if (userType == "employee") employeeIds.Add(userUUID);
                        }
                    }
                }

                foreach (var customerId in customerIds)
                {
                    FillCustomerData((Customer)users.First(u => u.UserUUID == customerId), customerId, con);
                }

                foreach (var employeeId in employeeIds)
                {
                    FillEmployeeData((Employee)users.First(u => u.UserUUID == employeeId), employeeId, con);
                }
            }

            return users;
        }

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "SELECT \"ProductID\", \"Name\", \"Description\", \"StockQuantity\", \"Price\", \"CategoryID\"\r\n\tFROM public.\"Products\";";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                Id = reader.GetInt16(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                Quantity = reader.GetInt16(3),
                                Price = reader.GetDecimal(4),
                                CategoryID = reader.GetInt32(5)
                            });
                        }
                    }
                }
            }

            return products;
        }

        public static List<Order> GetOrders()
        {
            var orders = new List<Order>();

            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "SELECT \"OrderID\", \"CustomerUUID\", \"OrderDate\", \"TotalAmount\"\r\n\tFROM public.\"Orders\";";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new Order
                            {
                                Id = reader.GetInt16(0),
                                CustomerUUID = reader.GetGuid(1),
                                OrderDate = reader.GetDateTime(2),
                                TotalPrice = reader.GetDecimal(3)
                            });
                        }
                    }
                }
            }

            return orders;
        }

        public static List<OrderDetail> GetOrderDetails()
        {
            var orders = new List<OrderDetail>();

            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "SELECT \"OrderDetailID\", \"OrderID\", \"ProductID\", \"Quantity\", \"Price\"\r\n\tFROM public.\"OrderDetails\";";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new OrderDetail
                            {
                                Id = reader.GetInt16(0),
                                OrderId = reader.GetInt16(1),
                                ProductId = reader.GetInt16(2),
                                Quantity = reader.GetInt16(3),
                                Price = reader.GetDecimal(4)
                            });
                        }
                    }
                }
            }

            return orders;
        }

        public static List<Category> GetCategories()
        {
            var categories = new List<Category>();

            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "SELECT \"CategoryID\", \"CategoryName\"\r\n\tFROM public.\"Categories\";";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Category
                            {
                                Id = reader.GetInt16(0),
                                CategoryName = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return categories;
        }

        private static void FillCustomerData(Customer customer, Guid userUUID, NpgsqlConnection con)
        {
            var sql = "SELECT \"UserUUID\", \"FirstName\", \"LastName\", \"Email\", \"PhoneNumber\", \"Address\"\r\n\tFROM public.\"Customers\"\r\n\tWHERE \"UserUUID\" = @UserUUID;";
            using (var cmd = new NpgsqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserUUID", userUUID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer.FirstName = reader.GetString(1);
                        customer.LastName = reader.GetString(2);
                        customer.Email = reader.GetString(3);
                        customer.Phone = reader.GetString(4);
                        customer.Address = reader.GetString(5);
                    }
                }
            }
        }

        private static void FillEmployeeData(Employee employee, Guid userUUID, NpgsqlConnection con)
        {
            var sql = "SELECT \"FirstName\", \"LastName\", \"Position\", \"Email\", \"PhoneNumber\"FROM public.\"Employees\" WHERE \"UserUUID\" = @UserUUID;";
            using (var cmd = new NpgsqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@UserUUID", userUUID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employee.FirstName = reader.GetString(0);
                        employee.LastName = reader.GetString(1);
                        employee.Position = reader.GetString(2);
                        employee.Email = reader.GetString(3);
                        employee.Phone = reader.GetString(4);
                    }
                }
            }
        }

        public static void RegisterUser(string login, string pass, string type, string name, string surname, string address, string phone, string email)
        {
            pass = EncryptPass(pass);
            Guid uuid = Guid.NewGuid();
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "INSERT INTO public.users(\r\n\t\"UserUUID\", login, password, type)\r\n\tVALUES (@UserUUID, @login, @password, @type);";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserUUID", uuid);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.ExecuteNonQuery();
                }
            }

            RegisterCustomer(uuid, name, surname, address, phone, email);
        }
        
        public static void RegisterCustomer(Guid uuid, string name, string surname, string address, string phone, string email)
        {
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "INSERT INTO public.\"Customers\"(\r\n\t\"UserUUID\", \"FirstName\", \"LastName\", \"Email\", \"PhoneNumber\", \"Address\")\r\n\tVALUES (@userUUID, @firstName, @lastName, @email, @phoneNumber, @address);";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@userUUID", uuid);
                    cmd.Parameters.AddWithValue("@firstName", name);
                    cmd.Parameters.AddWithValue("@lastName", surname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phoneNumber", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddProduct(string name, string description, decimal price, int quantity, int categoryId)
        {
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "INSERT INTO public.\"Products\"(\r\n\t\"Name\", \"Description\", \"StockQuantity\", \"Price\", \"CategoryID\")\r\n\tVALUES (@name, @description, @stockQuantity, @price, @categoryid);";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@stockQuantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@categoryid", categoryId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateProduct(Product product)
        {
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "UPDATE public.\"Products\" SET \"Name\" = @name, \"Description\" = @description, \"StockQuantity\" = @stockQuantity, \"Price\" = @price, \"CategoryID\" = @categoryid WHERE \"ProductID\" = @productId;";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@productId", product.Id);
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@stockQuantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@categoryid", product.CategoryID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddOrder(Guid uuid, DateTime date, decimal totalPrice, int productId, int quantity, int price)
        {
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "INSERT INTO public.\"Orders\"(\r\n\t\"CustomerUUID\", \"OrderDate\", \"TotalAmount\")\r\n\tVALUES (@customerUUID, @orderDate, @totalAmount) RETURNING \"OrderID\";";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@customerUUID", uuid);
                    cmd.Parameters.AddWithValue("@orderDate", date);
                    cmd.Parameters.AddWithValue("@totalAmount", totalPrice);
                    int orderId = (int)cmd.ExecuteScalar(); 

                    AddOrderDetails(orderId, productId, quantity, price);
                }
            }
        }

        public static void AddOrderDetails(int orderId, int productId, int quantity, int price)
        {
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "INSERT INTO public.\"OrderDetails\"(\r\n\t\"OrderID\", \"ProductID\", \"Quantity\", \"Price\")\r\n\tVALUES (@orderID, @productID, @quantity, @price);";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderId);
                    cmd.Parameters.AddWithValue("@productID", productId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteProduct(int productId)
        {
            using (var con = new NpgsqlConnection(BD_CONNECTION_STRING))
            {
                con.Open();
                var sql = "DELETE FROM public.\"Products\" WHERE \"ProductID\" = @productId;";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Employee GetEmployee(string username)
        {
            List<User> users = GetAllUsers();

            foreach (var user in users)
            {
                if (user.Login.ToLower() == username.ToLower() && user.Type == "employee")
                {
                    return (Employee)user;
                }
            }

            return null;
        }

        public static Employee GetEmployee(Guid uuid)
        {
            List<User> users = GetAllUsers();

            foreach (var user in users)
            {
                if (user.UserUUID == uuid && user.Type == "employee")
                {
                    return (Employee)user;
                }
            }

            return null;
        }

        public static Customer GetCustomer(string username)
        {
            List<User> users = GetAllUsers();

            foreach (var user in users)
            {
                if (user.Login.ToLower() == username.ToLower() && user.Type == "customer")
                {
                    return (Customer) user;
                }
            }

            return null;
        }

        public static Customer GetCustomer(Guid uuid)
        {
            List<User> users = GetAllUsers();

            foreach (var user in users)
            {
                if (user.UserUUID == uuid && user.Type == "customer")
                {
                    return (Customer)user;
                }
            }

            return null;
        }

        public static User GetUser(string username)
        {
            List<User> users = GetAllUsers();

            foreach (var user in users)
            {
                if (user.Login.ToLower() == username.ToLower())
                {
                    return user;
                }
            }

            return null;
        }

        public static User GetUser(Guid uuid)
        {
            List<User> users = GetAllUsers();

            foreach (var user in users)
            {
                if (user.UserUUID == uuid)
                {
                    return user;
                }
            }

            return null;
        }

        public static OrderDetail GetOrderDetail(int id)
        {
            List<OrderDetail> orders = GetOrderDetails();

            foreach (var order in orders)
            {
                if (order.OrderId == id)
                {
                    return order;
                }
            }

            return null;
        }

        public static Product GetProduct(int id)
        {
            List<Product> products = GetProducts();

            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }

            return null;
        }

        public static Product GetProduct(string name)
        {
            List<Product> products = GetProducts();

            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    return product;
                }
            }

            return null;
        }

        public static string GetCategoryName(int id)
        {
            List<Category> categories = GetCategories();
            foreach (var category in categories)
            {
                if (category.Id == id)
                {
                    return category.CategoryName;
                }
            }

            return "";

        }

        public static int GetCategoryId(string name)
        {
            List<Category> categories = GetCategories();
            foreach (var category in categories)
            {
                if (category.CategoryName.ToLower() == name.ToLower())
                {
                    return category.Id;
                }
            }

            return -1;
        }

        public static bool IsCategoryExist(string categoryName)
        {
            var categories = GetCategories();
            foreach (var category in categories)
            {
                if (category.CategoryName.ToLower() == categoryName.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class User
    {
        public Guid UserUUID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }

    public class Customer : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public Guid CustomerUUID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
