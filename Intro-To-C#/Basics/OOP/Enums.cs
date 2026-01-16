using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_To_CSharp.Basics.OOP
{
    // Enums using Days in Week
    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class EnumDays
    {
        private static void ListOfDays()
        {
            int WeekDayStart = (int)Days.Sunday;
            int WeekDayEnd = (int)Days.Saturday;

            Console.WriteLine("Days of the week:");
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{(int)day}: {day}");
            }
            Console.WriteLine($"\nThe Week starts on {WeekDayStart} and its end on {WeekDayEnd}");
        }
        private static void SpeficDay()
        {

            Days today = Days.Thursday;

            switch (today)
            {
                case Days.Sunday: Console.WriteLine("It's Sunday"); break;
                case Days.Monday: Console.WriteLine("It's Sunday"); break;
                case Days.Tuesday: Console.WriteLine("It's Sunday"); break;
                case Days.Wednesday: Console.WriteLine("It's Sunday"); break;
                case Days.Thursday: Console.WriteLine("It's Sunday"); break;
                case Days.Friday: Console.WriteLine("It's Sunday"); break;
                case Days.Saturday: Console.WriteLine("It's Sunday"); break;

            }

        }

        public static void Demonstrate()
        {
            ListOfDays();
            Console.WriteLine();
            SpeficDay();
        }
       
    }
    // Specifying Enum Values
    enum StatusCode
    {
        Success = 200,
        NotFound = 404,
        ServerError =500
    }
    class IdentifyStatusCode
    {
        public static void Demonstrate()
        {
            StatusCode code = StatusCode.Success;
            foreach(StatusCode status in Enum.GetValues(typeof(StatusCode)))
            {
                if (code == status) Console.WriteLine($"Status : {status}");  
            }
        }
    }
    // Comning Multiple Values Using Enum Flags
    [Flags]
    enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        FullControl = Read | Write | Execute
    }
    static class Roles
    {
        public static readonly Permission Admin = Permission.FullControl;
        public static readonly Permission Patron = Permission.Read | Permission.Write;
        public static readonly Permission Guest = Permission.None;
        public static readonly Permission Student = Permission.Read;
        public static readonly Permission Teacher = Permission.Write;
    }
    class PermissionManagement
    {
        // Map role names to their permissions
        private static readonly Dictionary<string, Permission> roleMap = new()
    {
        { "Admin", Roles.Admin },
        { "Patron", Roles.Patron },
        { "Guest", Roles.Guest },
        { "Student", Roles.Student },
        { "Teacher", Roles.Teacher }
    };

        // Helper to check if a permission contains all required flags
        private static bool HasPermissions(Permission userPermission, Permission required)
        {
            if (required == Permission.None)
                return userPermission == Permission.None; // exact match for Guest

            return (userPermission & required) == required;
        }


        // Determine the role without using if/else
        public static void Demonstrate(Permission userPermission)
        {
            foreach (var kvp in roleMap)
            {
                if (HasPermissions(userPermission, kvp.Value))
                {
                    Console.WriteLine($"You are a {kvp.Key}");
                    return; // stop after first match
                }
            }

            Console.WriteLine("Unknown Role");
        }

        public static void Run()
        {
            Console.WriteLine("Permission Management Demo:");
            PermissionManagement.Demonstrate(Permission.FullControl);
            PermissionManagement.Demonstrate(Permission.Read | Permission.Write);
            PermissionManagement.Demonstrate(Permission.None);
            PermissionManagement.Demonstrate(Permission.Write);
            PermissionManagement.Demonstrate(Permission.Read);
        }
    }
    // String to Integers Enums 
     enum OrderStatus
    {
        Pending = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
    class Order
    {
        public static void GetOrderStatus()
        {
            // String to Enum
            string input = "Processing";
            OrderStatus statusFromString = (OrderStatus)Enum.Parse(typeof(OrderStatus), input);
            Console.WriteLine($"Order status from string '{input}': {statusFromString}");

            // Interger to Enum
            int value = 3;
            OrderStatus statusFormat = (OrderStatus)value;
            Console.WriteLine($"Order status from integer '{value}': {statusFormat}");
        }

    }
    internal class Enums
    {
        public static void Demonstations()
        {
            EnumDays.Demonstrate();
            Console.WriteLine();
            IdentifyStatusCode.Demonstrate();
            Console.WriteLine();
            PermissionManagement.Run();
            Console.WriteLine();
            Order.GetOrderStatus();
        }
    }
}

