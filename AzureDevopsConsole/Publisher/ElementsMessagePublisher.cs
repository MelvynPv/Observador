using AzureDevopsConsole.Subscriptor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AzureDevopsConsole.Publisher
{
    public class ElementsMessagePublisher
    {
        private List<ISubscriptor> _subscriptors = new List<ISubscriptor>();

        public void Subscrip(ISubscriptor subscriptor)
        {
            if (!ExistInstanceInSubscriptors(subscriptor))
            {
                _subscriptors.Add(subscriptor);
            }
            else 
            {
                Console.WriteLine("Ya esta subscripto...");
            }
        }

        public void Notify()
        {
            foreach (ISubscriptor subcriptor in _subscriptors)
            {
                subcriptor.notify();
            }
        }

        private bool ExistInstanceInSubscriptors(ISubscriptor subscriptor) 
        {
            return _subscriptors.Select(subs => subs.GetType()).Contains(subscriptor.GetType());
        }
    }
}
