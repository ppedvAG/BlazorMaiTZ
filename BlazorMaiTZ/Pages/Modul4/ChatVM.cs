namespace BlazorMaiTZ.Pages.Modul4
{
    public class ChatVM
    {
        public Action OnAdd;
        public List<NachrichtModel> NachrichtenListe { get; set; }=
            new List<NachrichtModel>();
        public void Add(string msg)
        {
            NachrichtenListe.Add(new NachrichtModel() { Text = msg });
            OnAdd?.Invoke();    
        }
    }
}
