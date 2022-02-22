
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
            var locationX = string.Empty;
            var locationY = string.Empty;
            var direction = string.Empty;
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
                locationX = locations[0];
                locationY = locations[1];
                direction = locations[2];
                Rover rover = new Rover(locationX,locationY,direction,maxX,maxY);
                rover.MoveAll(operations);
              
                roverList.Add(rover);
            }
            roverList.ForEach((rover) => Console.WriteLine(rover.GetLatestLocation()));
        }          
     }
}