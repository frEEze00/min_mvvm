using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace min_mvvm {
    public class ApplicationViewModel : INotifyPropertyChanged {
        public ApplicationViewModel() {
            Cells = new ObservableCollection<Cell>() {
                new Cell(){Value = 1, IsBomb = false, IsEmpty = false, IsOpen= false},
                 new Cell(){Value = 0, IsBomb = false, IsEmpty = true, IsOpen= false},
                  new Cell(){Value = -1, IsBomb = true, IsEmpty = false, IsOpen= false},
                   new Cell(){Value = 2, IsBomb = false, IsEmpty = false, IsOpen= true},
                    new Cell(){Value = 1, IsBomb = false, IsEmpty = false, IsOpen= false},
            };
            SCell = new Cell() { Value = 5, IsBomb = false, IsEmpty = false, IsOpen = false };
        }
        private RelayCommand addCommand;
        public RelayCommand AddCommand {
            get {
                return addCommand ??
                  (addCommand = new RelayCommand(obj => {
                      Cell cell = new Cell();
                      Cells.Insert(0, cell);
                      SCell = cell;
                      MessageBox.Show("Sdad");
                      //OnPropertyChanged("SCell");
                  }));
            }
        }
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand {
            get {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj => {
                      Cell phone = obj as Cell;
                      if (phone != null) {
                          Cells.Remove(phone);
                      }
                  },
                 (obj) => Cells.Count > 0));
            }
        }

        private Cell selectedCell;
        public Cell SelectedCell {
            get { return selectedCell; }
            set {
                selectedCell = value;
                OnPropertyChanged("SelectedCell");
            }
        }


        public ObservableCollection<Cell> Cells { get; set; }
        public Cell SCell { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
