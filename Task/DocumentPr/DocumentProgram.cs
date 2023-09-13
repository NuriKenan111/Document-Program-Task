namespace Task;

public class DocumentProgram
{
    public void OpenDocument(){
        Console.WriteLine("Document opened");
    }
	public virtual void voidEditDocument(){
        Console.WriteLine("Can Edit in Pro and Expert versions");
    } 
    public virtual void voidSaveDocument(){
        Console.WriteLine("Can Save in Pro and Expert versions");
    }

}
