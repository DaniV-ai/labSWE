using System;


// Single Responsibility principle
namespace lab3{
    public static class lab3{
        static int Main(){
            
            Car car = new Car();
            car.drive();


            PassengerCar passengerCar = new PassengerCar();
            Lorry lorry = new Lorry();
            ArmoredTruck armoredTruck = new ArmoredTruck();

            passengerCar.drive();
            lorry.drive();
            armoredTruck.drive();

            return 0;
        }
    }
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
}