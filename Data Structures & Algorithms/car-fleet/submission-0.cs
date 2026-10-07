public class Solution 
{
public int CarFleet(int target, int[] position, int[] speed)
{
    int n = position.Length;

    var cars = position
        .Select((p, i) => new
        {
            Position = p,
            Time = (double)(target - p) / speed[i]
        })
        .OrderByDescending(x => x.Position);

    int fleets = 0;
    double maxTime = 0;

    foreach (var car in cars)
    {
        if (car.Time > maxTime)
        {
            fleets++;
            maxTime = car.Time;
        }
    }

    return fleets;

    }
}
