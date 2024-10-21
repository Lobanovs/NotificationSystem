using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSystem.Interfaces;

namespace NotificationSystem.Models
{
    public class SMSNotification : INotification
    {
        private readonly string _phoneNumber;

        public SMSNotification(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Отправка SMS на номер {_phoneNumber}: {message}");
        }
    }
}
