using MvvmHelpers;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public CustomerViewModel()
        {
            Customer = new CustomerModel();
            Customer.FullName = null;
        }

        private CustomerModel customerModel = null;

        public CustomerModel Customer
        {
            get => this.customerModel;
            set => base.SetProperty(ref customerModel, value);
        }
    }
}