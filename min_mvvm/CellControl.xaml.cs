using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace min_mvvm {
    /// <summary>
    /// Логика взаимодействия для CellControl.xaml
    /// </summary>
    public partial class CellControl : UserControl {
        public CellControl() {
            InitializeComponent();
            //DataContext = this;
        }
        //public int Value { get; set; }
        //public bool IsOpen { get; set; }
        //public bool IsEmpty { get; set; }
        //public bool IsBobm{ get; set; }


        public int Value {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(CellControl), new PropertyMetadata(0));


        public bool IsBomb {
            get { return (bool)GetValue(IsBombProperty); }
            set { SetValue(IsBombProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsBomb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBombProperty =
            DependencyProperty.Register("IsBomb", typeof(bool), typeof(CellControl), new PropertyMetadata(false));


        public bool IsEmpty {
            get { return (bool)GetValue(IsEmptyProperty); }
            set { SetValue(IsEmptyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsEmpty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEmptyProperty =
            DependencyProperty.Register("IsEmpty", typeof(bool), typeof(CellControl), new PropertyMetadata(false));


        public bool IsOpen {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(CellControl), new PropertyMetadata(false));






    }
}
