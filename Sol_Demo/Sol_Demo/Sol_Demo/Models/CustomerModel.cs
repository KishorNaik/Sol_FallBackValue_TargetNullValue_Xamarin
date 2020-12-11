using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Models
{
    public class CustomerModel : ObservableObject
    {
        private String fullName;

        public String FullName
        {
            get => fullName;
            set => base.SetProperty(ref fullName, value);
        }
    }
}