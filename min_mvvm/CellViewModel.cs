using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace min_mvvm {
    public class CellViewModel : INotifyPropertyChanged {
        private Cell cell;
        public CellViewModel(Cell c) {
            cell = c;
        }
        #region propfull
        public int Value {
            get { return cell.Value; }
            set {
                cell.Value = value;
                if (value == -1) {
                    IsBomb = true;
                } else if (value == 0) {
                    IsEmpty = true;
                }
                OnPropertyChanged("Value");
            }
        }
        public bool IsOpen {
            get { return cell.IsOpen; }
            set {
                cell.IsOpen = value;
                OnPropertyChanged("IsOpen");
            }
        }
        public bool IsEmpty {
            get { return cell.IsEmpty; }
            set {
                cell.IsEmpty = value;
                OnPropertyChanged("IsEmpty");
            }
        }
        public bool IsFlag {
            get { return cell.IsFlag; }
            set {
                cell.IsFlag = value;
                OnPropertyChanged("IsFlag");
            }
        }
        public bool IsBomb {
            get { return cell.IsBomb; }
            set {
                cell.IsBomb = value;
                OnPropertyChanged("IsBomb");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
