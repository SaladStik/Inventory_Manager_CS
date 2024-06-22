using Inventory.DB_Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inventory.DB_Interaction.Arguments;
namespace Inventory
{
    public class App
    {

        static async Task Main(string[] args)
        {
            DB_Integrator DB_Integrator = new DB_Integrator();

           

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

                   // await DB_Integrator.Query(product_add, new string[] { model_number, type, quantity.ToString(), barcode });
                    break;


                case "2"://displays data entries
                    Console.WriteLine(await DB_Integrator.SelectAsync(select_Product, null));
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
                   // await DB_Integrator.Query(product_update, new string[] { quantity.ToString(), barcode });
                    break;
                //adds history
                case "4":
                   // await DB_Integrator.Query(insert_data_into_history_if_not_exists, new string[] { "1", "3", "4", "99test", DateTime.Now.ToString(), "test2" });
                    break;
                //updates note
                case "5":
                  //  await DB_Integrator.Query(update_history_note, new string[] { "updated Note", "99test", "1" });
                    break;
                case "6":
                   // await DB_Integrator.Query(update_history_location, new string[] { "2", "99test", "1"});
                    break;
            }








            // Console.WriteLine(await DB_Integrator.Select(select_Product));


        }
    }
}
