using System;



namespace lab3{
    public static class lab3{
        static int Main(){
            
            Car car = new Car();

            PassengerCar passengerCar = new PassengerCar();
            Lorry lorry = new Lorry();
            ArmoredTruck armoredTruck = new ArmoredTruck();

 /*           
            car.drive();
            Console.WriteLine("=======================");
            passengerCar.drive();
            lorry.drive();
            armoredTruck.drive();
     */       
            /////////////////////////////////////////////////////

            Bird bird = new Bird();
            Duck duck = new Duck();
            Seagull seagull = new Seagull();


            bird.fly();

            Console.WriteLine("=======================");

            duck.fly();
            duck.swim();

            Console.WriteLine("=======================");

            seagull.fly();
            seagull.swim();


            return 0;
        }
    }

    // Single Responsibility principle

    // bad implementation
    
    public class Car {
        public void drive(){
            Console.Write("I carry people\n");
            Console.Write("I carry cargo\n");
            Console.Write("I carry money\n");
        }
    }


    // good implementation
    public class PassengerCar {
        public void drive(){
            Console.Write("I carry people\n");
        }
    }

    public class Lorry {
        public void drive(){
            Console.Write("I carry cargo\n");
        }
    }

    public class ArmoredTruck {
        public void drive(){
            Console.Write("I carry money\n");
        }
    }



    // Liskov substitution principle



    public class Bird(){
        public void fly(){
            Console.Write("*flies*\n");
        }
    }

    // bad implementation

    public class Duck(){
        public void fly(){
            Console.Write("*flies*\n");
        }
        public void swim(){
            Console.Write("*swims*\n");
        }
    }

    // good implementation

    public class Seagull() : Duck{
        public void swim() {
            Console.Write("*swims*\n");
        }
    }

}