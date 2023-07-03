namespace VetClinic.interfaces
{
    public interface IForm
    {
        void ShowRecords();
        void AddRecord();
        void UpdateRecord();
        void DeleteRecord();
        void ChangeVisibleGroupBox(bool isVisible);
    }
}
