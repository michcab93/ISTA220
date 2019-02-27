using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2
{
    class Program
    {
        static void Main(string[] args)
        {

            void introduction(string n, string t, string s, string d, string f)

            {
                Console.WriteLine($"I have an animal. \n It's name is {n}. \n {n} is {t}");
                Console.WriteLine($"{n} {s}");
                Console.WriteLine($"{n} {d}");
                Console.WriteLine($"{n} {f}");
            }

            Console.WriteLine("This is my animal farm");

            Cow instance = new Cow("cow", "an ordinary cow");
            string say = instance.Talk("mooo");
            string does = instance.Do("laydown and eat");
            string food = instance.Eat("grass");
            introduction("cow", "ordinary cow", say, does, food);

            
            Cow instance2 = new Cow("Fred","a Chick-fil_a");

           // Console.WriteLine($"I have a cow. \n His name is {n}. \n He is a {t} cow");
            string says2 = instance2.Talk("Eat mor chikn!");
           // Console.WriteLine($"{n} {says}");
            string does2 = instance2.Do("make signs");
           // Console.WriteLine($"{n} {does}");
            string food2 = instance2.Eat("chicken sandwiches");
            // Console.WriteLine($"{n} {food}");

            introduction("Fred", "a chick-fil-a cow", says2, does2, food2);

            Cow instance3 = new Cow("Lola", "a Got milk cow");
            string says3 = instance2.Talk("got milk?");
            string does3 = instance2.Do("produce milk");
            string food3 = instance2.Eat("chocolate chip cookies");

            introduction("Lola", "a got milk cow", says3, does3, food3);

            Cow instance4 = new Cow("Mrs.O'Leary", "an arsonist cow");
            string says4 = instance4.Talk("whooops");
            string does4 = instance4.Do("set things on fire");
            string eats4 = instance4.Eat("chrispy meat");

            introduction("Mrs.O'Leary", "an arsonist cow", says4, does4, eats4);

            Pig pig = new Pig("pig", "an ordinary pig");
            string says5 = pig.Talk("oink, oink");
            string does5 = pig.Do("sleep");
            string eats5 = pig.Eat("left overs");

            introduction("pig", "an ordinary pig", says5, does5, eats5);

       
            Pig babe = new Pig("babe", "a sheep hearding pig");
            string says6 = pig.Talk("move along there, ya ... big buttheads!");
            string does6 = pig.Do("heard sheep");
            string eats6 = pig.Eat("only vegtables");

            introduction("babe", "a sheep hearding pig", says6, does6, eats6);

            Pig piglet = new Pig("Piglet", "a scared pig");
            string says7 = pig.Talk("Pooh?");
            string does7 = pig.Do("hide");
            string eats7 = pig.Eat("honey with Pooh");

            introduction("Piglet", "a scared pig", says7, does7, eats7);

            Pig rosita = new Pig("Rosita", "a mommy pig");
            string says8 = pig.Talk("Norma? are you listening?");
            string does8 = pig.Do("sing.");
            string eats8 = pig.Eat("nothing because she is too busy taking care of 20 piglets");

            introduction("Rosita", "a mommy pig", says8, does8, eats8);

            Chicken chicken = new Chicken("chiken", "ordinary chicken");
            string reproduce = chicken.reproduce("laying eggs");
            string feel = chicken.feel("lots of emotions");
            string sing = chicken.sing("by clucking");


            introduction("chicken", "ordinary chicken", reproduce, feel, sing);


            Chicken little = new Chicken("little", "a brave chicken");
            string reproduce2 = little.reproduce("not having offsprings because he is too little");
            string feel2 = little.feel("sad to dissapoint his father, but proud when he makes it up");
            string sing2 = little.sing("we are the champions");

            introduction("little", "a brave chicken", reproduce2, feel2, sing2);

            Chicken pox = new Chicken("chicken pox", "a bad sickness");
            string reproduce3 = pox.reproduce("simple touch");
            string feel3 = pox.feel("supper itchy!!!");
            string sing3 = pox.sing("no song, it just itches");

            introduction("pox", "a bad sickness", reproduce3, feel3, sing3);

            Chicken erni = new Chicken("Erni", "a fighting chicken");
            string reproduce4 = erni.reproduce("not reproducing because he is to busy fighting");
            string feel4 = erni.feel("vengful");
            string sing4 = erni.sing("lots of Ludacrist");

            introduction("Erni", "a fighting chicken", reproduce4, feel4, sing4);


            Rabit rabit = new Rabit("Rabit", "ordinary bunny");
            string love = rabit.love("to hop");
            string want = rabit.want("to eat carrots");
            string dwells = rabit.dwells("a rabbit hole");

            introduction("Rabit", "ordinary rabit", love, want, dwells);

            Rabit Judy = new Rabit("Juddy Hops", " a cop bunny");
            string love2 = Judy.love("her job");
            string want2 = Judy.want("to catch the bad guys");
            string dwells2 = Judy.dwells("Zootopia");

            introduction("Judy Hops", "a cop rabit", love2, want2, dwells2);

            Rabit Bugs = new Rabit("Bugs", "slick bunny");
            string love3 = Bugs.love("playing tricks");
            string want3 = Bugs.want("to get away with eveythirg");
            string dwells3 = Bugs.dwells("any place where there are hunters");

            introduction("Bugs", "slick bunny", love3, want3, dwells3);

            Rabit Easter = new Rabit("Spring", "the Easter Bunny");
            string love4 = Easter.love("hide eggs");
            string want4 = Easter.want("you to find the eggs");
            string dwells4 = Easter.dwells("in the land of magical creatures");

            introduction("Spring", "the Easter Bunny", love4, want4, dwells4);
                                                                               

         /*   string n2 = "Joe";
            string t2 = "Ordinary";
            Console.WriteLine($"I have another cow. \n His name is {n2}. \n He is a {t2} cow");
            //string food = instance.Eat("grass");
            Console.WriteLine($"{n2} likes to eat {food}");


            Cow ordinary = new Cow();
            //string sound = ordinary.Talk();
            Console.WriteLine("This is a cow, it is ordinary");

            Cow second = new Cow("joe" , "ordinary cow");
            string say = second.Talk("Mooo");
            Console.WriteLine($"Joe says {say}");
            //string food = second.Graze();
            Console.WriteLine($"Joe eats {food}");*/
        }
    }
}
