namespace Task;

public class ProDocumentProgram : DocumentProgram
{
    public void OpenDocument(){
        Console.WriteLine("Document opened");
    }
    public override sealed void voidEditDocument(){
        Console.WriteLine("Document Edited");
    }
    override public void voidSaveDocument(){
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }

}
