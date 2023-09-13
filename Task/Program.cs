using Task;
string[] menuItems = {"Basic","Pro","Expert"};
int selectedItemIndex = 0;

while (true)
{
    Console.Clear();

        for (int i = 0; i < menuItems.Length; i++)
        {
            if (i == selectedItemIndex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t\t\t" + menuItems[i]);
                Console.ResetColor();
            }
            else Console.WriteLine("\n\t\t\t\t\t" + menuItems[i]); 
        }

    ConsoleKeyInfo keyInfo = Console.ReadKey();

    if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        selectedItemIndex = (selectedItemIndex + 1) % menuItems.Length; 
    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        selectedItemIndex = (selectedItemIndex - 1 + menuItems.Length) % menuItems.Length;
    }
    else if (keyInfo.Key == ConsoleKey.Enter)
    { 
        
        if (selectedItemIndex == 0)
        {
            DocumentProgram basic = new DocumentProgram();
            basic.OpenDocument();
            basic.voidEditDocument();
            basic.voidSaveDocument();
            Console.ReadLine();
        }
        else if (selectedItemIndex == 1)
        {
            ProDocumentProgram pro = new ProDocumentProgram();
            DocumentProgram docProgram = new ProDocumentProgram();
            docProgram.voidEditDocument();
            docProgram.voidSaveDocument();
            pro.OpenDocument();
            pro.voidEditDocument();
            pro.voidSaveDocument();
            Console.ReadLine();
        }
        else if (selectedItemIndex == 2)
        {
            ExpertDocument expert = new ExpertDocument();
            DocumentProgram docProgram = new ExpertDocument();
            docProgram.voidSaveDocument();
            docProgram.voidEditDocument();
            expert.OpenDocument();
            expert.voidEditDocument();
            expert.voidSaveDocument();
            Console.ReadLine();
        }

    }
}