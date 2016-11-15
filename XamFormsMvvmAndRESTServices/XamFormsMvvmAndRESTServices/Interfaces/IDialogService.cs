namespace XamMvvmAndWebServices.Interfaces
{

    //SHOW: IDialoService used to define platform-specific dialog boxes
    public interface IDialogService
    {
        void Alert(string message, string title, string okbtnText);
    }
}