namespace ProjectD.Common.Constants
{
    public static class DataConstants
    {
        public static class Map
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 3;

            public const double MaxLongitude = 180;
            public const double MinLongitude = -180;
            public const double MaxLatitude = 90;
            public const double MinLatitude = -90;

            public const double MinLength = 0;
            public const double MaxLength = 0;
        }

        public static class Message
        {
            public const int MaxTextLength = 150;
            public const int MinTextLength = 1;
        }

        public static class Racer
        {
            public const int MaxCarInfoLength = 80;
            public const int MinCarInfoLength = 5;
            public const int MaxNicknameLength = 30;
            public const int MinNicknameLength = 1;
        }

        public static class User
        {
            public const int MaxNameLength = 30;
            public const int MinNameLength = 2;
            public const int MaxPasswordLength = 60;
            public const int MinPasswordLength = 6;
        }

        public static class Room
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 2;
        }

        public static class Event
        {
            public const int MaxTitleLength = 50;
            public const int MinTitleLength = 2;

            public const int MaxTypeLength = 10;
            public const int MinTypeLength = 2;

            public const int MaxDescription = 300;
            public const int MaxCondition = 50;
        }

        public static class Ticket
        {

        }
    }
}
