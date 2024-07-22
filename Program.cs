List<int> boxes = new List<int> ()
{ 1, 7, 20, 13, 9, 5, 4, 17, 10, 15, 19, 4, 1, 4, 2, 3, 8, 29, 18 };

var smallboxes = boxes.Where(value => value < 5);
var agerageboxes = boxes.Where(value => value > 5).Where(value => value <15);
var bixboxes = boxes.Where(value => value >= 15);
int weightSmallboxes = smallboxes.Sum();
int weightAgerageboxes = agerageboxes.Sum();
int weightBixboxes = bixboxes.Sum();
Console.WriteLine(string.Join(", ", smallboxes));
Console.WriteLine(weightSmallboxes);
Console.WriteLine(string.Join(", ", agerageboxes));
Console.WriteLine(weightAgerageboxes);
Console.WriteLine(string.Join(", ", bixboxes));
Console.WriteLine(weightBixboxes);