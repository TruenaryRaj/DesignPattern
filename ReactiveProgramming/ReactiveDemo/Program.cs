/* Reactive Programming:
 * Reactive programming is a programming paradigm oriented around data flows and the change of data. It is similarly like 
 * observer design pattern, where an object subscribes to changes in another object. In reactive programming, the data 
 * are treated as streams that can be observed and react over time. In this example, we have time intervals as observable streams
 * and each time a new value is emmited it calls the subscriber's callback function to process the value if it is not disposed.
 * As the name suggests reactive programming basically is reacting to changes in data streams.
 */

using System;
using System.Reactive.Linq;

class Program
{
    static void Main()
    {
        var numberStream = Observable.Interval(TimeSpan.FromSeconds(1));

        var subscriber = numberStream.Subscribe(
            number => Console.WriteLine($"Subscriber 1 : {number}"),
            error => Console.WriteLine($"Subscriber 1 : {error.Message}"),
            () => Console.WriteLine("Subscriber 1 Done!")
        );

        var subscriber2 = numberStream.Subscribe(
            number => Console.WriteLine($"Subscriber 2 : {number}"),
            error => Console.WriteLine($"Subscriber 2 : {error.Message}"),
            () => Console.WriteLine("Subscriber 2 done!")
        );

        Console.ReadLine();
        subscriber.Dispose();

        Console.ReadLine();
        subscriber2.Dispose();
    }
}
