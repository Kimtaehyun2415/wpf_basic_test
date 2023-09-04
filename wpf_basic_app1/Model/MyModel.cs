using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_basic_app1.Model
{
    public class MyModel : MyModelBase
    {
        string data;
        ObservableCollection<string> obser_coll;

        public string Data { get => data; set => data = value; }
        public ObservableCollection<string> Obser_coll { get => obser_coll; set => obser_coll = value; }
    }
}
