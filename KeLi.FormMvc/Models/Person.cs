using System.ComponentModel;
using System.Runtime.CompilerServices;

using KeLi.FormMvc.Properties;

namespace KeLi.FormMvc.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string id;

        private string name;

        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id
        {
            get => id;

            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => name;

            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}