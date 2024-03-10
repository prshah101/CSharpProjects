using System;

namespace RobotSimulation
{
    //The object defines the set directions that the Robot can face
    public enum Direction
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }


    //The class defines the attributes and functions of the Robot
    public class Robot
    {
        // Gets or sets the X-coordinate of the robot's position on the map.
        public int X { get; set; }
        //Gets or sets the Y-coordinate of the robot's position on the map.
        public int Y { get; set; }
        //Gets or sets the direction the robot is facing.
        public Direction Facing { get; set; }

        //Function for placing the robot
        public void Place(int x, int y, Direction facing)
        {
            // Check that coordinates are within the boundries of the map (and positive integers)
            if (x >= 0 && x < Map.Size && y >= 0 && y < Map.Size)
            {
                // If so, update the robot's position and facing direction
                X = x;
                Y = y;
                Facing = facing;
            }
        }

        //Function for when the robot moves 1 unit
        public void Move()
        {
            // Store the current position of the robot
            int newX = X, newY = Y;

            // Continue based on the current direction the robot is facing, increment the relevant coordinate value
            switch (Facing)
            {
                case Direction.NORTH:
                    newY++;
                    break;
                case Direction.EAST:
                    newX++;
                    break;
                case Direction.SOUTH:
                    newY--;
                    break;
                case Direction.WEST:
                    newX--;
                    break;
            }

            // Check that coordinates are within the boundries of the map (and positive integers)
            if (newX >= 0 && newX < Map.Size && newY >= 0 && newY < Map.Size)
            {
                // Update the coordinates of the robot
                X = newX;
                Y = newY;
            }
        }

        //Function for when the robot runs left
        public void TurnLeft()
        {
            // Calculate the index of the new direction by subtracting 1 and handling wrap-around
            int newIndex = ((int)Facing + 3) % 4;
            // Set the new direction based on the calculated index
            Facing = (Direction)newIndex;
        }

        //Function for when the robot runs right
        public void TurnRight()
        {
            // Calculate the index of the new direction by adding 1 and handling wrap-around
            int newIndex = ((int)Facing + 1) % 4;
            // Set the new direction based on the calculated index
            Facing = (Direction)newIndex;
        }
    }

    //The class defines the artibutes of the Map
    public static class Map
    {
        public const int Size = 5;  //Note: Map is a square
    }

    //The class runs the main script and uses the other objects
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a robot object
            Robot robot = new Robot();
            //My Local placed value, (not the same as Placed)
            bool placed = false;

            //Keep running this loop
            while (true)
            {
                //Differnt color text on screen when informing the user of their options
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter a command (PLACE X,Y,D | LEFT | RIGHT | MOVE):");
                Console.ForegroundColor = ConsoleColor.Gray;

                //Read in the value inserted at the command line by the user
                string userInput = Console.ReadLine().Trim().ToUpper();

                //If Place was entered.
                //the robot on the map at coordinate (X,Y) facing the cardinal direction D out of 4 possible
                //directions: NORTH, EAST, SOUTH, WEST
                if (userInput.StartsWith("PLACE"))
                {
                    string[] placeCoordinates = Array.Empty<string>(); ;
                    try
                    {
                        placeCoordinates = userInput.Substring(6).Split(',');

                        if (placeCoordinates.Length == 3 && int.TryParse(placeCoordinates[0], out int x) && int.TryParse(placeCoordinates[1], out int y) && Enum.TryParse(placeCoordinates[2], out Direction facing))
                        {
                            robot.Place(x, y, facing);
                            //Set the boolean value to true, because the robot has now been placed
                            placed = true;
                            Console.WriteLine("====== The robot was placed sucessfully ======");

                        }
                        else
                        {
                            Console.WriteLine("Invalid command format. Please provide coordinates in the format 'PLACE X,Y,D'.");
                        }
                    }
                    //Try to catch the exception if the argument isn't in the correct format
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid command format. Please provide coordinates in the format 'PLACE X,Y,D'.");
                    }

                }
                //If Left was entered, turn the robot 90 degrees LEFT without changing its coordinates.
                else if (userInput == "LEFT" && placed == true)
                {
                    robot.TurnLeft();
                    Console.WriteLine($"Robot is at ({robot.X},{robot.Y}), facing {robot.Facing}");
                }
                //If Right was entered, Turn the robot 90 degrees RIGHT without changing its coordinates
                else if (userInput == "RIGHT" && placed == true)
                {
                    robot.TurnRight();
                    Console.WriteLine($"Robot is at ({robot.X},{robot.Y}), facing {robot.Facing}");
                }
                //If Move was entered, move robot one coordinate in the direction that it's facing
                else if (userInput == "MOVE" && placed == true)
                {
                    robot.Move();
                    Console.WriteLine($"Robot is at ({robot.X},{robot.Y}), facing {robot.Facing}");
                }
                //If robot hasn't been placed aler the user and perform no action.
                else if (placed == false)
                {
                    Console.WriteLine("Invalid Commmand Entered: The Robot hasn't been placed yet");
                }
            }
        }
    }
}
