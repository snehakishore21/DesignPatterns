using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    //facade
    //provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
    //wrap a complicated subsystem with a simpler interface.
    //implement a wrapper over a poorly designed collection of classes, each with different interfaces.
    //implementing complex or difficult-to-understand subsystems that have complex dependencies with other subsystems.
    public class Facade
    {
        private SubSystemClass1 _subSystemClass1;
        private SubSystemClass2 _subSystemClass2;
        private SubSystemClass3 _subSystemClass3;
        private SubSystemClass4 _subSystemClass4;

        public Facade()
        {
            _subSystemClass1 = new SubSystemClass1();
            _subSystemClass2 = new SubSystemClass2();
            _subSystemClass3 = new SubSystemClass3();
            _subSystemClass4 = new SubSystemClass4();
        }

        public void ChooseProducts()
        {
            _subSystemClass1.ChooseDress();
            _subSystemClass1.ChooseAccessory();
        }

        public void PlaceOrder()
        {
            _subSystemClass2.AddToCart();
            _subSystemClass2.ApplyDiscount();
            _subSystemClass3.AddAddress();
            _subSystemClass3.AddPayment();
            _subSystemClass3.ConfirmOrder();
        }

        public void TrackOrder()
        {
            _subSystemClass4.TrackOrder();
            _subSystemClass3.NotifyCustomer();
        }
    }
}
