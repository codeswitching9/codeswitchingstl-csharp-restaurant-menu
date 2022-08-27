using System;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem frenchOnionSoup = new MenuItem("French Onion Soup", 6.00, "Caramelized onions prepared with beef stock, topped with toasted baguette and melted Gruyère", "Appetizer", false);
            MenuItem saladeNicoise = new MenuItem("Salade Niçoise", 18.00, "Red leaf lettuce, sauteed salmon or medium-rare fresh tuna, hard-boiled egg, warm Fingerling Potatoes and Haricots Verts, Niçoise olives", "Appetizer", true);
            MenuItem spaetzle = new MenuItem("Spaetzle à l’Alsacienne", 19.00, "Homemade Alsace noodles baked with ham, onions, cream and cheese", "Main Course", true);
            MenuItem choucroute = new MenuItem("Choucroute Garnie", 23.00, "Sauerkraut served with 3 kinds of sausage and Fingerling potatoes", "Main Course", false);
            MenuItem mousse = new MenuItem("Mousse au Chocolat", 7.00, "Homemade chocolate mousse", "Dessert", true);
            MenuItem tarteAuCitron = new MenuItem("Tarte au Citron", 7.00, "Lemon pie", "Dessert", false);

            List<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(frenchOnionSoup);
            menuItems.Add(saladeNicoise);
            menuItems.Add(spaetzle);
            menuItems.Add(choucroute);
            menuItems.Add(mousse);
            menuItems.Add(tarteAuCitron);

            Menu newMenu = new Menu(DateTime.Now, menuItems);

            newMenu.AddToMenu(mousse);
            newMenu.RemoveFromMenu(spaetzle);

            newMenu.PrintMenu();
        }
    }
}
