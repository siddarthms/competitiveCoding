using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp12.Chain;

namespace ConsoleApp12
{
    public class Chain
    {

        public abstract class ILeavepprover
        {
            public abstract void Approve(int Leavedays);

            protected ILeavepprover _next;

            public void SetNextApprover(ILeavepprover nextapprover)
            {
                _next = nextapprover;
            }
        }

        public class TeamLead : ILeavepprover
        {

            public override void Approve(int Leavedays)
            {
                if (Leavedays <= 2)
                    Console.Write("approved by Lead");
                else
                    _next.Approve(Leavedays);

            }
        }

        public class Manager : ILeavepprover
        {

            public override void Approve(int Leavedays)
            {
                if (Leavedays <= 2)
                    Console.Write("approved by Lead");
                else
                    _next.Approve(Leavedays);
            }
        };

        public void apporvleave(int days)
        {

            var manager = new Manager();

            var lead = new TeamLead();
            lead.SetNextApprover(manager);
            lead.Approve(days);

        }

        public interface IPizzaBuilder
        {

            void SetDough();
            void SetSauce();
            void SetTopping();

            Pizza GetPizza();

        }

        public class Pizza
        {
            public string Dough { get; set; }
            public string Sauce { get; set; }
            public string Topping { get; set; }


            public override string ToString()
            {
                return $"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.";
            }
        }


        public class MarggerettaPizza : IPizzaBuilder
        {
            Pizza _builder;

            public MarggerettaPizza()
            {
                _builder = new Pizza();
            }
            public void SetDough() => _builder.Dough = "thin crust";
            public void SetSauce() => _builder.Sauce = "tonamato";
            public void SetTopping() => _builder.Topping = "Mozzarella";
            public Pizza GetPizza() => _builder;
        }
        public class CheesePizza : IPizzaBuilder
        {
            Pizza _builder;

            public CheesePizza()
            {
                _builder = new Pizza();
            }
            public void SetDough() => _builder.Dough = "hard crust";
            public void SetSauce() => _builder.Sauce = "white";
            public void SetTopping() => _builder.Topping = "cheese";
            public Pizza GetPizza() => _builder;
        }

        public class PizzaDirector
        {
            private IPizzaBuilder _builder;

            public PizzaDirector(IPizzaBuilder builder)
            {
                _builder = builder;
            }

            public void MakePizza()
            {
                _builder.SetDough();
                _builder.SetSauce();
                _builder.SetTopping();
            }
        }


        public void buildPizza()
        {
            IPizzaBuilder margeretta = new MarggerettaPizza();

            PizzaDirector pizzaBuilder = new PizzaDirector(margeretta);
            pizzaBuilder.MakePizza();
            
            margeretta.GetPizza().ToString();

        }


        public interface Isubscriber
        {
            void Notify(string channelName, string videoTitle);
        }

        public class Subscriber : Isubscriber 
        {
            string _name;
            public Subscriber(string name)
            {
                _name = name;
            }
            public void Notify(string channelName, string videoTitle)
            {
                Console.WriteLine($"notified {_name} as a video uploaded on channel {channelName} with title {videoTitle}");
            }
        }



        public class youtubeChannel 
        {
            List<Isubscriber> _Subs = new List<Isubscriber>();

            string _name;

            youtubeChannel(string Name)
            {
                _name = Name;
            }

            public void subscribe(Isubscriber subs)
            {
                _Subs.Add(subs);
            }

            public void Unsubscribe(Isubscriber subs)
            {
                _Subs.Remove(subs);
            }
            public void UploadVideo(string title)
            {
                _Subs.ForEach(x => x.Notify(_name, title));
            }
        }

    }
}
