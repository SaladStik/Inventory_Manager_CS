using Inventory.DB_Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class App
    {

        static async Task Main(string[] args)
        {
            DB_Integrator DB_Integrator = new DB_Integrator();
            string select_Product = "Select * FROM product ORDER BY id ASC"; // shows all product
            string product_add = "INSERT INTO product(model_number,type,quantity,barcode) VALUES('{0}','{1}',{2},'{3}');"; // adds a product
            string product_update = "UPDATE product SET quantity = {0} WHERE barcode = '{1}'"; //updates product quantity based on barcode
            string select_Location = "SELECT id FROM location WHERE name = '{0}';"; // shows locations
            string select_All_From_History = "Select * FROM history WHERE id_product = {0} ORDER BY id ASC";   //product history lookup
            string barcode;
            int quantity = 0;
            string type;
            string model_number;

            Console.WriteLine("Would you like to add a product[1] or view the existing products[2] update[3]");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1"://adds product
                    Console.WriteLine("Enter Model Number: ");
                    model_number = Console.ReadLine();
                    Console.WriteLine("Enter Product Type: ");
                    type = Console.ReadLine();
                    Console.WriteLine("Enter Quantity: ");
                    string quantityInput = Console.ReadLine();

                    // Check if the input is a valid unsigned integer
                    if (int.TryParse(quantityInput, out int parsedQuantity))
                    {
                        quantity = (int)parsedQuantity; // Safe to cast since uint is always positive
                    }
                    Console.WriteLine("Enter Barcode: ");
                    barcode = Console.ReadLine();

                    await DB_Integrator.Query(product_add, new string[] { model_number, type, quantity.ToString(), barcode });
                    break;


                case "2"://displays data entries
                    Console.WriteLine(await DB_Integrator.Select(select_All_From_History,new string[]{"1"}));
                    break;


                case "3": //edits quantity
                    Console.WriteLine("Enter Bar Code To Update: ");
                    barcode = Console.ReadLine();
                    Console.WriteLine("Enter Quantity: ");
                    string quantityInput2 = Console.ReadLine();

                    // Check if the input is a valid unsigned integer
                    if (int.TryParse(quantityInput2, out int parsedQuantity2))
                    {
                        quantity = (int)parsedQuantity2; // Safe to cast since uint is always positive
                    }
                    await DB_Integrator.Query(product_update, new string[] { quantity.ToString(), barcode });
                    break;
            }








            // Console.WriteLine(await DB_Integrator.Select(select_Product));


        }
    }
}
