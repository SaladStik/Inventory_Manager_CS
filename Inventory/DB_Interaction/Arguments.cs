using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DB_Interaction
{
    internal class Arguments
    {
        public static string select_Product = "Select * FROM product ORDER BY id ASC"; // shows all product

        public static string product_add = "INSERT INTO product(model_number,type,quantity,barcode,require_serial_number) VALUES('{0}','{1}',{2},'{3}',{4});"; // adds a product

        public static string product_update = "UPDATE product SET quantity = {0} WHERE barcode = '{1}'"; //updates product quantity based on barcode

        public static string select_Location = "SELECT id FROM location WHERE name = '{0}';"; // shows locations

        public static string select_All_From_History = "Select * FROM history WHERE id_product = {0} ORDER BY id ASC";   //product history lookup

        public static string insert_data_into_history_if_not_exists = "INSERT INTO history (id_product, id_location, id_action, serial_number, date, note)" +
            " SELECT {0}, {1}, {2}, '{3}','{4}','{5}' " +
            " WHERE NOT EXISTS ( SELECT * FROM history WHERE serial_number = '{3}');"; //this very long and more than likely bad piece of code is what allows me to add product histories

        public static string update_history_note = "UPDATE history SET note = '{0}' WHERE serial_number = '{1}' AND id_product = {2}"; //updates product history

        public static string update_history_location = "UPDATE history SET id_location = '{0}' WHERE serial_number = '{1}' AND id_product = {2}"; //updates history location
    }
}
