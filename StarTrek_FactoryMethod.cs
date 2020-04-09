using System;
using System.Collections.Generic;

namespace DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    /// <summary>
    /// Factory Method Design Pattern.
    /// 
    /// Definition: The Factory Method Design Pattern defines an interface or abstract class 
    /// that contains a method that is used to create an object; however, subclasses instantiate
    /// concrete instances of the object.
    /// 
    /// The primary objective of the Factory Method is extensibility.
    /// 
    /// The Factory Method differs from the Abstract Factory Pattern in that
    /// Factory Methods are abstract and return object types whereas
    /// the methods used to implement the Abstract Factory Pattern are virtual or abstract 
    /// and return abstract classes or interfaces (not objects).
    /// 
    /// In other words, Factory Methods return objects 
    /// and Abstract Factory Methods return abstract classes or interfaces.
    /// 
    /// 
    /// In the example below, we use the Factory Method to create different species in the Star Trek universe.
    /// 
    /// We use a Factory Method (defined as "CreateAttributes()" in an abstract class called "Species") to 
    /// create attributes.  The CreateAttributes() method is overriden in concrete implementations of "Species"
    /// to generate specific attributes for each unique species.
    /// 
    /// This satisifies the "Open-Closed" principle (see S.O.L.I.D. principles) in that the abstract class Species
    /// is open for extension but closed for modification.
    /// 
    /// </summary>
    public class Program
    {
       
        static void Main()
        {
            // Species constructors will call the Factory Method CreateAttributes()
            // For now, we create a list of species (Immortal and Mortal)...
            var speciesList = new List<Species> { new Immortal(), new Mortal() };

            // Display the attributes of each Star Trek species in the speciesList
            foreach (var species in speciesList)
            {
                Console.WriteLine(species + "--");
                foreach (var attribute in species.Attributes)
                {
                    Console.WriteLine(" " + attribute);
                }
                Console.WriteLine();
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Product' abstract class
    /// In this case, 'Product' is defined as an Attribute
    /// Each species (Mortal and Immortal) in the Star Trek universe has attributes
    /// </summary>
    abstract class Attribute
    {
        // Override. Display class name
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class ImmortalPower : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class Intelligence : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class Experience : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class Disposition : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class TechnicalExpertise : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class FightingSkills : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class Spirituality : Attribute
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// ConcreteProduct represents a specific type of Attribute (the abstract base class)
    /// </summary>
    class LifeSpan : Attribute
    {
    }

    /// <summary>
    /// The 'Creator' abstract class (Species)
    /// Creates different Star Trek species
    /// </summary>
    abstract class Species
    {
        // Constructor invokes Factory Method, "CreateAttributes()",
        // to dynamically generate attributes based on concrete class implementations of the abstract "Attribute" class
        public Species()
        {
            this.CreateAttributes();
        }

        // Gets list of species attributes
        public List<Attribute> Attributes { get; protected set; }

        // Factory Method: this will be overridden by the Concrete classes
        public abstract void CreateAttributes();

        // Override
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// ConcreteCreator classes create specific species (inheriting from the abstract "Species" class)
    /// 
    /// The CreateAttributes() method (defined as a Factory Method in the abstract base class) is overriden,
    /// and specific attributes are created based on the type of species (Immortal or Mortal)
    /// </summary>
    class Immortal : Species
    {
        // Factory Method implementation
        public override void CreateAttributes()
        {
            Attributes = new List<Attribute>
              { new ImmortalPower(),
                new Intelligence(),
                new Experience() };
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// ConcreteCreator classes create specific species (inheriting from the abstract "Species" class)
    /// 
    /// The CreateAttributes() method (defined as a Factory Method in the abstract base class) is overriden,
    /// and specific attributes are created based on the type of species (Immortal or Mortal)
    /// </summary>
    class Mortal : Species
    {
        // Factory Method implementation
        public override void CreateAttributes()
        {
            Attributes = new List<Attribute>
                { new Disposition(),
                  new TechnicalExpertise(),
                  new FightingSkills(),
                  new Spirituality(),
                  new LifeSpan() };
        }
    }
}
