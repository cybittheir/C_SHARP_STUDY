Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

int xa = 40;
int ya = 1;

int xb = 1;
int yb = 30;

int xc = 80;
int yc = 30;

int x=xa,y=ya;
int count=0;
string dot = "#";

while (count<30000)
{

int what = new Random().Next(0,3);


    switch (what) 
    {
        case 2:
            x = (x + xa) / 2;
            y = (y + ya) / 2;
            dot="+";
            break;
        case 1:
            x = (x + xb) / 2;
            y = (y + yb) / 2;
            dot="=";
            break;
        default:
            x = (x + xc) / 2;
            y = (y + yc) / 2;
            dot="#";
            break;
    }

/*
    if (what==0)
    {
            x = (x + xa) / 2;
            y = (y + ya) / 2;
            dot="+";
    }
    if (what==1)
    {
            x = (x + xb) / 2;
            y = (y + yb) / 2;
            dot="=";
    }
    if (what==2)
    {
            x = (x + xc) / 2;
            y = (y + yc) / 2;
            dot="#";
    }
 */

    Console.SetCursorPosition(x,y);
    Console.WriteLine(dot);
    count++;

}