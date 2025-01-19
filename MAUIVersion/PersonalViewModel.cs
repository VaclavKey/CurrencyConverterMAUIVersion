using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIVersion
{
    class PersonalViewModel : INotifyPropertyChanged
    {
        public static string currentCurrency { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

    }
}
