using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace min_mvvm {
    public class Cell : INotifyPropertyChanged {
        public Cell() {
            Random rnd = new Random();
            Value = rnd.Next(-3, 9);
            IsOpen = true;
        }
        #region propfull
        private int _value;
        public int Value {
            get { return _value; }
            set {
                _value = value;
                if (value == -1) {
                    IsBomb = true;
                } else if (value == 0) {
                    IsEmpty = true;
                }
                OnPropertyChanged("Value");
            }
        }
        private bool _isOpen;
        public bool IsOpen {
            get { return _isOpen; }
            set {
                _isOpen = value;
                OnPropertyChanged("IsOpen");
            }
        }
        private bool _isEmpty;
        public bool IsEmpty {
            get { return _isEmpty; }
            set {
                _isEmpty = value;
                OnPropertyChanged("IsEmpty");
            }
        }
        private bool _isFlag;
        public bool IsFlag {
            get { return _isFlag; }
            set {
                _isFlag = value;
                OnPropertyChanged("IsFlag");
            }
        }
        private bool _isBomb;
        public bool IsBomb {
            get { return _isBomb; }
            set {
                _isBomb = value;
                OnPropertyChanged("IsBomb");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        //public event EventHandler OpenEvent;
        //public event Action<Cell> OpenEvent2;


        //public void Open() {
        //    OpenEvent?.Invoke(this, null);
        //    //OpenEvent2(this);
        //}

        //public void LeftClick() {
        //    if (IsEmpty) {
        //        IsOpen = true;
        //        Open();
        //    }
        //}

        //public void RightClick() {
        //    if (!IsOpen) {
        //        IsFlag = !IsFlag;
        //    }
        //}
    }
}
