using Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone.Data
{
    public static class DatabaseMoq
    {
        public static List<SubscriberModel> Subscribers { get; set; }

        static DatabaseMoq()
        {
            Subscribers = new List<SubscriberModel>()
            {
                new SubscriberModel()
                {
                    Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQf3_9yjPB5QAK1s36tSmqhmwtOdp1ND4Q2zJBk6ymr89gc_m7BpdVg4bPZHYW2sgLphfA&usqp=CAU",
                    Name = "Vlad",
                },
                new SubscriberModel()
                {
                    Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQf3_9yjPB5QAK1s36tSmqhmwtOdp1ND4Q2zJBk6ymr89gc_m7BpdVg4bPZHYW2sgLphfA&usqp=CAU",
                    Name = "Daniel",
                },
                new SubscriberModel()
                {
                    Name = "Rostik",
                },
                new SubscriberModel()
                {
                    Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRfF1tNyfdpPyKNQTlqYEM4T-jhdcuNY61mJQ&usqp=CAU",
                    Name = "Kisia",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
                new SubscriberModel()
                {
                    Name = "Liza",
                },
            };
        }
    }
}
