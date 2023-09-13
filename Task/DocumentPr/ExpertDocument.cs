namespace Task;

public class ExpertDocument : ProDocumentProgram 
{

    public void OpenDocument(){
        Console.WriteLine("Document opened");
    }

    public new void voidEditDocument()
    {
        Console.WriteLine("Document Edited");
    }

    public override void voidSaveDocument(){
        Console.WriteLine("Document Saved in pdf format");
    }
}
