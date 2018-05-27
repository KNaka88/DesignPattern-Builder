using System;

namespace FacetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives.At("123 London Road")
                    .In("London")
                    .WithPostcode("SW12AC")
                .Works.At("Apple")
                    .AsA("Engineer")
                    .Earning(1230);
            Console.WriteLine(person);
        }
    }
}
