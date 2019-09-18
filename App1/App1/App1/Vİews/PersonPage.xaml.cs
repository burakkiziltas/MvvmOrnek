using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Vİews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentPage
    {
        private readonly IList<PersonModel> model = new ObservableCollection<PersonModel>();
        public PersonPage()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {
            model.Add(new PersonModel
            {
                Id=1,
                Name="Burak",
                Surname="Kızıltaş"
            });
            model.Add(new PersonModel
            {
                Id = 2,
                Name = "Burak",
                Surname = "Kızıltaş"
            });
            lstPerson.BindingContext = model;
        }

        private void onDelete(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            PersonModel selectedModel = (PersonModel)item.CommandParameter;
            if (selectedModel!=null)
            {
                model.Remove(selectedModel);
            }
        }

        private void onUpdate(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            PersonModel selectedModel = (PersonModel)item.CommandParameter;
            if (selectedModel != null)
            {
                selectedModel.Name = "dasdasd";
            }
        }
    }
}