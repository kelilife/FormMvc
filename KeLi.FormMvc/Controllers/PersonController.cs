using System.Windows.Forms;

using KeLi.FormMvc.Models;
using KeLi.FormMvc.Views;

namespace KeLi.FormMvc.Controllers
{
    public class PersonController
    {
        public PersonController(PersonForm view)
        {
            View = view;
            Model = new Person("001", "Max");
            View.Controller = this;
        }

        public PersonForm View { get; set; }

        public Person Model { get; set; }

        public void UpdateItem()
        {
            MessageBox.Show($"Id: {Model.Id}\r\nName: {Model.Name}");
        }
    }
}