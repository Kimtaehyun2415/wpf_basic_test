using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using wpf_basic_app1.Model;

namespace wpf_basic_app1.ViewModel
{
    public class MyViewMdoel : MyModel
    {
        public MyViewMdoel()
        {
            this.Data = "1234";
            Obser_coll = new System.Collections.ObjectModel.ObservableCollection<string>();
            Obser_coll.Add("TEST");
            Properties.Settings.Default.test_string = "TEST_STRING_GET";

            Properties.Settings.Default.Save();

        }
    }
}
