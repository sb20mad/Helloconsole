﻿Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");
int xa = 1;
int ya = 1;

int xb = 1;
int yb = 30;

int xc = 80;
int yc = 30;

int xd = 80;
int yd = 1;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

Console.SetCursorPosition(xd,yd);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;

while(count < 100000)
{
int what = new Random().Next(0, 4); // (0;3) 0 1 2
if(what == 0)
{
    x =(x+xa) / 2;
    y =(y+ya) / 2; 
 }
if(what == 1)
{
    x =(x+xb) / 2;
    y =(y+yb) / 2; 
 }
 if(what == 2)
{
    x =(x+xc) / 2;
    y =(y+yc) / 2; 
 }
 if(what == 3)
 {
    x =(x+xd) / 2;
    y =(y+yd) / 2; 
 }
 Console.SetCursorPosition(x, y);
 Console.WriteLine("+");
 count++;
} 