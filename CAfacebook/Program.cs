using Humanizer;

namespace CAfacebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we need to change the logic of Comment date from numbers to string (since 3 days , since 4 minutes  )
            // we us enuget package: Humanizer.Core
            // look to method (2)
            var fb = new List<FBComment>()
            {
                new FBComment()
                {
                    Owner="Rami S.",
                    Comment ="I Love Ranim",
                    CreatAt = DateTime.Now
                },
                new FBComment()
                {
                    Owner="Sami S.",
                    Comment ="I Love Sanim",
                    CreatAt = new DateTime(2021, 01, 03, 12, 30, 00)
                },
                new FBComment()
                {
                    Owner="Fami S.",
                    Comment ="I Love Fanim",
                    CreatAt = DateTime.Now.AddDays(-1)
                },
                new FBComment()
                {
                    Owner="Aami S.",
                    Comment ="I Love Aanim",
                    CreatAt = DateTime.Now.AddDays(-2)
                },
                new FBComment()
                {
                    Owner="Qami S.",
                    Comment ="I Love Qanim",
                    CreatAt = DateTime.Now.AddDays(-3)
                },
            };

            foreach (FBComment comment in fb)
            {
                Console.WriteLine(comment);
                Console.WriteLine("---------------------");
            }
            // we need to change the logic of Comment date from numbers to string (since 3 days , since 4 minutes  )
            // we us enuget package: Humanizer.Core
            // look to method (2)
            

            Console.ReadKey();
        }
    }
    class FBComment
    {
        public string? Owner { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatAt { get; set; }

        //----------------(1)---------------
        //public override string ToString()
        //{
        //    return $"{Owner} says: \n \"{Comment}\" \n\t\t\t\t {CreatAt.ToString("yyyy-MM-dd hh:mm")}";
        //}

        //----------------(2)---------------
        public override string ToString()
        {
            return $"{Owner} says: \n \"{Comment}\" \n\t\t\t\t {CreatAt.Humanize()}";
        }
    }
}