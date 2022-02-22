namespace HepsiBuradaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxCoordinates =  Console.ReadLine();
            var splittedLocation = maxCoordinates.Split(" ");
            var maxX = splittedLocation[0];
            var maxY = splittedLocation[1];
            var currentLocation = string.Empty;
            List<Rover> roverList = new List<Rover>();
            while (true) {
                 currentLocation = Console.ReadLine();

                if (string.IsNullOrEmpty(currentLocation)) {
                    break;
                }
                var operations = Console.ReadLine();

                  if (string.IsNullOrEmpty(operations)) {
                    break;
                }

                var locations =currentLocation.Split(" ");
                Rover rover = new Rover(locations[0],locations[1],maxX,maxY,locations[2]);

                foreach(char c in operations){
                    rover.Move(c);
                }
                roverList.Add(rover);
            }
            roverList.ForEach((rover) => Console.WriteLine(rover.GetLatestLocation()));
        }          
     }
}