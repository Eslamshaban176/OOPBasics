
using OperatorOverLoading;

Point pointOne = new Point(10, 5);
Point pointTwo = new Point(8, 4);

Point pointThree = pointOne + pointTwo;
Point pointFour = pointOne - pointTwo;
Point pointFive = pointOne * pointTwo;
Point pointSix = pointOne / pointTwo;

Console.WriteLine($"{pointOne} + {pointTwo} = {pointThree}");
Console.WriteLine($"{pointOne} - {pointTwo} = {pointFour}");
Console.WriteLine($"{pointOne} * {pointTwo} = {pointFive}");
Console.WriteLine($"{pointOne} / {pointTwo} = {pointSix}");

Console.WriteLine($"{pointOne} == {pointTwo} = {pointOne == pointTwo}");
Console.WriteLine($"{pointOne} != {pointTwo} = {pointOne != pointTwo}");


