using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Synchronization_Demo
{
    internal class BookMyShow
    {
        int availableTickets = 3;
        int noOfTicketsToBeBookedByThread1 = 1, noOfTicketsToBeBookedByThread2 = 2, noOfTicketsToBeBookedByThread3 = 3;
        
        static readonly object lockObject = new object();

        private void BookingTicket(string threadName, int noOfTicketsToBeNeededByThread)
        {
            lock (lockObject)
            {
                if (noOfTicketsToBeNeededByThread <= availableTickets)
                {
                    Console.WriteLine($"Thread with name {threadName} booked {noOfTicketsToBeNeededByThread} tickets");
                    availableTickets = availableTickets - noOfTicketsToBeNeededByThread;
                }
                else
                {
                    Console.WriteLine("No tickets available tyo book...");
                }
            }
        }

        public void BookTicket()
        {
            string threadName = Thread.CurrentThread.Name;
            if (threadName.Equals("thread1"))
            {
                BookingTicket(threadName, noOfTicketsToBeBookedByThread1);
            } else if (threadName.Equals("thread2"))
            {
                BookingTicket(threadName, noOfTicketsToBeBookedByThread2);
            } else 
            {
                BookingTicket(threadName, noOfTicketsToBeBookedByThread3);
            }
        }
    }
}
