using SOLID__Review_the_queue___Liskov_Substitution;
using System.Collections.Generic;

var myIntQueue = new IntQueue();

myIntQueue.Queue(1);
myIntQueue.Queue(2);
myIntQueue.Queue(3);
myIntQueue.Queue(4);

myIntQueue.Dequeue();
myIntQueue.Peek();

//-------------------------------------------

var myStringQueue = new StringQueue();

myStringQueue.Queue("Marco");
myStringQueue.Queue("Luca");
myStringQueue.Queue("Emanuele");
myStringQueue.Queue("Alberto");

myStringQueue.Dequeue();
myStringQueue.Peek();