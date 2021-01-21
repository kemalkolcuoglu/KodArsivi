#include <iostream>
#include <stdlib.h>
using namespace std;

int main(int argc, char *argv[])
{
    if(argc == 1)
    {
        cerr << "Please enter a number as argument" << endl;
        return -1;
    }
    long value = strtol(argv[1], NULL, 10);
    for (int i = 1; i <= 10; i++)
    {
        cout << value << '*' << i << '=' << value * i << endl;
    }
    return 0;
}