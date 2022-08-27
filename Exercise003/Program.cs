/* Write a program that askes the user to input a width and height of an image and tell whether the image is portrait or landscape. */

Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("-----------------------Portrait or Landscape------------------------");
Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine();
Console.Write("Please enter the width of the image: ");
int imageWidth = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the height of the image: ");
int imageHeight = Convert.ToInt32(Console.ReadLine());

if (imageHeight > imageWidth)
    Console.WriteLine("Your image is portrait.");
else
    Console.WriteLine("Your image is landscape.");