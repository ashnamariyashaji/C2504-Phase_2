using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace FullNameProject
{
    public delegate void DWidnowClose();
    public class PersonViewModel : INotifyPropertyChanged
    {
        public DWidnowClose NewWindowClose;
        public DWidnowClose EditWindowClose;
        //
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        //        
        private PersonModel _Person = null;
        public PersonModel Person
        {
            get => Person;
            set { _Person = value; OnPropertyChanged(nameof(PersonModel)); }
        }
        //
        private PersonModel _editablePerson = null;
        public PersonModel EditablePerson
        {
            get => _editablePerson;
            set {   _editablePerson = value; OnPropertyChanged(nameof(EditablePerson)); }
        }
        
        public ICommand UpdateCommand { get; }
       
      
        public PersonViewModel ()
        {
            this.Person = new PersonModel {FirstName="Ashna",LastName="Mariya" };
            
            UpdateCommand = new RelayCommand(Update);
           
        }
        
        public void Update()
        {
            var result = MessageBox.Show(messageBoxText: "Are you sure to update",
                caption: "Confirm",
                button: MessageBoxButton.YesNo,
                icon: MessageBoxImage.Question);
            if (this.EditablePerson == null)
            {
                return;
            }

            this.EditablePerson = this.EditablePerson;
             result = MessageBox.Show(messageBoxText: "Updated Successfully",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);
            if (EditWindowClose != null)
            {
                EditWindowClose();
            }

            
        }
        //public void Delete()
        //{
        //    if (this.SelectedItenary == null)
        //    {
        //        return;
        //    }
        //    this.Iternaries.Remove(this.SelectedItenary);
        //    this.SelectedItenary = null;
        //}
    }
}
