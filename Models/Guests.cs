﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]

    public class Guests
    {
        // RoomId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string GuestId { get; set; }


        //represent the Guests's number
        [BsonElement("guest_number"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int GuestNumber { get; set; }


        //represent the Guests's first name
        [BsonElement("first_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string FirstName { get; set; }


        //represent the Guests's last name
        [BsonElement("last_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string LastName { get; set; }

        //represent the Guests's phone number
        [BsonElement("phone_number"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string PhoneNumber { get; set; }

        //represent the Guests's room type(FK)
        [BsonElement("guest_room_type"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int GuestRoomType { get; set; }

        //represent the Guests's room number
        [BsonElement("guest_room_number"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int GuestRoomNumber { get; set; }

        //represent how many guests are staying in the room
        [BsonElement("persons"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Persons { get; set; }

        //represent the Guests's check in date
        [BsonElement("check_in_date"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime CheckInDate { get; set; }

        //represent the Guests's check out date
        [BsonElement("check_out_date"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime CheckOutDate { get; set; }




        //CTOR
        public Guests(int guestNumber, string firstName, string lastName, string phoneNumber, int guestRoomType, 
            int guestRoomNumber, int persons, DateTime checkInDate, DateTime checkOutDate)
        {
            this.GuestNumber = guestNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.GuestRoomNumber = guestRoomNumber;
            this.Persons = persons;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;

        }


        public override string ToString()
        {
            string str = "";

            str += "Guest's Unique ID Number: " + this.GuestNumber.ToString() +
                "\nGuest Room Number: " + this.GuestRoomNumber.ToString() +
                "\nGuest Full Name: " + this.FirstName + " " + this.LastName +
                "\nGuest Phone Number: " + this.PhoneNumber +
                "\nNumber of persons Booked in the room: " + this.Persons.ToString()+
                "\nCheck-in Date: " + this.CheckInDate.ToString() + " Check-out Date: " + this.CheckOutDate.ToString();
            return str;
        }

    }

}
